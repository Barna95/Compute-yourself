const ProductProperties = (props) => {
    return (
        <table>
            <thead>
                <tr>{props.elementKeys.map(element => <th key={element}>{element}</th>)}</tr>
            </thead>
            <tbody>
                <tr>{props.elementKeys.map(element => <td key={element}>{props.dataProperties[element]}</td>)}</tr>
            </tbody>
        </table>);
}

export default ProductProperties;