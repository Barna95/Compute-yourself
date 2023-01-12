import ModalWindow from '../Modal/ModalWindow';

const ProductProperties = (props) => {
    return (
        <div>
            <ModalWindow dataProperties={props.dataProperties}
                elementKeys={props.elementKeys}
                />
        </div>
        )
};

export default ProductProperties;