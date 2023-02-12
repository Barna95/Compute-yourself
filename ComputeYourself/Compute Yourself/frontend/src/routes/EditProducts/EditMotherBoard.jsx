import { AxiosGetById, AxiosPut } from "../../Axios/FetchWithAxios"
import { useEffect } from "react";
import { useNavigate, useParams } from "react-router-dom";
import { useState } from 'react';
import useAuth from "../../hooks/useAuth"
import themeStyle from "../../themeStyle"
import Button from '@material-ui/core/Button';
import TextField from '@mui/material/TextField';
import { Grid } from "@mui/material";	
import MenuItem from '@mui/material/MenuItem';


export default function EditMotherBoard() {
    const [data, setData] = useState([]);
    const navigate = useNavigate();
    let { id } = useParams();
    const keys = Object.keys(data).map((propName, idx) => { return propName });
    useEffect(() => {
        AxiosGetById("motherboard", id).then(
            (response) => {
                setData(response.data);
            });
    }, []);

    useEffect(() => {
        console.log(data);
    },[data])

    let handleChange = (e) => {
        if (e.target.name === "xmp" || e.target.name === "lighting" || e.target.name === "windows11Support" ) {
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
        AxiosPut(token, data.id, json, "motherboard", navigate);
    };


    return (
        <form onSubmit={e => handleSubmit(e)}>
            {/*TODO => Add enums. Size can be edited*/}
            {/* <div> Size enum, dont touch <input placeholder={data[keys[2]]} aria-label="{keys[2]}" type="text" name={keys[2]} onChange={e => handleChange(e)}/></div> */}
            <Grid container md={12} alignContent="center">
                <Grid item md={6} padding={2} autoComplete="off" noValidate>
                <TextField style={themeStyle.textInput} required id="outlined-required" variant="outlined" size = "small" label="Name" placeholder={data[keys[24]]} defaultValue=" " value={data[keys[24]]} name={keys[24]} onChange={e => handleChange(e)}/>
                <TextField style={themeStyle.textInput} required id="outlined-required" variant="outlined" size = "small" label="Description" placeholder={data[keys[25]]} defaultValue=" " value={data[keys[25]]} name={keys[25]} onChange={e => handleChange(e)}/>
                <TextField style={themeStyle.textInput} required id="outlined-number" type="number" variant="outlined" size = "small" label="Price" placeholder={data[keys[26]]} defaultValue="0" value={data[keys[26]]} name={keys[26]} onChange={e => handleChange(e)}/>
                <TextField style={themeStyle.textInput} required id="outlined-required" variant="outlined" size = "small" label="Brand" placeholder={data[keys[27]]} defaultValue=" " value={data[keys[27]]} name={keys[27]} onChange={e => handleChange(e)}/>
                <TextField style={themeStyle.textInput} required id="outlined-number" type="number" variant="outlined" size = "small" label="Warranty" placeholder={data[keys[28]]} defaultValue="0" value={data[keys[28]]} name={keys[28]} onChange={e => handleChange(e)}/>
                <TextField style={themeStyle.textInput} required id="outlined-number" type="number" variant="outlined" size = "small" label="Rating" placeholder={data[keys[29]]} defaultValue="0" value={data[keys[29]]} name={keys[29]} onChange={e => handleChange(e)}/>
                <TextField style={themeStyle.textInput} required id="outlined-required" variant="outlined" size = "small" label="Socket" placeholder={data[keys[0]]} defaultValue=" " value={data[keys[0]]} name={keys[0]} onChange={e => handleChange(e)}/>
                <TextField style={themeStyle.textInput} required id="outlined-required" variant="outlined" size = "small" label="Chipset" placeholder={data[keys[1]]} defaultValue=" " value={data[keys[1]]} name={keys[1]} onChange={e => handleChange(e)}/>
                <TextField style={themeStyle.textInput} required id="outlined-required" variant="outlined" size = "small" label="Igpu" placeholder={data[keys[3]]} defaultValue=" " value={data[keys[3]]} name={keys[3]} onChange={e => handleChange(e)}/>
                <TextField style={themeStyle.textInput} required id="outlined-required" variant="outlined" size = "small" label="Ram" placeholder={data[keys[4]]} defaultValue=" " value={data[keys[4]]} name={keys[4]} onChange={e => handleChange(e)}/>
                <TextField style={themeStyle.textInput} required id="outlined-number" type="number" variant="outlined" size = "small" label="Frequency" placeholder={data[keys[5]]} defaultValue="0" value={data[keys[5]]} name={keys[5]} onChange={e => handleChange(e)}/>
                <TextField style={themeStyle.textInput} required id="outlined-number" type="number" variant="outlined" size = "small" label="Memory Sockets" placeholder={data[keys[6]]} defaultValue="0" value={data[keys[6]]} name={keys[6]} onChange={e => handleChange(e)}/>
                <TextField style={themeStyle.textInput} select id="outlined-required" variant="outlined" size = "small" label="Xmp" placeholder={data[keys[7]]} value={data[keys[7]]} name={keys[7]} onChange={e => handleChange(e)}>
                    <MenuItem value={true}>Yes</MenuItem>
                    <MenuItem value={false}>No</MenuItem>
                </TextField>
                <TextField style={themeStyle.textInput} required id="outlined-number" type="number" variant="outlined" size = "small" label="Max Memory" placeholder={data[keys[8]]} defaultValue="0" value={data[keys[8]]} name={keys[8]} onChange={e => handleChange(e)}/>
                <TextField style={themeStyle.textInput} required id="outlined-required" variant="outlined" size = "small" label="CrossFire or SLI Support" placeholder={data[keys[9]]} defaultValue=" " value={data[keys[9]]} name={keys[9]} onChange={e => handleChange(e)}/>
                <TextField style={themeStyle.textInput} required id="outlined-required" variant="outlined" size = "small" label="Bluetooth" placeholder={data[keys[10]]} defaultValue=" " value={data[keys[10]]} name={keys[10]} onChange={e => handleChange(e)}/>
                <TextField style={themeStyle.textInput} select id="outlined-required" variant="outlined" size = "small" label="Lighting" placeholder={data[keys[11]]} value={data[keys[11]]} name={keys[11]} onChange={e => handleChange(e)}>
                    <MenuItem value={true}>Yes</MenuItem>
                    <MenuItem value={false}>No</MenuItem>
                </TextField>
                <TextField style={themeStyle.textInput} select id="outlined-required" variant="outlined" size = "small" label="Windows 11 Support" placeholder={data[keys[12]]} value={data[keys[12]]} name={keys[12]} onChange={e => handleChange(e)}>
                    <MenuItem value={true}>Yes</MenuItem>
                    <MenuItem value={false}>No</MenuItem>
                </TextField>
                <TextField style={themeStyle.textInput} required id="outlined-required" variant="outlined" size = "small" label="wifi" placeholder={data[keys[13]]} defaultValue=" " value={data[keys[13]]} name={keys[13]} onChange={e => handleChange(e)}/>
                <TextField style={themeStyle.textInput} required id="outlined-required" variant="outlined" size = "small" label="LanPort" placeholder={data[keys[14]]} defaultValue=" " value={data[keys[14]]} name={keys[14]} onChange={e => handleChange(e)}/>
                <TextField style={themeStyle.textInput} required id="outlined-number" type="number" variant="outlined" size = "small" label="LanportsNumber" placeholder={data[keys[15]]} defaultValue="0" value={data[keys[15]]} name={keys[15]} onChange={e => handleChange(e)}/>
                <TextField style={themeStyle.textInput} required id="outlined-number" type="number" variant="outlined" size = "small" label="PcIe16x" placeholder={data[keys[16]]} defaultValue="0" value={data[keys[16]]} name={keys[16]} onChange={e => handleChange(e)}/>
                <TextField style={themeStyle.textInput} required id="outlined-number" type="number" variant="outlined" size = "small" label="SatA3" placeholder={data[keys[17]]} defaultValue="0" value={data[keys[17]]} name={keys[17]} onChange={e => handleChange(e)}/>
                <TextField style={themeStyle.textInput} required id="outlined-number" type="number" variant="outlined" size = "small" label="M2" placeholder={data[keys[18]]} defaultValue="0" value={data[keys[18]]} name={keys[18]} onChange={e => handleChange(e)}/>
                <TextField style={themeStyle.textInput} required id="outlined-number" type="number" variant="outlined" size = "small" label="USB2" placeholder={data[keys[19]]} defaultValue="0" value={data[keys[19]]} name={keys[19]} onChange={e => handleChange(e)}/>
                <TextField style={themeStyle.textInput} required id="outlined-number" type="number" variant="outlined" size = "small" label="USB3" placeholder={data[keys[20]]} defaultValue="0" value={data[keys[20]]} name={keys[20]} onChange={e => handleChange(e)}/>
                <TextField style={themeStyle.textInput} required id="outlined-number" type="number" variant="outlined" size = "small" label="USB31" placeholder={data[keys[21]]} defaultValue="0" value={data[keys[21]]} name={keys[21]} onChange={e => handleChange(e)}/>
                <TextField style={themeStyle.textInput} required id="outlined-number" type="number" variant="outlined" size = "small" label="USBC" placeholder={data[keys[22]]} defaultValue="0" value={data[keys[22]]} name={keys[22]} onChange={e => handleChange(e)}/>
                <TextField style={themeStyle.textInput} required id="outlined-required" variant="outlined" size = "small" label="Main Image" placeholder={data[keys[30]]} defaultValue=" " value={data[keys[30]]} name={keys[30]} onChange={e => handleChange(e)}/>
                <TextField style={themeStyle.textInput} required id="outlined-required" variant="outlined" size = "small" label="Product Official Website" placeholder={data[keys[31]]} defaultValue=" " value={data[keys[31]]} name={keys[31]} onChange={e => handleChange(e)}/>
                <TextField style={themeStyle.textInput} required id="outlined-required" variant="outlined" size = "small" label="Model Number" placeholder={data[keys[32]]} defaultValue=" " value={data[keys[32]]} name={keys[32]} onChange={e => handleChange(e)}/>
                <Grid item md={2}>
                    <Button style={themeStyle.navbarButton} variant="outlined" size="small" type="submit">Save</Button>
                    <Button style={themeStyle.navbarButton} variant="outlined" size="small" onClick={() => navigate(`/product/motherboard`)}>Back</Button>
                    </Grid>
                </Grid>
            </Grid>
            
        </form>
    )
}