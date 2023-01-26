import { useEffect, useState } from "react";
import Card from "../componentsFolder/Card/CardOfProduct"
import React from 'react';
import axios from "axios";
import { useNavigate } from "react-router-dom";

export default function MotherBoards() {
    const [data, setData] = useState([]);
    const navigate = useNavigate();
    useEffect(() => {
        axios.get("https://localhost:7195/product/motherboard").then(
            (response) => {
                setData(response.data);
            });
    }, []);
    
    return (
        <div className='cpucoolers'>
            <button
                title="Go to Details"
                onClick={() => navigate(`/product/addnewmotherboard`, { replace: true, state: { formData: data, productType: "motherboard" } }
                )}
            >Add new</button>
            <Card dataProperties={data} productType="motherboard" />
        </div>
    )
}