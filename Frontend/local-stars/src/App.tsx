import React from "react";
import "./App.css";
import Buyer from "./pages/Buyer";
import Seller from "./pages/Seller";
import Home from "./HomePage";
import Map from "./Components/Map"
import { BrowserRouter as Router, Switch, Route } from "react-router-dom";
import { SignIn } from "./pages/SignIn";
import { Register } from "./pages/Register/Register";
import NewProduct from './pages/NewListingForm'
import Modal from 'react-modal';
Modal.setAppElement('#root')

function App() {
  return (
    <Router>
      <div className="App">
        <Switch>
          <Route path="/" exact component={Buyer} />
          <Route path="/signin" component={SignIn} />
          <Route path="/register" component={Register} />
          <Route path="/NewListingForm" component={NewProduct}/>
          <Route path="/map" component={Map}/>
        </Switch>
      </div>
    </Router>
  );
}

export default App;
