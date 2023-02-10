import { useState, useEffect } from "react";
import Button from '@material-ui/core/Button';
import axios from "axios";
import { useNavigate } from "react-router-dom";
import { toast } from 'react-toastify';
import * as React from 'react';
import Avatar from '@mui/material/Avatar';
import CssBaseline from '@mui/material/CssBaseline';
import TextField from '@mui/material/TextField';
import Link from '@mui/material/Link';
import Grid from '@mui/material/Grid';
import Box from '@mui/material/Box';
import LockOutlinedIcon from '@mui/icons-material/LockOutlined';
import Typography from '@mui/material/Typography';
import Container from '@mui/material/Container';
import { createTheme, ThemeProvider } from '@mui/material/styles';
import PasswordStrengthBar from 'react-password-strength-bar';
import { withStyles } from '@material-ui/core/styles';

export default function Register() {
    //account/login account/register
    const CustomPasswordStrengthBar = withStyles({
        root: {
          height: '15px',
          width: '200px',
        },
      })(PasswordStrengthBar);
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
                <Container component="main" maxWidth="xs">
                    <Box
                    sx={{
                        marginTop: 8,
                        display: 'flex',
                        flexDirection: 'column',
                        alignItems: 'center',
                        }}
                        >
                    <Avatar sx={{ m: 1, bgcolor: 'grey' }}>
                    <LockOutlinedIcon />
                    </Avatar>
                    <Typography component="h1" variant="h5">
                        Sign up
                    </Typography>
                    <Box sx={{ mt: 3 }}>
                        <Grid container spacing={2}>
                            <Grid item xs={12}>
                                <TextField
                                autoComplete="given-name"
                                required
                                fullWidth
                                id="userName"
                                label="UserName"
                                autoFocus
                                name="userName" onChange={e => handleChange(e)}
                                />
                            </Grid>
                            <Grid item xs={12}>
                                <TextField
                                required
                                fullWidth
                                id="email"
                                label="Email Address"
                                autoComplete="email"
                                name="email" onChange={e => handleChange(e)}
                                />
                            </Grid>
                            <Grid item xs={12}>
                                <TextField
                                required
                                fullWidth
                                label="Password"
                                type="password"
                                id="password"
                                autoComplete="new-password"
                                name="password" onChange={e => handleChange(e)}
                                />
                                <CustomPasswordStrengthBar password={data.password} />
                            </Grid>
                        </Grid>
                        <Button
                        type="submit"
                        fullWidth
                        variant="contained"
                        sx={{ mt: 3, mb: 2 }}
                        >
                        Sign Up
                        </Button>
                        <Grid container justifyContent="flex-end">
                            <Grid item>
                                <Link href="#" variant="body2" onClick={() => navigate(`/account/login`)}>
                                Already have an account? Sign in
                                </Link>
                            </Grid>
                        </Grid>
                    </Box>
                    </Box>
                </Container>
            </form>
        </>
        )
}