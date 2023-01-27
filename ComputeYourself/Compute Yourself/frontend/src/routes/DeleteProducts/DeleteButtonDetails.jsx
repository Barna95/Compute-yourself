import Button from '@mui/material/Button';
import DeleteIcon from '@mui/icons-material/Delete';
import IconButton from '@mui/material/IconButton';
import React from 'react'
import axios from "axios";
import { useNavigate } from "react-router-dom";

export default function DeleteButtonForDetails(props) {
    const navigate = useNavigate();
    const  deleteFunction = async ()=>{
            await axios.delete(`https://localhost:7195/product/${props.productType}/${props.productId}`)
            return navigate(`/product`)
        };
  return (
        <Button variant="outlined" size="small" onClick={deleteFunction} color='error' startIcon={<DeleteIcon />}>Delete</Button>
        
  )
}
