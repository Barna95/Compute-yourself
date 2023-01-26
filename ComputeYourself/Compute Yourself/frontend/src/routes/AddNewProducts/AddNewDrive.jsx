﻿import { useState } from 'react';
import { useNavigate } from "react-router-dom";
import axios from "axios";

export default function AddNewDrive() {
    const [formValues, setFormValues] = useState({
        "connectionType": "",
        "capacity": 0,
        "maxWrite": 0,
        "maxRead": 0,
        "name": "",
        "description": "",
        "price": 0,
        "brand": "",
        "warranty": 0,
        "rating": 0,
        "mainImage": "",
        "productOfficialWebsite": "",
        "modelNumber": ""
    });
    const navigate = useNavigate();
    const keys = Object.keys(formValues).map((propName, idx) => { return propName });
    let handleChange = (e) => {
        formValues[e.target.name] = e.target.value;
        console.log(formValues);
    }

    let handleSubmit = async () => {
        const json = JSON.stringify(formValues);
        await axios.post(`https://localhost:7195/product/drive`, json, {
            headers: {
                'Content-Type': 'application/json;charset=UTF-8',
            }
        })
    };
    // TODO -> input fields be required as its needed.
    // create the input nodes with map but it would be hard to change the different
    //input fields like checkbox or choose from enums in dropdown
    // so ill just leave it here for now.
    // keys.map((propName, idx) => <div key={idx}> {propName}<input placeholder="" aria-label="{propName}" type="text" name={propName} onChange={e => handleChange(e)} /></div>)
    return (
        <form onSubmit={handleSubmit}>
            <div> Name <input placeholder="" aria-label="{keys[4]}" type="text" name={keys[4]} onChange={e => handleChange(e)} required /></div>
            <div> Description <input placeholder="" aria-label="{keys[5]}" type="text" name={keys[5]} onChange={e => handleChange(e)} required /></div>
            <div> Price <input placeholder="" aria-label="{keys[6]}" type="number" name={keys[6]} onChange={e => handleChange(e)} required /></div>
            <div> Brand <input placeholder="" aria-label="{keys[7]}" type="text" name={keys[7]} onChange={e => handleChange(e)} /></div>
            <div> Warranty <input placeholder="" aria-label="{keys[8]}" type="number" name={keys[8]} onChange={e => handleChange(e)} required /></div>
            <div> Rating <input placeholder="" aria-label="{keys[9]}" type="number" name={keys[9]} onChange={e => handleChange(e)} required /></div>
            <div> Connection Type <input placeholder="" aria-label="{keys[0]}" type="text" name={keys[0]} onChange={e => handleChange(e)} required /></div>
            <div> Capacity <input placeholder="" aria-label="{keys[1]}" type="number" name={keys[1]} onChange={e => handleChange(e)} required /></div>
            <div> MaxWrite <input placeholder="" aria-label="{keys[2]}" type="number" name={keys[2]} onChange={e => handleChange(e)} required /></div>
            <div> MaxRead <input placeholder="" aria-label="{keys[3]}" type="number" name={keys[3]} onChange={e => handleChange(e)} required /></div>
            <div> Main Image <input placeholder="" aria-label="{keys[10]}" type="text" name={keys[10]} onChange={e => handleChange(e)} required /></div>
            <div> Product Official Website <input placeholder="" aria-label="{keys[11]}" type="text" name={keys[11]} onChange={e => handleChange(e)} required /></div>
            <div> Model Number <input placeholder="" aria-label="{keys[12]}" type="text" name={keys[12]} onChange={e => handleChange(e)} required /></div>

            <div className="button-section">
                <button type="submit">Save</button>
                <button type="button" onClick={() => navigate("/product")}> go back </button>
            </div>
        </form>
    )
}