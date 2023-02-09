import { useEffect } from "react";
import { Navigate } from "react-router-dom";


export default function Unauthorized() {

    useEffect(() => {
        localStorage.setItem("isLoggedIn", false);
    }, [])

    return (
        <>
            <h1>Unauthorized</h1>
        </>
        )
}