import React from 'react'
import NavBar from './Components/NavigationBar/NavBar'
import Map from './Components/Map'


function Home() {
  return (
    <div>
      <h1>Home Page</h1>
      <NavBar/>
      <div style={{position:'relative', left:'1168px', display:'flex', marginTop: '10px'}}>
        <Map />
    </div>

    </div>
  );
}

export default Home;