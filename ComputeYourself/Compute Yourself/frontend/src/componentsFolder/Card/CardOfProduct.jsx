import { useEffect, useState } from "react";

import Box from '@mui/material/Box';
import Button from '@material-ui/core/Button';
import CardContent from "@material-ui/core/CardContent";
import CardMedia from '@mui/material/CardMedia';
import Grid from "@material-ui/core/Grid";
import Paper from "@mui/material/Paper";
import PropTypes from "prop-types";
import Rating from '@mui/material/Rating';
import Typography from "@material-ui/core/Typography";
import { useNavigate } from "react-router-dom";
import { withStyles } from '@material-ui/core/styles';

const styles = (theme) => ({
    mainGrid: {
      padding: 10,
      marginTop: theme.spacing(4),
    },
    productGrid: {
      padding: 10,
      spacing: 10,
    },
    card: {
      display: "flex",
    },
    cardDetails: {
      flex: 1,
    },
    cardMedia: {
      width: 200,
      height: 60,
    },
  });

const Card = (props) => {
    const navigate = useNavigate();
    const neededValues = [];
    const { classes } = props;
    
    return (
    <>
        {props.dataProperties.map((value, index) =>
            <Grid item md={6}>
                <Paper key={index} elevation={18}>
                
                    <CardMedia
                        sx={{ height: 330 }}
                        image={value.mainImage?value.mainImage:"https://via.placeholder.com/400x150.png"}
                    />
                <CardContent>
                
                        <Typography noWrap="true">{value.name}</Typography>
                        <Typography noWrap="true">{Math.round((value.price)*100)/100} €</Typography>
                        <Typography noWrap="true">Rating</Typography>
                        
                        <Rating name="read-only" value={value.rating} readOnly />
                        <Button variant="outlined" size="small"
                            title="Go to Details"
                            onClick={() => {
                              localStorage.setItem("productType", props.productType)
                              return navigate(`/product/details`, { replace: true, state: { itemId: value.id, productType: props.productType } }
                            )}}
                        >Details
                        </Button>
                        <Button 
                          variant="outlined" 
                          size="small" 
                          title="Go to Edit"
                          onClick={() => {localStorage.setItem("itemId", value.id); return navigate(`/product/${props.productType}/edit`, { replace: true, state: { itemId: value.id } })}}>
                          Edit
                        </Button>
                    </CardContent>
                </Paper>
            </Grid>
        )
      }
    </>    
    )
};

Card.propTypes = {
    classes: PropTypes.object.isRequired,
  };
export default withStyles(styles)(Card);