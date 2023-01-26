import * as React from 'react';
import { useEffect, useState } from "react";
import axios from "axios";
import { useLocation, useNavigate } from "react-router-dom";
import Button from '@material-ui/core/Button';
import Paper from '@mui/material/Paper';
import { Grid, Rating, Typography } from '@mui/material';
import Card from '@mui/material/Card';
import CardMedia from '@mui/material/CardMedia';

export default function ShowProductDetails() {
    const [data, setData] = useState([]);
    const location = useLocation();
    const navigate = useNavigate();
    // From all objects -> 
    //let productValues = []
    //const selectValues = Object.values(props.dataProperties).map((e) => productValues.push(Object.values(e)));
    //let productKeys = [];
    //const selectKeys = Object.keys(props.dataProperties.map((e) => productKeys.push(Object.keys(e))));
    useEffect(() => {
        axios.get(`https://localhost:7195/product/${location.state.productType}/${location.state.itemId}`).then(
            (response) => {
                setData(response.data);
            });
    }, []);
    const picture = "https://www.pcgamesn.com/wp-content/sites/pcgamesn/2017/09/cpu-upgrade.jpg";
    console.log(typeof(data.rating));
    //From 1 object ->
    // show keys -> {Object.keys(data).map((asd, idx) => <p key={idx}> {asd }</p> ) }
    // show values -> {Object.keys(data).map((asd, idx) => <p key={idx}> {data[asd] }</p> ) } 
    // ami most bent van az az összes adatból való magic, not so good.
    return (
        <>
        <Paper>
            <Button variant="outlined" size="small" onClick={() => navigate("/product") }> go back </Button>
            <Grid container md={12}>
                <Grid item md={6}>
                <Typography style={{fontSize: 20, fontWeight: 'bold' }}>{data.name}</Typography>

                <Card sx={{ maxWidth: 550 }}>
                <CardMedia
                    sx={{ height: 330 }}
                    image={picture}
                    title="green iguana"
                />
                </Card>
                <Typography style={{fontSize: 20, fontWeight: 'normal' }} align="center" noWrap="true">Price <Typography style={{fontSize: 25, fontWeight: 'bold' }}>{Math.round((data.price/388)*100)/100} €</Typography></Typography>
                </Grid>
                <Grid item md={3}>
                {Object.keys(data).map((propName, idx) => <Typography style={{fontWeight: 'bold' }}>{propName}:</Typography>)}
                </Grid>
                <Grid item md={3}>
                {Object.values(data).map((propName, idx) => <Typography style={{fontWeight: 'normal' }}>{propName}</Typography>)}
                </Grid>
            </Grid>
        </Paper>
        </>
    );
}