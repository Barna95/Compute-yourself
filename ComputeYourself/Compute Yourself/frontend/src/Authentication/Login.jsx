import { useState } from "react";
import Button from '@material-ui/core/Button';
import axios from "axios";
import { useNavigate } from "react-router-dom";
import useAuth from '../hooks/useAuth';
import jwt from 'jwt-decode';
import { toast } from 'react-toastify';


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
            localStorage.setItem("isLoggedIn", true);
            const decoded = jwt(token);
            const claims = Object.values(decoded)
            setAuth({
                name: claims[1],
                roles: claims[2],
                token : token,
            })  
            if (response.status === 200) {
                toast.success('Successful login.', {
                    position: toast.POSITION.BOTTOM_RIGHT
                });
                return navigate("/")
            }
        }).catch((error) => {
            if (error.response) {
                // The request was made and the server responded with a status code
                // that falls out of the range of 2xx
                console.log(error.response.data);
                console.log(error.response.status);
                console.log(error.response.headers);

            } else if (error.request) {
                // The request was made but no response was received
                // `error.request` is an instance of XMLHttpRequest in the browser and an instance of
                // http.ClientRequest in node.js
                console.log(error.request);
            } else {
                // Something happened in setting up the request that triggered an Error
                console.log('Error', error.message);
            }
            toast.error('Incorrect username or password', {
                position: toast.POSITION.BOTTOM_RIGHT
            });
            console.log(error.config);
        })        
    };

    return (
        <>
            <form onSubmit={e => handleSubmit(e)}>
                <div> Name <input placeholder="" aria-label="userName" type="text" name="userName" onChange={e => handleChange(e)} required /></div>
                <div> Password <input placeholder="" aria-label="password" type="text" name="password" onChange={e => handleChange(e)} required /></div>
                <div className="button-section">
                    <Button type="submit" variant="outlined" size="small">Login</Button>
                    <Button type="button" variant="outlined" size="small" onClick={() => navigate("/")}> Back </Button>
                </div>
            </form>
        </>
    )
}