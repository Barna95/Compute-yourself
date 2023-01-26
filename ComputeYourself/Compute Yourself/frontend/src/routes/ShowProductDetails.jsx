import * as React from 'react';
import { useEffect, useState } from "react";
import axios from "axios";
import { useLocation, useNavigate } from "react-router-dom";



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

    const renderValues = [];

    Object.keys(data).map((x, idx) => {
        if (x == 'mainImage') {
            //do nothing
        }
        else if (x == 'productOfficialWebsite') {
            //do nothing
        } else if (data[x] === false) {
            renderValues.push(<input type="checkbox" disabled/>)
        } else if (data[x] === true) {
            renderValues.push(<input type="checkbox" checked disabled/>)
        } else if (x == 'id') {
            //do nothing
        } else {
            renderValues.push(<td key={idx}>{data[x]}</td>);
        }    
    })

    const renderKeys = [];

    Object.keys(data).map((x, idx) => {
        if (x == 'mainImage') {
            //do nothing
        }
        else if (x == 'productOfficialWebsite') {
            //do nothing
        } else if (x == 'id') {
            //do nothing
        } else {
            renderKeys.push(<td key={idx}>{x}</td>);
        }
    })
    
    //From 1 object ->
    // show keys -> {Object.keys(data).map((asd, idx) => <p key={idx}> {asd }</p> ) }
    // show values -> {Object.keys(data).map((asd, idx) => <p key={idx}> {data[asd] }</p> ) } 
    // ami most bent van az az összes adatból való magic, not so good.
    return (
        <div>
            <button onClick={() => navigate("/product") }> go back </button>
            <table>
                <thead>
                    <tr>{renderKeys}</tr>
                </thead>
                <tbody>
                    <tr>{renderValues}</tr>
                </tbody>
            </table>
        </div>
    );
}