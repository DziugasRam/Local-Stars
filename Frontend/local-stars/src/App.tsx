
import React from 'react'
import './App.css';
import Bar from './AppBar';
import Seller from './Seller';
import Buyer from './Buyer';
import Home from './HomePage';
import {BrowserRouter as Router, Switch, Route} from 'react-router-dom';
import FullProductCard from './FullProductCard';

function App() {
  return (
    <Router>
      <div className="App">
        <Bar/>
        <Switch>
          <Route path="/" exact component={Home}/>
          <Route path="/seller" component={Seller}/>
          <Route path="/buyer" component={Buyer}/>
          <Route path="/productpage" render={() => <FullProductCard title="Cucumbers" price="0.89" imageUrl="https://www.shethepeople.tv/wp-content/uploads/2019/05/cucumber-e1558166231577.jpg" description="I picked these myself. They're grown with love and without any chemicals" seller="Adam202" phonenumber="861234512"/>}/>
        </Switch>
      </div>
    </Router>
  );
}

export default App;