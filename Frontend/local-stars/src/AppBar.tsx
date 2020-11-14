import React from 'react'
import './App.css';
import {Link} from 'react-router-dom'
import { AppBar, IconButton, makeStyles, Toolbar, Typography } from '@material-ui/core';
import HomeIcon from '@material-ui/icons/Home';

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

function Bar() {
    
    const classes = useStyles();

    const navStyle = {
      color : 'white'
    }

    return (
    <div className={classes.root}>
        <AppBar position="static">
            <Toolbar>
                <Link style={navStyle} to='/'>
                    <IconButton edge="start" className={classes.menuButton} color="inherit" aria-label="menu">
                        <HomeIcon />
                    </IconButton>
                </Link>
                <Typography variant="h6" className={classes.links}>
                    <Link style={navStyle} to='/seller'>
                        Seller
                    </Link>
                </Typography>
                <Typography variant="h6" className={classes.links}>
                    <Link style={navStyle} to='/buyer'>
                        Buyer
                    </Link>
                </Typography>
            </Toolbar>
        </AppBar>
    </div>
    );
}

export default Bar;