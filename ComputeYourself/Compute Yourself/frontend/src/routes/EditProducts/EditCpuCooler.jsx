import { useEffect, useState } from "react";
import React from 'react';
import axios from "axios";
import { useNavigate, useParams } from "react-router-dom";
import useAuth from "../../hooks/useAuth"
import themeStyle from "../../themeStyle"
import Button from '@material-ui/core/Button';
import TextField from '@mui/material/TextField';
import { Grid } from "@mui/material";

export default function EditCpuCooler() {
    const [data, setData] = useState([]);
    const navigate = useNavigate();
    let { id } = useParams();
    const keys = Object.keys(data).map((propName, idx) => { return propName });
    useEffect(() => {
        axios.get(`https://localhost:7195/product/cpucooler/${id}`).then(
            (response) => {
                setData(response.data);
            });
    }, []);
    console.log(data);
    let handleChange = (e) => {
        setData({ ...data, [e.target.name]: e.target.value });
    }

    const { auth } = useAuth();

    let handleSubmit = async (e) => {
        e.preventDefault()
        const token = auth.token;
        const json = JSON.stringify(data);
        await axios.put(`https://localhost:7195/product/cpucooler/${data.id}`, json, {
            headers: {
                'Content-Type': 'application/json;charset=UTF-8',
                'Authorization': `Bearer ${token}`
            }
        })
        return navigate(`/product/cpucooler/${id}/details`)
    };

    return (
        <form onSubmit={e => handleSubmit(e)}>
            <Grid container md={12} alignContent="center">
                <Grid item md={6} padding={2} autoComplete="off" noValidate>
                <TextField style={themeStyle.textInput} required id="outlined-required" variant="outlined" size = "small" label="Name" placeholder={data[keys[4]]} defaultValue=" " value={data[keys[4]]} name={keys[4]} onChange={e => handleChange(e)}/>
                <TextField style={themeStyle.textInput} required id="outlined-required" variant="outlined" size = "small" label="Description" placeholder={data[keys[5]]} defaultValue=" " value={data[keys[5]]} name={keys[5]} onChange={e => handleChange(e)}/>
                <TextField style={themeStyle.textInput} required id="outlined-number" type="number" variant="outlined" size = "small" label="Price" placeholder={data[keys[6]]} defaultValue="0" value={data[keys[6]]} name={keys[6]} onChange={e => handleChange(e)}/>
                <TextField style={themeStyle.textInput} required id="outlined-required" variant="outlined" size = "small" label="Brand" placeholder={data[keys[7]]} defaultValue=" " value={data[keys[7]]} name={keys[7]} onChange={e => handleChange(e)}/>
                <TextField style={themeStyle.textInput} required id="outlined-number" type="number" variant="outlined" size = "small" label="Warranty" placeholder={data[keys[8]]} defaultValue="0" value={data[keys[8]]} name={keys[8]} onChange={e => handleChange(e)}/>
                <TextField style={themeStyle.textInput} required id="outlined-number" type="number" variant="outlined" size = "small" label="Rating" placeholder={data[keys[9]]} defaultValue="0" value={data[keys[9]]} name={keys[9]} onChange={e => handleChange(e)}/>
                <TextField style={themeStyle.textInput} required id="outlined-required" variant="outlined" size = "small" label="Cooler Type" placeholder={data[keys[0]]} defaultValue=" " value={data[keys[0]]} name={keys[0]} onChange={e => handleChange(e)}/>
                <TextField style={themeStyle.textInput} required id="outlined-required" variant="outlined" size = "small" label="Height" placeholder={data[keys[1]]} defaultValue=" " value={data[keys[1]]} name={keys[1]} onChange={e => handleChange(e)}/>
                <TextField style={themeStyle.textInput} required id="outlined-required" variant="outlined" size = "small" label="Cpu Type" placeholder={data[keys[2]]} defaultValue=" " value={data[keys[2]]} name={keys[2]} onChange={e => handleChange(e)}/>
                <TextField style={themeStyle.textInput} required id="outlined-required" variant="outlined" size = "small" label="Main Image" placeholder={data[keys[10]]} defaultValue=" " value={data[keys[10]]} name={keys[10]} onChange={e => handleChange(e)}/>
                <TextField style={themeStyle.textInput} required id="outlined-required" variant="outlined" size = "small" label="Product Official Website" placeholder={data[keys[11]]} defaultValue=" " value={data[keys[11]]} name={keys[11]} onChange={e => handleChange(e)}/>
                <TextField style={themeStyle.textInput} required id="outlined-required" variant="outlined" size = "small" label="Model Number" placeholder={data[keys[12]]} defaultValue=" " value={data[keys[12]]} name={keys[12]} onChange={e => handleChange(e)}/>
                <Grid item md={2}>
                    <Button style={themeStyle.navbarButton} variant="outlined" size="small" type="submit">Save</Button>
                    <Button style={themeStyle.navbarButton} variant="outlined" size="small" onClick={() => navigate(`/product/cpucooler`)}>Back</Button>
                    </Grid>
                </Grid>
            </Grid>
{/* 
            <div> Name <input placeholder={data[keys[4]]} aria-label="{keys[4]}" type="text" name={keys[4]} onChange={e => handleChange(e)} /></div>
            <div> Description <input placeholder={data[keys[5]]} aria-label="{keys[5]}" type="text" name={keys[5]} onChange={e => handleChange(e)} /></div>
            <div> Price <input placeholder={data[keys[6]]} aria-label="{keys[6]}" type="number" name={keys[6]} onChange={e => handleChange(e)} /></div>
            <div> Brand <input placeholder={data[keys[7]]} aria-label="{keys[7]}" type="text" name={keys[7]} onChange={e => handleChange(e)} /></div>
            <div> Warranty <input placeholder={data[keys[8]]} aria-label="{keys[8]}" type="number" name={keys[8]} onChange={e => handleChange(e)} /></div>
            <div> Rating <input placeholder={data[keys[9]]} aria-label="{keys[9]}" type="number" name={keys[9]} onChange={e => handleChange(e)} /></div>
            <div> Cooler Type <input placeholder={data[keys[0]]} aria-label="{keys[0]}" type="text" name={keys[0]} onChange={e => handleChange(e)} /></div>
            <div> Height <input placeholder={data[keys[1]]} aria-label="{keys[1]}" type="text" name={keys[1]} onChange={e => handleChange(e)} /></div>
            <div> Cpu Type <input placeholder={data[keys[2]]} aria-label="{keys[2]}" type="text" name={keys[2]} onChange={e => handleChange(e)} /></div>
            <div> Main Image <input placeholder={data[keys[10]]} aria-label="{keys[10]}" type="text" name={keys[10]} onChange={e => handleChange(e)} /></div>
            <div> Product Official Website <input placeholder={data[keys[11]]} aria-label="{keys[11]}" type="text" name={keys[11]} onChange={e => handleChange(e)} /></div>
            <div> Model Number <input placeholder={data[keys[12]]} aria-label="{keys[12]}" type="text" name={keys[12]} onChange={e => handleChange(e)} /></div>
            <div className="button-section">
                <button type="submit">Save</button>
                <button variant="outlined" size="small" onClick={() => navigate(`/product/cpucooler`)}> Back </button>
            </div> */}
        </form>
    )
}