import Button from '@material-ui/core/Button';
import axios from "axios";
import { useNavigate } from "react-router-dom";
import { useState } from 'react';
import useAuth from "../../hooks/useAuth"

export default function AddNewRam() {
    const [formValues, setFormValues] = useState({
        "size": 0,
        "memoryType": "",
        "frequency": 0,
        "latency": 0,
        "heatSink": true,
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
        if (e.target.name === "heatSink") {
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
        await axios.post(`https://localhost:7195/product/ram`, json, {
            headers: {
                'Content-Type': 'application/json;charset=UTF-8',
                'Authorization': `Bearer ${token}`
            }
        })
        return navigate("/product/ram")
    };
    // create the input nodes with map but it would be hard to change the different
    //input fields like checkbox or choose from enums in dropdown
    // so ill just leave it here for now.
    // keys.map((propName, idx) => <div key={idx}> {propName}<input placeholder="" aria-label="{propName}" type="text" name={propName} onChange={e => handleChange(e)} /></div>)
    return (
        <form onSubmit={e => handleSubmit(e)}>
            <div> Name <input placeholder="" aria-label="{keys[5]}" type="text" name={keys[5]} onChange={e => handleChange(e)} required /></div>
            <div> Description <input placeholder="" aria-label="{keys[6]}" type="text" name={keys[6]} onChange={e => handleChange(e)} required /></div>
            <div> Price <input placeholder="" aria-label="{keys[7]}" type="number" name={keys[7]} onChange={e => handleChange(e)} required /></div>
            <div> Brand <input placeholder="" aria-label="{keys[8]}" type="text" name={keys[8]} onChange={e => handleChange(e)} /></div>
            <div> Warranty <input placeholder="" aria-label="{keys[9]}" type="number" name={keys[9]} onChange={e => handleChange(e)} required /></div>
            <div> Rating <input placeholder="" aria-label="{keys[10]}" type="number" name={keys[10]} onChange={e => handleChange(e)} required /></div>
            <div> Size <input placeholder="" aria-label="{keys[0]}" type="number" name={keys[0]} onChange={e => handleChange(e)} required /></div>
            <div> Memory Type <input placeholder="" aria-label="{keys[1]}" type="text" name={keys[1]} onChange={e => handleChange(e)} required/></div>
            <div> Frequency <input placeholder="" aria-label="{keys[2]}" type="number" name={keys[2]} onChange={e => handleChange(e)} required /></div>
            <div> Latency <input placeholder="" aria-label="{keys[3]}" type="number" name={keys[3]} onChange={e => handleChange(e)} required /></div>
            <div> Heat Sink <input placeholder="" aria-label="{keys[4]}" type="checkbox" name={keys[4]} onChange={e => handleChange(e)} required /></div>
            <div> Main Image <input placeholder="" aria-label="{keys[11]}" type="text" name={keys[11]} onChange={e => handleChange(e)} required /></div>
            <div> Product Official Website <input placeholder="" aria-label="{keys[12]}" type="text" name={keys[12]} onChange={e => handleChange(e)} required /></div>
            <div> Model Number <input placeholder="" aria-label="{keys[13]}" type="text" name={keys[13]} onChange={e => handleChange(e)} required /></div>
            <div className="button-section">
            <Button type="submit" variant="outlined" size="small">Save</Button>
                <Button type="button" variant="outlined" size="small" onClick={() => navigate("/product/ram")}> Back </Button>
            </div>
        </form>
    )
}