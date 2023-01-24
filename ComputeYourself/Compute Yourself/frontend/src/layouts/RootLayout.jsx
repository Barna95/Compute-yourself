import { Outlet, NavLink } from "react-router-dom";

import Footer from "../routes/Footer";

//import Logo from '../assets/logo.svg';

export default function RootLayout() {
  return (
    <div className="root-layout">
      <header>
        <nav>
          <div>
            <NavLink to="/">Home</NavLink>
            <NavLink to="about">About</NavLink>
            <NavLink to="product">Products</NavLink>
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