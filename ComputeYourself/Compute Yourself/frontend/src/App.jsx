import "./App.css";

import {
  Route,
  RouterProvider,
  createBrowserRouter,
  createRoutesFromElements,
} from "react-router-dom";
import { useEffect, useState } from "react";

import About from "./routes/About";
import Cpu from "./routes/Cpu";
import Home from "./routes/Home";
import Ram from "./routes/Ram";
import RootLayout from "./layouts/RootLayout";
import reactLogo from "./assets/react.svg";

// import { productURL } from "./endpoints";

const router = createBrowserRouter(
  createRoutesFromElements(
    <Route path="/" element={<RootLayout />}>
      <Route index element={<Home />} />
      <Route path="about" element={<About />} />
      <Route path="product/cpu" element={<Cpu />} />
      <Route path="product/ram" element={<Ram />} />
    </Route>
  )
);

function App() {
  return <RouterProvider router={router} />;
}

export default App;
