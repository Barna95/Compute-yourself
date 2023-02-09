import axios from "axios";
import { useNavigate } from "react-router-dom";
import { useState } from 'react';
import useAuth from "../../hooks/useAuth"
import themeStyle from "../../themeStyle"
import Button from '@material-ui/core/Button';
import TextField from '@mui/material/TextField';
import { Grid } from "@mui/material";	
import useAuth from "../../hooks/useAuth";
import { toast } from 'react-toastify';

export default function AddNewPcCase() {
    const [formValues, setFormValues] = useState({
        "sizeCompatibility": "ATX",
        "maxCpuCoolerHeight": 0,
        "maxGpuLength": 0,
        "name": " ",
        "description": " ",
        "price": 0,
        "brand": " ",
        "warranty": 0,
        "rating": 0,
        "mainImage": " ",
        "productOfficialWebsite": " ",
        "modelNumber": " "
    });
    const navigate = useNavigate();
    const keys = Object.keys(formValues).map((propName, idx) => { return propName });
    let handleChange = (e) => {
        setFormValues({ ...formValues, [e.target.name]: e.target.value });
    }

    const { auth } = useAuth();

    let handleSubmit = async (e) => {
        e.preventDefault();
        const token = auth.token
        const json = JSON.stringify(formValues);
        await axios.post(`https://localhost:7195/product/pccase`, json, {
            headers: {
                'Content-Type': 'application/json;charset=UTF-8',
                'Authorization': `Bearer ${token}`
            }
        }).then(response => {
            if (response.status === 200) {
                toast.success('Created.', {
                    position: toast.POSITION.TOP_RIGHT
                });
                return navigate("/product/pccase")
            }
        }).catch((error) => {
            console.log(error.config);
            toast.error('Oops, something went wrong!', {
                position: toast.POSITION.BOTTOM_RIGHT
            });
        }) 
    };

    //TODO -> add enum so this works <div> Size Compatibility enum, no touchy <input placeholder="" aria-label="{keys[0]}" type="text" name={keys[0]} onChange={e => handleChange(e)} /></div>

    // input fields be required as its needed.
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
                    <TextField style={themeStyle.textInput} required id="outlined-number" type="number" variant="outlined" size = "small" label="Max CpuCooler Height" defaultValue="0" name={keys[1]} onChange={e => handleChange(e)}/>
                    <TextField style={themeStyle.textInput} required id="outlined-number" type="number" variant="outlined" size = "small" label="Max GpuLength" defaultValue="0" name={keys[2]} onChange={e => handleChange(e)}/>
                    <TextField style={themeStyle.textInput} required id="outlined-required" variant="outlined" size = "small" label="Main Image" defaultValue=" " name={keys[9]} onChange={e => handleChange(e)}/>
                    <TextField style={themeStyle.textInput} required id="outlined-required" variant="outlined" size = "small" label="Product Official Website" defaultValue=" " name={keys[10]} onChange={e => handleChange(e)}/>
                    <TextField style={themeStyle.textInput} required id="outlined-required" variant="outlined" size = "small" label="Model Number" defaultValue=" " name={keys[11]} onChange={e => handleChange(e)}/>
                <Grid item md={2}>
                    <Button style={themeStyle.navbarButton} variant="outlined" size="small" type="submit">Save</Button>
                    <Button style={themeStyle.navbarButton} variant="outlined" size="small" onClick={() => navigate(`/product/pccase`)}>Back</Button>
                    </Grid>
                </Grid>
            </Grid>
        </form>
    )
}