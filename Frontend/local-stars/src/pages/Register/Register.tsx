import "../../styles/forms.css";

import React from "react";
import { Switch, Route } from "react-router-dom";
import { RegisterUser } from "./RegisterUser";
import { RegisterSeller } from "./RegisterSeller";
import { RegisterBuyer } from "./RegisterBuyer";

export const Register = () => {
	return (
		<Switch>
			<Route path="/register/user">
				<RegisterUser/>
			</Route>
			<Route path="/register/seller">
				<RegisterSeller/>
			</Route>
			<Route path="/register/buyer">
				<RegisterBuyer/>
			</Route>
		</Switch>
	);
};
