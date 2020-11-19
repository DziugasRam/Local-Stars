import React from 'react';
import { Card, CardHeader, CardMedia, CardContent, CardActions, Avatar, IconButton, Typography, makeStyles, Theme } from '@material-ui/core';
import { green } from '@material-ui/core/colors';
import {Link} from 'react-router-dom'
import FavoriteIcon from '@material-ui/icons/Favorite';
import ShareIcon from '@material-ui/icons/Share';
import MoreVertIcon from '@material-ui/icons/MoreVert';
import { AspectRatio } from '@material-ui/icons';

const useStyles = makeStyles((theme: Theme) => ({
    root: {
        maxWidth: 345,
    },
    media: {
        height: 200,
    },
    avatar: {
        backgroundColor: green[500],
    },
}));

function ProductCard(props: { phonenumber: string; seller: string; price: string; imageUrl: string; title: string; subtitle: string; description: string;}) {
    const classes = useStyles();

    return (
        <Card className={classes.root}>
            <CardHeader
            avatar={
                <Avatar aria-label="product" className={classes.avatar}>
                S
                </Avatar>
            }
            action={
                <IconButton aria-label="settings">
                <MoreVertIcon />
                </IconButton>
            }
            title={props.title}
            subheader={props.subtitle}
            />
            <CardMedia
            className={classes.media}
            image={props.imageUrl}
            />
            <CardContent>
                <Typography>
                    {props.description}
                </Typography>
            </CardContent>
            <CardActions disableSpacing>
                <IconButton aria-label="add to favorites">
                    <FavoriteIcon />
                </IconButton>
                <IconButton aria-label="share">
                    <ShareIcon />
                </IconButton>
                <Link to="/productpage">
                    <IconButton aria-label="expand">
                        <AspectRatio />
                    </IconButton>
                </Link>
            </CardActions>
        </Card>
    );
}

export default ProductCard;