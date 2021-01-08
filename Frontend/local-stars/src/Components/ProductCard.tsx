import React, {useState, useEffect} from 'react';
import { Card, CardHeader, CardMedia, CardContent, CardActions, IconButton, Typography, makeStyles, Theme, Paper, Grid} from '@material-ui/core';
import { green } from '@material-ui/core/colors';
import { serverUrl } from "../configuration";
import { authFetch } from "../utils/auth";
import FavoriteIcon from '@material-ui/icons/Favorite';
import DeleteForever from '@material-ui/icons/DeleteForever'
import Edit from '@material-ui/icons/Edit'
import FavoriteBorderIcon from '@material-ui/icons/FavoriteBorder';
import DescriptionTable from './DescriptionTable';
import AspectRatio from '@material-ui/icons/AspectRatio';
import Modal from 'react-modal';
import { UserService } from '../http-service/user-service';
import { ProductsService } from '../http-service/products-service';

const useStyles = makeStyles((theme: Theme) => ({
    root: {
        maxWidth: 375,
        maxHeight: 600,
        backgroundColor: '#ffdba1',
    },
    media: {
        height: 250,
        maxHeight: 250,
        width: 'auto',
        maxWidth: 400,
    },
    header: {
        height: 100,
    },
    avatar: {
        backgroundColor: green[500],
    },
    paper: {
        padding: theme.spacing(2),
        margin: 'auto',
        maxWidth: 1000,
    },
    img: {
        width: 400,
        height: 400,
    },
    modal: {
        margin: 'auto',
        marginTop: 200,
        maxWidth: 1000,
    },
}));


function ProductCard(props: { title: string; category: string; price: string; description: string; id: string; seller: any; image: string; buyerId: string | null}) {
    const isCurrentSellers = UserService.getSellerId() == props.seller?.id;
    const classes = useStyles();

    const [modalIsOpne, setModalIsOpen] = useState(false);
    const [isLiked, setIsLiked] = useState(false);

    const handleClose = () => setModalIsOpen(false)

    const handleOpen = () => setModalIsOpen(true)

    useEffect (() => {
        if(props.buyerId){
            authFetch(`${serverUrl}/api/buyer/isLiked?buyerId=${props.buyerId}&productId=${props.id}`)
            .then(resp => resp?.json())
            .then(data => setIsLiked(data))
        }
    }, [])

    const handleLike = () => {
        if (props.buyerId == null) {
            alert("You have to signin to like products")
            return;
        };

        const product = {
            id: props.id,
            description: props.description,
            seller: props.seller,
            price: props.price,
            category: props.category,
            title: props.title,
            image: props.image,
        };

        const requestOptionsPost: RequestInit = {
            method: "POST",
            headers: {
				"Content-Type": "application/json",
			},
            body: JSON.stringify(product),
        };

        const requestOptionsDelete: RequestInit = {
            method: "DELETE",
            headers: {
				"Content-Type": "application/json",
			},
            body: JSON.stringify(product),
        };

        isLiked
            ? authFetch(`${serverUrl}/api/buyer/unlike/${props.buyerId}`, requestOptionsDelete)
            : authFetch(`${serverUrl}/api/buyer/like/${props.buyerId}`, requestOptionsPost)

        setIsLiked(!isLiked)
    }

    const handleDelete = () => {
        ProductsService.deleteProduct(props.id).then(success => {
            if(success) {
                ProductsService.removeProduct(props.id)
                setModalIsOpen(false);
            }
        });
    }

    const editTitle = () => {
        const title = prompt("Title:") || props.title;
        ProductsService.updateProductData(props.id, {title: title});
    }

    const editPrice = () => {
        const price = parseInt(prompt("Price:") || props.price);
        ProductsService.updateProductData(props.id, {price: price});
    }

    const editDescription = () => {
        const description = prompt("Description:") || props.description;
        ProductsService.updateProductData(props.id, {description: description});
    }

    const Like = () => {
        if (isLiked) return <FavoriteIcon />;
        return <FavoriteBorderIcon />;
    }

    return (
        <div>
            <Card className={classes.root}>
                <CardHeader
                title={props.title}
                subheader={props.category}
                className={classes.header}
                />
                <CardMedia className={classes.media}>
                <img className={classes.media} alt="product" src={`data:image/jpg;base64,${props.image}`} />
                </CardMedia>
                <CardContent>
                    <Typography noWrap={true}>
                        {props.description}
                    </Typography>
                </CardContent>
                <CardActions disableSpacing>
                    <IconButton aria-label="add to favorites" onClick={handleLike}>
                        <Like/>
                    </IconButton>
                    <IconButton aria-label="expand" onClick={handleOpen}>
                        <AspectRatio />
                    </IconButton>
                </CardActions>
            </Card>
            
            <Modal isOpen={modalIsOpne} onRequestClose={handleClose} className={classes.modal}>
                <Paper className={classes.paper}>
                    <Grid container spacing={2}>
                    <Grid item>
                        <img className={classes.img} alt="product" src={`data:image/jpg;base64,${props.image}`} />
                    </Grid>
                    <Grid item xs={12} sm container>
                        <Grid item xs container direction="column">
                            <Grid item xs>
                                <Typography variant="h3">
                                    {props.title}, 1kg
                                    {isCurrentSellers ? 
                                        <IconButton aria-label="edit title" onClick={editTitle}>
                                            <Edit/>
                                        </IconButton>
                                        :
                                        null
                                    }
                                </Typography>
                                <Typography variant="h4">
                                    € {props.price}/kg
                                    {isCurrentSellers ? 
                                        <IconButton aria-label="edit price" onClick={editPrice}>
                                            <Edit/>
                                        </IconButton>
                                        :
                                        null
                                    }
                                </Typography>
                                <IconButton aria-label="favorites" onClick={handleLike}>
                                    <Like/>
                                </IconButton>
                                {isCurrentSellers ?
                                    <IconButton aria-label="delete" onClick={handleDelete}>
                                        <DeleteForever/>
                                    </IconButton>
                                    :
                                    null
                                }
                            </Grid>
                            <Grid item xs>
                                <DescriptionTable description={props.description} seller={props.seller?.firstName} phonenumber={props.seller?.phoneNumber} editDescription={isCurrentSellers ? editDescription : null}/>
                            </Grid>
                        </Grid>
                    </Grid>
                    </Grid>
                </Paper>
            </Modal>
        </div>
    );
}

export default ProductCard;