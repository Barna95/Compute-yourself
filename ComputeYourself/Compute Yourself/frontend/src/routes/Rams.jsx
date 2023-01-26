import { useEffect, useState } from "react";
import { useNavigate } from "react-router-dom";
import Card from "../componentsFolder/Card/CardOfProduct"
import React from 'react';
import axios from "axios";

export default function Rams() {
    const [data, setData] = useState([]);
    const navigate = useNavigate();
    useEffect(() => {
        axios.get("https://localhost:7195/product/ram").then(
            (response) => {
                setData(response.data);
            });
    }, []);

    return (
        <div className='cpus'>
            <button
                title="Go to Details"
                onClick={() => navigate(`/product/addnewram`, { replace: true, state: { formData: data, productType: "ram" } }
                )}
            >Add new</button>
            <Card dataProperties={data} productType="ram" />
        </div>
    )
}