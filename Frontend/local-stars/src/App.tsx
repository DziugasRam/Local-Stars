
import React from 'react'
import './App.css';
import Bar from './AppBar';
import Seller from './Seller';
import Buyer from './Buyer';
import Home from './HomePage';
import NewProduct from './NewListingForm'
import {BrowserRouter as Router, Switch, Route} from 'react-router-dom';
import $ from "jquery";

function App() {
  return (
    <Router>
      <div className="App">
        <Bar/>
        <Switch>
          <Route path="/" exact component={Home}/>
          <Route path="/seller" component={Seller}/>
          <Route path="/buyer" component={Buyer}/>
          <Route path="/NewListingForm" component={NewProduct}/>
        </Switch>
      </div>
    </Router>
  );
}

export default App;