//import 'bootstrap/dist/css/bootstrap.min.css';
import "./App.css";

import {
  Route,
  RouterProvider,
  createBrowserRouter,
  createRoutesFromElements,
} from "react-router-dom";

import About from "./routes/About";
import Cpu from "./routes/Cpus";
import Psu from "./routes/Psus";
import PcCase from "./routes/PcCases";
import MotherBoard from "./routes/MotherBoards";
import CpuCooler from "./routes/CpuCoolers";
import Gpu from "./routes/Gpus";
import Home from "./routes/Homes";
import Ram from "./routes/Rams";
import Drive from "./routes/Drives";
import RootLayout from "./layouts/RootLayout";
import Products from "./routes/Products"
import reactLogo from "./assets/react.svg";
// import { productURL } from "./endpoints";

const router = createBrowserRouter(
  createRoutesFromElements(
    <Route path="/" element={<RootLayout />}>
      <Route index element={<Home />} />
      <Route path="about" element={<About />} />
      <Route path="product" element={<Products/> }/>
      <Route path="product/cpu" element={<Cpu />} />
      <Route path="product/psu" element={<Psu />} />
      <Route path="product/pccase" element={<PcCase />} />
      <Route path="product/motherboard" element={<MotherBoard />} />
      <Route path="product/ram" element={<Ram />} />
      <Route path="product/gpu" element={<Gpu />} />
      <Route path="product/cpucooler" element={<CpuCooler />} />
      <Route path="product/drive" element={<Drive /> }/>
    </Route>
  )
);

function App() {
  return <RouterProvider router={router} />;
}

export default App;
