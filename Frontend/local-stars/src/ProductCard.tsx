import React from 'react';
import { Card, CardHeader, CardMedia, CardContent, CardActions, Avatar, IconButton, Typography, makeStyles, Theme } from '@material-ui/core';
import { green } from '@material-ui/core/colors';
import FavoriteIcon from '@material-ui/icons/Favorite';
import ShareIcon from '@material-ui/icons/Share';
import MoreVertIcon from '@material-ui/icons/MoreVert';

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

function ProductCard(props: { imgSrc: string; title: string; subtitle: string; description: string;}) {
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
        image={props.imgSrc}
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
        </CardActions>
    </Card>
    );
}

export default ProductCard;