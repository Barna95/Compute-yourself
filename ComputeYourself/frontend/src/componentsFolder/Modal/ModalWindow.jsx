import * as React from 'react';
import Box from '@mui/material/Box';
import Button from '@mui/material/Button';
import Modal from '@mui/material/Modal';
import { useEffect, useState } from "react";
import axios from "axios";

const style = {
    display: 'flex',
    position: 'absolute',
    top: '50%',
    left: '50%',
    transform: 'translate(-50%, -50%)',
    color : 'lightblue',
    bgcolor: 'lightred',
    border: '2px solid #000',
    boxShadow: 24,
    p: 4,
};

export default function ModalWindow(props) {
    const [data, setData] = useState([]);
    const [open, setOpen] = useState(false);
    const handleOpen = () => setOpen(true);
    const handleClose = () => setOpen(false);
    let productValues = []
    const selectValues = Object.values(props.dataProperties).map((e) => productValues.push(Object.values(e)));
    let productKeys = [];
    const selectKeys = Object.keys(props.dataProperties.map((e) => productKeys.push(Object.keys(e))));

    useEffect(() => {
        axios.get("https://localhost:7195/product/cpu").then(
            (response) => {
                setData(response.data);
            });
    }, []);

    // id alapú lekérdezés show keys -> {Object.keys(data).map((asd, idx) => <p key={idx}> {asd }</p> ) }
    // id alapú lekérdezés show actual data -> {Object.keys(data).map((asd, idx) => <p key={idx}> {data[asd] }</p> ) } 
    // ami most bent van az az összes adatból való magic, not so good.
    return (
        <div>
            {props.dataProperties.map((value, index) => <Button onClick={handleOpen} key={index}> {value.name} </Button>)}
            <Modal
                open={open}
                onClose={handleClose}
                aria-labelledby="modal-modal-title"
                aria-describedby="modal-modal-description"
            >
                <Box sx={style}>                  
                    <table>
                        <thead>
                            <tr>{productKeys.map((key, idx) => <td key={idx}>{key}</td> )}</tr>
                        </thead>
                        <tbody>
                            <tr>{productValues.map((value, idx) => <td key={idx}>{value}</td>)}</tr>
                        </tbody>
                    </table>
                </Box>
            </Modal>
        </div>
    );
}