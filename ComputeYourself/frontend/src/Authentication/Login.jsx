import Avatar from '@mui/material/Avatar';
import {AxiosLoginPost} from '../Axios/FetchWithAxios'
import Box from '@mui/material/Box';
import Container from '@mui/material/Container';
import Grid from '@mui/material/Grid';
import Link from '@mui/material/Link';
import LockOutlinedIcon from '@mui/icons-material/LockOutlined';
import TextField from '@mui/material/TextField';
import Typography from '@mui/material/Typography';
import useAuth from '../hooks/useAuth';
import { useNavigate } from "react-router-dom";
import { useState } from "react";

// import Button from '@material-ui/core/Button';












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
        AxiosLoginPost(json, navigate, setAuth);   
    };

    return (
        <>
            <form onSubmit={e => handleSubmit(e)}>
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
                            Sign in
                        </Typography>
                        <Box sx={{ mt: 1 }}>
                            <TextField
                            margin="normal"
                            required
                            fullWidth
                            id="username"
                            label="Username"
                            autoComplete="email"
                            autoFocus
                            name="userName" onChange={e => handleChange(e)}
                            />
                            <TextField
                            margin="normal"
                            required
                            fullWidth
                            label="Password"
                            type="password"
                            id="password"
                            autoComplete="current-password"
                            name="password" onChange={e => handleChange(e)}
                            />
                            <Button
                            type="submit"
                            fullWidth
                            variant="contained"
                            sx={{ mt: 3, mb: 2 }}
                            >
                            Sign In
                            </Button>
                            <Grid container>
                                <Grid item xs>
                                </Grid>
                                <Grid item>
                                    <Link href="#" variant="body2" onClick={() => navigate(`/account/register`)}>
                                    {"Don't have an account? Sign Up"}
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