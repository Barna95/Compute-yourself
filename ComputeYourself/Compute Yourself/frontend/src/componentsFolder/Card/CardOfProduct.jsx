import { useState, useEffect } from "react";
import { useNavigate } from "react-router-dom";


const Card = (props) => {
    const navigate = useNavigate();
    const neededValues = [];
    const fillNeededValues =
        props.dataProperties.map((value, index) => {
            neededValues.push(<div key={index}>{value.name} </div>,
                <div>{value.price}</div>,
                <div>{value.rating}</div>,
                <button
                    title="Go to Details"
                    onClick={() => navigate(`/product/details`, { replace: true, state: { itemId: value.id, productType: props.productType } }
                    )}
                >Details</button>)
        });

    useEffect(() => {
        fillNeededValues;
    }, []);

    return (
        <div>
            <div>{neededValues}</div>
        </div>
    )
};

export default Card;