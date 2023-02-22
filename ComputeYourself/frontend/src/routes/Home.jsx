import React from 'react'
import Grid from "@mui/material/Grid";
import Paper from "@mui/material/Paper";
import { Box } from '@mui/system';
import Mainpicture from '../assets/maintitle.jpg';
import { CardMedia } from '@mui/material';
import themeStyle from "../themeStyle"

export default function Home() {
  return (
    <>
      <Grid container component={Paper} elevation={24} md={12}>
          <Grid item md={4} sx={themeStyle.mainPageHeader}>
              <Box>
                Hardware Store
              </Box>
          </Grid>
          <Grid item md={8} >
            <CardMedia 
              component="img"
              sx={{ height: 190, width: '100%'}}
              image={`${Mainpicture}`}
            />
          </Grid>
      </Grid>
      <Paper elevation={24} sx={{ padding: 2, borderRadius: 0}}>
        <Box style={themeStyle.welcomeTextTitle}>
          Welcome dear Customer!
        </Box>
        <Box style={themeStyle.welcomeText}>
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
