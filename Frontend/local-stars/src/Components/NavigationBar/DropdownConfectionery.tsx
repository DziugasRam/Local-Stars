import React, {Component} from 'react'
import './Dropdown.css'

function DropdownConfectionery() {
    
    const[click, setClick] = React.useState(false)
    
    const handleClick = () => setClick(!click)

    return (
    <>
        <ul onClick={handleClick}
            className={click ? 'dropdownConfectionery-menu clicked' : 'dropdownConfectionery-menu'}>
            <li>
                    <a className='dropdownConfectioneryF-link' href='#'>
                        Confectionery
                    </a>
                  
                </li>
                <li>
                    <a className='dropdown-link' href='#'>
                        Pies
                    </a>
                </li>
                <li>
                    <a className='dropdown-link' href='#'>
                        Cakes
                    </a>
                </li>
                <li>
                    <a className='dropdown-link' href='#'>
                        Pastry
                    </a>
                </li>
                <li>
                    <a className='dropdown-link' href='#'>
                        
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

export default DropdownConfectionery