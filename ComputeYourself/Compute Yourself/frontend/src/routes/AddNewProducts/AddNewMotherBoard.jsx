import Button from '@material-ui/core/Button';
import { AxiosPost } from "../../Axios/FetchWithAxios"
import { useNavigate } from "react-router-dom";
import { useState } from 'react';
import useAuth from "../../hooks/useAuth"
import themeStyle from "../../themeStyle"
import { Grid } from "@mui/material";	
import TextField from '@mui/material/TextField';
import MenuItem from '@mui/material/MenuItem';

export default function AddNewMotherBoard() {
    const [formValues, setFormValues] = useState({
        "socket": "",
        "chipset": "",
        "size": "MicroATX",
        "igpu": "",
        "ram": "",
        "frequency": 0,
        "memorySockets": 0,
        "xmp": false,
        "maxMemory": 0,
        "cForSLISupport": "",
        "bluetooth": "",
        "lighting": false,
        "windows11Support": false,
        "wifi": "",
        "lanPort": "",
        "lanportsNumber": 0,
        "pcIe16x": 0,
        "satA3": 0,
        "m2": 0,
        "usB2": 0,
        "usB3": 0,
        "usB31": 0,
        "usbc": 0,
        "name": "",
        "description": "",
        "price": 0,
        "brand": "",
        "warranty": 0,
        "rating": 0,
        "mainImage": "",
        "productOfficialWebsite": "",
        "modelNumber": "",
    });
    const navigate = useNavigate();
    const keys = Object.keys(formValues).map((propName, idx) => { return propName });
    let handleChange = (e) => {
        if (e.target.name === "xmp" || e.target.name === "lighting" || e.target.name === "windows11Support" ) {
            if (formValues[e.target.name] == true) {
                setFormValues({ ...formValues, [e.target.name]: false });
            } else {
                setFormValues({ ...formValues, [e.target.name]: true });
            }
        } else {
            setFormValues({ ...formValues, [e.target.name]: e.target.value });
        }
    }

    const { auth } = useAuth();

    let handleSubmit = async (e) => {
        e.preventDefault();
        const token = auth.token
        const json = JSON.stringify(formValues);
        AxiosPost("motherboard", token, json, navigate)
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
                    <TextField style={themeStyle.textInput} required id="outlined-required" variant="outlined" size = "small" label="Name" defaultValue=" " name={keys[23]} onChange={e => handleChange(e)}/>
                    <TextField style={themeStyle.textInput} required id="outlined-required" variant="outlined" size = "small" label="Description" defaultValue=" " name={keys[24]} onChange={e => handleChange(e)}/>
                    <TextField style={themeStyle.textInput} required id="outlined-number" type="number" variant="outlined" size = "small" label="Price" defaultValue="0" name={keys[25]} onChange={e => handleChange(e)}/>
                    <TextField style={themeStyle.textInput} required id="outlined-required" variant="outlined" size = "small" label="Brand" defaultValue=" " name={keys[26]} onChange={e => handleChange(e)}/>
                    <TextField style={themeStyle.textInput} required id="outlined-number" type="number" variant="outlined" size = "small" label="Warranty" defaultValue="0" name={keys[27]} onChange={e => handleChange(e)}/>
                    <TextField style={themeStyle.textInput} required id="outlined-number" type="number" variant="outlined" size = "small" label="Rating" defaultValue="0" name={keys[28]} onChange={e => handleChange(e)}/>
                    <TextField style={themeStyle.textInput} required id="outlined-required" variant="outlined" size = "small" label="Socket" defaultValue=" " name={keys[0]} onChange={e => handleChange(e)}/>
                    <TextField style={themeStyle.textInput} required id="outlined-required" variant="outlined" size = "small" label="Chipset" defaultValue=" " name={keys[1]} onChange={e => handleChange(e)}/>
                    <TextField style={themeStyle.textInput} required id="outlined-required" variant="outlined" size = "small" label="Size enum, dont touch" defaultValue=" " name={keys[2]} onChange={e => handleChange(e)}/>
                    <TextField style={themeStyle.textInput} required id="outlined-required" variant="outlined" size = "small" label="Igpu" defaultValue=" " name={keys[3]} onChange={e => handleChange(e)}/>
                    <TextField style={themeStyle.textInput} required id="outlined-required" variant="outlined" size = "small" label="Ram" defaultValue=" " name={keys[4]} onChange={e => handleChange(e)}/>
                    <TextField style={themeStyle.textInput} required id="outlined-number" type="number" variant="outlined" size = "small" label="Frequency" defaultValue="0" name={keys[5]} onChange={e => handleChange(e)}/>
                    <TextField style={themeStyle.textInput} required id="outlined-number" type="number" variant="outlined" size = "small" label="Memory Sockets" defaultValue="0" name={keys[6]} onChange={e => handleChange(e)}/>
                    <TextField style={themeStyle.textInput} select id="outlined-required" variant="outlined" size = "small" label="Xmp" name={keys[7]} onChange={e => handleChange(e)}>
                        <MenuItem value={true}>Yes</MenuItem>
                        <MenuItem value={false}>No</MenuItem>
                    </TextField>
                    <TextField style={themeStyle.textInput} required id="outlined-number" type="number" variant="outlined" size = "small" label="Max Memory" defaultValue="0" name={keys[8]} onChange={e => handleChange(e)}/>
                    <TextField style={themeStyle.textInput} required id="outlined-required" variant="outlined" size = "small" label="C For SLI Support" defaultValue=" " name={keys[9]} onChange={e => handleChange(e)}/>
                    <TextField style={themeStyle.textInput} required id="outlined-required" variant="outlined" size = "small" label="Bluetooth" defaultValue=" " name={keys[10]} onChange={e => handleChange(e)}/>
                    <TextField style={themeStyle.textInput} select id="outlined-required" variant="outlined" size = "small" label="Lighting" name={keys[11]} onChange={e => handleChange(e)}>
                        <MenuItem value={true}>Yes</MenuItem>
                        <MenuItem value={false}>No</MenuItem>
                    </TextField>
                    <TextField style={themeStyle.textInput} select id="outlined-required" variant="outlined" size = "small" label="Windows 11 Support" name={keys[12]} onChange={e => handleChange(e)}>
                        <MenuItem value={true}>Yes</MenuItem>
                        <MenuItem value={false}>No</MenuItem>
                    </TextField>
                    <TextField style={themeStyle.textInput} required id="outlined-required" variant="outlined" size = "small" label="wifi" defaultValue=" " name={keys[13]} onChange={e => handleChange(e)}/>
                    <TextField style={themeStyle.textInput} required id="outlined-required" variant="outlined" size = "small" label="LanPort" defaultValue=" " name={keys[14]} onChange={e => handleChange(e)}/>
                    <TextField style={themeStyle.textInput} required id="outlined-number" type="number" variant="outlined" size = "small" label="LanportsNumber" defaultValue="0" name={keys[15]} onChange={e => handleChange(e)}/>
                    <TextField style={themeStyle.textInput} required id="outlined-number" type="number" variant="outlined" size = "small" label="PcIe16x" defaultValue="0" name={keys[16]} onChange={e => handleChange(e)}/>
                    <TextField style={themeStyle.textInput} required id="outlined-number" type="number" variant="outlined" size = "small" label="SatA3" defaultValue="0" name={keys[17]} onChange={e => handleChange(e)}/>
                    <TextField style={themeStyle.textInput} required id="outlined-number" type="number" variant="outlined" size = "small" label="M2" defaultValue="0" name={keys[18]} onChange={e => handleChange(e)}/>
                    <TextField style={themeStyle.textInput} required id="outlined-number" type="number" variant="outlined" size = "small" label="USB2" defaultValue="0" name={keys[19]} onChange={e => handleChange(e)}/>
                    <TextField style={themeStyle.textInput} required id="outlined-number" type="number" variant="outlined" size = "small" label="USB3" defaultValue="0" name={keys[20]} onChange={e => handleChange(e)}/>
                    <TextField style={themeStyle.textInput} required id="outlined-number" type="number" variant="outlined" size = "small" label="USB31" defaultValue="0" name={keys[21]} onChange={e => handleChange(e)}/>
                    <TextField style={themeStyle.textInput} required id="outlined-number" type="number" variant="outlined" size = "small" label="USBC" defaultValue="0" name={keys[22]} onChange={e => handleChange(e)}/>
                    <TextField style={themeStyle.textInput} required id="outlined-required" variant="outlined" size = "small" label="Main Image" defaultValue=" " name={keys[29]} onChange={e => handleChange(e)}/>
                    <TextField style={themeStyle.textInput} required id="outlined-required" variant="outlined" size = "small" label="Product Official Website" defaultValue=" " name={keys[30]} onChange={e => handleChange(e)}/>
                    <TextField style={themeStyle.textInput} required id="outlined-required" variant="outlined" size = "small" label="Model Number" defaultValue=" " name={keys[31]} onChange={e => handleChange(e)}/>
                    <Grid id item md={2}>
                        <Button style={themeStyle.navbarButton} variant="outlined" size="small" type="submit">Save</Button>
                        <Button style={themeStyle.navbarButton} variant="outlined" size="small" onClick={() => navigate(`/product/motherboard`)}>Back</Button>
                    </Grid>
                </Grid>
            </Grid>
        </form>
    )
}