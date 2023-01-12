import * as React from 'react';
import Box from '@mui/material/Box';
import Button from '@mui/material/Button';
import Modal from '@mui/material/Modal';

const style = {
    display: 'flex',
    position: 'absolute',
    top: '50%',
    left: '50%',
    transform: 'translate(-50%, -50%)',
    bgcolor: 'background.paper',
    border: '2px solid #000',
    boxShadow: 24,
    p: 4,
};

export default function ModalWindow(props) {
    const [open, setOpen] = React.useState(false);
    const handleOpen = () => setOpen(true);
    const handleClose = () => setOpen(false);

    return (
        <div>
            <Button onClick={handleOpen}>{props.dataProperties.name}</Button>
            <Modal
                open={open}
                onClose={handleClose}
                aria-labelledby="modal-modal-title"
                aria-describedby="modal-modal-description"
            >
                <Box sx={style}>                  
                    <table>
                        <thead>
                            <tr>{props.elementKeys.map(element => <th key={element}>{element}</th>)}</tr>
                        </thead>
                        <tbody>
                            <tr>{props.elementKeys.map(element => <td key={element}>{props.dataProperties[element]}</td>)}</tr>
                        </tbody>
                    </table>
                </Box>
            </Modal>
        </div>
    );
}