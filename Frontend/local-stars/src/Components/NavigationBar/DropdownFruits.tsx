import React, {Component} from 'react'
import './Dropdown.css'

function DropdownFruits() {
    
    const[click, setClick] = React.useState(false)
    
    const handleClick = () => setClick(!click)

    return (
    <>
        <ul onClick={handleClick}
            className={click ? 'dropdown-menu clicked' : 'dropdown-menu'}>
            <li>
                    <a className='dropdownFruits-link' href='#'>
                        Fruits
                    </a>
                  
                </li>
                <li>
                    <a className='dropdown-link' href='#'>
                        Apples
                    </a>
                </li>
                <li>
                    <a className='dropdown-link' href='#'>
                        Apricots
                    </a>
                </li>
                <li>
                    <a className='dropdown-link' href='#'>
                        Plums
                    </a>
                </li>
                <li>
                    <a className='dropdown-link' href='#'>
                        Pears
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

export default DropdownFruits