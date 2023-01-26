//import 'bootstrap/dist/css/bootstrap.min.css';
import "./App.css";

import {
    Route,
    Routes,
  RouterProvider,
  createBrowserRouter,
  createRoutesFromElements,
} from "react-router-dom";

import About from "./routes/About";
import Cpus from "./routes/Cpus";
import Psus from "./routes/Psus";
import PcCases from "./routes/PcCases";
import MotherBoards from "./routes/MotherBoards";
import CpuCoolers from "./routes/CpuCoolers";
import Gpus from "./routes/Gpus";
import Home from "./routes/Home";
import Rams from "./routes/Rams";
import Drives from "./routes/Drives";
import RootLayout from "./layouts/RootLayout";
import Products from "./routes/Products"
import AddNewCpu from "./routes/AddNewCpu"
import reactLogo from "./assets/react.svg";
import ShowProductDetails from "./routes/ShowProductDetails";
// import { productURL } from "./endpoints";

const router = createBrowserRouter(
  createRoutesFromElements(
    <Route path="/" element={<RootLayout />}>
      <Route index element={<Home />} />
      <Route path="about" element={<About />} />
      <Route path="product" element={<Products/> }/>
      <Route path="product/cpu" element={<Cpus />} />
      <Route path="product/psu" element={<Psus />} />
      <Route path="product/pccase" element={<PcCases />} />
      <Route path="product/motherboard" element={<MotherBoards />} />
      <Route path="product/ram" element={<Rams />} />
      <Route path="product/gpu" element={<Gpus />} />
      <Route path="product/cpucooler" element={<CpuCoolers />} />
      <Route path="product/drive" element={<Drives />} />
      <Route path="product/details/" element={<ShowProductDetails />} />
      <Route path="product/addnewcpu" element={<AddNewCpu />} />
    </Route>
  )
);

function App() {
  return <RouterProvider router={router} />;
}

export default App;
