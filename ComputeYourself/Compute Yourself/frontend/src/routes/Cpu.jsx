import { useEffect, useState } from "react";
import ProductProperties from "../componentsFolder/ProductProperties/productProperties"
import React from 'react';
import axios from "axios";

export default function Cpu() {
    const [data, setData] = useState("");
    useEffect(() => {
        axios.get("https://localhost:7195/product/cpu").then((response) => {
            response.data.map((e) => {
                setData(e);
            });
        });

    }, []);
    const elements = Object.keys(data);
    return (
        <div className='cpus'>
            <ProductProperties dataProperties={data} elementKeys={elements} />
        </div>
    )
}