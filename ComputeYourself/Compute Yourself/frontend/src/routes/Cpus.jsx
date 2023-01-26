import { useEffect, useState } from "react";
import Card from "../componentsFolder/Card/CardOfProduct"
import React from 'react';
import axios from "axios";
import Grid from "@mui/material/Grid";
import { useNavigate } from "react-router-dom";
import Button from '@material-ui/core/Button';

export default function Cpus() {
    const [data, setData] = useState([]);
    const navigate = useNavigate();

    useEffect(() => {
        axios.get("https://localhost:7195/product/cpu").then(
            (response) => {
                setData(response.data);
            });
    }, []);
    return (
            <>
            <Grid item md={10}>
            <Button variant="outlined" size="medium" 
                title="Go to Details"
                onClick={() => navigate(`/product/addnewcpu`, { replace: true, state: { formData: data, productType: "cpu" } }
                )}
            >Add new</Button>
            </Grid>
            <Card dataProperties={data} productType="cpu" />
            </>
    );
}