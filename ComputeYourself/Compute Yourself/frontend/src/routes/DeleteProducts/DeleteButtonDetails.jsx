import Button from '@mui/material/Button';
import DeleteIcon from '@mui/icons-material/Delete';
import React from 'react';
import axios from "axios";
import { useNavigate } from "react-router-dom";
import useAuth from "../../hooks/useAuth";
import { toast } from 'react-toastify';

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
            }).then(response => {
                if (response.status === 200) {
                    toast.success('Successfully deleted.', {
                        position: toast.POSITION.TOP_RIGHT
                    });
                    return navigate(`/product/${props.productType}`)
                }
            }).catch((error) => {
                console.log(error.config);
                toast.error('I am a toaster, cannot delete', {
                    position: toast.POSITION.TOP_RIGHT
                });
            })
    };


  return (
        <Button variant="outlined" size="small" onClick={deleteFunction} color='error' startIcon={<DeleteIcon />}>Delete</Button>
        
  )
}
