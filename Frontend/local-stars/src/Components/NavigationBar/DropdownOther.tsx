import React, {Component} from 'react'
import './Dropdown.css'

function DropdownOther() {
    
    const[click, setClick] = React.useState(false)
    
    const handleClick = () => setClick(!click)

    return (
    <>
        <ul onClick={handleClick}
            className={click ? 'dropdownOther-menu clicked' : 'dropdownOther-menu'}>
            <li>
                    <a className='dropdownOtherF-link' href='#'>
                        Other
                    </a>
                  
                </li>
                <li>
                    <a className='dropdown-link' href='#'>
                        Dairy
                    </a>
                </li>
                <li>
                    <a className='dropdown-link' href='#'>
                        Eggs
                    </a>
                </li>
                <li>
                    <a className='dropdown-link' href='#'>
                        Honey products
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

export default DropdownOther