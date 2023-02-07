import Button from '@mui/material/Button';
import DeleteIcon from '@mui/icons-material/Delete';
import IconButton from '@mui/material/IconButton';
import React from 'react'
import axios from "axios";
import { useNavigate } from "react-router-dom";
import useAuth from "../../hooks/useAuth"

export default function DeleteButtonForDetails(props) {
    const navigate = useNavigate();
    const { auth } = useAuth();
    const  deleteFunction = async ()=>{
        await axios.delete(`https://localhost:7195/product/${props.productType}/${props.productId}`,
            {
            headers: {
                'Content-Type': 'application/json;charset=UTF-8',
                'Authorization': `Bearer ${auth.token}`
            }
        })
            return navigate(`/product/${props.productType}`)
        };
  return (
        <Button variant="outlined" size="small" onClick={deleteFunction} color='error' startIcon={<DeleteIcon />}>Delete</Button>
        
  )
}
