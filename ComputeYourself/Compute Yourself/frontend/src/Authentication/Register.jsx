import { useState, useEffect } from "react";
import Button from '@material-ui/core/Button';
import axios from "axios";
import { useNavigate } from "react-router-dom";
import { toast } from 'react-toastify';

export default function Register() {
    //account/login account/register
    const navigate = useNavigate();
    const [data, setData] = useState({
        "userName": "",
        "password": "",
        "email": ""
    });

    let handleChange = (e) => {
        setData({ ...data, [e.target.name]: e.target.value });
    }

    let handleSubmit = async (e) => {
        e.preventDefault();
        const json = JSON.stringify(data);
        await axios.post(`https://localhost:7195/account/register`, json, {
            headers: {
                'Content-Type': 'application/json;charset=UTF-8',
                withCredentials: true,
            }
        }).then(response => {
            if (response.status === 201) {
                toast.success('Successful Registration.', {
                    position: toast.POSITION.BOTTOM_RIGHT
                });
                return navigate("/account/login")
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
            toast.error('Oops, something went wrong!', {
                position: toast.POSITION.BOTTOM_RIGHT
            });
            toast.warning('May god bless you!', {
                position: toast.POSITION.BOTTOM_LEFT
            });
            console.log(error.config.data);
            //return navigate("/account/register")
        })
    };

    return (
        <>
            <form onSubmit={e => handleSubmit(e) }>
                <div> Name <input placeholder="" aria-label="userName" type="text" name="userName" onChange={e => handleChange(e)} required /></div>
                <div> Password <input placeholder="" aria-label="password" type="text" name="password" onChange={e => handleChange(e)} required /></div>
                <div> E-mail <input placeholder="" aria-label="email" type="text" name="email" onChange={e => handleChange(e)} required /></div>
                    <div className="button-section">
                        <Button type="submit" variant="outlined" size="small">Register</Button>
                        <Button type="button" variant="outlined" size="small" onClick={() => navigate("/")}> Back </Button>
                    </div>
            </form>
        </>
        )
}