import * as React from 'react';
import { Grid, Rating, Typography } from '@mui/material';
import { useEffect, useState } from "react";
import { useNavigate, useParams } from "react-router-dom";

import Button from '@material-ui/core/Button';
import Card from '@mui/material/Card';
import CardMedia from '@mui/material/CardMedia';
import DeleteButtonForDetails from './DeleteProducts/DeleteButtonDetails';
import EditIcon from '@mui/icons-material/Edit';
import Paper from '@mui/material/Paper';
import Stack from '@mui/material/Stack';
import axios from "axios";

export default function ShowProductDetails() {
    let { productType, id } = useParams();
    const [data, setData] = useState([]);
    const navigate = useNavigate();
    // From all objects -> 
    //let productValues = []
    //const selectValues = Object.values(props.dataProperties).map((e) => productValues.push(Object.values(e)));
    //let productKeys = [];
    //const selectKeys = Object.keys(props.dataProperties.map((e) => productKeys.push(Object.keys(e))));
    useEffect(() => {
        axios.get(`https://localhost:7195/product/${productType}/${id}`).then(
            (response) => {
                setData(response.data);
            });
    }, []);

    const renderValues = [];

    Object.keys(data).map((x, idx) => {
        if (x == 'mainImage') {
            //do nothing
        }
        else if (x == 'productOfficialWebsite') {
            //do nothing
        } else if (data[x] === false) {
            renderValues.push(<input type="checkbox" disabled/>)
        } else if (data[x] === true) {
            renderValues.push(<input type="checkbox" checked disabled/>)
        } else if (x == 'id') {
            //do nothing
        } else {
            renderValues.push(<Typography key={idx} style={{fontWeight: 'bold' }}>{data[x]}</Typography>);
        }    
    })

    const renderKeys = [];

    Object.keys(data).map((x, idx) => {
        if (x == 'mainImage') {
            //do nothing
        }
        else if (x == 'productOfficialWebsite') {
            //do nothing
        } else if (x == 'id') {
            //do nothing
        } else {
            renderKeys.push(<Typography key={idx} style={{fontWeight: 'bold' }}>{x}:</Typography>);
        }
    })

    //const productType = localStorage.getItem("productType");
    //From 1 object ->
    // show keys -> {Object.keys(data).map((asd, idx) => <p key={idx}> {asd }</p> ) }
    // show values -> {Object.keys(data).map((asd, idx) => <p key={idx}> {data[asd] }</p> ) } 
    // ami most bent van az az összes adatból való magic, not so good.
    return (

        <>
        <Paper>
            <Button variant="outlined" size="small" onClick={() => navigate(`/product/${productType}`) }> Go back </Button>
            <Grid container md={12}>
                <Grid item md={6}>
                <Typography style={{fontSize: 20, fontWeight: 'bold' }}>{data.name}</Typography>

                <Card sx={{ maxWidth: 550 }}>
                <CardMedia
                    sx={{ height: 330 }}
                    image={data.mainImage}
                />
                </Card>
                <Typography style={{fontSize: 20, fontWeight: 'normal' }} align="center" noWrap="true">Price <Typography style={{fontSize: 25, fontWeight: 'bold' }}>{Number(data.price).toFixed(2)} €</Typography></Typography>
                <Stack  align='center' spacing={1}>
                <Button 
                    color="primary"
                    variant="outlined" 
                    size="small" 
                    title="Go to Edit"
                    onClick={() => {return navigate(`/product/${productType}/${data.id}/edit`)}}>
                   <EditIcon color="primary"  fontSize="small"></EditIcon> Edit
                </Button>
                <DeleteButtonForDetails productType={productType} productId={data.id}/>
                </Stack>
                </Grid>
                <Grid item md={3}>
                {renderKeys}
                </Grid>
                <Grid item md={3}>
                {renderValues}
                </Grid>
            </Grid>
        </Paper>
        </>
    );
}