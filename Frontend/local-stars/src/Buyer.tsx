import React from 'react'
import ProductCard from './ProductCard'
import { Grid } from '@material-ui/core';
import productList from './MockData';
import Map from './Components/Map';
import NavBarHoriz from './Components/NavBarHoriz';

function Buyer() {

  const getProductCard = (product: { phonenumber: string; seller: string; price: string; imageUrl: string; title: string; subtitle: string; description: string;}) => (
    <Grid item xs={12} sm={6} md={4} lg={3}>
      <ProductCard {...product}/>
    </Grid>
  )

  return (
    <div>
      <NavBarHoriz/>
      <Grid container spacing={2} alignItems="center">
      <Grid item xs={1} sm={2}/>
      <Grid item container xs={10} sm={8} spacing={5}>
          {productList.map(product => getProductCard(product))}
      </Grid>
      <Map />
    </Grid>
    </div>
  );
}

export default Buyer;