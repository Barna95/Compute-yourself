import { useEffect, useState } from "react";
import { AxiosGet } from "../Axios/FetchWithAxios"
import AddIcon from '@mui/icons-material/Add';
import Button from '@material-ui/core/Button';
import Card from "../componentsFolder/Card/CardOfProduct"
import Grid from "@mui/material/Grid";
import React from 'react';
import { useNavigate } from "react-router-dom";
import useAuth from "../hooks/useAuth"

export default function Drives() {
    const [data, setData] = useState([]);
    const navigate = useNavigate();
    const [trigger, setTrigger] = useState("false");
    useEffect(() => {
        AxiosGet("drive").then(
            (response) => {
                setData(response.data);
            });
    }, [trigger]);

    //Show admin field
    const { auth } = useAuth();
    const isAdmin = auth?.roles?.includes("Admin");
    const loggedIn = localStorage.getItem("isLoggedIn");
    const adminField = [];
    if (isAdmin && loggedIn === "true") {
        adminField.push(
            <Grid item md={10}>
                <Button variant="outlined" size="medium"
                    title="Go to Details"
                    onClick={() => navigate(`/product/addnewdrive`, { replace: true, state: { formData: data, productType: "drive" } }
                    )}
                ><AddIcon color="success" ></AddIcon>DRIVE</Button>
            </Grid>
        );
    }


    return (
        <>
            {adminField}
            <Card dataProperties={data} productType="drive" trigger={setTrigger} />
            </>
    )
}