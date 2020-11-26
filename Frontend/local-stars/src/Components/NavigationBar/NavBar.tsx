import React, {Component} from 'react'
import './NavBar.css';
import DropdownFruits from './DropdownFruits';
import DropdownBerries from './DropdownBerries';
import DropdownVegetables from './DropdownVegetables';
import DropdownConfectionery from './DropdownConfectionery';
import DropdownMeatAndFish from './DropdownMeatAndFish';
import DropdownOther from './DropdownOther';


function NavBar() {

    const [dropdownFruits, setDropdownFruits] = React.useState(false);
    const [dropdownBerries, setDropdownBerries] = React.useState(false);
    const [dropdownVegetables, setDropdownVegetables] = React.useState(false);
    const [dropdownConfectionery, setDropdownConfectionery] = React.useState(false);
    const [dropdownMeatAndFish, setDropdownMeatAndFish] = React.useState(false);
    const [dropdownOther, setDropdownOther] = React.useState(false);

    const onMouseEnterFruits = () => setDropdownFruits(true);
    const onMouseLeaveFruits = () => setDropdownFruits(false);

    const onMouseEnterBerries = () => setDropdownBerries(true);
    const onMouseLeaveBerries = () => setDropdownBerries(false);

    const onMouseEnterVegetables = () => setDropdownVegetables(true);
    const onMouseLeaveVegetables = () => setDropdownVegetables(false);

    const onMouseEnterConfectionery = () => setDropdownConfectionery(true);
    const onMouseLeaveConfectionery = () => setDropdownConfectionery(false);

    const onMouseEnterMeatAndFish = () => setDropdownMeatAndFish(true);
    const onMouseLeaveMeatAndFish = () => setDropdownMeatAndFish(false);

    const onMouseEnterOther = () => setDropdownOther(true);
    const onMouseLeaveOther = () => setDropdownOther(false);

    return(
        <nav className="NavBarItems">
            <ul className='nav-menu'>
                <li className='nav-item'
                onMouseEnter={onMouseEnterFruits}
                onMouseLeave={onMouseLeaveFruits}>
                    <a className='nav-links' href='#'>
                        Fruits
                    </a>
                    {dropdownFruits && <DropdownFruits />}
                </li>
                <li className='nav-item'
                onMouseEnter={onMouseEnterBerries}
                onMouseLeave={onMouseLeaveBerries}>
                    <a className='nav-links' href='#'>
                        Berries
                    </a>
                    {dropdownBerries && <DropdownBerries />}
                </li>
                <li className='nav-item'
                onMouseEnter={onMouseEnterVegetables}
                onMouseLeave={onMouseLeaveVegetables}>
                    <a className='nav-links' href='#'>
                        Vegetables
                    </a>
                    {dropdownVegetables && <DropdownVegetables />}
                </li>
                <li className='nav-item'
                onMouseEnter={onMouseEnterConfectionery}
                onMouseLeave={onMouseLeaveConfectionery}>
                    <a className='nav-links' href='#'>
                        Confectionery
                    </a>
                    {dropdownConfectionery && <DropdownConfectionery />}
                </li>
                <li className='nav-item'
                onMouseEnter={onMouseEnterMeatAndFish}
                onMouseLeave={onMouseLeaveMeatAndFish}>
                    <a className='nav-links' href='#'>
                        Meat and Fish
                    </a>
                    {dropdownMeatAndFish && <DropdownMeatAndFish />}
                </li>
                <li className='nav-item'
                onMouseEnter={onMouseEnterOther}
                onMouseLeave={onMouseLeaveOther}>
                    <a className='nav-links' href='#'>
                        Other
                    </a>
                    {dropdownOther && <DropdownOther />}
                </li>
            </ul>
        </nav>
    )
}


export default NavBar;