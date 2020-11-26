import React, { useReducer, useState } from 'react';
import "../styles/NewListingForm.css";
import { authFetch } from "../utils/auth";
import { serverUrl } from "../configuration";
import { Divider } from '@material-ui/core';

interface FormData {
	title: string;
	description: string;
    price: number;
    category: string;
    image: any;
}

// export const Insert = () => {
// 	const getFormData = () => {
// 		return {
// 			title: (document.getElementById("title") as HTMLInputElement).value,
// 			description: (document.getElementById("description") as HTMLInputElement).value,
// 			price: (document.getElementById("price") as HTMLInputElement).value
//         } as FormData;
//     }

//     const validateInputs = (formData: FormData) => {
// 		//TODO: validate inputs
// 		return true;
//     }
    
// 	const onSubmit = () => {
// 		const formData = getFormData();

// 		if(!validateInputs(formData))
// 			return;
		
// 		const requestOptions: RequestInit = {
// 			method: "POST",
// 			headers: {
// 				'Content-Type': 'application/json'
// 			},
// 			body: JSON.stringify({
// 				title: formData.title,
// 				description: formData.description
// 			})
// 		}
// 		authFetch(`${serverUrl}/api/product/Insert`, requestOptions)
// 			.then(resp => {
// 				if (resp?.status == 200){
// 					const params = new URLSearchParams(document.location.search);
// 					const returnUrl = params.get("returnUrl") ?? document.location.origin;
// 					document.location.href = returnUrl
// 				}
// 			});
// 	}


const formReducer = (state: any, event: { name: any; value: any; }) => {
    '!=='
    return {
        ...state,
        [event.name]: event.value
    }
}

function NewListingForm() {

    const [formData, setFormData] = useReducer(formReducer, {});
    const [submitting, setSubmitting] = useState(false);
    const [open, setOpen] = useState(false);
     const handleSubmit = (event: { preventDefault: () => void; }) => {
         event.preventDefault();
         setSubmitting(true);

    //         $.ajax({
    //             type: "POST",
    //             url: "https://localhost:44346/api/product",
    //             data: JSON.stringify( [{
    //                 "title": "Seller1_Product1", "category": "Pears", "price": 2, "seller": {"id": "931fbb66-b782-4d7c-8cfe-98fa4f459218" }, "description": "new", "id": "4095bc5c-2886-4c4c-b66a-a9b6ac6621d1"
    //             }]),
    //             dataType: "json",
    //             contentType:"application/json; charset=utf-8"
                
    //           }).then (() => {
    //             setSubmitting(false);
    //           });
              
     }


    const handleChange = (event: { target: { name: String; value: any; }; }) => {
        setFormData({
            name: event.target.name,
            value: event.target.value,
        });
    }

	return (
    <div>
        <h1
			style={{
				textAlign: "left",
				fontSize: 48,
				fontWeight: 400,
				marginBottom: 20,
		    }}
		>
			New Product:
		</h1>
			<div className="new-listing-container">
				<div className="product-title-container"  >
                <label className="label" htmlFor="title">
						<h2>Title:</h2>	
						</label>
						<input
							className="label-input"
							type="text"
							id="title"
						/>
				</div>
                
                <div className="product-price-container" >
                <label className="label" htmlFor="price">
						<h2>Price:</h2>	
						</label>
						<input
							className="label-input"
							type="text"
                            id="price"
                            style={{
                                width: 150,
                                height: 67,
                            }}
						/>
                </div>
                
                <div className="product-description-container">
                <label className="label" htmlFor="price">
						<h2>Description:</h2>	
						</label>
						<input
							className="label-input"
							type="text"
                            id="description"
                            style={{
                                width: 600,
                                height: 100,
                            }}
               />
                </div>
            </div>			
    </div>
	);
};



export default NewListingForm;