import { useEffect, useState } from "react";
import { useNavigate } from "react-router-dom";
import Card from "../componentsFolder/Card/CardOfProduct"
import React from 'react';
import axios from "axios";

export default function Psus() {
    const [data, setData] = useState([]);
    const navigate = useNavigate();
    useEffect(() => {
        axios.get("https://localhost:7195/product/psu").then(
            (response) => {
                setData(response.data);
            });
    }, []);
   
    return (
        <div className='psus'>
            <button
                title="Go to Details"
                onClick={() => navigate(`/product/addnewpsu`, { replace: true, state: { formData: data, productType: "psu" } }
                )}
            >Add new</button>
            <Card dataProperties={data} productType="psu" />
        </div>
    )
}