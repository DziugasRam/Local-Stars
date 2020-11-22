
import React from 'react'
import './App.css';
import Bar from './AppBar';
import Seller from './Seller';
import Buyer from './Buyer';
import Home from './HomePage';
import {BrowserRouter as Router, Switch, Route} from 'react-router-dom';
import Modal from 'react-modal';

Modal.setAppElement('#root')

function App() {
  return (
    <Router>
      <div className="App">
        <Bar/>
        <Switch>
          <Route path="/" exact component={Home}/>
          <Route path="/seller" component={Seller}/>
          <Route path="/buyer" component={Buyer}/>
        </Switch>
      </div>
    </Router>
  );
}

export default App;