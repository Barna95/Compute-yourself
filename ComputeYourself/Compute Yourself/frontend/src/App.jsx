import "./App.css";

import {
  Route,
  RouterProvider,
  createBrowserRouter,
  createRoutesFromElements,
} from "react-router-dom";
import { useEffect, useState } from "react";

import About from "./routes/About";
// import { productURL } from "./endpoints";
import Home from './routes/Home';
import Cpu from './routes/Cpu';
import RootLayout from './layouts/RootLayout'
import reactLogo from "./assets/react.svg";


const router = createBrowserRouter(
  createRoutesFromElements(
    <Route path="/" element={<RootLayout />}>
      <Route index element={<Home />} />
          <Route path="about" element={<About />} />
          <Route path="cpus" element={<Cpu /> }/>
    </Route>
  )
);

function App() {
  return <RouterProvider router={router} />;
}

export default App;
