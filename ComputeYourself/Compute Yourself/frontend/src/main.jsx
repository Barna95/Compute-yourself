import React from 'react'
import ReactDOM from 'react-dom/client'
import App from './App'
//import './index.css'
import { AuthProvider } from './Authentication/AuthContext/AuthProvider';
import { Container } from "@mui/material"

ReactDOM.createRoot(document.getElementById('root')).render(
    <React.StrictMode>
        <AuthProvider>
            <App />
        </AuthProvider>
  </React.StrictMode>,
)

   