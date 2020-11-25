import React, { useReducer, useState } from 'react';
import './App.css';
import $ from "jquery";

const formReducer = (state: any, event: { name: any; value: any; }) => {
    '!=='
    return {
        ...state,
        [event.name]: event.value
    }
}

function NewListingForm() {

    const [formData, setFormData] = useReducer(formReducer, {});
    const [submitting, setSubmitting] = useState(false);
    const [open, setOpen] = useState(false);
    const handleSubmit = (event: { preventDefault: () => void; }) => {
        event.preventDefault();
        setSubmitting(true);

        // $.post("https://localhost:44346/api/product", [{
        //     "title": "Seller1_Product1", "category": "Pears", "price": 2, "seller": {"id": "931fbb66-b782-4d7c-8cfe-98fa4f459218" }, "description": "new", "id": "4095bc5c-2886-4c4c-b66a-a9b6ac6621d1"
        // }]).then (() => {
        //       setSubmitting(false);
        //     });

            $.ajax({
                type: "POST",
                url: "https://localhost:44346/api/product",
                data: JSON.stringify( [{
                    "title": "Seller1_Product1", "category": "Pears", "price": 2, "seller": {"id": "931fbb66-b782-4d7c-8cfe-98fa4f459218" }, "description": "new", "id": "4095bc5c-2886-4c4c-b66a-a9b6ac6621d1"
                }]),
                dataType: "json",
                contentType:"application/json; charset=utf-8"
                
              }).then (() => {
                setSubmitting(false);
              });
              
        //setTimeout(() => {
        //  setSubmitting(false);
        //}, 3000)
    }


    const handleChange = (event: { target: { name: String; value: any; }; }) => {
        setFormData({
            name: event.target.name,
            value: event.target.value,
        });
    }

    return (

        <div className="wrapper">
            <h1>Add a new Listening</h1>
            {submitting &&
                <div>
                    You are submitting the following:
         <ul>
                        {Object.entries(formData).map(([name, value]) => (
                            <li key={name}><strong>{name}</strong>:{(value as string)}</li>
                        ))}
                    </ul>
                </div>
            }
            <form onSubmit={handleSubmit}>
                <fieldset>
                    <label>
                        <p>Title</p>
                        <input name="name" onChange={handleChange} />
                    </label>
                </fieldset>
                <fieldset>
                    <label>
                        <p>Category</p>
                        <select name="" onChange={handleChange}>
                            <option value="">--Please choose an option--</option>
                            <option value="fuji">Fuji</option>
                            <option value="jonathan">Jonathan</option>
                            <option value="honey-crisp">Honey Crisp</option>
                        </select>
                    </label>
                </fieldset>
                <button type="submit">Submit</button>
            </form>
        </div>

    );
}
function DropdownMenu() {

    function DropdownItem(props: any) {
        return (
            <a href="#" className="menu-item">
                <span className="icon-button">{props.leftIcon}</span>
                {props.children}

                <span className="icon-right">{props.rightIcon}</span>
            </a>
        )
    }
    return (
        <div className="dropdown">
            <DropdownItem>Fruits</DropdownItem>
            <DropdownItem>Bananas</DropdownItem>
        </div>
    )
}



export default NewListingForm;