import Button from '@mui/material/Button';
import DeleteIcon from '@mui/icons-material/Delete';
import React from 'react'
import axios from "axios";
import useAuth from "../../hooks/useAuth"

export default function DeleteButtonCard(props) {

    const { auth } = useAuth();
    const  deleteFunction = async ()=>{
        await axios.delete(`https://localhost:7195/product/${props.productType}/${props.productId}`, {
            headers: {
                'Content-Type': 'application/json;charset=UTF-8',
                'Authorization': `Bearer ${auth.token}`
            }
        })
        };
  return (
        <Button variant="outlined" size="small" onClick={deleteFunction} color='error' startIcon={<DeleteIcon />}>Delete</Button>
  )
}
