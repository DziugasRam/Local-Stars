import "../../styles/forms.css";

import React from "react";
import backgroundImage from "../../assets/register-background.svg";
import { FormEvent } from "react";
import { UserService } from "../../http-service/user-service";

interface FormData {
	username: string;
	password: string;
	confirmPassword: string;
}

export const RegisterUser = () => {
	const getFormData = () => {
		return {
			username: (document.getElementById("username") as HTMLInputElement).value,
			password: (document.getElementById("password") as HTMLInputElement).value,
			confirmPassword: (document.getElementById("confirmPassword") as HTMLInputElement).value,
		} as FormData;
	};
	const validateInputs = (formData: FormData) => {
		//TODO: validate inputs with regex and check username in db
		return true;
	};

	const onSubmit = (e: FormEvent<HTMLFormElement>) => {
		e.preventDefault();
		const formData = getFormData();

		if (!validateInputs(formData)) return;

		const requestOptions: RequestInit = {
			method: "POST",
			headers: {
				"Content-Type": "application/json",
			},
			body: JSON.stringify({
				username: formData.username,
				password: formData.password,
			}),
		};

		UserService.register(formData.username, formData.password);
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
					Local Stars
				</h1>
				<p style={{ textAlign: "left", fontSize: 20 }}>
					Support your local businesses who support
					<br />
					the area where you live, work and play.
				</p>
				<form className="sign-in-form" onSubmit={onSubmit}>
					<div className="sign-in-form-content">
						<label className="form-label" htmlFor="username">
							Username:
						</label>
						<input className="form-label-input" type="text" id="username" />
						<label className="form-label" htmlFor="password">
							Password:
						</label>
						<input className="form-label-input" type="password" id="password" />
						<label className="form-label" htmlFor="confirmPassword">
							Confirm Password:
						</label>
						<input className="form-label-input" type="password" id="confirmPassword" />
						<button className="form-button" style={{ marginTop: 30 }}>
							Register
						</button>
					</div>
				</form>
			</div>
		</div>
	);
};
