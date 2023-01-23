import { useEffect, useState } from "react";
import ProductProperties from "../componentsFolder/ProductProperties/productProperties"
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
            <ProductProperties dataProperties={data} />
        </div>
    )
}