import React, { useState, useEffect } from 'react'
import ProductCard from '../Components/ProductCard'
import { Grid } from '@material-ui/core';
import Map from '../Components/Map';
import { serverUrl } from "../configuration";
import { authFetch } from "../utils/auth";

const Buyer = () => {

  const [products, setProducts] = useState([]);

  const getPhoneNumber = (seller: {phoneNumber: string;}) => seller.phoneNumber

  const getFirstName = (seller: {firstName: string;}) => seller.firstName

  const getProductCard = (product: { category: string; description: string; price: string; seller: any; title: string; }) => {
    
    const phoneNumber = getPhoneNumber(product.seller);
    
    const firstName = getFirstName(product.seller);

    return (
    <Grid item xs={12} sm={6} md={4} lg={3}>
      <ProductCard title={product.title} category={product.category} price={product.price} description={product.description} firstName={firstName} phoneNumber={phoneNumber}/>
    </Grid>
    )
  }

  useEffect(() => {
    authFetch(`${serverUrl}/api/product/get`)
      .then(resp => resp?.json())
      .then(data => setProducts(data))
  }, []);

  console.log(products);

  return (
      <Grid container>
      <Grid item xs={1} sm={2}/>
      <Grid item container xs={10} sm={8} spacing={5}>
          {products.map(product => getProductCard(product))}
      </Grid>
      <Grid item xs={1} sm={2}>
        <Map/>
      </Grid>
    </Grid>
  );
}

export default Buyer;