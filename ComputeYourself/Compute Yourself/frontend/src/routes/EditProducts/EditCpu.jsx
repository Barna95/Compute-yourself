import { useEffect, useState } from "react";
import React from 'react';
import axios from "axios";
import { useNavigate, useParams } from "react-router-dom";
import useAuth from "../../hooks/useAuth"
import TextField from '@mui/material/TextField';
import { Grid } from "@mui/material";
import themeStyle from "../../themeStyle"
import Button from '@material-ui/core/Button';

export default function EditCpu() {
    const [data, setData] = useState([]);
    let { id } = useParams();
    const navigate = useNavigate();
    const keys = Object.keys(data).map((propName, idx) => { return propName });


    useEffect(() => {
        console.log(data);
    }, [data]);

    useEffect(() => {
        axios.get(`https://localhost:7195/product/cpu/${id}`).then(
            (response) => {
                setData(response.data);
            });
    }, []);

    let handleChange = (e) => {
        if (e.target.name === "manufacturerCooler") {
            //Checkbox target value always stays on, some magic happens, check whats behind it
            if (data[e.target.name] == false) {
                setData({ ...data, [e.target.name]: true });
            } else if (data[e.target.name] == true) {
                setData({ ...data, [e.target.name]: false });
            }
        } else {
            setData({ ...data, [e.target.name]: e.target.value });
        }
    }

    const { auth } = useAuth();

    let handleSubmit = async (e) => {
        e.preventDefault();
        const token = auth.token;
        const json = JSON.stringify(data);
        await axios.put(`https://localhost:7195/product/cpu/${data.id}`, json, {
            headers: {
                'Content-Type': 'application/json;charset=UTF-8',
                'Authorization': `Bearer ${token}`
            }
        })
        return navigate(`/product/cpu/${id}/details`)
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
        <form onSubmit={e => handleSubmit(e)}>
                <Grid container md={12} alignContent="center">
                    <Grid item md={6} padding={2} autoComplete="off" noValidate>
                    <TextField style={themeStyle.textInput} required id="outlined-required" variant="outlined" size = "small" label="Name" placeholder={data[keys[11]]} defaultValue=" " value={data[keys[11]]} name={keys[11]} onChange={e => handleChange(e)}/>
                    <TextField style={themeStyle.textInput} required id="outlined-required" variant="outlined" size = "small" label="Description" placeholder={data[keys[12]]} defaultValue=" " value={data[keys[12]]} name={keys[12]} onChange={e => handleChange(e)}/>
                    <TextField style={themeStyle.textInput} required id="outlined-number" type="number" variant="outlined" size = "small" label="Price" placeholder={data[keys[13]]} defaultValue="0" value={data[keys[13]]} name={keys[13]} onChange={e => handleChange(e)}/>
                    <TextField style={themeStyle.textInput} required id="outlined-required" variant="outlined" size = "small" label="Brand" placeholder={data[keys[14]]} defaultValue=" " value={data[keys[14]]} name={keys[14]} onChange={e => handleChange(e)}/>
                    <TextField style={themeStyle.textInput} required id="outlined-number" type="number" variant="outlined" size = "small" label="Warranty" placeholder={data[keys[15]]} defaultValue="0" value={data[keys[15]]} name={keys[15]} onChange={e => handleChange(e)}/>
                    <TextField style={themeStyle.textInput} required id="outlined-number" type="number" variant="outlined" size = "small" label="Rating" placeholder={data[keys[16]]} defaultValue="0" value={data[keys[16]]} name={keys[16]} onChange={e => handleChange(e)}/>
                    <TextField style={themeStyle.textInput} required id="outlined-required" variant="outlined" size = "small" label="Socket" placeholder={data[keys[0]]} defaultValue=" " value={data[keys[0]]} name={keys[0]} onChange={e => handleChange(e)}/>
                    <TextField style={themeStyle.textInput} required id="outlined-number" type="number" variant="outlined" size = "small" label="L3Cache" placeholder={data[keys[2]]} defaultValue="0" value={data[keys[2]]} name={keys[2]} onChange={e => handleChange(e)}/>
                    <TextField style={themeStyle.textInput} required id="outlined-number" type="number" variant="outlined" size = "small" label="Total Cache" placeholder={data[keys[3]]} defaultValue="0" value={data[keys[3]]} name={keys[3]} onChange={e => handleChange(e)}/>
                    <TextField style={themeStyle.textInput} required id="outlined-number" type="number" variant="outlined" size = "small" label="Cores" placeholder={data[keys[4]]} defaultValue="0" value={data[keys[4]]} name={keys[4]} onChange={e => handleChange(e)}/>
                    <TextField style={themeStyle.textInput} required id="outlined-number" type="number" variant="outlined" size = "small" label="Threads" placeholder={data[keys[5]]} defaultValue="0" value={data[keys[5]]} name={keys[5]} onChange={e => handleChange(e)}/>
                    <TextField style={themeStyle.textInput} required id="outlined-required" variant="outlined" size = "small" label="Igpu" placeholder={data[keys[6]]} defaultValue=" " value={data[keys[6]]} name={keys[6]} onChange={e => handleChange(e)}/>
                    <TextField style={themeStyle.textInput} required id="outlined-number" type="number" variant="outlined" size = "small" label="Tdp" placeholder={data[keys[7]]} defaultValue="0" value={data[keys[7]]} name={keys[7]} onChange={e => handleChange(e)}/>
                    <TextField style={themeStyle.textInput} required id="outlined-number" type="number" variant="outlined" size = "small" label="Core Clock" placeholder={data[keys[8]]} defaultValue="0" value={data[keys[8]]} name={keys[8]} onChange={e => handleChange(e)}/>
                    <TextField style={themeStyle.textInput} required id="outlined-number" type="number" variant="outlined" size = "small" label="Turbo Core Clock" placeholder={data[keys[9]]} defaultValue="0" value={data[keys[9]]} name={keys[9]} onChange={e => handleChange(e)}/>
                    <TextField style={themeStyle.textInput} required id="outlined-required" variant="outlined" size = "small" label="Main Image" placeholder={data[keys[17]]} defaultValue=" " value={data[keys[17]]} name={keys[17]} onChange={e => handleChange(e)}/>
                    <TextField style={themeStyle.textInput} required id="outlined-required" variant="outlined" size = "small" label="Product Official Website" placeholder={data[keys[18]]} defaultValue=" " value={data[keys[18]]} name={keys[18]} onChange={e => handleChange(e)}/>
                    <TextField style={themeStyle.textInput} required id="outlined-required" variant="outlined" size = "small" label="Model Number" placeholder={data[keys[19]]} defaultValue=" " value={data[keys[19]]} name={keys[19]} onChange={e => handleChange(e)}/>
                    <Grid item md={2}>
                        <Button style={themeStyle.navbarButton} variant="outlined" size="small" type="submit">Save</Button>
                        <Button style={themeStyle.navbarButton} variant="outlined" size="small" onClick={() => navigate(`/product/cpu`)}>Back</Button>
                    </Grid>
                    </Grid>
                </Grid>
                {/* <div className="button-section">
                    <button type="submit" variant="outlined" size="small">Save</button>
                    <button variant="outlined" size="small" onClick={() => navigate(`/product/cpu`)}> Back </button>
                </div> */}

        </form>
    )
}