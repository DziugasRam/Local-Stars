import React, { useReducer, useState } from "react";
import "../styles/NewListingForm.css";
import { authFetch } from "../utils/auth";
import { serverUrl } from "../configuration";
import { Divider } from "@material-ui/core";

interface FormData {
	title: string;
	description: string;
	price: string;
	category: "pears";
}

export const NewListingForm = () => {
	const getFormData = () => {
		return {
			title: (document.getElementById("title") as HTMLInputElement).value,
			price: (document.getElementById("price") as HTMLInputElement).value,
			description: (document.getElementById("description") as HTMLInputElement).value,
			//  category: (document.getElementById("category") as HTMLInputElement).value
		} as FormData;
	};

	const validateInputs = (formData: FormData) => {
		//TODO: validate inputs
		return true;
	};

	const onSubmit = () => {
		const formData = getFormData();

		// if(!validateInputs(formData))
		//     return;

		const requestOptions: RequestInit = {
			method: "POST",
			headers: {
				"Content-Type": "application/json",
			},
			body: JSON.stringify({
				title: formData.title,
				category: "cucumbers",
				price: Number(formData.price),
				description: formData.description,
			}),
		};
        authFetch(`${serverUrl}/api/product/insert`, requestOptions)
        .then(resp => {
            if (resp?.status == 200){
                const params = new URLSearchParams(document.location.search);
                const returnUrl = params.get("returnUrl") ?? document.location.origin;
                document.location.href = returnUrl
                      }
        });
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
			<div className="new-listing-container" style={{ marginLeft: "4%" }}>
				<div style={{ display: "flex" }}>
					<div className="product-title-container">
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
							type="text"
							id="title"
							style={{
								marginRight: "22%",
							}}
						/>
					</div>

					<div
						className="product-title-container"
						style={{ marginLeft: "2%" }}
					>
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
							style={{
								marginRight: "22%",
							}}
						/>
					</div>
				</div>
				<div
					className="product-description-container"
					style={{ marginTop: "2%" }}
				>
					<h2
						style={{
							textAlign: "left",
							marginLeft: "4%",
						}}
					>
						Description:
					</h2>

					<input
						className="label-input"
						type="text"
						id="description"
						style={{
							marginRight: "2%",
							width: 900,
							height: 80,
						}}
					/>
				</div>
				<div
					className="product-description-container"
					style={{ marginTop: "1%" }}
				>
					<h2
						style={{
							textAlign: "left",
							marginLeft: "4%",
						}}
					>
						Image:
					</h2>

					<input
						className="label-input"
						type="image"
						id="image"
						style={{
							marginRight: "2%",
							width: 900,
							height: 90,
						}}
					/>
				</div>
				<div>
					<button
						className="add-button"
						type="button"
						onClick={onSubmit}
						style={{}}
					>
						Add product
					</button>
				</div>
			</div>
		</div>
	);
};

export default NewListingForm;
