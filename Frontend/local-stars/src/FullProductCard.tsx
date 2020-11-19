import React from 'react';
import { makeStyles, createStyles, Theme } from '@material-ui/core/styles';
import Grid from '@material-ui/core/Grid';
import Paper from '@material-ui/core/Paper';
import Typography from '@material-ui/core/Typography';
import ButtonBase from '@material-ui/core/ButtonBase';
import { IconButton } from '@material-ui/core';
import FavoriteBorderIcon from '@material-ui/icons/FavoriteBorder';
import DescriptionTable from './DescriptionTable';


const useStyles = makeStyles((theme: Theme) =>
    createStyles({
    root: {
        flexGrow: 1,
    },
    paper: {
        padding: theme.spacing(2),
        margin: 'auto',
        maxWidth: 1000,
    },
    image: {
        width: 250,
        height: 250,
    },
    map: {
        width: 300,
        height: 300,
    },
    img: {
        margin: 'auto',
        display: 'block',
        maxWidth: '100%',
        maxHeight: '100%',
    },
    }),
);

function FullProductCard(props: {title: string; price: string; imageUrl: string; description: string; seller: string; phonenumber: string; }) {
    const classes = useStyles();

    return (
    <div className={classes.root}>
    <Paper className={classes.paper}>
        <Grid container spacing={2}>
        <Grid item>
            <ButtonBase className={classes.map} disableRipple>
            <img className={classes.img} alt="map" src="https://www.zemelapis.lt/resources/i/maps/vilnius.png" />
            </ButtonBase>
        </Grid>
        <Grid item xs={12} sm container>
            <Grid item xs container direction="column">
                <Grid item xs>
                    <Typography variant="h3">
                        {props.title}, 1kg
                    </Typography>
                    <Typography variant="h4">
                        € {props.price}/kg
                    </Typography>
                    <IconButton aria-label="favorites">
                        <FavoriteBorderIcon fontSize="large"/>
                    </IconButton>
                </Grid>
                <Grid item xs>
                    <DescriptionTable description={props.description} seller={props.seller} phonenumber={props.phonenumber}/>
                </Grid>
            </Grid>
            <Grid item>
                <ButtonBase className={classes.image} disableRipple>
                <img className={classes.img} alt="product" src={props.imageUrl} />
                </ButtonBase>        
            </Grid>
        </Grid>
        </Grid>
    </Paper>
    </div>
    );
}

export default FullProductCard;