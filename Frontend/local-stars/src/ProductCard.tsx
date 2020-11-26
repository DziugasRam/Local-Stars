import React, {useState} from 'react';
import { Card, CardHeader, CardMedia, CardContent, CardActions, IconButton, Typography, makeStyles, Theme, Paper, Grid} from '@material-ui/core';
import { green } from '@material-ui/core/colors';
import FavoriteIcon from '@material-ui/icons/Favorite';
import ShareIcon from '@material-ui/icons/Share';
import MoreVertIcon from '@material-ui/icons/MoreVert';
import FavoriteBorderIcon from '@material-ui/icons/FavoriteBorder';
import DescriptionTable from './DescriptionTable';
import AspectRatio from '@material-ui/icons/AspectRatio';
import Modal from 'react-modal';

const useStyles = makeStyles((theme: Theme) => ({
    root: {
        maxWidth: 375,
        maxHeight: 600,
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

function ProductCard(props: { phonenumber: string; seller: string; price: string; imageUrl: string; title: string; subtitle: string; description: string;}) {
    const classes = useStyles();

    const [modalIsOpne, setModalIsOpen] = useState(false)

    const handleClose = () => setModalIsOpen(false)

    const handleOpen = () => setModalIsOpen(true)

    return (
        <div>
            <Card className={classes.root}>
                <CardHeader
                action={
                    <IconButton aria-label="settings">
                    <MoreVertIcon />
                    </IconButton>
                }
                title={props.title}
                subheader={props.subtitle}
                className={classes.header}
                />
                <CardMedia
                className={classes.media}
                image={props.imageUrl}
                />
                <CardContent>
                    <Typography noWrap={true}>
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
                    <IconButton aria-label="expand" onClick={handleOpen}>
                        <AspectRatio />
                    </IconButton>
                </CardActions>
            </Card>
            
            <Modal isOpen={modalIsOpne} onRequestClose={handleClose} className={classes.modal}>
                <Paper className={classes.paper}>
                    <Grid container spacing={2}>
                    <Grid item>
                        <img className={classes.img} alt="product" src={props.imageUrl} />
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
                    </Grid>
                    </Grid>
                </Paper>
            </Modal>
        </div>
    );
}

export default ProductCard;