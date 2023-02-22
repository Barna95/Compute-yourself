import { useEffect, useState } from "react";
import AddIcon from '@mui/icons-material/Add';
import { AxiosGet } from "../Axios/FetchWithAxios"
import Card from "../componentsFolder/Card/CardOfProduct"
import Grid from "@mui/material/Grid";
import React from 'react';
import useAuth from "../hooks/useAuth"
import { useNavigate } from "react-router-dom";
import Button from '@mui/material/Button';

export default function Rams() {
    const [data, setData] = useState([]);
    const navigate = useNavigate();
    const [trigger, setTrigger] = useState("false");
    useEffect(() => {
        AxiosGet("ram").then(
            (response) => {
                setData(response.data);
            });
        setTrigger("false");
    }, [trigger]);

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
            <Card dataProperties={data} productType="ram" trigger={setTrigger} />
        </>
    )
}