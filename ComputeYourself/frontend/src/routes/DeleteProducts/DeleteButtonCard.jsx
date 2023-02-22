import Button from '@mui/material/Button';
import { AxiosDelete } from "../../Axios/FetchWithAxios"
import DeleteIcon from '@mui/icons-material/Delete';
import React from 'react';
import useAuth from "../../hooks/useAuth";

export default function DeleteButtonCard(props) {
    const { auth } = useAuth();
    const setTrigger = props.trigger;
    const deleteFunction = async () => {
        AxiosDelete(props.productType, props.productId, auth.token);
        setTrigger("true");
        };
  return (
        <Button variant="outlined" size="small" onClick={deleteFunction} color='error' startIcon={<DeleteIcon />}>Delete</Button>
  )
}
