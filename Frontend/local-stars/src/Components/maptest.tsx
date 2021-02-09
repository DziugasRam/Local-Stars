import React, {Component, useState, useEffect} from 'react';
 import GoogleMapReact from "google-map-react";
 import Pin from '../assets/clipart2825061.png';
 import { serverUrl } from "../configuration";
import { authFetch } from "../utils/auth";


class Mapg extends React.Component {

    render() {

        const [sellers, setSellers] = useState<any[]>([]);
       const [latitude, setLat] = useState(0);
       const [longitude, setLng] = useState(0);

         console.log("pirmas");

        useEffect( () => {

          authFetch(`${serverUrl}/api/seller/get`)
         .then(resp => resp?.json())
         .then(data => setSellers(data));
        
         console.log(sellers);

          navigator.geolocation.getCurrentPosition(position => {const pos = {lat: position.coords.latitude,
          lng: position.coords.longitude};
          setLat(pos.lat);
          setLng(pos.lng);

        })}, []);


        const getSellerInfo = (seller: { firstName: string; lastName: string; phoneNumber: string; longitude: number; latitude: number; address: string; id: any;}) => (
          {lat: seller.latitude, lng: seller.longitude, address: seller.address, firstName: seller.firstName, lastName: seller.lastName, phoneNumber: seller.phoneNumber}
        );

        console.log("trecias");

       const renderMarkers = (map: any, maps: any) => {

        console.log("ketvirtas");

         sellers.map((seller)=> 
         {
           var sellerInfo = getSellerInfo(seller);
           console.log(sellerInfo);
           let marker = new maps.Marker({
            position: { lat: sellerInfo.lat, lng: sellerInfo.lng },
            map
            });
  
           console.log('adresas:');

           let infoWindow = new maps.InfoWindow({
            map,
            content: "<h6>Pardavėjo informacija:</h6><p><b>Pardavėjas:</b> "+sellerInfo.firstName+" "+sellerInfo.lastName+
            "</p><p><b> Telefono numeris:</b> "+sellerInfo.phoneNumber+"</p><p><b> Adresas: </b>"+sellerInfo.address+"</p>",
            });

            marker.addListener("click", () => {infoWindow.open(map, marker)});

            return marker;

         }
         )
       };

        return (

       <div style={{height: '100vh', width: '100%'}}>
           <GoogleMapReact
           bootstrapURLKeys={{ key: "AIzaSyCOlAIs7DJ8Un5CpZ8XFDAE702JGlki9FQ", language: 'en' }}
           yesIWantToUseGoogleMapApiInternals
           onGoogleApiLoaded={({ map, maps }) => renderMarkers(map, maps)}
           defaultZoom={14} 
           center={{lat: latitude, lng: longitude}}>
           </GoogleMapReact>
       </div>

        )
    }

}


 export default Mapg;
