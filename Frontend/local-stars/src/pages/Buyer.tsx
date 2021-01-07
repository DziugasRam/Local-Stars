import React, { useState, useEffect, constructor } from 'react'
import ProductCard from '../Components/ProductCard'
import { Grid } from '@material-ui/core';
import { serverUrl } from "../configuration";
import { authFetch } from "../utils/auth";
import NavBarHoriz from '../Components/NavBarHoriz';
import BuyerBar from '../Components/BuyerBar';
import Pagination from "react-js-pagination";

const Buyer = () => {

  const [products, setProducts] = useState([]);
  const[productNumber,setProductNumber]= useState(0);
  const [showLikedProducts, setShowLikedProducts] = useState(false);
  const [buyerId, setBuyerId] = useState("");
  const [currentPage,setCurrentPage]= useState(1);
  const[variant,setVariant]= useState("");

  useEffect (() => {
    authFetch(`${serverUrl}/api/product/count`)
    .then(resp => resp?.json())
    .then(data => setProductNumber(data))
    handlePageChange(currentPage)
          
    authFetch(`${serverUrl}/api/buyer/getId`)
      .then(resp => resp?.json())
      .then(data => setBuyerId(data))
      
    showAllProducts()
  }, [])

  const getProductCard = (product: { category: string; description: string; price: string; seller: any; title: string; id: string; image: string;}) => (
    <Grid item xs={12} sm={6} md={4} lg={3}>
      <ProductCard title={product.title} category={product.category} price={product.price} description={product.description} id={product.id} seller={product.seller} image={product.image} buyerId={buyerId}/>
    </Grid>
  )

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
    authFetch(`${serverUrl}/api/product/catego?searchVal=${category}&page=${currentPage}`)
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

  const handlePageChange=(pageNumber: any)=> {
    setCurrentPage(pageNumber);
    authFetch(`${serverUrl}/api/product/sorted?variant=${variant}&page=${pageNumber}`)
    .then(resp => resp?.json())
    .then(data => setProducts(data))
  }

  return (
    <div>
      <BuyerBar onSearch={onSearch} onSortSelect={onSortSelect} onLiked={onLiked} buyerId={buyerId}/>
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
          {products.map(product => getProductCard(product))}
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