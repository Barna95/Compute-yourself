import * as React from 'react';
import { useEffect, useState } from "react";
import axios from "axios";
import { useLocation, useNavigate } from "react-router-dom";
import Button from '@material-ui/core/Button';



export default function ShowProductDetails() {
    const [data, setData] = useState([]);
    const location = useLocation();
    const navigate = useNavigate();
    // From all objects -> 
    //let productValues = []
    //const selectValues = Object.values(props.dataProperties).map((e) => productValues.push(Object.values(e)));
    //let productKeys = [];
    //const selectKeys = Object.keys(props.dataProperties.map((e) => productKeys.push(Object.keys(e))));
    useEffect(() => {
        axios.get(`https://localhost:7195/product/${location.state.productType}/${location.state.itemId}`).then(
            (response) => {
                setData(response.data);
            });
    }, []);

    //From 1 object ->
    // show keys -> {Object.keys(data).map((asd, idx) => <p key={idx}> {asd }</p> ) }
    // show values -> {Object.keys(data).map((asd, idx) => <p key={idx}> {data[asd] }</p> ) } 
    // ami most bent van az az összes adatból való magic, not so good.
    return (
        <div>
            <Button  variant="outlined" size="small" onClick={() => navigate("/product") }> go back </Button>
            <table>
                <thead>
                    <tr>{Object.keys(data).map((propName, idx) => <td key={idx}> {propName}</td>)}</tr>
                </thead>
                <tbody>
                    <tr>{Object.keys(data).map((propName, idx) => <td key={idx}> {data[propName]}</td>)}</tr>
                </tbody>
            </table>
        </div>
    );
}