import Box from '@mui/material/Box';
import Button from '@material-ui/core/Button';
import CardContent from "@material-ui/core/CardContent";
import CardMedia from '@mui/material/CardMedia';
import DeleteButtonCard from "../../routes/DeleteProducts/DeleteButtonCard";
import EditIcon from '@mui/icons-material/Edit';
import Grid from "@material-ui/core/Grid";
import Paper from "@mui/material/Paper";
import Rating from '@mui/material/Rating';
import Stack from '@mui/material/Stack';
import Typography from "@material-ui/core/Typography";
import VisibilityIcon from '@mui/icons-material/Visibility';
import { Link, useNavigate } from "react-router-dom";
import useAuth from "../../hooks/useAuth"


function adminField(props, value, navigate, loggedIn, isAdmin) {

    if (isAdmin && loggedIn){
    return (
      <Stack direction="row-reverse"   align='center' spacing={1}>
        <Button variant="outlined" size="small"
            title="Go to Details"
            onClick={() => {return navigate(`/product/${props.productType}/${value.id}/details`)}}>
          <VisibilityIcon fontSize="small"></VisibilityIcon> Details
        </Button>
        <Button 
          variant="outlined" 
          size="small" 
          title="Go to Edit"
          color="primary"
          onClick={() => {return navigate(`/product/${props.productType}/${value.id}/edit`)}}>
          <EditIcon color="primary"  fontSize="small"></EditIcon> Edit
        </Button>
        <DeleteButtonCard productType={props.productType} productId={value.id}/>
      </Stack>
    );
  }
}
const Card = (props) => {
    const navigate = useNavigate();
    const { auth } = useAuth();
    const loggedIn = localStorage.getItem("isLoggedIn");
    const isAdmin = auth?.roles?.includes("Admin");
    return (
    <>
        {props.dataProperties.map((value, index) =>
            <Grid item md={6} key={index }>
                <Paper key={index} elevation={18}>
                  <CardContent>
                      <Box height={280} sx={{ display: 'flex', justifyContent: 'center' }}>
                        <CardMedia 
                          component="img"
                          sx={{ height: 250, width: 'auto'}}
                          image={value.mainImage?value.mainImage:"https://via.placeholder.com/400x150.png"}
                          onClick={() => {return navigate(`/product/${props.productType}/${value.id}/details`)}}
                          />
                      </Box>
                    <Typography align='center' variant='subtitle1'>
                      <Link to={`/product/${props.productType}/${value.id}/details`}>{value.name }</Link>
                    </Typography>
                    {/* <Typography onClick={() => {return navigate(`/product/${props.productType}/${value.id}/details`)}} align='center' variant='subtitle1'>{value.name}</Typography> */}
                    <Typography align='center' variant='h6'>{Number(value.price).toFixed(2)} €</Typography>
                    {/* <Typography variant='justify'>Rating </Typography> */}
                    <Stack direction="column" spacing={1}>
                      <Typography align='left' variant='body1'>Rating</Typography>
                      <Rating precision={0.5} name="read-only" value={value.rating?value.rating:null} readOnly />
                    </Stack>
                        {adminField(props, value, navigate, loggedIn, isAdmin)}
                </CardContent>
              </Paper>
            </Grid>
        )
      }
    </>    
    )
};

export default (Card);