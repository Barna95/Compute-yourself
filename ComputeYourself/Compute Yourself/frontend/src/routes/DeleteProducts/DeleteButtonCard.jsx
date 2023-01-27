import Button from '@mui/material/Button';
import DeleteIcon from '@mui/icons-material/Delete';
import React from 'react'
import SendIcon from '@mui/icons-material/Send';
import Stack from '@mui/material/Stack';
import axios from "axios";
import { useNavigate } from "react-router-dom";

export default function DeleteButtonCard(props) {
    const  deleteFunction = async ()=>{
            await axios.delete(`https://localhost:7195/product/${props.productType}/${props.productId}`)
        };
  return (
        <Button variant="outlined" size="small" onClick={deleteFunction} color='error' startIcon={<DeleteIcon />}>Delete</Button>
  )
}
