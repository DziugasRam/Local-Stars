
import React from 'react'
import './App.css';
import Bar from './AppBar';
import Seller from './Seller';
import Buyer from './Buyer';
import Home from './HomePage';
import {BrowserRouter as Router, Switch, Route} from 'react-router-dom';
import NavBar from './Components/NavigationBar/NavBar';

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
        <NavBar />
      </div>
    </Router>
  );
}

export default App;