import Logo from '../assets/logo.svg';
import React from 'react'
import Grid from "@mui/material/Grid";
import Paper from "@mui/material/Paper";
import { Box, ThemeProvider, createTheme } from '@mui/system';
const mystyle = {
welcomeText: {
  flex: 1,
  fontSize: 30,
  textAlign: "center",
  padding: 70,
  margin: 30,
},
welcomeTextTitle: {
  flex: 1,
  fontSize:  50,
  textAlign: "center",
},
};

export default function home() {
  return (
    <>
      <Paper elevation={24}>
        <Box style={mystyle.welcomeTextTitle}>
          Welcome dear Customer!
        </Box>
        <Box style={mystyle.welcomeText}>
          Our team is a small group of people working together on this webpage to give our customers an
          easily readable, and useable online shopping center, where they can buy computer parts, or build
          their own computer before buying it.

          We hope that our customers will feel the same as what we think about our webpage, and hopefully you,
          the reader already has the inteded feeling.   
        </Box>
      </Paper>
    
</>
  )
}
