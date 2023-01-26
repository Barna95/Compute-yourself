import { useEffect, useState } from "react";
import Card from "../componentsFolder/Card/CardOfProduct"
import React from 'react';
import axios from "axios";
import { useNavigate } from "react-router-dom";

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

            <Button variant="outlined" size="small" 
                title="Go to Add"
                onClick={() => navigate(`/product/addnewcpucooler`, { replace: true, state: { formData: data, productType: "cpucooler" } }
                )}
            >Add new</Button>

            <Card dataProperties={data} productType="cpucooler" />
    )
}