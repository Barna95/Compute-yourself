import { useEffect, useState } from 'react';

import axios from "axios";
import { useNavigate } from "react-router-dom";

export default function EditGpu() {
    const [data, setData] = useState([]);
    const navigate = useNavigate();
    const [itemId] = useState(localStorage.getItem("itemId"));
    const keys = Object.keys(data).map((propName, idx) => { return propName });
    useEffect(() => {
        axios.get(`https://localhost:7195/product/gpu/${itemId}`).then(
            (response) => {
                setData(response.data);
            });
    }, []);

    let handleChange = (e) => {
        setData({ ...data, [e.target.name]: e.target.value });
        console.log(data);
    }

    let handleSubmit = async () => {
        const json = JSON.stringify(data);
        await axios.put(`https://localhost:7195/product/gpu/${itemId}`, json, {
            headers: {
                'Content-Type': 'application/json;charset=UTF-8',
            }
        })
    };
    console.log(keys);
    return (
        <form onSubmit={handleSubmit}>
            <div> Name <input placeholder={data[keys[6]]} aria-label="{keys[6]}" type="text" name={keys[6]} onChange={e => handleChange(e)} /></div>
            <div> Description <input placeholder={data[keys[7]]} aria-label="{keys[7]}" type="text" name={keys[7]} onChange={e => handleChange(e)} /></div>
            <div> Price <input placeholder={data[keys[8]]} aria-label="{keys[8]}" type="number" name={keys[8]} onChange={e => handleChange(e)} /></div>
            <div> Brand <input placeholder={data[keys[9]]} aria-label="{keys[9]}" type="text" name={keys[9]} onChange={e => handleChange(e)} /></div>
            <div> Warranty <input placeholder={data[keys[10]]} aria-label="{keys[10]}" type="number" name={keys[10]} onChange={e => handleChange(e)} /></div>
            <div> Rating <input placeholder={data[keys[11]]} aria-label="{keys[11]}" type="number" name={keys[11]} onChange={e => handleChange(e)} /></div>
            <div> Video Chipset <input placeholder={data[keys[0]]} aria-label="{keys[0]}" type="text" name={keys[0]} onChange={e => handleChange(e)} /></div>
            <div> Vram Size <input placeholder={data[keys[1]]} aria-label="{keys[1]}" type="number" name={keys[1]} onChange={e => handleChange(e)} /></div>
            <div> VramType <input placeholder={data[keys[2]]} aria-label="{keys[2]}" type="text" name={keys[2]} onChange={e => handleChange(e)} /></div>
            <div> Required PSU <input placeholder={data[keys[3]]} aria-label="{keys[3]}" type="number" name={keys[3]} onChange={e => handleChange(e)} /></div>
            <div> Length <input placeholder={data[keys[4]]} aria-label="{keys[4]}" type="number" name={keys[4]} onChange={e => handleChange(e)} /></div>
            <div> Main Image <input placeholder={data[keys[12]]} aria-label="{keys[12]}" type="text" name={keys[12]} onChange={e => handleChange(e)} /></div>
            <div> Product Official Website <input placeholder={data[keys[13]]} aria-label="{keys[13]}" type="text" name={keys[13]} onChange={e => handleChange(e)} /></div>
            <div> Model Number <input placeholder={data[keys[14]]} aria-label="{keys[14]}" type="text" name={keys[14]} onChange={e => handleChange(e)} /></div>
            <div className="button-section">
                <button type="submit">Save</button>
                <button type="button" onClick={() => navigate("/product")}> go back </button>
            </div>
        </form>
    )
}