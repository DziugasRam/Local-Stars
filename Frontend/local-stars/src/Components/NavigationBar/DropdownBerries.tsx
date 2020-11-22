import React, {Component} from 'react'
import './Dropdown.css'

function DropdownBerries() {
    
    const[click, setClick] = React.useState(false)
    
    const handleClick = () => setClick(!click)

    return (
    <>
        <ul onClick={handleClick}
            className={click ? 'dropdownBerries-menu clicked' : 'dropdownBerries-menu'}>
            <li>
                    <a className='dropdownBerriesF-link' href='#'>
                        Berries
                    </a>
                  
                </li>
                <li>
                    <a className='dropdown-link' href='#'>
                        Grapes
                    </a>
                </li>
                <li>
                    <a className='dropdown-link' href='#'>
                        Blueberries
                    </a>
                </li>
                <li>
                    <a className='dropdown-link' href='#'>
                        Strawberries
                    </a>
                </li>
                <li>
                    <a className='dropdown-link' href='#'>
                        Cherries
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

export default DropdownBerries