import { Box, ThemeProvider, createTheme } from '@mui/system';
import { Link, NavLink, Outlet, useNavigate } from "react-router-dom";

import Button from '@material-ui/core/Button';
import { Container } from "react-bootstrap";
import Grid from "@mui/material/Grid";
import IconButton from '@material-ui/core/IconButton';
import Logo from '../assets/banner_gs.png';
import Mainpicture from '../assets/maintitle.jpg';
import Paper from "@mui/material/Paper";
import PropTypes from 'prop-types';
import SearchIcon from '@material-ui/icons/Search';
import Toolbar from '@material-ui/core/Toolbar';
import { withStyles } from '@material-ui/core/styles';
import jwt from 'jwt-decode';
import useAuth from "../hooks/useAuth"

//import Logo from '../assets/logo.svg';


const classes = {
  root: {
    flexGrow: 1
  },
  paper: {
    padding: 20,
    textAlign: "center",
    color: "blue"
  },
  cyLogo: {
    padding: 5,
    marginLeft: 15,
    textAlign: "left",
    color: "blue"
  },
  cyLogoText: {
    margin: 7,
    fontSize: 50,
    fontWeight: 'bold',
    textAlign: "center",
    color: "black"
  },
  searchButton: {
    padding: 20,
    textAlign: "center",
  },
  mainTitle: {
    padding: 20,
    fontSize: 50,
    textAlign: "left",
    color: "black"
  },
};

const styles = theme => ({
  layout: {
    width: 'auto',
    marginLeft: theme.spacing(3),
    marginRight: theme.spacing(3),
    [theme.breakpoints.up(1500 + theme.spacing(6))]: {
      width: 1150,
      marginLeft: 'auto',
      marginRight: 'auto',
    },
  },
  mainTitle: {
    padding: 60,
    fontSize: 45,
    textAlign: "left",
    color: "black",
    borderRadius: 3,

    backgroundColor: "grey",
  },
  mainTitlePicture: {
    image:`url(${Mainpicture})`,
    backgroundSize:"contain",
  },
  toolbarMain: {
    borderBottom: `4px solid ${theme.palette.grey[300]}`,
  },
  toolbarTitle: {
    flex: 1,
  },
  toolbarSecondary: {
    justifyContent: 'space-between',
  },
  mainFeaturedPost: {
    
    marginBottom: theme.spacing(3),
  },
  mainFeaturedPostContent: {
    borderRadius: 3,

    backgroundColor: "grey",
    padding: `${theme.spacing(4)}px`,
    [theme.breakpoints.up('md')]: {
      paddingRight: 0,
    },
  },
  mainGrid: {
    marginTop: theme.spacing(3),
  },
  card: {
    display: 'flex',
  },
  cardDetails: {
    flex: 1,
  },
  cardMedia: {
    width: 160,
  },
  markdown: {
    padding: `${theme.spacing(3)}px 0`,
  },
  sidebarAboutBox: {
    padding: theme.spacing(2),
    backgroundColor: theme.palette.grey[200],
  },
  sidebarSection: {
    marginTop: theme.spacing(3),
  },
  footer: {
    backgroundColor: theme.palette.background.paper,
    textAlign: "center",
    marginTop: theme.spacing(8),
    padding: `${theme.spacing(2)}px 0`,
  },
});
function RootLayout(props) {
    
  const { classes } = props;
  return (
    <div className={classes.layout}>
        <header>
          <div style={classes.root}>
            <Toolbar className={classes.toolbarMain}>
              <Grid container spacing={1} >
                <Grid container item xs={12} spacing={3}>
                  <Header />
                </Grid>
              </Grid>
            </Toolbar>
          </div>
          <nav>
            <Toolbar>
              <NavBar />
            </Toolbar>
          </nav>
        </header>
      <main>

       
          <Outlet />

        <footer className={classes.footer}>
          <Box>
            Compute Yourself team 2023.
          </Box>
        </footer>  

      </main>
    </div>
  );
}

function Header() {
    const navigate = useNavigate();   
    let { auth } = useAuth();
    let checkIfLoggedIn = localStorage.getItem("isLoggedIn");
  return (
    <>
      <Grid item xs={2}>
        <Box  style={classes.cyLogo}>
          <Link to="/">
            <Box component="img" sx={{ height: 80, width: 80, }} alt="Compute yourself" src={Logo}/>
          </Link>
        </Box>
      </Grid>
      <Grid item xs={6}>
        <Box style={classes.cyLogoText}>
          Compute Yourself
        </Box>
      </Grid>
      <Grid item xs={1}>
        <Box style={classes.searchButton}>
          <IconButton>
            <SearchIcon />
          </IconButton>
        </Box>
          </Grid>
          {checkIfLoggedIn == null ? 
              <>
              <Grid item xs={2}>
                <Box style={classes.searchButton}>
                 <Button variant="outlined" size="small" onClick={() => navigate(`/account/register`)}>
                    Sign up
                  </Button>
                </Box>
              </Grid>
              <Grid item xs={1}>
                <Box style={classes.searchButton}>
                <Button variant="outlined" size="small" onClick={() => navigate(`/account/login`)}>
                    Login
                  </Button>
                </Box>
              </Grid>
              </>
              :
              <>
                  <Grid item xs={2}>
                      <Box style={classes.searchButton}>
                          <Button variant="outlined" size="small">
                              {auth.name }
                          </Button>
                      </Box>
                  </Grid>
                <Grid item xs={1}>
                    <Box style={classes.searchButton}>
                          <Button variant="outlined" size="small" onClick={() => {
                              localStorage.removeItem("isLoggedIn")
                              return navigate("/")
                          }}>
                            Logout
                        </Button>
                    </Box>
                </Grid>
              </>}
    </>

  )
}

function NavBar() {

  return (
    <>
        <Grid item xs={1}>
          <Box style={classes.searchButton}>
            <Button component={Link} to="/" variant="outlined" size="small">
              Home
            </Button>
          </Box>
        </Grid>
        <Grid item xs={1}>
          <Box style={classes.searchButton}>
              <Button component={Link} to="/about" variant="outlined" size="small">
                About
              </Button>
          </Box>
        </Grid>
        <Grid item xs={1}>
          <Box style={classes.searchButton}>
              <Button component={Link} to="/product/cpu" variant="outlined" size="small">
                Products
              </Button>
          </Box>
        </Grid>
    </>
  )
}

RootLayout.propTypes = {
  classes: PropTypes.object.isRequired,
};

export default withStyles(styles)(RootLayout, Header);