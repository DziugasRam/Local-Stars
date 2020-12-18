import React, {Component} from 'react'
import {DropdownButton, Dropdown, ButtonGroup, Navbar} from 'react-bootstrap' 
import Categories from '../CategoryData'
import "./NavigationBar/Dropdown.css"


function NavBarHoriz(props: {onCategoryChange: any}) {

    const [value,setValue]=React.useState('');
    const handleSelect=(e:any)=>{
    setValue(e)
    props.onCategoryChange(e)
    }

    return (
        <>
        {Categories.map(
          (variant) => (
            <DropdownButton
              as={ButtonGroup}
              key={variant[variant.length-1].substring(6)}
              variant={variant[variant.length-1].substring(6).toLowerCase()}
              id={`dropdown-variants-${variant[variant.length-1].substring(6)}`}
              size ="lg"
              title={variant[variant.length-1].substring(6)}
              onSelect={handleSelect}
            >
             {variant.map((item) => (
        <Dropdown.Item className="dropdown-button" size ="lg" eventKey={item}>{item}</Dropdown.Item>
       ))} 
            </DropdownButton>
          ),
        )}
        <h6> Now displaying these products: {value}</h6>
      </>
    )
}

var catValue = '';

export { NavBarHoriz, catValue };