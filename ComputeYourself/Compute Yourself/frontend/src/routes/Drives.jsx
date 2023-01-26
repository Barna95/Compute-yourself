﻿import { useEffect, useState } from "react";
import Card from "../componentsFolder/Card/CardOfProduct"
import React from 'react';
import axios from "axios";
import { useNavigate } from "react-router-dom";

export default function Drives() {
    const [data, setData] = useState([]);
    const navigate = useNavigate();
    useEffect(() => {
        axios.get("https://localhost:7195/product/drive").then(
            (response) => {
                setData(response.data);
            });
    }, []);
    return (
        <div className='drives'>
            <button
                title="Go to Details"
                onClick={() => navigate(`/product/addnewdrive`, { replace: true, state: { formData: data, productType: "drive" } }
                )}
            >Add new</button>
            <Card dataProperties={data} productType="drive" />
        </div>
    )
}