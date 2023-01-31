import { useEffect, useState } from "react";

import Box from '@mui/material/Box';
import React from 'react';
import TextField from '@mui/material/TextField';
import axios from "axios";
import { useNavigate } from "react-router-dom";

export default function EditCpu() {
    const [data, setData] = useState([]);
    const navigate = useNavigate();
    const [itemId] = useState(localStorage.getItem("itemId"));
    const keys = Object.keys(data).map((propName, idx) => { return propName });
    useEffect(() => {
        axios.get(`https://localhost:7195/product/cpu/${itemId}`).then(
            (response) => {
                setData(response.data);
            });
    }, []);

    let handleChange = (e) => {
        if (e.target.name === "manufacturerCooler") {
            if (data[e.target.name] == true) {
                setData({ ...data, [e.target.name]: false });
            } else {
                setData({ ...data, [e.target.name]: true });
            }
        } else {
            //data[e.target.name] = e.target.value;
            setData({ ...data, [e.target.name]: e.target.value });
        }
        console.log(data);
    }

    let handleSubmit = async () => {
        const json = JSON.stringify(data);
        await axios.put(`https://localhost:7195/product/cpu/${data.id}`, json, {
            headers: {
                'Content-Type': 'application/json;charset=UTF-8',
            }
        })
    };

    return (
        
        // <Box component="form" sx={{'& .MuiTextField-root': { m: 1, width: '35ch' }, }} noValidate autoComplete="off">
        //     <div  xs={4}>
        //     <TextField
        //   required
        //   id="outlined-required"
        //   label={data[keys[11]]}
        //   defaultValue={data[keys[11]]}
        //   onChange={e => handleChange(e)}
        // />
        // <TextField
        //   required
        //   id="outlined-required"
        //   label="Required"
        //   defaultValue="Cpu Description"
        // />
        // <TextField
        //   id="outlined-number"
        //   label="Number"
        //   type="number"
        //   InputLabelProps={{
        //     shrink: true,
        //   }}
        // />
        //     </div>
        
        // </Box>
        <form onSubmit={handleSubmit}>
            <div>
                <div> Name <input placeholder={data[keys[11]]} aria-label="{keys[11]}" type="text" name={keys[11]} onChange={e => handleChange(e)} /></div>
                <div> Description <input placeholder={data[keys[12]]} aria-label="{keys[12]}" type="text" name={keys[12]} onChange={e => handleChange(e)} /></div>
                <div> Price <input placeholder={data[keys[13]]} aria-label="{keys[13]}" type="number" name={keys[13]} onChange={e => handleChange(e)} /></div>
                <div> Brand <input placeholder={data[keys[14]]} aria-label="{keys[14]}" type="text" name={keys[14]} onChange={e => handleChange(e)} /></div>
                <div> Warranty <input placeholder={data[keys[15]]} aria-label="{keys[15]}" type="number" name={keys[15]} onChange={e => handleChange(e)} /></div>
                <div> Rating <input placeholder={data[keys[16]]} aria-label="{keys[16]}" type="number" name={keys[16]} onChange={e => handleChange(e)} /></div>
                <div> Socket <input placeholder={data[keys[0]]} aria-label="{keys[0]}" type="text" name={keys[0]} onChange={e => handleChange(e)} /></div>
                <div> Manufacturer Cooler <input placeholder={data[keys[1]]} aria-label="{keys[1]}" type="checkbox" name={keys[1]} onChange={e => handleChange(e)} /></div>
                <div> L3Cache <input placeholder={data[keys[2]]} aria-label="{keys[2]}" type="number" name={keys[2]} onChange={e => handleChange(e)} /></div>
                <div> Total Cache <input placeholder={data[keys[3]]} aria-label="{keys[3]}" type="number" name={keys[3]} onChange={e => handleChange(e)} /></div>
                <div> Cores <input placeholder={data[keys[4]]} aria-label="{keys[4]}" type="number" name={keys[4]} onChange={e => handleChange(e)} /></div>
                <div> Threads <input placeholder={data[keys[5]]} aria-label="{keys[5]}" type="number" name={keys[5]} onChange={e => handleChange(e)} /></div>
                <div> Igpu <input placeholder={data[keys[6]]} aria-label="{keys[6]}" type="text" name={keys[6]} onChange={e => handleChange(e)} /></div>
                <div> Tdp <input placeholder={data[keys[7]]} aria-label="{keys[7]}" type="number" name={keys[7]} onChange={e => handleChange(e)} /></div>
                <div> Core Clock <input placeholder={data[keys[8]]} aria-label="{keys[8]}" type="number" name={keys[8]} onChange={e => handleChange(e)} /></div>
                <div> Turbo Core Clock <input placeholder={data[keys[9]]} aria-label="{keys[9]}" type="number" name={keys[9]} onChange={e => handleChange(e)} /></div>
                <div> Main Image <input placeholder={data[keys[17]]} aria-label="{keys[17]}" type="text" name={keys[17]} onChange={e => handleChange(e)} /></div>
                <div> Product Official Website <input placeholder={data[keys[18]]} aria-label="{keys[18]}" type="text" name={keys[18]} onChange={e => handleChange(e)} /></div>
                <div> Model Number <input placeholder={data[keys[19]]} aria-label="{keys[19]}" type="text" name={keys[19]} onChange={e => handleChange(e)} /></div>
                <div className="button-section">
                    <button type="submit" variant="outlined" size="small">Save</button>
                    <button type="button" variant="outlined" size="small"onClick={() => navigate("/product")}> Back </button>
                </div>
            </div>
        </form>
    )
}