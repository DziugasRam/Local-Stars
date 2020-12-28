import React, { useReducer, useState } from "react";
import "../styles/NewListingForm.css";
import { authFetch } from "../utils/auth";
import { serverUrl } from "../configuration";
import { Grid } from '@material-ui/core';
import {NavBarVert, catValue} from "../Components/NavBarVert"
import { Divider } from "@material-ui/core";


interface FormData {
	title: string;
	description: string;
	price: string;
	category: string;
}

export const NewListingForm = () => {
	const getFormData = () => {
		var input = document.getElementById("image") as HTMLInputElement;

		return {
			title: (document.getElementById("title") as HTMLInputElement).value,
			price: (document.getElementById("price") as HTMLInputElement).value,
			description: (document.getElementById("description") as HTMLInputElement).value,
			category: catValue
		} as FormData;
	};

	const validateInputs = (formData: FormData) => {
		//TODO: validate inputs
		return true;
	};


	const onSubmit1 = () => {
		const data = getFormData();
		var input = document.getElementById("image") as HTMLInputElement;
		if (input.files && input.files[0]) {
			let formData = new FormData();
			formData.append("imageFile", input.files[0]);
			formData.append("title", data.title);
			formData.append("category", data.category);
			formData.append("price", data.price);
			formData.append("description", data.description);

			const requestOptions: RequestInit = {
				method: "POST",
				body: formData,
			};

			authFetch(`${serverUrl}/api/product/insert`, requestOptions).then((resp) => {
				if (resp?.status == 200) {
					const params = new URLSearchParams(document.location.search);
					const returnUrl = params.get("returnUrl") ?? document.location.origin;
					document.location.href = returnUrl;
				}
			});
		} else console.log("you have to upload a picture");
	};

	return (
		
		<div>		
			
			<h1
				style={{
					textAlign: "left",
					fontSize: 38,
					fontWeight: 400,
					marginBottom: "1%",
					marginLeft: "4%",
				}}
			>
				New Product:
			</h1>
			<Grid container spacing={5}>
			<Grid item container xs={12} md={8} spacing={5}>
			
				<Grid className="product-title-container" item xs={12} sm={6} style={{ marginTop: "2%" }}>
				
						<h2
							style={{
								textAlign: "left",
								marginLeft: "8%",
							}}
						>
							Title:
						</h2>
						<input
							className="label-input"
							placeholder="Title"
							name="productTitle"
							type="text"
							id="title"
							style={{
								marginRight: "2%",
							}}
						/>
					
					</Grid>
					<Grid className="product-title-container" item xs={12} sm={6} style={{ marginTop: "2%" }}>
					
						<h2
							style={{
								textAlign: "left",
								marginLeft: "8%",
							}}
						>
							Price:
						</h2>

						<input
							className="label-input"
							type="text"
							id="price"
							placeholder="Price"
							style={{
								marginRight: "2%",
							}}
						/>
					
					</Grid>
					
				
				<Grid item xs={12} className="product-description-container" style={{ marginTop: "2%" }}>
				
					<h2
						style={{
							textAlign: "left",
							marginLeft: "8%",
							
						}}
					>
						Description:
					</h2>

					<input
						className="label-input"
						type="text"
						id="description"
						placeholder="Description"
						style={{
							marginLeft: "8%",
							width: "90%",
							height: "80%",
							
						}}
					/>
				</Grid>
				<Grid item xs={12} className="product-description-container" style={{ marginTop: "2%" }}>
					<h2
						style={{
							textAlign: "left",
							marginLeft: "8%",
						}}
					>
						Image:
					</h2>

					<input
						className="label-input"
						type="file"
						id="image"
						style={{
							marginLeft: "8%",
							width: "90%",
							height: "80%",
						}}
					/>
				</Grid>

			</Grid>
			<Grid  className= "navbar-container" item container xs={12} md={3}  >
			
						<NavBarVert  />
					
			
			<Grid xs={12} sm={6} item   alignItems="center" justify="center">
				
				<button className="add-button" type="button" onClick={onSubmit1} id="add" >
					Add product
				</button>
			
			</Grid></Grid>
		</Grid>
		</div>
		
	);
};

export default NewListingForm;
