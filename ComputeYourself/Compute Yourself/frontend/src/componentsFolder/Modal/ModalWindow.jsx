import * as React from "react";

import Box from "@mui/material/Box";
import Button from "@mui/material/Button";
import Modal from "@mui/material/Modal";
import Table from 'react-bootstrap/Table';

// --primary: #bc4123;
//   --secondary: #2b3452;
const style = {
  display: "flex",
  position: "absolute",
  top: "50%",
  left: "50%",
  transform: "translate(-50%, -50%)",
  bgcolor: "#2b3452",
  border: "2px solid #000",
  boxShadow: 24,
  p: 4,
  color: "#bc4123",
};

export default function ModalWindow(props) {
  const [open, setOpen] = React.useState(false);
  const handleOpen = () => setOpen(true);
  const handleClose = () => setOpen(false);

  const mystyle = {
    color: "#bc4123",
    backgroundColor: "#2b3452",
    padding: "10px",
    fontFamily: "Arial",
  };

  const tableCell = {
    color: "white",
  };

  const modalButton = {
    color: 'white',
    fontFamily: "Arial",
  };
  
  return (
    <div>
      <Button style={modalButton} onClick={handleOpen}>{props.dataProperties.name}</Button>
      <Modal
        open={open}
        onClose={handleClose}
        aria-labelledby="modal-modal-title"
        aria-describedby="modal-modal-description"
      >
        <Box sx={style}>
          <table>
            <thead>
              <tr>
                {props.elementKeys.map((element) => (
                  <th style={tableCell} key={element}>{element}</th>
                ))}
              </tr>
            </thead>
            <tbody>
              <tr>
                {props.elementKeys.map((element) => (
                  <td style={tableCell} key={element}>{props.dataProperties[element]}</td>
                ))}
              </tr>
            </tbody>
          </table>
        </Box>
      </Modal>
    </div>
  );
}
