import { useEffect, useState } from "react";
import { AxiosGet } from "../Axios/FetchWithAxios"
import AddIcon from '@mui/icons-material/Add';
import Button from '@material-ui/core/Button';
import Card from "../componentsFolder/Card/CardOfProduct"
import Grid from "@mui/material/Grid";
import React from 'react';
import { useNavigate } from "react-router-dom";
import useAuth from "../hooks/useAuth"

export default function PcCases() {
    const [data, setData] = useState([]);
    const navigate = useNavigate();
    const [trigger, setTrigger] = useState("false");
    useEffect(() => {
        AxiosGet("pccase").then(
            (response) => {
                setData(response.data);
            });
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
                    onClick={() => navigate(`/product/addnewpccase`, { replace: true, state: { formData: data, productType: "pccase" } }
                    )}
                ><AddIcon color="success" ></AddIcon>Pc case</Button>
            </Grid>
        );
    }


    return (
        <>
            {adminField}
            <Card dataProperties={data} productType="pccase" trigger={setTrigger} />
        </>
    )
}