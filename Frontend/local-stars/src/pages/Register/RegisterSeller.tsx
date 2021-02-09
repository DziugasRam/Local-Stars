import "../../styles/forms.css";

import React from "react";
import backgroundImage from "../../assets/register-background.svg";
import { serverUrl } from "../../configuration";
import { authFetch } from "../../utils/auth";
import { FormEvent } from "react";
import { UserService } from "../../http-service/user-service";

interface FormData {
	firstName: string;
	lastName: string;
	phoneNumber: string;
	address: string;
	longitude: number;
	latitude: number;
}

export const RegisterSeller = () => {
	const getFormData = () => {
		return Object.fromEntries(Array.from(document.getElementsByTagName("input")).map((el: HTMLInputElement) => [el.id, el.value]));
	};

	const validateInputs = (formData: FormData) => {
		//TODO: validate inputs with regex and check username in db
		return true;
	};

	const onSubmit = (e: FormEvent<HTMLFormElement>) => {
		e.preventDefault();
		const formData = getFormData();

		if (!validateInputs(formData as any)) return;

		const requestOptions: RequestInit = {
			method: "POST",
			headers: {
				"Content-Type": "application/json",
			},
			body: JSON.stringify({
				formData
			}),
		};
		authFetch(`${serverUrl}/api/seller/register`, requestOptions).then((resp) => {
			if (resp.ok) {
				UserService.signOut().then(() => {
					document.location.href = `${document.location.origin}/signin`;
				})
			}
		});
	};

	return (
		<div>
			<img className="sign-in-background" src={backgroundImage} />
			<div className="sign-in-form-container">
				<h1
					style={{
						textAlign: "left",
						fontSize: 50,
						fontWeight: 400,
						marginBottom: 20,
					}}
				>
					Create selling profile
				</h1>
				<form className="sign-in-form" id="CreateSellerForm" onSubmit={onSubmit}>
					<div className="sign-in-form-content">
						<label className="form-label" htmlFor="firstName">
							First name:
						</label>
						<input className="form-label-input" type="text" id="firstName" />
						<label className="form-label" htmlFor="lastName">
							Last name:
						</label>
						<input className="form-label-input" id="lastName" />
						<label className="form-label" htmlFor="phoneNumber">
							Phone number:
						</label>
						<input className="form-label-input" type="tel" id="phoneNumber" />
						<label className="form-label" htmlFor="address">
							Address:
						</label>
						<input className="form-label-input" id="address" />
						<label className="form-label" htmlFor="longitude">
							Longitude:
						</label>
						<input className="form-label-input" id="longitude" />
						<label className="form-label" htmlFor="latitude">
							Latitude:
						</label>
						<input className="form-label-input" id="latitude" />
						<button className="form-button" style={{ marginTop: 30 }}>
							Create
						</button>
					</div>
				</form>
			</div>
		</div>
	);
};
