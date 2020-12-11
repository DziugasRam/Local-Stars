import React, {useState} from 'react';
import { Card, CardHeader, CardMedia, CardContent, CardActions, IconButton, Typography, makeStyles, Theme, Paper, Grid} from '@material-ui/core';
import { green } from '@material-ui/core/colors';
import FavoriteIcon from '@material-ui/icons/Favorite';
import ShareIcon from '@material-ui/icons/Share';
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

function ProductCard(props: { phoneNumber: string; title: string; category: string; price: string; firstName: string; description: string;}) {
    const classes = useStyles();

    const [modalIsOpne, setModalIsOpen] = useState(false)

    const [isLiked, setIsLiked] = useState(false)

    const handleClose = () => setModalIsOpen(false)

    const handleOpen = () => setModalIsOpen(true)

    const handleLike = () => setIsLiked(!isLiked)

    const Like = (props: {isLiked:boolean;}) => {
        if (props.isLiked) return <FavoriteIcon />;
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
                <CardMedia
                className={classes.media}
                image="https://www.shethepeople.tv/wp-content/uploads/2019/05/cucumber-e1558166231577.jpg"
                />
                <CardContent>
                    <Typography noWrap={true}>
                        {props.description}
                    </Typography>
                </CardContent>
                <CardActions disableSpacing>
                    <IconButton aria-label="add to favorites" onClick={handleLike}>
                        <Like isLiked = {isLiked}/>
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
                        <img className={classes.img} alt="product" src="https://www.shethepeople.tv/wp-content/uploads/2019/05/cucumber-e1558166231577.jpg" />
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
                                <IconButton aria-label="favorites" onClick={handleLike}>
                                    <Like isLiked = {isLiked}/>
                                </IconButton>
                            </Grid>
                            <Grid item xs>
                                <DescriptionTable description={props.description} seller={props.firstName} phonenumber={props.phoneNumber}/>
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