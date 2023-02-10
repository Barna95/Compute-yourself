import { useEffect, useState } from "react";

import AddIcon from '@mui/icons-material/Add';
import Button from '@material-ui/core/Button';
import Card from "../componentsFolder/Card/CardOfProduct"
import Grid from "@mui/material/Grid";
import React from 'react';
import axios from "axios";
import { useNavigate } from "react-router-dom";
import useAuth from "../hooks/useAuth"

export default function Rams() {
    const [data, setData] = useState([]);
    const navigate = useNavigate();
    useEffect(() => {
        axios.get("https://localhost:7195/product/ram").then(
            (response) => {
                setData(response.data);
            });
    }, [data]);

    const { auth } = useAuth();
    const isAdmin = auth?.roles?.includes("Admin");
    const loggedIn = localStorage.getItem("isLoggedIn");
    const adminField = [];
    if (isAdmin && loggedIn === "true") {
        adminField.push(
            <Grid item md={10}>
                <Button variant="outlined" size="medium"
                    title="Go to Details"
                    onClick={() => navigate(`/product/addnewram`, { replace: true, state: { formData: data, productType: "ram" } }
                    )}
                ><AddIcon color="success" ></AddIcon>Ram</Button>
            </Grid>
        );
    }


    return (
        <>
            {adminField }
            <Card dataProperties={data} productType="ram" />
        </>
    )
}