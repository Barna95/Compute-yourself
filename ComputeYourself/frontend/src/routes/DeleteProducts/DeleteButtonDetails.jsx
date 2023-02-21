// import Button from '@mui/material/Button';

import { AxiosDelete } from "../../Axios/FetchWithAxios"
import DeleteIcon from '@mui/icons-material/Delete';
import React from 'react';
import useAuth from "../../hooks/useAuth";
import { useNavigate } from "react-router-dom";

export default function DeleteButtonForDetails(props) {
    const navigate = useNavigate();
    const { auth } = useAuth();
    const deleteFunction = async () => {
        AxiosDelete(props.productType, props.productId, auth.token);
        return navigate(`/product/${props.productType}`)
    };

  return (
        <Button variant="outlined" size="small" onClick={deleteFunction} color='error' startIcon={<DeleteIcon />}>Delete</Button>
        
  )
}
