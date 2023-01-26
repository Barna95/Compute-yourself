import { useEffect, useState } from "react";
import { useNavigate } from "react-router-dom";
import Card from "../componentsFolder/Card/CardOfProduct"
import React from 'react';
import axios from "axios";

export default function PcCases() {
    const [data, setData] = useState([]);
    const navigate = useNavigate();
    useEffect(() => {
        axios.get("https://localhost:7195/product/pccase").then(
            (response) => {
                setData(response.data);
            });
    }, []);
   
    return (
            <Button variant="outlined" size="small" 
                title="Go to Details"
                onClick={() => navigate(`/product/addnewpccase`, { replace: true, state: { formData: data, productType: "pccase" } }
                )}
            >Add new</Button>
            <Card dataProperties={data} productType="pccase" />
    )
}