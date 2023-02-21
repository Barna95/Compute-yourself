// import Button from '@material-ui/core/Button';

import { AxiosPost } from "../../Axios/FetchWithAxios"
import { Grid } from "@mui/material";
import TextField from '@mui/material/TextField';
import themeStyle from "../../themeStyle"
import useAuth from "../../hooks/useAuth"
import { useNavigate } from "react-router-dom";
import { useState } from 'react';

export default function AddNewCpuCooler() {
    const [formValues, setFormValues] = useState({
        "coolerType": "",
        "height": 0,
        "cpuType": "",
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
        setFormValues({ ...formValues, [e.target.name]: e.target.value });
    }

    const { auth } = useAuth();

    let handleSubmit = async (e) => {
        e.preventDefault
        const token = auth.token
        const json = JSON.stringify(formValues);
        AxiosPost("cpucooler", token, json, navigate)
    };
    // TODO -> input fields be required as its needed.
    // create the input nodes with map but it would be hard to change the different
    //input fields like checkbox or choose from enums in dropdown
    // so ill just leave it here for now.
    // keys.map((propName, idx) => <div key={idx}> {propName}<input placeholder="" aria-label="{propName}" type="text" name={propName} onChange={e => handleChange(e)} /></div>)
    return (
        <form onSubmit={e => handleSubmit(e)}>
            <Grid container md={12} alignContent="center">
                <Grid item md={6} padding={2} autoComplete="off" noValidate>
                <TextField style={themeStyle.textInput} required id="outlined-required" variant="outlined" size = "small" label="Name" defaultValue=" " name={keys[3]} onChange={e => handleChange(e)}/>
                <TextField style={themeStyle.textInput} required id="outlined-required" variant="outlined" size = "small" label="Description" defaultValue=" " name={keys[4]} onChange={e => handleChange(e)}/>
                <TextField style={themeStyle.textInput} required id="outlined-number" type="number" variant="outlined" size = "small" label="Price" defaultValue="0" name={keys[5]} onChange={e => handleChange(e)}/>
                <TextField style={themeStyle.textInput} required id="outlined-required" variant="outlined" size = "small" label="Brand" defaultValue=" " name={keys[6]} onChange={e => handleChange(e)}/>
                <TextField style={themeStyle.textInput} required id="outlined-number" type="number" variant="outlined" size = "small" label="Warranty" defaultValue="0" name={keys[7]} onChange={e => handleChange(e)}/>
                <TextField style={themeStyle.textInput} required id="outlined-number" type="number" variant="outlined" size = "small" label="Rating" defaultValue="0" name={keys[8]} onChange={e => handleChange(e)}/>
                <TextField style={themeStyle.textInput} required id="outlined-required" variant="outlined" size = "small" label="Cooler Type" defaultValue=" " name={keys[0]} onChange={e => handleChange(e)}/>
                <TextField style={themeStyle.textInput} required id="outlined-required" variant="outlined" size = "small" label="Height" defaultValue=" " name={keys[1]} onChange={e => handleChange(e)}/>
                <TextField style={themeStyle.textInput} required id="outlined-required" variant="outlined" size = "small" label="Cpu Type" defaultValue=" " name={keys[2]} onChange={e => handleChange(e)}/>
                <TextField style={themeStyle.textInput} required id="outlined-required" variant="outlined" size = "small" label="Main Image" defaultValue=" " name={keys[9]} onChange={e => handleChange(e)}/>
                <TextField style={themeStyle.textInput} required id="outlined-required" variant="outlined" size = "small" label="Product Official Website" defaultValue=" " name={keys[10]} onChange={e => handleChange(e)}/>
                <TextField style={themeStyle.textInput} required id="outlined-required" variant="outlined" size = "small" label="Model Number" defaultValue=" " name={keys[11]} onChange={e => handleChange(e)}/>
                <Grid item md={2}>
                    <Button style={themeStyle.navbarButton} variant="outlined" size="small" type="submit">Save</Button>
                    <Button style={themeStyle.navbarButton} variant="outlined" size="small" onClick={() => navigate(`/product/cpucooler`)}>Back</Button>
                    </Grid>
                </Grid>
            </Grid>
        </form>
    )
}