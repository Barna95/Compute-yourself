import Button from "@mui/material/Button";
import CardContent from "@material-ui/core/CardContent";
import CpuCoolers from "../routes/CpuCoolers";
import Cpus from "../routes/Cpus";
import Drives from "../routes/Drives";
import Gpus from "../routes/Gpus";
import Grid from "@material-ui/core/Grid";
import { Link } from "react-router-dom";
import MotherBoards from "../routes/MotherBoards";
import Paper from "@mui/material/Paper";
import PcCases from "../routes/PcCases";
import PropTypes from "prop-types";
import Psus from "../routes/Psus";
import Rams from "../routes/Rams";
import React from "react";
import Typography from "@material-ui/core/Typography";
import { useState } from "react";
import { withStyles } from "@material-ui/core/styles";

const styles = (theme) => ({
  mainGrid: {
    padding: 10,
    marginTop: 2,
  },
  productGrid: {
    padding: 3,
    spacing: 2,
  },
  card: {
    display: "flex",
  },
  cardDetails: {
    flex: 1,
  },
  cardMedia: {
    width: 200,
    height: 60,
  },
});



function ProductsLayout(props) {
  const [productEntries, setProductEntries] = useState(<Cpus />);
  const { classes } = props;
  const cpu = () => {
      setProductEntries([<Cpus key={0 }/>]);
  };
  const psu = () => {
    setProductEntries([<Psus />]);
  };
  const pccase = () => {
    setProductEntries([<PcCases />]);
  };
  const motherboard = () => {
    setProductEntries([<MotherBoards />]);
  };
  const ram = () => {
    setProductEntries([<Rams />]);
  };
  const gpu = () => {
    setProductEntries([<Gpus />]);
  };
  const cpucooler = () => {
    setProductEntries([<CpuCoolers />]);
  };
  const drive = () => {
    setProductEntries([<Drives />]);
  };

  const featuredPosts = [
    {
      title: "CPU",
      image:
        "https://www.pcgamesn.com/wp-content/sites/pcgamesn/2017/09/cpu-upgrade.jpg",
      page: "cpu",
      function : cpu
    },
    {
      title: "PSU",
      image:
        "https://www.lifewire.com/thmb/G1ZNM9qzBsfLTbeL5KDPH3Xd-Wk=/786x0/filters:no_upscale():max_bytes(150000):strip_icc():format(webp)/power-supply-5aba984fba617700376b877f.PNG",
      page: "psu",
      function : psu
    },
    {
      title: "CPU COOLER",
      image:
        "https://media.icdn.hu/product/GalleryMod/2021-03/686483/resp/1607087_be_quiet_pure_rock_slim_2.webp",
      page: "/product/cpucooler",
      function : cpucooler
    },
    {
      title: "DRIVE",
      image:
        "https://www.crucial.com/content/dam/crucial/articles/pc-users/why-is-my-laptop-so-slow-/hard-disk-drive.jpg.transform/large-jpg/img.jpg",
      page: "/product/drive",
      function : drive
    },
    {
      title: "GPU",
      image:
        "https://assets.reedpopcdn.com/rtx_2080_ti.jpg/BROK/resize/1200x1200%3E/format/jpg/quality/70/rtx_2080_ti.jpg",
      page: "/product/gpu",
      function : gpu
    },
    {
      title: "MOTHERBOARD",
      image:
        "https://upload.wikimedia.org/wikipedia/commons/thumb/b/b7/Computer-motherboard.jpg/640px-Computer-motherboard.jpg",
      page: "/product/motherboard",
      function: motherboard
    },
    {
      title: "PC CASE",
      image:
        "https://www.pcspecialist.co.uk/images/landing/corsair/cases/case-feature2.png",
      page: "/product/pccase",
      function : pccase
    },
    {
      title: "RAM",
      image:
        "https://media.icdn.hu/product/GalleryMod/2015-06/302515/resp/2003539_kingston-16gb-ddr4-2400mhz-kcp424nd8-16.webp",
      page: "/product/ram",
      function : ram
    },
  ];
 
  return (
    <>
      <Paper elevation={24}>
          <Grid container md={12} style={{ textDecoration: "none", spacing: 2 , padding: 0}}>
            <Grid item md={2} style={{ textDecoration: "none", padding: 12}}>
            {featuredPosts.map((post,index) => (
              <Grid item key={index} >
                <Paper
                  component={Link}
                  onClick={post.function}
                  style={{ textDecoration: "none" }}
                  size="medium"
                  variant="outlined"
                  className={classes.card}
                  spacing={3}
                >
                  <CardContent className={classes.cardDetails}>
                        <Typography key={post.title} noWrap="true">{post.title}</Typography>
                  </CardContent>
                </Paper>
              </Grid>
            ))}
            </Grid>
            <Grid item md={10} style={{ textDecoration: "none", padding: 12}}>
              <Grid container spacing={2}>
                  {productEntries}
              </Grid>
            </Grid>
          </Grid>
      </Paper>
    </>
  );
}
ProductsLayout.propTypes = {
  classes: PropTypes.object.isRequired,
};

export default withStyles(styles)(ProductsLayout);
