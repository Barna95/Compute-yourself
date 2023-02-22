import { useEffect, useState } from "react";
import AddIcon from '@mui/icons-material/Add';
import { AxiosGet } from "../Axios/FetchWithAxios"
import Card from "../componentsFolder/Card/CardOfProduct"
import Grid from "@mui/material/Grid";
import React from 'react';
import useAuth from "../hooks/useAuth"
import { useNavigate } from "react-router-dom";
import Button from '@mui/material/Button';

export default function Cpus() {
    const [data, setData] = useState([]);
    const navigate = useNavigate();
    const { auth } = useAuth();
    const [trigger, setTrigger] = useState("false");

    useEffect(() => {
            AxiosGet("cpu").then(
                (response) => {
                    setData(response.data);
                });
        setTrigger("false");
    }, [trigger]);
        
    //Show admin field
    const isAdmin = auth?.roles?.includes("Admin");
    const loggedIn = localStorage.getItem("isLoggedIn");
    const adminField = [];
    if (isAdmin && loggedIn === "true"){
        adminField.push(
            <Grid item md={12}>
                <Button variant="outlined" size="medium" 
                    title="Go to Details"
                    onClick={() => navigate(`/product/addnewcpu`, { replace: true, state: { formData: data, productType: "cpu" } }
                    )}>
                    <AddIcon color="success" ></AddIcon>
                    CPU
                </Button>
            </Grid>
        );
    }
    return (
            <>
            {adminField}
            <Card dataProperties={data} productType="cpu" trigger={setTrigger}/>
            </>
    );
}