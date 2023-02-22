import { Link, Outlet, useNavigate } from "react-router-dom";
import { Box } from '@mui/system';
import Logo from '../assets/banner_gs.png';
import Mainpicture from '../assets/maintitle.jpg';
import themeStyle from "../themeStyle"
import useAuth from "../hooks/useAuth"
import { styled } from '@mui/material/styles';
import Toolbar from '@mui/material/Toolbar';
import SearchIcon from '@mui/icons-material/Search';
import IconButton from '@mui/material/IconButton';
import Button from '@mui/material/Button';
import Grid from "@mui/material/Grid";

const Layout = styled('div')(({ theme }) => ({
  flexGrow: 1,
  width: 'auto',
  marginLeft: theme.spacing(3),
  marginRight: theme.spacing(3),
  [theme.breakpoints.up(1200 + theme.spacing(2))]: {
    width: 1150,
    marginLeft: 'auto',
    marginRight: 'auto',
  },
}));

const MainTitle = styled('div')(({ theme }) => ({
  padding: 60,
  fontSize: 45,
  textAlign: 'left',
  color: 'black',
  borderRadius: 3,
  backgroundColor: 'grey',
}));

const MainTitlePicture = styled('div')(({ theme }) => ({
  backgroundImage: `url(${Mainpicture})`,
  backgroundSize: 'contain',
}));

const ToolbarBorder = styled('div')(({ theme }) => ({
  borderBottom: '4px solid lightgrey',
}));

const ToolbarTitle = styled('div')(({ theme }) => ({
  flex: 1,
}));

const ToolbarSecondary = styled('div')(({ theme }) => ({
  justifyContent: 'space-between',
}));

const MainFeaturedPost = styled('div')(({ theme }) => ({
  marginBottom: theme.spacing(3),
}));

const MainFeaturedPostContent = styled('div')(({ theme }) => ({
  borderRadius: 3,
  backgroundColor: 'grey',
  padding: `${theme.spacing(4)}px`,
  [theme.breakpoints.up('md')]: {
    paddingRight: 0,
  },
}));

const MainGrid = styled('div')(({ theme }) => ({
  marginTop: theme.spacing(3),
}));

const Card = styled('div')(({ theme }) => ({
  display: 'flex',
}));

const CardDetails = styled('div')(({ theme }) => ({
  flex: 1,
}));

const CardMedia = styled('div')(({ theme }) => ({
  width: 160,
}));

const Markdown = styled('div')(({ theme }) => ({
  padding: `${theme.spacing(3)}px 0`,
}));

const SidebarAboutBox = styled('div')(({ theme }) => ({
  padding: theme.spacing(2),
  backgroundColor: theme.palette.grey[200],
}));

const SidebarSection = styled('div')(({ theme }) => ({
  marginTop: theme.spacing(3),
}));

const Footer = styled('div')(({ theme }) => ({
  backgroundColor: theme.palette.background.paper,
  textAlign: 'center',
  marginTop: theme.spacing(8),
  padding: `${theme.spacing(2)}px 0`,
}));

export {
  Layout,
  MainTitle,
  MainTitlePicture,
  ToolbarBorder,
  ToolbarTitle,
  ToolbarSecondary,
  MainFeaturedPost,
  MainFeaturedPostContent,
  MainGrid,
  Card,
  CardDetails,
  CardMedia,
  Markdown,
  SidebarAboutBox,
  SidebarSection,
  Footer,
};


function RootLayout(props) {
    
  const { classes } = props;
  return (
    <Layout>
      <header>
        <div style={themeStyle.root}>
        </div>
          <ToolbarBorder>
            <Grid container spacing={1} >
              <Grid container item xs={12} spacing={3}>
                <Header />
              </Grid>
            </Grid>
          </ToolbarBorder>
        <nav>
          <Toolbar>
            <NavBar />
          </Toolbar>
        </nav>
      </header>
      <main>
        <Outlet />
        <Footer>
          <Box>
            Compute Yourself team 2023.
          </Box>
        </Footer>  
      </main>
    </Layout>
  );
}

function Header() {
    const navigate = useNavigate();   
    let { auth } = useAuth();
    let checkIfLoggedIn = localStorage.getItem("isLoggedIn");
  return (
    
    <>
      <Grid item md={2}>
        <Link to="/">
          <Box component="img" style={themeStyle.mainLogo} alt="Compute yourself" src={Logo}/>
        </Link>
      </Grid>
      <Grid item md={6}>
        <Box style={themeStyle.mainLogoText}>
          Compute Yourself
        </Box>
      </Grid>
      <Grid item md={1}>
          <IconButton style={themeStyle.navbarButton}>
            <SearchIcon />
          </IconButton>
      </Grid>
      {checkIfLoggedIn == "false" ? 
        <>
        <Grid item md={1}>
            <Button style={themeStyle.navbarButton} variant="outlined" size="small" onClick={() => navigate(`/account/register`)}>
              Sign up
            </Button>
        </Grid>
        <Grid item md={1}>
          <Button style={themeStyle.navbarButton} variant="outlined" size="small" onClick={() => navigate(`/account/login`)}>
              Login
            </Button>
        </Grid>
        </>
        :
        <>
          <Grid item md={1}>
            <Box style={themeStyle.navbarButton}>
              <Link to="/about">{auth.name }</Link>  
            </Box>
          </Grid>

          <Grid item md={1}>
            <Button style={themeStyle.navbarButton} variant="outlined" size="small" onClick={() => {
                localStorage.setItem("isLoggedIn", "false")
                return navigate("/")
              }}>
              Logout
            </Button>
          </Grid>
        </>
      }
    </>
  )
}

function NavBar() {
  return (
    <>
        <Grid item md={1}>
          <Button style={themeStyle.navbarButton} component={Link} to="/" variant="outlined" size="small">
            Home
          </Button>
        </Grid>
        <Grid item md={1}>
          <Button style={themeStyle.navbarButton} component={Link} to="/about" variant="outlined" size="small">
            About
          </Button>
        </Grid>
        <Grid item md={1}>
          <Button style={themeStyle.navbarButton} component={Link} to="/product/cpu" variant="outlined" size="small">
            Products
          </Button>
        </Grid>
    </>
  )
}

export default (RootLayout);