import { Outlet, Link, NavLink } from "react-router-dom";
import { Box, ThemeProvider, createTheme } from '@mui/system';
import PropTypes from 'prop-types';
import { withStyles } from '@material-ui/core/styles';
import Logo from '../assets/banner_gs.png';
import Mainpicture from '../assets/maintitle.jpg';

import Button from '@material-ui/core/Button';
//import Logo from '../assets/logo.svg';
import IconButton from '@material-ui/core/IconButton';
import SearchIcon from '@material-ui/icons/Search';
import Toolbar from '@material-ui/core/Toolbar';
import Typography from '@material-ui/core/Typography';
import { Container } from "react-bootstrap";
import Grid from "@mui/material/Grid";
import Paper from "@mui/material/Paper";

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
    color: "blue"
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
    marginLeft: theme.spacing.unit * 3,
    marginRight: theme.spacing.unit * 3,
    [theme.breakpoints.up(1500 + theme.spacing.unit * 3 * 2)]: {
      width: 1150,
      marginLeft: 'auto',
      marginRight: 'auto',
    },
  },
  mainTitle: {
    padding: 60,
    fontSize: 45,
    textAlign: "left",
    color: "black"
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
    
    marginBottom: theme.spacing.unit * 3,
  },
  mainFeaturedPostContent: {
    borderRadius: 3,

    backgroundColor: "grey",
    padding: `${theme.spacing.unit * 4}px`,
    [theme.breakpoints.up('md')]: {
      paddingRight: 0,
    },
  },
  mainGrid: {
    marginTop: theme.spacing.unit * 3,
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
    padding: `${theme.spacing.unit * 3}px 0`,
  },
  sidebarAboutBox: {
    padding: theme.spacing.unit * 2,
    backgroundColor: theme.palette.grey[200],
  },
  sidebarSection: {
    marginTop: theme.spacing.unit * 3,
  },

});
function RootLayout(props) {
  const { classes } = props;
  return (
    <div className={classes.layout}>
      <div>
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
      </div>
      <main>

        <Outlet />
        

      </main>
    </div>
  );
}

function Header() {

  return (
    <>
      <Grid item xs={2}>
        <Box  style={classes.cyLogo}>
          <Link to="/">
            <Box component="img" sx={{ height: 80, width: 80, }} alt="Compute yourself" src={Logo}/>
          </Link>
        </Box>
      </Grid>
      <Grid item xs={7}>
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
      <Grid item xs={1}>
        <Box style={classes.searchButton}>
          <Button variant="outlined" size="small">
            Sign up
          </Button>
        </Box>
      </Grid>
      <Grid item xs={1}>
        <Box style={classes.searchButton}>
          <Button variant="outlined" size="small">
            Login
          </Button>
        </Box>
      </Grid>
    </>

  )
}

function NavBar() {
  return (
    <>
        <Grid item xs={1}>
          <Box style={classes.searchButton}>
            <Button component={Link} to="/"variant="outlined" size="small">
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
              <Button component={Link} to="/product" variant="outlined" size="small">
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
Header.propTypes = {
  header: PropTypes.object.isRequired,
};
export default withStyles(styles)(RootLayout, Header);