import { useState, useEffect } from "react";
import { useNavigate } from "react-router-dom";
import Paper from "@mui/material/Paper";
import Button from '@material-ui/core/Button';
import PropTypes from "prop-types";
import { withStyles } from '@material-ui/core/styles';
import Grid from "@material-ui/core/Grid";
import CardContent from "@material-ui/core/CardContent";
import Typography from "@material-ui/core/Typography";

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
        <div>
            <Grid xs={1} md={5}>
                {props.dataProperties.map((value, index) =>
                    <Grid  className={classes.productGrid}>
                    <Paper elevation={18}>
                        <div>
                            <div key={index}></div>
                            <CardContent>
                                <Typography noWrap="true">{value.name}</Typography>
                                <Typography noWrap="true">{Math.round(value.price/360)} $</Typography>
                                <Typography noWrap="true">{value.rating}</Typography>
                                <Button variant="outlined" size="small"
                                    title="Go to Details"
                                    onClick={() => navigate(`/product/details`, { replace: true, state: { itemId: productId, productType: props.productType } }
                                    )}
                                >Details
                                </Button>
                            </CardContent>
                        </div>
                    </Paper>
                    </Grid>
                )}
                </Grid>
                
        </div>
    )
};
Card.propTypes = {
    classes: PropTypes.object.isRequired,
  };
export default withStyles(styles)(Card);