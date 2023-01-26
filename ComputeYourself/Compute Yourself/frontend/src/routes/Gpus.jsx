import { useEffect, useState } from "react";

import Card from "../componentsFolder/Card/CardOfProduct"
import React from 'react';
import axios from "axios";

export default function Gpus() {
    const [data, setData] = useState([]);
    useEffect(() => {
        axios.get("https://localhost:7195/product/gpu").then(
            (response) => {
                setData(response.data);
            });
    }, []);

    return (
            <Card dataProperties={data} productType="gpu" />
    )
}