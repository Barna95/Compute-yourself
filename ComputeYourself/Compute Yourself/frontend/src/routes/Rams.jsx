import { useEffect, useState } from "react";

import ProductProperties from "../componentsFolder/ProductProperties/productProperties"
import React from 'react';
import axios from "axios";

export default function Rams() {
    const [data, setData] = useState([]);
    useEffect(() => {
        axios.get("https://localhost:7195/product/ram").then(
            (response) => {
                setData(response.data);
            });
    }, []);

    return (
        <div className='cpus'>
            <ProductProperties dataProperties={data} />
        </div>
    )
}