import React, { useState, useEffect } from 'react'
import ProductCard from '../Components/ProductCard'
import { Grid } from '@material-ui/core';
import Map from '../Components/Map';
import { serverUrl } from "../configuration";
import { authFetch } from "../utils/auth";
import {NavBarHoriz, catValue} from '../Components/NavBarHoriz';
import data from '../MockData';
import { Filter } from '@material-ui/icons';

const Buyer = () => {


  const [products, setProducts] = useState([]);

  const getProductCard = (product: { category: string; description: string; price: string; seller: any; title: string; }) => (
    <Grid item xs={12} sm={6} md={4} lg={3}>
      <ProductCard title={product.title} category={product.category} price={product.price} description={product.description} firstName={product.seller.firstName} phoneNumber={product.seller.phoneNumber}/>
    </Grid>
  )

  useEffect (() => {
    authFetch(`${serverUrl}/api/product/catego?searchVal=`)
      .then(resp => resp?.json())
      .then(data => setProducts(data))
  }, [])

  const onCategoryChange = (category: string) => {
    authFetch(`${serverUrl}/api/product/catego?searchVal=${category}`)
      .then(resp => resp?.json())
      .then(data => setProducts(data))
  }

  return (
    <div>
      <NavBarHoriz onCategoryChange={onCategoryChange}/>
      <Grid container spacing={2} alignItems="center">
      <Grid item xs={1} sm={2}/>
      <Grid item container xs={10} sm={8} spacing={5}>
          {products.map(product => getProductCard(product))}
      </Grid>
        <Map/>
      </Grid>
    </div>
  );
  }

export default Buyer;