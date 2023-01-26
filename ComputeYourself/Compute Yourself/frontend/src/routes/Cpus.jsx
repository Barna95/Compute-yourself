import { useEffect, useState } from "react";
import Card from "../componentsFolder/Card/CardOfProduct"
import React from 'react';
import axios from "axios";
import { useNavigate } from "react-router-dom";

export default function Cpus() {
    const [data, setData] = useState([]);
    const navigate = useNavigate();

    useEffect(() => {
        axios.get("https://localhost:7195/product/cpu").then(
            (response) => {
                setData(response.data);
            });
    }, []);



    return (
        <div className='cpus'>
            <button
                title="Go to Details"
                onClick={() => navigate(`/product/addnewcpu`, { replace: true, state: { formData: data, productType: "cpu" } }
                )}
            >Add new</button>
            <Card dataProperties={data} productType="cpu" />
        </div>
    );
}