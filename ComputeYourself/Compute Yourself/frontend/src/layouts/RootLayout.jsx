import { NavLink, Outlet } from "react-router-dom";

import Footer from "../routes/Footer";
import Logo from '../assets/logo.svg';

export default function RootLayout() {
  return (
    <div className="root-layout">
      <header>
        <nav>
          <div className="nav-logo">
            <img src={Logo} alt="Logo" />
          </div>
          <div>
            <NavLink to="/">Home</NavLink>
            <NavLink to="about">About</NavLink>
            <NavLink to="product/cpu">Cpus</NavLink>
            <NavLink to="product/psu">Psus</NavLink>
            <NavLink to="product/pccase">PcCases</NavLink>
            <NavLink to="product/motherboard">MotherBoards</NavLink>
            <NavLink to="product/ram">Rams</NavLink>
            <NavLink to="product/gpu">Gpus</NavLink>
            <NavLink to="product/cpucooler">CpuCoolers</NavLink>
            <NavLink to="product/drive">Drives</NavLink>
          </div>
        </nav>
      </header>
      <main>
        <Outlet />
        <footer>
          <Footer />
        </footer>
      </main>
    </div>
  );
}