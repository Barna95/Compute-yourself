import * as React from 'react';
import { Grid, Typography } from '@mui/material';
import { useEffect, useState } from "react";
import { useNavigate, useParams } from "react-router-dom";
import Box from '@mui/material/Box';
import Button from '@material-ui/core/Button';
import Card from '@mui/material/Card';
import CardMedia from '@mui/material/CardMedia';
import DeleteButtonForDetails from './DeleteProducts/DeleteButtonDetails';
import EditIcon from '@mui/icons-material/Edit';
import Paper from '@mui/material/Paper';
import Stack from '@mui/material/Stack';
import axios from "axios";
import Table from '@mui/material/Table';
import TableBody from '@mui/material/TableBody';
import TableCell from '@mui/material/TableCell';
import TableContainer from '@mui/material/TableContainer';
import TableRow from '@mui/material/TableRow';
import Link from '@mui/material/Link';
import useAuth from "../hooks/useAuth"

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

    const renderKeys = [];

    Object.keys(data).map((x, idx) => {
        const camelKeysToText = x.replace(/([A-Z])/g, " $1").charAt(0).toUpperCase() + x.replace(/([A-Z])/g, " $1").slice(1);
        if (x == 'mainImage') {
            //do nothing
        }
        else if (x == 'productOfficialWebsite') {
            //do nothing
        } else if (x == 'id') {
            //do nothing
        } else if (x == 'description') {
            //do nothing
        } else {
            renderKeys.push(
            <TableBody>
                <TableRow>
                    <TableCell align="left" style={{fontWeight: 'bold' }}>{camelKeysToText}:</TableCell>
                    <TableCell align="right">{(data[x]==false || data[x]== null) ? "No" : (data[x]==true) ? "Yes" : data[x]}</TableCell>
                </TableRow>
            </TableBody>
            );
        }
    })

    //Show admin field
    const { auth } = useAuth();
    const isAdmin = auth?.roles?.includes("Admin");
    const adminField = [];
    if (isAdmin){
        adminField.push(
                <Grid item md={12} padding={2}>
                    <Paper elevation={5} align="center">
                        <Stack direction="row" padding={1} spacing={2} width={300}>
                            <Button variant="outlined" size="small" onClick={() => navigate(`/product/${productType}`) }> Go back </Button>
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
                    </Paper>
                </Grid>
        );
    }
    //const productType = localStorage.getItem("productType");
    //From 1 object ->
    // show keys -> {Object.keys(data).map((asd, idx) => <p key={idx}> {asd }</p> ) }
    // show values -> {Object.keys(data).map((asd, idx) => <p key={idx}> {data[asd] }</p> ) } 
    // ami most bent van az az összes adatból való magic, not so good.
    return (

        <>
        <Paper elevation={24} sx={{padding: 2}}>
            {adminField}
            <Grid container md={12}>
                <Grid item md={6} padding={2}>
                    <Paper elevation={5} align="center" style={{ height: 530 }}>
                        <Typography padding={1} style={{fontSize: 20, fontWeight: 'bold' }}>
                            {data.name}
                        </Typography>
                        <Box height={280} sx={{  padding: 3, display: 'flex', justifyContent: 'center' }}>
                                <CardMedia 
                                component="img"
                                sx={{ height: 240, width: 'auto' }}
                                image={data.mainImage}
                                />
                        </Box>
                        <Typography align="center" noWrap="true" padding={1} style={{fontSize: 20, fontWeight: 'normal' }} >Price <Typography style={{fontSize: 25, fontWeight: 'bold' }}>{Number(data.price).toFixed(2)} €</Typography></Typography>
                        <Button variant="contained" color="primary"> 
                            Add to cart
                        </Button>
                    </Paper>
                </Grid>
                <Grid item md={6} padding={2}>
                    <Paper elevation={5} style={{ height: 530 }} sx={{ overflow: 'auto'}}>
                        <Box padding={2} >
                            <TableContainer>
                                <Table  size="small" aria-label="a dense table">
                                    {renderKeys}
                                </Table>
                            </TableContainer>
                        </Box>
                    </Paper>
                </Grid>
                <Grid container md={12}>
                    <Grid item md={12} padding={2}>
                        <Paper elevation={5}>
                        <Typography padding={2} style={{fontSize: 20, fontWeight: 'normal' }}>Description:</Typography>
                            <Box 
                                style={{fontSize: 16 }}
                                padding={3}>
                                    {data.description}
                            </Box>
                            <Box padding={3}>
                                <Link 
                                    style={{fontSize: 18, fontWeight: 'bold' }}
                                    href={data.productOfficialWebsite}>
                                        Link to the official product website...
                                </Link>
                            </Box>
                        </Paper>
                    </Grid>
                </Grid>
            </Grid>
        </Paper>
        </>
    );
}