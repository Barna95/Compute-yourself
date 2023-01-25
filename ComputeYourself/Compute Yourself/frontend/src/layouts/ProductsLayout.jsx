import { useState } from "react";
import Button from '@mui/material/Button';
import Cpus from '../routes/Cpus';
import Psus from "../routes/Psus";
import PcCases from "../routes/PcCases";
import MotherBoards from "../routes/MotherBoards";
import CpuCoolers from "../routes/CpuCoolers";
import Gpus from "../routes/Gpus";
import Rams from "../routes/Rams";
import Drives from "../routes/Drives";
import React from 'react';
import PropTypes from 'prop-types';
import { withStyles } from '@material-ui/core/styles';
import Typography from '@material-ui/core/Typography';
import Grid from '@material-ui/core/Grid';
import Card from '@material-ui/core/Card';
import CardContent from '@material-ui/core/CardContent';
import CardMedia from '@material-ui/core/CardMedia';
import Hidden from '@material-ui/core/Hidden';
import { Outlet, Link, NavLink } from "react-router-dom";
import Paper from "@mui/material/Paper";
import { call } from "file-loader";

const styles = theme => ({
    mainGrid: {
      marginTop: theme.spacing.unit * 4,
    },
    card: {
      display: 'flex',
    },
    cardDetails: {
      flex: 1,
    },
    cardMedia: {
    width: 200,
    height: 60,
},
});
const[productEntries, setProductEntries] = useState([<Cpus/>])
const { classes } = props;
const cpu = () => {
    setProductEntries([<Cpus />])
};
const psu = () => {
    setProductEntries([<Psus />])
};
const pccase = () => {
    setProductEntries([<PcCases />])
};
const motherboard = () => {
    setProductEntries([<MotherBoards />])
};
const ram = () => {
    setProductEntries([<Rams />])
};
const gpu = () => {
    setProductEntries([<Gpus />])
};
const cpucooler = () => {
    setProductEntries([<CpuCoolers />])
};
const drive = () => {
    setProductEntries([<Drives />])
};

const featuredPosts = [
{
    title: 'CPU',
    image: 'https://www.pcgamesn.com/wp-content/sites/pcgamesn/2017/09/cpu-upgrade.jpg',
    page: 'cpu',
    cpu
},
{
    title: 'PSU',
    image: 'https://www.lifewire.com/thmb/G1ZNM9qzBsfLTbeL5KDPH3Xd-Wk=/786x0/filters:no_upscale():max_bytes(150000):strip_icc():format(webp)/power-supply-5aba984fba617700376b877f.PNG',
    page: 'psu',
    psu
},
{
    title: 'CPU COOLER',
    image: 'https://media.icdn.hu/product/GalleryMod/2021-03/686483/resp/1607087_be_quiet_pure_rock_slim_2.webp',
    page: '/product/cpucooler',
    cpucooler
},
{
    title: 'DRIVE',
    image: 'https://www.crucial.com/content/dam/crucial/articles/pc-users/why-is-my-laptop-so-slow-/hard-disk-drive.jpg.transform/large-jpg/img.jpg',
    page: '/product/drive'
},
{
    title: 'GPU',
    image: 'https://assets.reedpopcdn.com/rtx_2080_ti.jpg/BROK/resize/1200x1200%3E/format/jpg/quality/70/rtx_2080_ti.jpg',
    page: '/product/gpu'
},
{
    title: 'MOTHERBOARD',
    image: 'https://upload.wikimedia.org/wikipedia/commons/thumb/b/b7/Computer-motherboard.jpg/640px-Computer-motherboard.jpg',
    page: '/product/motherboard'
},
{
    title: 'PC CASE',
    image: 'https://www.pcspecialist.co.uk/images/landing/corsair/cases/case-feature2.png',
    page: '/product/pccase'
},
{
    title: 'RAM',
    image: 'https://media.icdn.hu/product/GalleryMod/2015-06/302515/resp/2003539_kingston-16gb-ddr4-2400mhz-kcp424nd8-16.webp',
    page: '/product/ram'
},
];

function ProductsLayout(props){


    const RoutesList = [cpu, psu, drive]['cpu', 'psu', 'drive'];
    return (
        <>
        <Paper elevation={24}>
        <Grid container  className={classes.mainGrid} xs={12} >
            <Grid xs={4} md={2} style={{ textDecoration: 'none', spacing: 10 }}>
                {featuredPosts.map(post => (
                    <Grid item key={post} spacing={3}>
                        <Paper component={Link} onClick={post.function} style={{ textDecoration: 'none' }} size="medium" variant="outlined" className={classes.card} spacing={3}>
                        <div className={classes.cardDetails}>

                            <CardContent>
                            <Typography noWrap="true" >
                                {post.title}
                            </Typography>
                            </CardContent>
                        </div>

                        </Paper>
                    </Grid>
                ))}
            </Grid>
            <Grid xs={8} md={10} >
                <div> {productEntries}</div>

            </Grid>
        </Grid>
        </Paper>
            <ul>
                <li><Button onClick={cpu} >Cpus</Button></li>
                <li><Button onClick={psu} >Psus</Button></li>
                <li><Button onClick={pccase} >Pc Cases</Button></li>
                <li><Button onClick={motherboard} >Motherboards</Button></li>
                <li><Button onClick={ram} >Memory</Button></li>
                <li><Button onClick={gpu} >Graphic Cards</Button></li>
                <li><Button onClick={cpucooler} >Cpu Coolers</Button></li>
                <li><Button onClick={drive} >Drives</Button></li>        
            </ul>
        </>
    )
}
ProductsLayout.propTypes = {
    classes: PropTypes.object.isRequired,
  };

export default withStyles(styles)(ProductsLayout);