import React, {Component} from 'react'
import {DropdownButton, Dropdown, ButtonGroup, Navbar} from 'react-bootstrap'
import Categories from '../CategoryData'
import "./NavigationBar/Dropdown.css"

function NavBarVert() {
 
    const [value,setValue]=React.useState('');
    const handleSelect=(e:any)=>{
    setValue(e)
    }

    return (
        <>
        <ButtonGroup vertical className="dropdown-button" style={{width: 290}} >
        {Categories.map(
          (variant) => (
            <DropdownButton className="dropdown-element"
              
              as={ButtonGroup}
              key={variant[variant.length-1].substring(6)}
              variant={variant[variant.length-1].substring(6).toLowerCase()}
              id={`dropdown-variants-${variant[variant.length-1].substring(6)}`}
              size="lg"
              title={variant[variant.length-1].substring(6)}
              onSelect={handleSelect}
            >
             {variant.map((item) => (
        <Dropdown.Item style={{width:290}}size="md" eventKey={item}>{item}</Dropdown.Item>
       ))} 
            </DropdownButton>
          ),
        )}
        </ButtonGroup>
        <div style={{height: "50px"}}> </div>
        <h6> Chosen product subcategory: {value}</h6>
      </>
    )
}

export default NavBarVert;