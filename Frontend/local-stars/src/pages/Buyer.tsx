import React, { useState, useEffect, constructor } from 'react'
import ProductCard from '../Components/ProductCard'
import { Grid } from '@material-ui/core';
import { serverUrl } from "../configuration";
import { authFetch } from "../utils/auth";
import NavBarHoriz from '../Components/NavBarHoriz';
import BuyerBar from '../Components/BuyerBar';
import Pagination from "react-js-pagination";
import { ProductsService } from '../http-service/products-service';
import { UserService } from '../http-service/user-service';

const Buyer = () => {

  const [products, setProductsState] = useState([] as any[]);
  const [productNumber,setProductNumber] = useState(0);
  const [showLikedProducts, setShowLikedProducts] = useState(false);
  const [currentPage,setCurrentPage] = useState(1);
  const [variant, setVariant] = useState("");

  const buyerId = UserService.getBuyerId();
  const sellerId = UserService.getSellerId();

  const setProducts = (products: any[]) => {
    ProductsService.setProducts(products);
  }

  useEffect(() => {
    const listener = () => {
      setProductsState(ProductsService.getProducts());
    };

    ProductsService.addProductsListener(listener);

    return () => {
      ProductsService.removeProductsListener(listener);
    }
  }, [products, setProductsState]);

  useEffect (() => {
    authFetch(`${serverUrl}/api/product/count`)
    .then(resp => resp?.json())
    .then(data => setProductNumber(data))
    handlePageChange(currentPage)
  }, [])
  
  const showAllProducts = () => {
    authFetch(`${serverUrl}/api/product/get`)
      .then(resp => resp?.json())
      .then(data => setProducts(data))
  }

  const showAllLikedProducts = () => {
    authFetch(`${serverUrl}/api/buyer/likedProducts/${buyerId}`)
      .then(resp => resp?.json())
      .then(data => setProducts(data))
  }

  const onCategoryChange = (category: string) => {
    setVariant(variant)
    setCurrentPage(1)
    authFetch(`${serverUrl}/api/product/category?searchVal=${category}&page=${currentPage}`)
      .then(resp => resp?.json())
      .then(data => setProducts(data))
  }

  const onSearch = (searchResult: string) => {
    authFetch(`${serverUrl}/api/product/title?searchVal=${searchResult}`)
        .then(resp => resp?.json())
        .then(data => setProducts(data))
  }

  const onSortSelect = (variant: string) => {
    setVariant(variant)
    setCurrentPage(1)
    authFetch(`${serverUrl}/api/product/sorted?variant=${variant}&page=${currentPage}`)
        .then(resp => resp?.json())
        .then(data => setProducts(data))
  }

  const onLiked = () => {
     showLikedProducts
     ? showAllProducts()
     : showAllLikedProducts()
    
    setShowLikedProducts(!showLikedProducts)
  }

  const handlePageChange=(pageNumber: number)=> {
    setCurrentPage(pageNumber);
    authFetch(`${serverUrl}/api/product/sorted?variant=${variant}&page=${pageNumber}`)
    .then(resp => resp?.json())
    .then(data => setProducts(data))
  }
  
  const onSellersProducts = () => {
    authFetch(`${serverUrl}/api/product/sellerId?id=${sellerId}`)
    .then(resp => resp?.json())
    .then(data => setProducts(data.products))
  }

  return (
    <div>
      <BuyerBar onSearch={onSearch} onSortSelect={onSortSelect} onLiked={onLiked} onSellersProducts={onSellersProducts} buyerId={buyerId}/>
      <NavBarHoriz onCategoryChange={onCategoryChange}/>
      <Pagination
          itemClass="page-item"
          linkClass="page-link"
          activePage={currentPage}
          totalItemsCount={productNumber}
          onChange={handlePageChange.bind(this)}
        />
      <Grid container spacing={2}>
      <Grid item xs={1} sm={2}/>
      <Grid item container xs={10} sm={8} spacing={5}>
          {products?.map(product => 
            <Grid item xs={12} sm={6} md={4} lg={3}>
              <ProductCard title={product.title} category={product.category} price={product.price} description={product.description} id={product.id} seller={product.seller} image={product.image} buyerId={buyerId}/>
            </Grid>
          )}
      </Grid>
      <Grid item xs={1} sm={2}/>
      </Grid>
    
      <Pagination
          itemClass="page-item"
          linkClass="page-link"
          activePage={currentPage}
          totalItemsCount={productNumber}
          onChange={handlePageChange.bind(this)}
        />

   </div>
  );
}

export default Buyer;