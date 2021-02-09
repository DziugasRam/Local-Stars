import React, {useState} from 'react';
import { fade, makeStyles, Theme, createStyles } from '@material-ui/core/styles';
import AppBar from '@material-ui/core/AppBar';
import Toolbar from '@material-ui/core/Toolbar';
import IconButton from '@material-ui/core/IconButton';
import InputBase from '@material-ui/core/InputBase';
import MenuItem from '@material-ui/core/MenuItem';
import Menu from '@material-ui/core/Menu';
import SearchIcon from '@material-ui/icons/Search';
import FavoriteIcon from '@material-ui/icons/Favorite';
import SortIcon from '@material-ui/icons/Sort';
import AddIcon from '@material-ui/icons/Add';
import MoreIcon from '@material-ui/icons/MoreVert';
import SignInIcon from '@material-ui/icons/LockOpen';
import SignOutIcon from '@material-ui/icons/Lock';
import StoreIcon from '@material-ui/icons/Store';
import { Link } from 'react-router-dom';
import { Tooltip } from '@material-ui/core';
import { UserService } from '../http-service/user-service';

const useStyles = makeStyles((theme: Theme) =>
  createStyles({
    bar: {
        position: 'static',
        backgroundColor: '#FBB03B',
    },
    grow: {
      flexGrow: 1,
    },
    search: {
        position: 'relative',
        borderRadius: theme.shape.borderRadius,
        backgroundColor: fade(theme.palette.common.white, 0.15),
        '&:hover': {
            backgroundColor: fade(theme.palette.common.white, 0.25),
        },
        width: '100%',
        [theme.breakpoints.up('sm')]: {
            marginLeft: theme.spacing(3),
            width: 'auto',
        },
    },
    searchIcon: {
        padding: theme.spacing(0, 2),
        height: '100%',
        position: 'absolute',
        pointerEvents: 'none',
        display: 'flex',
        alignItems: 'center',
        justifyContent: 'center',
    },
    inputRoot: {
        color: 'inherit',
    },
    inputInput: {
        padding: theme.spacing(1, 1, 1, 0),
        paddingLeft: `calc(1em + ${theme.spacing(4)}px)`,
        transition: theme.transitions.create('width'),
        width: '100%',
        [theme.breakpoints.up('md')]: {
        width: '50ch',
        },
    },
    sectionDesktop: {
        display: 'none',
        [theme.breakpoints.up('md')]: {
        display: 'flex',
        },
    },
    sectionMobile: {
        display: 'flex',
        [theme.breakpoints.up('md')]: {
        display: 'none',
        },
    },
  }),
);

function BuyerBar (props: {onSearch: any; onSortSelect: any; onLiked: any; onSellersProducts: any; buyerId: string | null}) {
    const classes = useStyles();
    const [anchorEl, setAnchorEl] = useState<null | HTMLElement>(null);
    const [mobileMoreAnchorEl, setMobileMoreAnchorEl] = useState<null | HTMLElement>(null);

    const isMenuOpen = Boolean(anchorEl);
    const isMobileMenuOpen = Boolean(mobileMoreAnchorEl);

    const handleSortMenuOpen = (event: React.MouseEvent<HTMLElement>) => {
        setAnchorEl(event.currentTarget);
    };

    const handleMobileMenuClose = () => {
        setMobileMoreAnchorEl(null);
    };

    const handleMenuClose = () => {
        setAnchorEl(null);
        handleMobileMenuClose();
    };

    const handleMobileMenuOpen = (event: React.MouseEvent<HTMLElement>) => {
        setMobileMoreAnchorEl(event.currentTarget);
    };

    const handleTextInput = (event: React.ChangeEvent<HTMLInputElement | HTMLTextAreaElement>) => {
        const searchResult = event.target.value;

        props.onSearch(searchResult);
    };

    const handleAZ = () => {
        handleMenuClose();

        props.onSortSelect("A-Z");
    };

    const handleZA = () => {
        handleMenuClose();

        props.onSortSelect("Z-A");
    };

    const handleLowPrice = () => {
        handleMenuClose();

        props.onSortSelect("Price: Lowest First");
    };

    const handleHighPrice = () => {
        handleMenuClose();

        props.onSortSelect("Price: Highest First");
    };

    const handleLiked = () => {
        if (props.buyerId == null) {
            window.alert("You have to signin to see liked products")
            return;
        }
        props.onLiked();
    };

    const handleSellersProducts = () => {
        if (props.buyerId == null) {
            window.alert("You have to signin to see your products")
            return;
        }
        props.onSellersProducts();
    };

    const handleSignOut = () => {
        UserService.signOut().then(success => success && (document.location.href = document.location.origin))
    }

    const menuId = 'primary-sort-menu';
    const renderMenu = (
    <Menu
        anchorEl={anchorEl}
        anchorOrigin={{ vertical: 'top', horizontal: 'right' }}
        id={menuId}
        keepMounted
        transformOrigin={{ vertical: 'top', horizontal: 'right' }}
        open={isMenuOpen}
        onClose={handleMenuClose}
    >
        <MenuItem onClick={handleAZ}>A-Z</MenuItem>
        <MenuItem onClick={handleZA}>Z-A</MenuItem>
        <MenuItem onClick={handleLowPrice}>Price: Lowest First</MenuItem>
        <MenuItem onClick={handleHighPrice}>Price: Highest First</MenuItem>
    </Menu>
    );

    const mobileMenuId = 'primary-menu-mobile';
    const renderMobileMenu = (
    <Menu
        anchorEl={mobileMoreAnchorEl}
        anchorOrigin={{ vertical: 'top', horizontal: 'right' }}
        id={mobileMenuId}
        keepMounted
        transformOrigin={{ vertical: 'top', horizontal: 'right' }}
        open={isMobileMenuOpen}
        onClose={handleMobileMenuClose}
    >
        <MenuItem onClick={handleSortMenuOpen}>
            <IconButton 
                aria-label="sort menu"
                color="inherit"
                aria-controls={menuId}
                aria-haspopup="true"
            >
                <SortIcon />
            </IconButton>
            <p>Sort</p>
        </MenuItem>
        <MenuItem onClick={handleLiked}>
            <IconButton aria-label="liked products" color="inherit">
                    <FavoriteIcon />
            </IconButton>
            <p>Liked Products</p>
        </MenuItem>
        <MenuItem onClick={handleSellersProducts}>
            <IconButton aria-label="sellers products" color="inherit">
                    <StoreIcon />
            </IconButton>
            <p>My Products</p>
        </MenuItem>
        <Link to ="/NewListingForm" style={{ color: '#000' }}>
            <MenuItem>
                <IconButton aria-label="add new product" color="inherit">
                        <AddIcon />
                </IconButton>
                <p>Add Product</p>
            </MenuItem>
        </Link>
        <Link to ="/signin" style={{ color: '#000' }}>
            <MenuItem>
                <IconButton aria-label="signin" color="inherit">
                        <SignInIcon />
                </IconButton>
                <p>Signin</p>
            </MenuItem>
        </Link>
    </Menu>
    );

    return (
    <div className={classes.grow}>
        <AppBar className={classes.bar}>
        <Toolbar>
            <div className={classes.search}>
            <div className={classes.searchIcon}>
                <SearchIcon />
            </div>
            <InputBase
                placeholder="Search…"
                classes={{
                root: classes.inputRoot,
                input: classes.inputInput,
                }}
                inputProps={{ 'aria-label': 'search' }}
                onChange={handleTextInput}
            />
            </div>
            <div className={classes.grow} />
            <div className={classes.sectionDesktop}>
            <Tooltip title="Sort">
            <IconButton
                aria-label="sort menu"
                color="inherit"
                aria-controls={menuId}
                aria-haspopup="true"
                onClick={handleSortMenuOpen}
            >
                <SortIcon />
            </IconButton>
            </Tooltip>
            {
                UserService.getUserId() != null ?
                <Tooltip title="Liked Products">
                    <IconButton aria-label="liked products" color="inherit" onClick={handleLiked}>
                        <FavoriteIcon />
                    </IconButton>
                </Tooltip>
                :
                null
            }
            {
                UserService.getSellerId() != null ?
                <Tooltip title="My Products">
                    <IconButton aria-label="sellers products" color="inherit" onClick={handleSellersProducts}>
                        <StoreIcon />
                    </IconButton>
                </Tooltip>
                :
                null
            }
            {
                UserService.getSellerId() != null ?
                <Tooltip title="Add Product">
                    <Link to ="/NewListingForm" style={{ color: '#FFF' }}>
                        <IconButton aria-label="add new product" color="inherit">
                            <AddIcon />
                        </IconButton>
                    </Link>
                </Tooltip>
                :
                null
            }
            {
                UserService.getUserId() == null ?
                <Tooltip title="Signin">
                    <Link to ="/signin" style={{ color: '#FFF' }}>
                        <IconButton aria-label="signin" color="inherit">
                            <SignInIcon />
                        </IconButton>
                    </Link>
                </Tooltip>
                :
                <Tooltip title="Signout">
                    <IconButton aria-label="signout" color="inherit" onClick={handleSignOut}>
                        <SignOutIcon />
                    </IconButton>
                </Tooltip>
            }
            </div>
            <div className={classes.sectionMobile}>
            <IconButton
                aria-label="show more"
                aria-controls={mobileMenuId}
                aria-haspopup="true"
                onClick={handleMobileMenuOpen}
                color="inherit"
            >
                <MoreIcon />
            </IconButton>
            </div>
        </Toolbar>
        </AppBar>
        {renderMobileMenu}
        {renderMenu}
    </div>
    );
}

export default BuyerBar;