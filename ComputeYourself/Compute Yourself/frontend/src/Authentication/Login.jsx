import { useState } from "react";
import Button from '@material-ui/core/Button';
import axios from "axios";
import { useNavigate } from "react-router-dom";
import useAuth from '../hooks/useAuth';
import jwt from 'jwt-decode';


export default function Register() {
    //account/login account/register
    const navigate = useNavigate()
    const [data, setData] = useState({
        "userName": "",
        "password": "",
    });
    const { setAuth } = useAuth();

    let handleChange = (e) => {
        setData({ ...data, [e.target.name]: e.target.value });
        
    }

    let handleSubmit = async (e) => {
        e.preventDefault();
        const json = JSON.stringify(data);
        await axios.post(`https://localhost:7195/account/login`, json, {
            headers: {
                'Content-Type': 'application/json;charset=UTF-8',
                withCredentials: true,
            }
        }).then(response => {
            const token = response.data.token;
            localStorage.setItem("isLoggedIn", "IamPotato");
            const decoded = jwt(token);
            const claims = Object.values(decoded)
            setAuth({
                name: claims[1],
                roles: claims[2],
                token : token,
            })          
        })
        data.userName = "";
        data.password = "";
        return navigate("/")
    };

    return (
        <>
            <form onSubmit={e => handleSubmit(e)}>
                <div> Name <input placeholder="" aria-label="userName" type="text" name="userName" onChange={e => handleChange(e)} required /></div>
                <div> Password <input placeholder="" aria-label="password" type="text" name="password" onChange={e => handleChange(e)} required /></div>
                <div className="button-section">
                    <Button type="submit" variant="outlined" size="small">Save</Button>
                    <Button type="button" variant="outlined" size="small" onClick={() => navigate("/product/cpu")}> Back </Button>
                </div>
            </form>
        </>
    )
}