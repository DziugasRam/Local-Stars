import React, { useState } from 'react'
import ProductCard from '../Components/ProductCard'
import { Grid } from '@material-ui/core';
import Map from '../Components/Map';
import { serverUrl } from "../configuration";
import { authFetch } from "../utils/auth";

const Buyer = () => {

  const [products, setProducts] = useState([]);

  const getProductCard = (product: { phonenumber: string; title: string; subtitle: string; price: string; seller: string; description: string;}) => (
    <Grid item xs={12} sm={6} md={4} lg={3}>
      <ProductCard {...product}/>
    </Grid>
  )
  
  const onRequest = () => {
  authFetch(`${serverUrl}/api/product/get`)
    .then(resp => resp?.json())
    .then(data => setProducts(data))
  }

  return (
      <Grid container>
      <Grid item xs={1} sm={2}>
      <button onClick={onRequest}/>
      </Grid>
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