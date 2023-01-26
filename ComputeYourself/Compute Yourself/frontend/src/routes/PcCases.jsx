import { useEffect, useState } from "react";

import Card from "../componentsFolder/Card/CardOfProduct"
import React from 'react';
import axios from "axios";

export default function PcCases() {
    const [data, setData] = useState([]);
    useEffect(() => {
        axios.get("https://localhost:7195/product/pccase").then(
            (response) => {
                setData(response.data);
            });
    }, []);
   
    return (
            <Card dataProperties={data} productType="pccase" />
    )
}