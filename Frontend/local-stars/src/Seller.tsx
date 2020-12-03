import React from 'react'
import Map from './Components/Map'
import NavBar from './Components/NavigationBar/NavBar'

function Seller() {
  return (
    <div>
      <h1>Seller Page</h1>
      <NavBar />
      <div style={{position:'relative', left:'1168px', display:'flex', marginTop: '10px'}}>
        <Map />
    </div>
    </div>
    
  );
}

export default Seller;