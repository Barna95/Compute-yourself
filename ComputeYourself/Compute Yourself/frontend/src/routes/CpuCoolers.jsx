import { useEffect, useState } from "react";

import AddIcon from '@mui/icons-material/Add';
import Button from '@material-ui/core/Button';
import Card from "../componentsFolder/Card/CardOfProduct"
import Grid from "@mui/material/Grid";
import React from 'react';
import axios from "axios";
import { useNavigate } from "react-router-dom";
import useAuth from "../hooks/useAuth"

export default function CpuCoolers() {
    const [data, setData] = useState([]);
    const navigate = useNavigate();

    useEffect(() => {
        axios.get("https://localhost:7195/product/cpucooler").then(
            (response) => {
                setData(response.data);
            });
    }, []);

    const { auth } = useAuth();
    const isAdmin = auth?.roles?.includes("Admin");
    const loggedIn = localStorage.getItem("isLoggedIn");
    const adminField = [];
    if (isAdmin && loggedIn == "true") {
        adminField.push(
            <Grid item md={10}>
                <Button
                    variant="outlined"
                    size="medium"
                    color="success"
                    onClick={() => navigate(`/product/addnewcpucooler`, { replace: true, state: { formData: data, productType: "cpucooler" } }
                    )}
                ><AddIcon color="success" ></AddIcon>Cpu Cooler</Button>
            </Grid>
        );
    }

    return (
           <>
            {adminField }
            <Card dataProperties={data} productType="cpucooler" />
           </>
    )
}