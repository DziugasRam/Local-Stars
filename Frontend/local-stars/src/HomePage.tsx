import React from 'react'
import NavBarHoriz from './Components/NavBarHoriz'
import Map from './Components/Map'
import ProductCard from './ProductCard'
import { Grid } from '@material-ui/core';
import productList from './MockData';

const getProductCard = (product: { phonenumber: string; seller: string; price: string; imageUrl: string; title: string; subtitle: string; description: string;}) => (
  <Grid item xs={12} sm={6} md={4} lg={3}>
    <ProductCard {...product}/>
  </Grid>
)

function Home() {
  return (
    <div>
      <h1>Home Page</h1>
    <div>
      <NavBarHoriz/>
      <div style={{height: "30px"}}> </div>
      <Grid container spacing={2}>
      <Grid item xs={1} sm={2}/>
      <Grid item container xs={10} sm={8} spacing={5}>
          {productList.map(product => getProductCard(product))}
      </Grid>
      <Map />
    </Grid>
    </div>
  
    </div>

  )

}

export default Home;