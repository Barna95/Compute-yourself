import Button from '@material-ui/core/Button';
import axios from "axios";
import { useNavigate } from "react-router-dom";
import { useState } from 'react';
import useAuth from "../../hooks/useAuth";
import { toast } from 'react-toastify';

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
        await axios.post(`https://localhost:7195/product/motherboard`, json, {
            headers: {
                'Content-Type': 'application/json;charset=UTF-8',
                'Authorization': `Bearer ${token}`
            }
        }).then(response => {
            if (response.status === 200) {
                toast.success('Created.', {
                    position: toast.POSITION.TOP_RIGHT
                });
                return navigate("/product/motherboard")
            }
        }).catch((error) => {
            console.log(error.config);
            toast.error('Oops, something went wrong!', {
                position: toast.POSITION.BOTTOM_RIGHT
            });
        }) 
    };
    // TODO -> input fields be required as its needed.
    // create the input nodes with map but it would be hard to change the different
    //input fields like checkbox or choose from enums in dropdown
    // so ill just leave it here for now.
    // keys.map((propName, idx) => <div key={idx}> {propName}<input placeholder="" aria-label="{propName}" type="text" name={propName} onChange={e => handleChange(e)} /></div>)
    return (
        <form onSubmit={e => handleSubmit(e)}>
            <div> Name <input placeholder="" aria-label="{keys[23]}" type="text" name={keys[23]} onChange={e => handleChange(e)} required /></div>
            <div> Description <input placeholder="" aria-label="{keys[24]}" type="text" name={keys[24]} onChange={e => handleChange(e)} required /></div>
            <div> Price <input placeholder="" aria-label="{keys[25]}" type="number" name={keys[25]} onChange={e => handleChange(e)} required /></div>
            <div> Brand <input placeholder="" aria-label="{keys[26]}" type="text" name={keys[26]} onChange={e => handleChange(e)} /></div>
            <div> Warranty <input placeholder="" aria-label="{keys[27]}" type="number" name={keys[27]} onChange={e => handleChange(e)} required /></div>
            <div> Rating <input placeholder="" aria-label="{keys[28]}" type="number" name={keys[28]} onChange={e => handleChange(e)} required /></div>
            <div> Socket <input placeholder="" aria-label="{keys[0]}" type="text" name={keys[0]} onChange={e => handleChange(e)} /></div>
            <div> Chipset <input placeholder="" aria-label="{keys[1]}" type="text" name={keys[1]} onChange={e => handleChange(e)} /></div>
            <div> Size enum, dont touch <input placeholder="" aria-label="{keys[2]}" type="text" name={keys[2]} onChange={e => handleChange(e)}/></div>
            <div> Igpu <input placeholder="" aria-label="{keys[3]}" type="text" name={keys[3]} onChange={e => handleChange(e)} required /></div>
            <div> Ram <input placeholder="" aria-label="{keys[4]}" type="text" name={keys[4]} onChange={e => handleChange(e)} required /></div>
            <div> Frequency <input placeholder="" aria-label="{keys[5]}" type="number" name={keys[5]} onChange={e => handleChange(e)} required /></div>
            <div> Memory Sockets <input placeholder="" aria-label="{keys[6]}" type="number" name={keys[6]} onChange={e => handleChange(e)} required /></div>
            <div> Xmp <input placeholder="" aria-label="{keys[7]}" type="checkbox" name={keys[7]} onChange={e => handleChange(e)} /></div>
            <div> Max Memory <input placeholder="" aria-label="{keys[8]}" type="number" name={keys[8]} onChange={e => handleChange(e)} required /></div>
            <div> C For SLI Support <input placeholder="" aria-label="{keys[9]}" type="text" name={keys[9]} onChange={e => handleChange(e)} required /></div>
            <div> Bluetooth <input placeholder="" aria-label="{keys[10]}" type="text" name={keys[10]} onChange={e => handleChange(e)} required /></div>
            <div> Lighting <input placeholder="" aria-label="{keys[11]}" type="checkbox" name={keys[11]} onChange={e => handleChange(e)} /></div>
            <div> Windows 11 Support <input placeholder="" aria-label="{keys[12]}" type="checkbox" name={keys[12]} onChange={e => handleChange(e)} /></div>
            <div> wifi <input placeholder="" aria-label="{keys[13]}" type="text" name={keys[13]} onChange={e => handleChange(e)} required /></div>
            <div> LanPort <input placeholder="" aria-label="{keys[14]}" type="text" name={keys[14]} onChange={e => handleChange(e)} required /></div>
            <div> LanportsNumber <input placeholder="" aria-label="{keys[15]}" type="number" name={keys[15]} onChange={e => handleChange(e)} required /></div>
            <div> PcIe16x <input placeholder="" aria-label="{keys[16]}" type="number" name={keys[16]} onChange={e => handleChange(e)} required /></div>
            <div> SatA3 <input placeholder="" aria-label="{keys[17]}" type="number" name={keys[17]} onChange={e => handleChange(e)} required /></div>
            <div> M2 <input placeholder="" aria-label="{keys[18]}" type="number" name={keys[18]} onChange={e => handleChange(e)} required /></div>
            <div> USB2 <input placeholder="" aria-label="{keys[19]}" type="number" name={keys[19]} onChange={e => handleChange(e)} required /></div>
            <div> USB3 <input placeholder="" aria-label="{keys[20]}" type="number" name={keys[20]} onChange={e => handleChange(e)} required /></div>
            <div> USB31 <input placeholder="" aria-label="{keys[21]}" type="number" name={keys[21]} onChange={e => handleChange(e)} required /></div>
            <div> USBC <input placeholder="" aria-label="{keys[22]}" type="number" name={keys[22]} onChange={e => handleChange(e)} required /></div>
            <div> Main Image <input placeholder="" aria-label="{keys[29]}" type="text" name={keys[29]} onChange={e => handleChange(e)} required /></div>
            <div> Product Official Website <input placeholder="" aria-label="{keys[30]}" type="text" name={keys[30]} onChange={e => handleChange(e)} required /></div>
            <div> Model Number <input placeholder="" aria-label="{keys[31]}" type="text" name={keys[31]} onChange={e => handleChange(e)} required /></div>           
            <div className="button-section">
            <Button type="submit" variant="outlined" size="small">Save</Button>
                <Button type="button" variant="outlined" size="small" onClick={() => navigate("/product/motherboard")}> Back </Button>
            </div>
        </form>
    )
}