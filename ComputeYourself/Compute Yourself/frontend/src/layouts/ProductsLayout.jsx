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



export default function ProductsLayout()
{
    const[productEntries, setProductEntries] = useState([<Cpus/>])

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
    return (
        <>
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
            <div> {productEntries}</div>
        </>
    )
}