import { AxiosGetById, AxiosPut } from "../../Axios/FetchWithAxios"
import { useEffect, useState } from 'react';
import { useNavigate, useParams } from "react-router-dom";

import { Grid } from "@mui/material";
import MenuItem from '@mui/material/MenuItem';
import TextField from '@mui/material/TextField';
import themeStyle from "../../themeStyle"
import useAuth from "../../hooks/useAuth"

// import Button from '@material-ui/core/Button';




export default function EditRam() {
    const [data, setData] = useState([]);
    const navigate = useNavigate();
    let { id } = useParams();
    const keys = Object.keys(data).map((propName, idx) => { return propName });
    useEffect(() => {
        AxiosGetById("ram", id).then(
            (response) => {
                setData(response.data);
            });
    }, []);

    let handleChange = (e) => {
        if (e.target.name === "heatSink") {
            if (data[e.target.name] == true) {
                setData({ ...data, [e.target.name]: false });
            } else {
                setData({ ...data, [e.target.name]: true });
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
        AxiosPut(token, data.id, json, "ram", navigate);
    };

    return (
        <form onSubmit={e => handleSubmit(e)}>
            <Grid container md={12} alignContent="center">
                <Grid item md={6} padding={2} autoComplete="off" noValidate>
                <TextField style={themeStyle.textInput} required id="outlined-required" variant="outlined" size = "small" label="Name" placeholder={data[keys[6]]} defaultValue=" " value={data[keys[6]]} name={keys[6]} onChange={e => handleChange(e)}/>
                <TextField style={themeStyle.textInput} required id="outlined-required" variant="outlined" size = "small" label="Description" placeholder={data[keys[7]]} defaultValue=" " value={data[keys[7]]} name={keys[7]} onChange={e => handleChange(e)}/>
                <TextField style={themeStyle.textInput} required id="outlined-number" type="number" variant="outlined" size = "small" label="Price" placeholder={data[keys[8]]} defaultValue="0" value={data[keys[8]]} name={keys[8]} onChange={e => handleChange(e)}/>
                <TextField style={themeStyle.textInput} required id="outlined-required" variant="outlined" size = "small" label="Brand" placeholder={data[keys[9]]} defaultValue=" " value={data[keys[9]]} name={keys[9]} onChange={e => handleChange(e)}/>
                <TextField style={themeStyle.textInput} required id="outlined-number" type="number" variant="outlined" size = "small" label="Warranty" placeholder={data[keys[10]]} defaultValue="0" value={data[keys[10]]} name={keys[10]} onChange={e => handleChange(e)}/>
                <TextField style={themeStyle.textInput} required id="outlined-number" type="number" variant="outlined" size = "small" label="Rating" placeholder={data[keys[11]]} defaultValue="0" value={data[keys[11]]} name={keys[11]} onChange={e => handleChange(e)}/>
                <TextField style={themeStyle.textInput} required id="outlined-number" type="number" variant="outlined" size = "small" label="Size" placeholder={data[keys[0]]} defaultValue="0" value={data[keys[0]]} name={keys[0]} onChange={e => handleChange(e)}/>
                <TextField style={themeStyle.textInput} required id="outlined-required" variant="outlined" size = "small" label="Memory Type" placeholder={data[keys[1]]} defaultValue=" " value={data[keys[1]]} name={keys[1]} onChange={e => handleChange(e)}/>
                <TextField style={themeStyle.textInput} required id="outlined-number" type="number" variant="outlined" size = "small" label="Frequency" placeholder={data[keys[2]]} defaultValue="0" value={data[keys[2]]} name={keys[2]} onChange={e => handleChange(e)}/>
                <TextField style={themeStyle.textInput} required id="outlined-number" type="number" variant="outlined" size = "small" label="Latency" placeholder={data[keys[3]]} defaultValue="0" value={data[keys[3]]} name={keys[3]} onChange={e => handleChange(e)}/>
                <TextField style={themeStyle.textInput} select id="outlined-required" variant="outlined" size = "small" label="Heat Sink" placeholder={data[keys[4]]} value={data[keys[4]]} name={keys[4]} onChange={e => handleChange(e)}>
                    <MenuItem value={true}>Yes</MenuItem>
                    <MenuItem value={false}>No</MenuItem>
                </TextField>
                <TextField style={themeStyle.textInput} required id="outlined-required" variant="outlined" size = "small" label="Main Image" placeholder={data[keys[12]]} defaultValue=" " value={data[keys[12]]} name={keys[12]} onChange={e => handleChange(e)}/>
                <TextField style={themeStyle.textInput} required id="outlined-required" variant="outlined" size = "small" label="Product Official Website" placeholder={data[keys[13]]} defaultValue=" " value={data[keys[13]]} name={keys[13]} onChange={e => handleChange(e)}/>
                <TextField style={themeStyle.textInput} required id="outlined-required" variant="outlined" size = "small" label="Model Number" placeholder={data[keys[14]]} defaultValue=" " value={data[keys[14]]} name={keys[14]} onChange={e => handleChange(e)}/>
                <Grid item md={2}>
                    <Button style={themeStyle.navbarButton} variant="outlined" size="small" type="submit">Save</Button>
                    <Button style={themeStyle.navbarButton} variant="outlined" size="small" onClick={() => navigate(`/product/ram`)}>Back</Button>
                    </Grid>
                </Grid>
            </Grid>
        </form>
    )
}