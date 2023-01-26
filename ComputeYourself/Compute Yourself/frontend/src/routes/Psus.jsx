import { useEffect, useState } from "react";
import { useNavigate } from "react-router-dom";
import Card from "../componentsFolder/Card/CardOfProduct"
import React from 'react';
import axios from "axios";
import Button from '@material-ui/core/Button';
import Grid from "@mui/material/Grid";

export default function Psus() {
    const [data, setData] = useState([]);
    const navigate = useNavigate();
    useEffect(() => {
        axios.get("https://localhost:7195/product/psu").then(
            (response) => {
                setData(response.data);
            });
    }, []);
   
    return (
        <>
            <Grid item md={10}>
            <Button variant="outlined" size="small" 
                title="Go to Details"
                onClick={() => navigate(`/product/addnewpsu`, { replace: true, state: { formData: data, productType: "psu" } }
                )}
            >Add new</Button>
            </Grid>
            <Card dataProperties={data} productType="psu" />
        </>
    )
}