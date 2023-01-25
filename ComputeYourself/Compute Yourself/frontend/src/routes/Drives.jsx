﻿import { useEffect, useState } from "react";
import Card from "../componentsFolder/Card/CardOfProduct"
import React from 'react';
import axios from "axios";

export default function Drives() {
    const [data, setData] = useState([]);
    useEffect(() => {
        axios.get("https://localhost:7195/product/drive").then(
            (response) => {
                setData(response.data);
            });
    }, []);
    return (
        <div className='drives'>
            <Card dataProperties={data} productType="drive" />
        </div>
    )
}