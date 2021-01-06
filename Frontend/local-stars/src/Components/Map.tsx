 import React, {Component} from 'react';
 import Pin from '../assets/clipart2825061.png';
 import GoogleMapReact from 'google-map-react'


class MapsReact extends Component {


   state = { userLocation: { lat: 32, lng: 32 }, loading: true };

   componentDidMount() {
     navigator.geolocation.getCurrentPosition(
       position => {
         const { latitude, longitude } = position.coords;

         this.setState({
           userLocation: { lat: latitude, lng: longitude },
           loading: false
         });
       },
       () => {
         this.setState({ loading: false });
       }
     );
   }
  
     render() {

       const { loading, userLocation } = this.state;
  
       if (loading) {
         return null;
       }
      
      const Marker = (props:any) => {
        return <img style={{flex: 1, height: "35px", width: "30px"}} src={Pin} />
      }

        const renderMarkers = (map: any , maps: any) => {
         let marker = new maps.Marker({
         position: { lat: userLocation.lat, lng: userLocation.lng },
         map
         });
         return marker;
        }
        ;
  
      return (
      <div style={{height: '100vh', width: '100%'}}>
          <GoogleMapReact
          bootstrapURLKeys={{ key: "AIzaSyCOlAIs7DJ8Un5CpZ8XFDAE702JGlki9FQ", language: 'en' }}
          yesIWantToUseGoogleMapApiInternals
          center={userLocation}
          defaultZoom={14} 
          onGoogleApiLoaded={({ map, maps }) => renderMarkers(map, maps)} >
          <Marker lat={userLocation.lat} lng={userLocation.lng} />
          </GoogleMapReact>
      </div>
      )

  }
}


export default MapsReact;
