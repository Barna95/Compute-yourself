import React from 'react'
import ReactDOM from 'react-dom/client'
import App from './App'
import './index.css'
import { Container } from "@mui/material"

ReactDOM.createRoot(document.getElementById('root')).render(
    <React.StrictMode>
        <Container maxWidth={false} sx={{ bgcolor: "lightgrey" }}>
            <App />
        </Container>
  </React.StrictMode>,
)

   