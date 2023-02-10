import { useEffect, useState } from "react";

import AddIcon from '@mui/icons-material/Add';
import Button from '@material-ui/core/Button';
import Card from "../componentsFolder/Card/CardOfProduct"
import Grid from "@mui/material/Grid";
import React from 'react';
import axios from "axios";
import { useNavigate } from "react-router-dom";
import useAuth from "../hooks/useAuth"

export default function MotherBoards() {
    const [data, setData] = useState([]);
    const navigate = useNavigate();
    useEffect(() => {
        axios.get("https://localhost:7195/product/motherboard").then(
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
                    onClick={() => navigate(`/product/addnewmotherboard`, { replace: true, state: { formData: data, productType: "motherboard" } }
                    )}
                ><AddIcon color="success" ></AddIcon>MotherBoard</Button>
            </Grid>
        );
    }

    return (
        <>
            {adminField}
            <Card dataProperties={data} productType="motherboard" />
        </>
    )
}