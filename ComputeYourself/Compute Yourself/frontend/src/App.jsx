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
import RootLayout from './layouts/RootLayout'
import axios from "axios";
import reactLogo from "./assets/react.svg";

const router = createBrowserRouter(
  createRoutesFromElements(
    <Route path="/" element={<RootLayout />}>
      <Route index element={<Home />} />
      <Route path="about" element={<About />} />
    </Route>
  )
);

function App() {
  const [count, setCount] = useState(0);
  useEffect(() => {
    axios.get("https://localhost:7195/product").then((response) => {
      response.data.map((e) => {
        console.log(e);
      });
    });
  }, []);
  return <RouterProvider router={router} />;
}

export default App;
