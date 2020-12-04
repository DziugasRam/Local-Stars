 import React, {Component} from 'react';
// import {GoogleMap, withScriptjs, withGoogleMap, Marker} from "react-google-maps";


// class MapContainer extends Component {
//     state = { userLocation: { lat: 32, lng: 32 }, loading: true };
  
//     componentDidMount() {
//       navigator.geolocation.getCurrentPosition(
//         position => {
//           const { latitude, longitude } = position.coords;
  
//           this.setState({
//             userLocation: { lat: latitude, lng: longitude },
//             loading: false
//           });
//         },
//         () => {
//           this.setState({ loading: false });
//         }
//       );
//     }
  
//     render() {
//       const { loading, userLocation } = this.state;
  
//       if (loading) {
//         return null;
//       }
  
//       return (
//       <div>
//           <GoogleMap defaultCenter={userLocation} zoom={13} />;
//         <Marker position = {userLocation} />;
//           </div>
//       )
//     }
//   }


// function Map() {

//     const WrappedMapConst = withScriptjs(withGoogleMap(MapContainer)) as any;

//     return(
//     <div className="map" style={{width: "18vw", height: "45vw"}}>
//         <WrappedMapConst 
//         googleMapURL={'https://maps.googleapis.com/maps/api/js?key=AIzaSyCOlAIs7DJ8Un5CpZ8XFDAE702JGlki9FQ&libraries=geometry,drawing,places'}
//         loadingElement={<div style={ {height:"100%"} }/>}
//         containerElement={<div style={ {height:"100%"} }/>}
//         mapElement={<div style={ {height:"100%"} }/>} />
//     </div>
//     )
// }

// export default Map;