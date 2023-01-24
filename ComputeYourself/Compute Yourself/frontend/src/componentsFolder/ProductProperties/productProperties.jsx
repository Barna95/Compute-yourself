import ModalWindow from '../Modal/ModalWindow';


const ProductProperties = (props) => {
    return (
        <div>
            <ModalWindow dataProperties={props.dataProperties}/>
        </div>
        )
};

export default ProductProperties;