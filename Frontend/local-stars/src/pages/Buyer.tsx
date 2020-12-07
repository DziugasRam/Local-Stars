import React, { useState } from 'react'
import ProductCard from '../Components/ProductCard'
import { Grid } from '@material-ui/core';
import productList from '../MockData';
import Map from '../Components/Map';
import { serverUrl } from "../configuration";
import { authFetch } from "../utils/auth";


interface FormData {
  title: string;
  subtitle: string;
	price: string;
  seller: string;
  description: string
  phonenumber: string;
}


const Buyer = () => {

  const getProductCard = (product: { phonenumber: string; seller: string; price: string; imageUrl: string; title: string; subtitle: string; description: string;}) => (
    <Grid item xs={12} sm={6} md={4} lg={3}>
      <ProductCard {...product}/>
    </Grid>
  )

  const [products, setProducts] = useState([]);

  const getFormData = () => {
		return {
			title: (document.getElementById("title") as HTMLInputElement).value,
			subtitle: (document.getElementById("category") as HTMLInputElement).value,
      price: (document.getElementById("price") as HTMLInputElement).value,
      seller: (document.getElementById("description") as HTMLInputElement).value,
      description: (document.getElementById("seller") as HTMLInputElement).value,
      phonenumber: (document.getElementById("phonenumber") as HTMLInputElement).value,
		} as FormData;
  };

		const formData = getFormData();

		const requestOptions: RequestInit = {
			method: "GET",
			headers: {
				"Content-Type": "application/json",
			},
			body: JSON.stringify({
				title: formData.title,
        subtitle: formData.subtitle,
	      price: formData.price,
        seller: formData.description,
        description: formData.seller,
        phonenumber: formData.phonenumber,
			}),
    };
    
    authFetch(`${serverUrl}/api/product/get`, requestOptions)
    .then(resp => resp?.json())
    .then(data => setProducts(data))

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