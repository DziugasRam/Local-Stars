import React from 'react'
import './App.css';
import {Link} from 'react-router-dom'

function Nav() {

  const navStyle = {
      color : 'white'
  }  

  return (
    <nav>
        <Link style={navStyle} to='/'>
            <h3>Home</h3>
        </Link>
        <ul className="nav-links">
            <Link style={navStyle} to='/seller'>
                <li>Seller</li>
            </Link>
            <Link style={navStyle} to='/buyer'>
                <li>Buyer</li>
            </Link>
        </ul>
    </nav>
  );
}

export default Nav;
