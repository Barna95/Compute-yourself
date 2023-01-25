import { useState, useEffect } from "react";
import { useNavigate } from "react-router-dom";


const Card = (props) => {
    const [productId, setProductId] = useState([]);
    const navigate = useNavigate();
    const neededValues = [];
    const fillNeededValues =
        props.dataProperties.map((value, index) => {
            neededValues.push(<div key={index}>{value.name} </div>,
                <div>{value.price}</div>,
                <div>{value.rating}</div>)
        });

    useEffect(() => {
        fillNeededValues;
    }, []);

    useEffect(() => {
        Object.keys(props.dataProperties.map((e) => setProductId(e.id)));
    }, [neededValues])


    return (
        <div>
            <div>{neededValues}</div>
            <button
                title="Go to Details"
                onClick={ () => navigate(`/product/details`, { replace: true, state: { itemId: productId, productType: props.productType }}
                )}
            >Details</button>
        </div>
    )
};

export default Card;