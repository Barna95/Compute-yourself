//import 'bootstrap/dist/css/bootstrap.min.css';

//import "./App.css";

import {
    Route,
    RouterProvider,
    createBrowserRouter,
    createRoutesFromElements,
} from "react-router-dom";

import About from "./routes/About";
import AddNewCpu from "./routes/AddNewProducts/AddNewCpu";
import AddNewCpuCooler from "./routes/AddNewProducts/AddNewCpuCooler";
import AddNewDrive from "./routes/AddNewProducts/AddNewDrive";
import AddNewGpu from "./routes/AddNewProducts/AddNewGpu";
import AddNewMotherBoard from "./routes/AddNewProducts/AddNewMotherBoard";
import AddNewPcCase from "./routes/AddNewProducts/AddNewPcCase";
import AddNewPsu from "./routes/AddNewProducts/AddNewPsu";
import AddNewRam from "./routes/AddNewProducts/AddNewRam";
import EditCpu from "./routes/EditProducts/EditCpu"
import EditCpuCooler from "./routes/EditProducts/EditCpuCooler"
import EditDrive from "./routes/EditProducts/EditDrive"
import EditGpu from './routes/EditProducts/EditGpu';
import EditMotherBoard from "./routes/EditProducts/EditMotherBoard"
import EditPcCase from './routes/EditProducts/EditPcCase';
import EditPsu from './routes/EditProducts/EditPsu';
import EditRam from './routes/EditProducts/EditRam';
import Register from './Authentication/Register';
import Login from './Authentication/Login';
import Home from "./routes/Home";
import RootLayout from "./layouts/RootLayout";
import ProductsLayout from "./layouts/ProductsLayout"
import ShowProductDetails from "./routes/ShowProductDetails";

// import { productURL } from "./endpoints";


function App() {
    const router = createBrowserRouter(
        createRoutesFromElements(
            <Route path="/" element={<RootLayout />}>
                <Route index element={<Home />} />
                <Route path="about" element={<About />} />
                <Route path="product/:productType" element={<ProductsLayout />} />
                <Route path="product/:productType/:id/details" element={<ShowProductDetails />} />
                <Route path="product/addnewcpu" element={<AddNewCpu />} />
                <Route path="product/addnewcpucooler" element={<AddNewCpuCooler />} />
                <Route path="product/addnewdrive" element={<AddNewDrive />} />
                <Route path="product/addnewgpu" element={<AddNewGpu />} />
                <Route path="product/addnewmotherboard" element={<AddNewMotherBoard />} />
                <Route path="product/addnewpccase" element={<AddNewPcCase />} />
                <Route path="product/addnewpsu" element={<AddNewPsu />} />
                <Route path="product/addnewram" element={<AddNewRam />} />
                <Route path="product/cpu/:id/edit" element={<EditCpu />} />
                <Route path="product/motherboard/:id/edit" element={<EditMotherBoard />} />
                <Route path="product/cpucooler/:id/edit" element={<EditCpuCooler />} />
                <Route path="product/drive/:id/edit" element={<EditDrive />} />
                <Route path="product/pccase/:id/edit" element={<EditPcCase />} />
                <Route path="product/psu/:id/edit" element={<EditPsu />} />
                <Route path="product/ram/:id/edit" element={<EditRam />} />
                <Route path="product/gpu/:id/edit" element={<EditGpu />} />
                <Route path="account/login" element={<Login />} />
                <Route path="account/register" element={<Register />} />
            </Route>
        )
    );

  return <RouterProvider router={router} />;
}

export default App;
