import Logo from '../assets/logo.svg';
import React from 'react'
import Grid from "@mui/material/Grid";
import Paper from "@mui/material/Paper";
import { Box, ThemeProvider, createTheme } from '@mui/system';
import Mainpicture from '../assets/maintitle.jpg';
import { CardMedia } from '@mui/material';
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
mainTitle: {
  padding: 60,
  fontSize: 45,
  textAlign: "left",
  color: "black",
  borderRadius: 3,

  backgroundColor: "grey",
},
};
//className={classes.mainFeaturedPost}  
// className={classes.mainTitle}

export default function home() {
  return (
    <>
      <Grid container component={Paper} elevation={24} md={12}>
          <Grid item md={4} sx={{padding: 3, height: 190, fontSize: 45, textAlign: "left", color: "black", borderRadius: 0, backgroundColor: "grey"}}>
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
