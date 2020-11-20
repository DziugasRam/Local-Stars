import React, {Component} from 'react'
import './Dropdown.css'

function DropdownVegetables() {
    
    const[click, setClick] = React.useState(false)
    
    const handleClick = () => setClick(!click)

    return (
    <>
        <ul onClick={handleClick}
            className={click ? 'dropdownVegetables-menu clicked' : 'dropdownVegetables-menu'}>
            <li>
                    <a className='dropdownVegetablesF-link' href='#'>
                        Vegetables
                    </a>
                  
                </li>
                <li>
                    <a className='dropdown-link' href='#'>
                        Garlics
                    </a>
                </li>
                <li>
                    <a className='dropdown-link' href='#'>
                        Onions
                    </a>
                </li>
                <li>
                    <a className='dropdown-link' href='#'>
                        Peppers
                    </a>
                </li>
                <li>
                    <a className='dropdown-link' href='#'>
                        Tomatoes
                    </a>
                </li>
                <li>
                    <a className='dropdown-link' href='#'>
                        Potatoes
                    </a>
                </li>
                <li>
                    <a className='dropdown-link' href='#'>
                        Other
                    </a>
                </li>
        </ul>
    </>
    )
}

export default DropdownVegetables