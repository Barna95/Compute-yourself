import axios from "axios";
import { useEffect } from "react";
import { useNavigate } from "react-router-dom";
import { useState } from 'react';

export default function AddNewMotherBoard() {
    const [data, setData] = useState([]);
    const navigate = useNavigate();
    const [itemId] = useState(localStorage.getItem("itemId"));
    const keys = Object.keys(data).map((propName, idx) => { return propName });
    useEffect(() => {
        axios.get(`https://localhost:7195/product/motherboard/${itemId}`).then(
            (response) => {
                setData(response.data);
            });
    }, []);

    let handleChange = (e) => {
        if (e.target.name === "xmp" || e.target.name === "lighting" || e.target.name === "windows11Support" ) {
            if (data[e.target.name] == true) {
                data[e.target.name] = false;
            } else {
                formValues[e.target.name] = true;
            }
        } else {
            data[e.target.name] = e.target.value;
        }
        console.log(data);
    }

    let handleSubmit = async () => {
        const json = JSON.stringify(data);
        await axios.put(`https://localhost:7195/product/motherboard/${data.id}`, json, {
            headers: {
                'Content-Type': 'application/json;charset=UTF-8',
            }
        })
    };

    console.log(keys);
    return (
        <form onSubmit={handleSubmit}>
            {/*TODO => Add enums. Size can be edited*/}
            {/* <div> Size enum, dont touch <input placeholder={data[keys[2]]} aria-label="{keys[2]}" type="text" name={keys[2]} onChange={e => handleChange(e)}/></div> */}
            <div> Name <input placeholder={data[keys[24]]} aria-label="{keys[24]}" type="text" name={keys[24]} onChange={e => handleChange(e)} /></div>
            <div> Description <input placeholder={data[keys[25]]} aria-label="{keys[25]}" type="text" name={keys[25]} onChange={e => handleChange(e)} /></div>
            <div> Price <input placeholder={data[keys[26]]} aria-label="{keys[26]}" type="number" name={keys[26]} onChange={e => handleChange(e)} /></div>
            <div> Brand <input placeholder={data[keys[27]]} aria-label="{keys[27]}" type="text" name={keys[27]} onChange={e => handleChange(e)} /></div>
            <div> Warranty <input placeholder={data[keys[28]]} aria-label="{keys[28]}" type="number" name={keys[28]} onChange={e => handleChange(e)} /></div>
            <div> Rating <input placeholder={data[keys[29]]} aria-label="{keys[29]}" type="number" name={keys[29]} onChange={e => handleChange(e)} /></div>
            <div> Socket <input placeholder={data[keys[0]]} aria-label="{keys[0]}" type="text" name={keys[0]} onChange={e => handleChange(e)} /></div>
            <div> Chipset <input placeholder={data[keys[1]]} aria-label="{keys[1]}" type="text" name={keys[1]} onChange={e => handleChange(e)} /></div>
            <div> Igpu <input placeholder={data[keys[3]]} aria-label="{keys[3]}" type="text" name={keys[3]} onChange={e => handleChange(e)} /></div>
            <div> Ram <input placeholder={data[keys[4]]} aria-label="{keys[4]}" type="text" name={keys[4]} onChange={e => handleChange(e)} /></div>
            <div> Frequency <input placeholder={data[keys[5]]} aria-label="{keys[5]}" type="number" name={keys[5]} onChange={e => handleChange(e)} /></div>
            <div> Memory Sockets <input placeholder={data[keys[6]]} aria-label="{keys[6]}" type="number" name={keys[6]} onChange={e => handleChange(e)} /></div>
            <div> Xmp <input placeholder={data[keys[7]]} aria-label="{keys[7]}" type="checkbox" name={keys[7]} onChange={e => handleChange(e)} /></div>
            <div> Max Memory <input placeholder={data[keys[8]]} aria-label="{keys[8]}" type="number" name={keys[8]} onChange={e => handleChange(e)} /></div>
            <div> CrossFire or SLI Support <input placeholder={data[keys[9]]} aria-label="{keys[9]}" type="text" name={keys[9]} onChange={e => handleChange(e)} /></div>
            <div> Bluetooth <input placeholder={data[keys[10]]} aria-label="{keys[10]}" type="text" name={keys[10]} onChange={e => handleChange(e)} /></div>
            <div> Lighting <input placeholder={data[keys[11]]} aria-label="{keys[11]}" type="checkbox" name={keys[11]} onChange={e => handleChange(e)} /></div>
            <div> Windows 11 Support <input placeholder={data[keys[12]]} aria-label="{keys[12]}" type="checkbox" name={keys[12]} onChange={e => handleChange(e)} /></div>
            <div> wifi <input placeholder={data[keys[13]]} aria-label="{keys[13]}" type="text" name={keys[13]} onChange={e => handleChange(e)} /></div>
            <div> LanPort <input placeholder={data[keys[14]]} aria-label="{keys[14]}" type="text" name={keys[14]} onChange={e => handleChange(e)} /></div>
            <div> LanportsNumber <input placeholder={data[keys[15]]} aria-label="{keys[15]}" type="number" name={keys[15]} onChange={e => handleChange(e)} /></div>
            <div> PcIe16x <input placeholder={data[keys[16]]} aria-label="{keys[16]}" type="number" name={keys[16]} onChange={e => handleChange(e)} /></div>
            <div> SatA3 <input placeholder={data[keys[17]]} aria-label="{keys[17]}" type="number" name={keys[17]} onChange={e => handleChange(e)} /></div>
            <div> M2 <input placeholder={data[keys[18]]} aria-label="{keys[18]}" type="number" name={keys[18]} onChange={e => handleChange(e)} /></div>
            <div> USB2 <input placeholder={data[keys[19]]} aria-label="{keys[19]}" type="number" name={keys[19]} onChange={e => handleChange(e)} /></div>
            <div> USB3 <input placeholder={data[keys[20]]} aria-label="{keys[20]}" type="number" name={keys[20]} onChange={e => handleChange(e)} /></div>
            <div> USB31 <input placeholder={data[keys[21]]} aria-label="{keys[21]}" type="number" name={keys[21]} onChange={e => handleChange(e)} /></div>
            <div> USBC <input placeholder={data[keys[22]]} aria-label="{keys[22]}" type="number" name={keys[22]} onChange={e => handleChange(e)} /></div>
            <div> Main Image <input placeholder={data[keys[30]]} aria-label="{keys[30]}" type="text" name={keys[30]} onChange={e => handleChange(e)} /></div>
            <div> Product Official Website <input placeholder={data[keys[31]]} aria-label="{keys[31]}" type="text" name={keys[31]} onChange={e => handleChange(e)} /></div>
            <div> Model Number <input placeholder={data[keys[32]]} aria-label="{keys[32]}" type="text" name={keys[32]} onChange={e => handleChange(e)} /></div>   

            <div className="button-section">
                <button type="submit">Save</button>
                <button type="button" onClick={() => navigate("/product")}> go back </button>
            </div>
        </form>
    )
}