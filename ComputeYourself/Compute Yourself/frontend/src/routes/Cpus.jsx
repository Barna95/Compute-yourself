import { useEffect, useState } from "react";
import Card from "../componentsFolder/Card/CardOfProduct"
import React from 'react';
import axios from "axios";

export default function Cpus() {
    const [data, setData] = useState([]);

    useEffect(() => {
        axios.get("https://localhost:7195/product/cpu").then(
            (response) => {
                setData(response.data);
            });
    }, []);
    return (
        <div className='cpus'>
            <Card dataProperties={data} productType="cpu"/>
        </div>
    );
    }