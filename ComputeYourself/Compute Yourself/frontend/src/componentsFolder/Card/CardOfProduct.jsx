import { useState, useEffect } from "react";
import { useNavigate } from "react-router-dom";
import Paper from "@mui/material/Paper";
import Button from '@material-ui/core/Button';
import PropTypes from "prop-types";
import { withStyles } from '@material-ui/core/styles';
import Grid from "@material-ui/core/Grid";
import CardContent from "@material-ui/core/CardContent";
import Typography from "@material-ui/core/Typography";
import Rating from '@mui/material/Rating';

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
    const [productId, setProductId] = useState([]);
    const navigate = useNavigate();
    const neededValues = [];
    const { classes } = props;
    useEffect(() => {
        Object.keys(props.dataProperties.map((e) => setProductId(e.id)));
    }, [neededValues])


    return (
    <>
        {props.dataProperties.map((value, index) =>
            <Grid item md={6}>
                <Paper key={index} elevation={18}>
                    <CardContent>
                        <Typography noWrap="true">{value.name}</Typography>
                        <Typography noWrap="true">{Math.round((value.price/388)*100)/100} €</Typography>
                        <Typography noWrap="true">Rating</Typography>
                        
                        <Rating name="read-only" value={value.rating} readOnly />
                        <Button variant="outlined" size="small"
                            title="Go to Details"
                            onClick={() => navigate(`/product/details`, { replace: true, state: { itemId: productId, productType: props.productType } }
                            )}
                        >Details
                        </Button>
                    </CardContent>
                </Paper>
            </Grid>
        )}
    </>    

    )
};
Card.propTypes = {
    classes: PropTypes.object.isRequired,
  };
export default withStyles(styles)(Card);