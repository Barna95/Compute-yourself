import { useEffect, useState } from 'react';

import axios from "axios";
import { useNavigate } from "react-router-dom";

export default function EditPsu() {
    const [data, setData] = useState([]);
    const navigate = useNavigate();
    const [itemId] = useState(localStorage.getItem("itemId"));
    const keys = Object.keys(data).map((propName, idx) => { return propName });
    useEffect(() => {
        axios.get(`https://localhost:7195/product/psu/${itemId}`).then(
            (response) => {
                setData(response.data);
            });
    }, []);
    
    let handleChange = (e) => {
        if (e.target.name === "modular") {
            if (data[e.target.name] == true) {
                setData({ ...data, [e.target.name]: false });
            } else {
                setData({ ...data, [e.target.name]: true });
            }
        } else {
            setData({ ...data, [e.target.name]: e.target.value });
        }
        console.log(data);
    }

    let handleSubmit = async () => {
        const json = JSON.stringify(data);
        await axios.put(`https://localhost:7195/product/psu/${itemId}`, json, {
            headers: {
                'Content-Type': 'application/json;charset=UTF-8',
            }
        })
    };
    console.log(keys);
    return (
        <form onSubmit={handleSubmit}>
            <div> Name <input placeholder={data[keys[4]]} aria-label="{keys[4]}" type="text" name={keys[4]} onChange={e => handleChange(e)} /></div>
            <div> Description <input placeholder={data[keys[5]]} aria-label="{keys[5]}" type="text" name={keys[5]} onChange={e => handleChange(e)} /></div>
            <div> Price <input placeholder={data[keys[6]]} aria-label="{keys[6]}" type="number" name={keys[6]} onChange={e => handleChange(e)} /></div>
            <div> Brand <input placeholder={data[keys[7]]} aria-label="{keys[7]}" type="text" name={keys[7]} onChange={e => handleChange(e)} /></div>
            <div> Warranty <input placeholder={data[keys[8]]} aria-label="{keys[8]}" type="number" name={keys[8]} onChange={e => handleChange(e)} /></div>
            <div> Rating <input placeholder={data[keys[9]]} aria-label="{keys[9]}" type="number" name={keys[9]} onChange={e => handleChange(e)} /></div>

            <div> Capacity <input placeholder={data[keys[0]]} aria-label="{keys[0]}" type="number" name={keys[0]} onChange={e => handleChange(e)} /></div>
            <div> Modular <input placeholder={data[keys[1]]} aria-label="{keys[1]}" type="checkbox" name={keys[1]} onChange={e => handleChange(e)} /></div>
            

            <div> Main Image <input placeholder={data[keys[10]]} aria-label="{keys[10]}" type="text" name={keys[10]} onChange={e => handleChange(e)} /></div>
            <div> Product Official Website <input placeholder={data[keys[11]]} aria-label="{keys[11]}" type="text" name={keys[11]} onChange={e => handleChange(e)} /></div>
            <div> Model Number <input placeholder={data[keys[12]]} aria-label="{keys[12]}" type="text" name={keys[12]} onChange={e => handleChange(e)} /></div>
            <div className="button-section">
                <button type="submit">Save</button>
                <button type="button" onClick={() => navigate("/product")}> go back </button>
            </div>
        </form>
    )
}