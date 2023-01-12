import { NavLink, Outlet } from "react-router-dom";
import Logo from '../assets/logo.svg';

import Footer from "../routes/Footer";

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
            <NavLink to="cpus">Cpus</NavLink>
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