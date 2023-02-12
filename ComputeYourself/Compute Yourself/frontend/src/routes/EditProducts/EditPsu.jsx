import { useEffect, useState } from 'react';
import useAuth from "../../hooks/useAuth"
import { AxiosGetById, AxiosPut } from "../../Axios/FetchWithAxios"
import { useNavigate, useParams } from "react-router-dom";
import themeStyle from "../../themeStyle"
import Button from '@material-ui/core/Button';
import TextField from '@mui/material/TextField';
import { Grid } from "@mui/material";			
import MenuItem from '@mui/material/MenuItem';

export default function EditPsu() {
    const [data, setData] = useState([]);
    const navigate = useNavigate();
    let { id } = useParams();
    const keys = Object.keys(data).map((propName, idx) => { return propName });
    useEffect(() => {
        AxiosGetById("psu", id).then(
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
    }

    const { auth } = useAuth();

    let handleSubmit = async (e) => {
        e.preventDefault();
        const token = auth.token;
        const json = JSON.stringify(data);
        AxiosPut(token, data.id, json, "psu", navigate);
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
                <TextField style={themeStyle.textInput} required id="outlined-number" type="number" variant="outlined" size = "small" label="Capacity" placeholder={data[keys[0]]} defaultValue="0" value={data[keys[0]]} name={keys[0]} onChange={e => handleChange(e)}/>
                <TextField style={themeStyle.textInput} select id="outlined-required" variant="outlined" size = "small" label="Modular" placeholder={data[keys[1]]} value={data[keys[1]]} name={keys[1]} onChange={e => handleChange(e)}>
                    <MenuItem value={true}>Yes</MenuItem>
                    <MenuItem value={false}>No</MenuItem>
                </TextField>
                <TextField style={themeStyle.textInput} required id="outlined-required" variant="outlined" size = "small" label="Main Image" placeholder={data[keys[10]]} defaultValue=" " value={data[keys[10]]} name={keys[10]} onChange={e => handleChange(e)}/>
                <TextField style={themeStyle.textInput} required id="outlined-required" variant="outlined" size = "small" label="Product Official Website" placeholder={data[keys[11]]} defaultValue=" " value={data[keys[11]]} name={keys[11]} onChange={e => handleChange(e)}/>
                <TextField style={themeStyle.textInput} required id="outlined-required" variant="outlined" size = "small" label="Model Number" placeholder={data[keys[12]]} defaultValue=" " value={data[keys[12]]} name={keys[12]} onChange={e => handleChange(e)}/>
                <Grid item md={2}>
                    <Button style={themeStyle.navbarButton} variant="outlined" size="small" type="submit">Save</Button>
                    <Button style={themeStyle.navbarButton} variant="outlined" size="small" onClick={() => navigate(`/product/psu`)}>Back</Button>
                    </Grid>
                </Grid>
            </Grid>
        </form>
    )
}