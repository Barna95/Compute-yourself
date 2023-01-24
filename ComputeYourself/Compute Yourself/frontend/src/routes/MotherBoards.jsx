import { useEffect, useState } from "react";
import Card from "../componentsFolder/Card/CardOfProduct"
import React from 'react';
import axios from "axios";

export default function MotherBoards() {
    const [data, setData] = useState([]);
    useEffect(() => {
        axios.get("https://localhost:7195/product/motherboard").then(
            (response) => {
                setData(response.data);
            });
    }, []);
    
    return (
        <div className='cpucoolers'>
            <Card dataProperties={data} productType="motherboard" />
        </div>
    )
}