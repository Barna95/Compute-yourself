import { useEffect, useState } from "react";
import ProductProperties from "../componentsFolder/ProductProperties/productProperties"
import React from 'react';
import axios from "axios";

export default function CpuCooler() {
    const [data, setData] = useState("");
    useEffect(() => {
        axios.get("https://localhost:7195/product/cpucooler").then((response) => {
            response.data.map((e) => {
                setData(e);
            });
        });

    }, []);
    const elements = Object.keys(data);
    return (
        <div className='cpucoolers'>
            <ProductProperties dataProperties={data} elementKeys={elements} />
        </div>
    )
}