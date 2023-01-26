import { useEffect, useState } from "react";
import Card from "../componentsFolder/Card/CardOfProduct"
import React from 'react';
import axios from "axios";
import { useNavigate } from "react-router-dom";
import Button from '@material-ui/core/Button';
import Grid from "@mui/material/Grid";

export default function CpuCoolers() {
    const [data, setData] = useState([]);
    const navigate = useNavigate();

    useEffect(() => {
        axios.get("https://localhost:7195/product/cpucooler").then(
            (response) => {
                setData(response.data);
            });
    }, []);
    
    return (
<>
            <Grid item md={10}>
            <Button variant="outlined" size="small" 
                title="Go to Add"
                onClick={() => navigate(`/product/addnewcpucooler`, { replace: true, state: { formData: data, productType: "cpucooler" } }
                )}
                >Add new</Button>

            </Grid>
                <Card dataProperties={data} productType="cpucooler" />
            </>
    )
}