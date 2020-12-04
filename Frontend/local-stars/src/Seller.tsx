import React, { Component} from 'react'
import {Link} from 'react-router-dom'
import './App.css';
import { AppBar, IconButton, makeStyles, Toolbar, Typography } from '@material-ui/core';
//import Map from './Components/Map'
import NavBar from './Components/NavigationBar/NavBar'


const useStyles = makeStyles((theme) => ({
  root: {
    flexGrow: 1,
  },
  menuButton: {
    marginRight: theme.spacing(2),
  },
  links: {
    flexGrow: 1,
  },
}));

function Seller() {

  const classes = useStyles();
  const navStyle = {
    color : 'white'
  }
  return (
    
    <div className={classes.root}>
      <h1>Seller</h1>
                <Typography variant="h6" className={classes.links}>
                    <Link style={navStyle} to='/NewListingForm'>
                    <button >Add new listing</button>                     
                    </Link>
                </Typography>

            <NavBar />
      <div style={{position:'relative', left:'1168px', display:'flex', marginTop: '10px'}}>
        {/* <Map /> */}
      </ div>
    <div>
    </div>
    </div>
    
  );
}

export default Seller;
