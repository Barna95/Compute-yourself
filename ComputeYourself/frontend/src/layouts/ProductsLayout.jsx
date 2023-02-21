import { useNavigate, useParams } from "react-router-dom";

import { Box } from "@mui/system";
import CpuCoolers from "../routes/CpuCoolers";
import Cpus from "../routes/Cpus";
import Drives from "../routes/Drives";
import Gpus from "../routes/Gpus";
import MotherBoards from "../routes/MotherBoards";
import Paper from "@mui/material/Paper";
import PcCases from "../routes/PcCases";
import Psus from "../routes/Psus";
import Rams from "../routes/Rams";
import React from "react";

// import Button from "@mui/material/Button";











// import Grid from "@material-ui/core/Grid";







function ProductsLayout() {
    const navigate = useNavigate();
    const { productType } = useParams();
    let productEntries = null;

    if (productType === "psu") {
        productEntries = <Psus/>
    }
    if (productType === "cpu") {
        productEntries = <Cpus/>
    }
    if (productType === "pccase") {
        productEntries = <PcCases/>
    }
    if (productType === "motherboard") {
        productEntries = <MotherBoards/>
    }
    if (productType === "ram") {
        productEntries = <Rams/>
    }
    if (productType === "cpucooler") {
        productEntries = <CpuCoolers/>
    }
    if (productType === "gpu") {
        productEntries = <Gpus/>
    }
    if (productType === "drive") {
        productEntries = <Drives/>
    }
 
const productCategories = [
    {
        title: "CPU",
        page: "cpu",
    },
    {
        title: "PSU",
        page: "psu",
    },
    {
        title: "CPU COOLER",
        page: "cpucooler",
    },
    {
        title: "DRIVE",
        page: "drive",
    },
    {
        title: "GPU",
        page: "gpu",
    },
    {
        title: "MOTHERBOARD",
        page: "motherboard",
    },
    {
        title: "PC CASE",
        page: "pccase",
    },
    {
        title: "RAM",
        page: "ram",
    },
  ];

 //no Link, Button makes the redirect with navigate <Button onClick={() => navigate(`/product/${post.page}`)}>{post.title }</Button>
  return (
    <>
      <Paper elevation={24}>
          <Grid container md={12} style={{ textDecoration: "none", spacing: 2 , padding: 0}}>
            <Grid item md={2} style={{ textDecoration: "none", padding: 12}}>
                <Box sx={{ fontSize: 26, padding: 2 }}>
                    PRODUCTS
                </Box>
            {productCategories.map((category,index) => (
                <Grid item key={index} >
                    <Button sx={{ width: 150 }} style={{justifyContent: "flex-start"}} onClick={() => navigate(`/product/${category.page}`)}>{category.title }</Button>
                </Grid>
            ))}
            </Grid>
            <Grid item md={10} style={{ textDecoration: "none", padding: 12}}>
              <Grid container md={12} spacing={2}>
                  {productEntries}
              </Grid>
            </Grid>
          </Grid>
      </Paper>
    </>
  );
}


export default (ProductsLayout);
