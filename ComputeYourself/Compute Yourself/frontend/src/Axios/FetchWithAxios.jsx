﻿import axios from "axios";
import { toast } from 'react-toastify';
import jwt from 'jwt-decode';

async function AxiosGet(productType) {
    const response = await axios.get(`https://localhost:7195/product/${productType}`)
    return response;
}

async function AxiosGetById(productType, id) {
    const response = axios.get(`https://localhost:7195/product/${productType}/${id}`)
    return response;
}

async function AxiosPut(token, id, bodyData, productType, navigate) {
    
    await axios.put(`https://localhost:7195/product/${productType}/${id}`, bodyData, {
        headers: {
            'Content-Type': 'application/json;charset=UTF-8',
            'Authorization': `Bearer ${token}`
        }
    }).then(response => {
        if (response.status === 200) {
            toast.success(`Edited ${productType}`, {
                position: toast.POSITION.TOP_RIGHT
            });
            return navigate(`/product/${productType}/${id}/details`)
        }
    }).catch((error) => {
        console.log(error);
        toast.error('Oops, something went wrong!', {
            position: toast.POSITION.BOTTOM_RIGHT
        });
    })
}

async function AxiosPost(productType, token, bodyData, navigate) {
    await axios.post(`https://localhost:7195/product/${productType}`, bodyData, {
        headers: {
            'Content-Type': 'application/json;charset=UTF-8',
            'Authorization': `Bearer ${token}`
        }
    }).then(response => {
        if (response.status === 200) {
            toast.success(`Created ${productType}`, {
                position: toast.POSITION.TOP_RIGHT
            });
            return navigate(`/product/${productType}`)
        }
    }).catch((error) => {
        console.log(error.config);
        toast.error('Oops, something went wrong!', {
            position: toast.POSITION.BOTTOM_RIGHT
        });
    })
}

async function AxiosDelete(productType, id, token) {
    await axios.delete(`https://localhost:7195/product/${productType}/${id}`, {
        headers: {
            'Content-Type': 'application/json;charset=UTF-8',
            'Authorization': `Bearer ${token}`
        }
    }).then(response => {
        if (response.status === 200) {
            toast.success('Successfully deleted.', {
                position: toast.POSITION.TOP_RIGHT
            });
        }
    }).catch((error) => {
        console.log(error.config);
        toast.error('I am a toaster, cannot delete', {
            position: toast.POSITION.TOP_RIGHT
        });
    })
}

async function AxiosLoginPost(bodyData, navigate, setAuth) {
    const response = await axios.post(`https://localhost:7195/account/login`, bodyData, {
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
            token: token,
            deleted: "",
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
    return response
}

async function AxiosRegisterPost(bodyData, navigate) {
    await axios.post(`https://localhost:7195/account/register`, bodyData, {
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
        console.log(error.config.data);
        //return navigate("/account/register")
    })
}

export { AxiosGet, AxiosGetById, AxiosPut, AxiosPost, AxiosDelete, AxiosLoginPost, AxiosRegisterPost }