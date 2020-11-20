import React, {Component} from 'react'
import './Dropdown.css'

function DropdownMeatAndFish() {
    
    const[click, setClick] = React.useState(false)
    
    const handleClick = () => setClick(!click)

    return (
    <>
        <ul onClick={handleClick}
            className={click ? 'dropdownMeatAndFish-menu clicked' : 'dropdownMeatAndFish-menu'}>
            <li>
                    <a className='dropdownMeatAndFishF-link' href='#'>
                        Meat and Fish
                    </a>
                  
                </li>
                <li>
                    <a className='dropdown-link' href='#'>
                        Beef
                    </a>
                </li>
                <li>
                    <a className='dropdown-link' href='#'>
                        Poultry
                    </a>
                </li>
                <li>
                    <a className='dropdown-link' href='#'>
                        Pork
                    </a>
                </li>
                <li>
                    <a className='dropdown-link' href='#'>
                        Fish
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

export default DropdownMeatAndFish