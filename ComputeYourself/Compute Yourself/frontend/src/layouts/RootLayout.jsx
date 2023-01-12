import { NavLink, Outlet } from "react-router-dom";

import Footer from "../routes/Footer";

export default function RootLayout() {
  return (
    <div className="root-layout">
      <header>
        <nav>
          <h1>Compute Yourself</h1>
          <NavLink to="/">Home</NavLink>
          <NavLink to="about">About</NavLink>
          <NavLink to="cpus">Cpus</NavLink>
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