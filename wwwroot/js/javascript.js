var map;
var infowindow;
var service;
var directionsService;
var directionsDisplay;
var choisen;
var pos;
var keyword;
var type;
var infobubble;
var markers = new Array(5);
let currentPlace={};
function initMap() {
  var pyrmont = { lat: 50.45136068, lng: 30.48783713 };
  map = new google.maps.Map(document.getElementById('map'), {
    center: pyrmont,
    zoom: 4,
    mapTypeId: 'roadmap',
    styles: [
    {
        "featureType": "all",
        "elementType": "all",
        "stylers": [
            {
                "hue": "#008eff"
            }
        ]
    },
    {
        "featureType": "poi",
        "elementType": "all",
        "stylers": [
            {
                "visibility": "off"
            }
        ]
    },
    {
        "featureType": "road",
        "elementType": "all",
        "stylers": [
            {
                "saturation": "0"
            },
            {
                "lightness": "0"
            }
        ]
    },
    {
        "featureType": "transit",
        "elementType": "all",
        "stylers": [
            {
                "visibility": "off"
            }
        ]
    },
    {
        "featureType": "water",
        "elementType": "all",
        "stylers": [
            {
                "visibility": "simplified"
            },
            {
                "saturation": "-60"
            },
            {
                "lightness": "-20"
            }
        ]
    }
]    
  });


  var iconBase = 'https://maps.google.com/mapfiles/kml/shapes/';
  var icons = {
    1: {
      icon:
        'https://goodzone.international/map/mmm2.png', //orange
 },
    2: {
      icon:
        'https://goodzone.international/map/mmm3.png', //red   
 },
    3: {
      icon:
        'https://goodzone.international/images/m1.png', //pink
    },
    0: {
      icon:
        'https://goodzone.international/map/mmm1.png', // white  
  },
  };
  console.log(markers);

  infoWindow = new google.maps.InfoWindow();
  service = new google.maps.places.PlacesService(map);
 

 var locations = new Array(5);
  for (let i = 0; i < markers.length; i++) {
    console.log(markers[i]);
    markers[i].position = new google.maps.LatLng(
      markers[i].lat,
      markers[i].lng
    );
  }
  var arr = new Array(5);
  let i = 0;
  // Create markers.
  markers.forEach(function(mark) {
    var marker = new google.maps.Marker({
      position: mark.position,
      icon: icons[3].icon,
      map: map,
      name:mark.name, 
      place_id: mark.place_id, 
      address: mark.address,
      rating: mark.rating, 
      site: mark.site,
      state: mark.state,
      type: mark.type, 
      city: mark.city,
      street: mark.street
    });
    arr[i++] = marker;

let  bpnq="https://monamo.ru/wp-content/uploads/2017/03/strelochka1.png";
      marker.addListener( 'click', function() {	
      marker.setIcon(icons[mark.state].icon); 
if(marker.state!=2 || marker.site =="" )
var site = "";
else var site=  '<br>Site:  <a href="' +marker.site+'" > '+marker.site + '  </a>'; 
if (marker.state==0)
{
var s = "НОВОЕ МЕСТО"  //"<br> Rating: &#128077   "; 
//var inf0 = new InfoBubble({
//          maxWidth: 300, 
//		  content: '<div class="c0"> <a href='+marker.site +' target="_blank"> <div class="cont_1">'+marker.type.toUpperCase()+" -- "+ marker.name.toUpperCase()  +' <br><strong> '+marker.street+"  " + marker.city+'</strong> <br><strong> '+s+'</strong></div></a></div> ' ,
//		  backgroundColor: 'rgb(250, 250, 250)',
                                
////var markers = new Array(5);
////let currentPlace={};
//});
//         inf0.close();
     	 //inf0.open(map, marker);
    infowindow.setContent('<div class="c"> <a href=' + marker.site + ' target="_blank"> <div class="cont_1">' + marker.type.toUpperCase() + " -- " + marker.name.toUpperCase() + ' <br><strong> ' + marker.street + "  " + marker.city + '</strong> <br><strong> ' + s + '</strong></div></a></div> ');
    infowindow.open(map, marker);
}
else if (marker.state==1 )
{
 var s ="ПРОВЕРЕНО " // "<br> Rating: &#128078   ";
//var inf1 = new InfoBubble({
//          maxWidth: 300,
//                  content: '<div class="c1"> <a href='+marker.site +' target="_blank"> <div class="cont_1">'+marker.type.toUpperCase()+" -- "+ marker.name.toUpperCase()  +' <br><strong> '+marker.street+"  " + marker.city+'</strong> <br><strong> '+s+'</strong></div></a></div> ' ,
//                  backgroundColor: 'rgb(249, 117, 0)'
//});
//		 inf1.open(map, marker);
    infowindow.setContent('<div class="c"> <a href=' + marker.site + ' target="_blank"> <div class="cont_1">' + marker.type.toUpperCase() + " -- " + marker.name.toUpperCase() + ' <br><strong> ' + marker.street + "  " + marker.city + '</strong> <br><strong> ' + s + '</strong></div></a></div> ');
    infowindow.open(map, marker);
}
else if (marker.state==2)
{
var s="КЛЕВОЕ МЕСТО "
//var inf2 = new InfoBubble({
//          maxWidth: 300,
//                  content: '<div class="c2"> <a href='+marker.site +' target="_blank"> <div class="cont_1">'+marker.type.toUpperCase()+" -- "+ marker.name.toUpperCase()  +' <br><strong> '+marker.street+"  " + marker.city+'</strong> <br><strong> '+s+'</strong></div></a></div> ' ,
//                  backgroundColor: 'rgb(141,0, 0)'
//});
//		 inf2.open(map, marker);
    infowindow.setContent('<div class="c"> <a href=' + marker.site + ' target="_blank"> <div class="cont_1">' + marker.type.toUpperCase() + " -- " + marker.name.toUpperCase() + ' <br><strong> ' + marker.street + "  " + marker.city + '</strong> <br><strong> ' + s + '</strong></div></a></div> ');
    infowindow.open(map, marker);

}
// infoWindow.setContent('<div class="c"> <a href='+marker.site +' target="_blank"> <div class="cont_1">'+marker.type.toUpperCase()+" -- "+ marker.name.toUpperCase()  +' <br><strong> '+marker.street+"  " + marker.city+'</strong> <br><strong> '+s+'</strong></div></a></div> ' );
           // infoWindow.open(map, marker);
// google.maps.event.addListener(infowindow, 'click', (function(i){
  //                      alert("go! ");
    //                }));
         
        });  
});

  // Add a marker clusterer to manage the markers.
  var markerCluster = new MarkerClusterer(map, arr, {
    imagePath:
      '../images/m',
  });

//  infoWindow = new google.maps.InfoWindow();
 // service = new google.maps.places.PlacesService(map);

  // autocomplete
  var input = /** @type {!HTMLInputElement} */ (document.getElementById(
    'search-box'
  ));
  var infowindow2 = new google.maps.InfoWindow();
  var marker = new google.maps.Marker({
    map: map,
    anchorPoint: new google.maps.Point(0, -29),
  });

  var autocomplete = new google.maps.places.Autocomplete(input);
  autocomplete.bindTo('bounds', map);
  var marker = new google.maps.Marker({
    map: map,
    anchorPoint: new google.maps.Point(0, -29),
  });

  autocomplete.addListener('place_changed', function() {
    infowindow2.close();
    marker.setVisible(false);
 var place = autocomplete.getPlace();
 currentPlace.lat= place.geometry.location.lat();
 currentPlace.lng= place.geometry.location.lng();
currentPlace.place_id= place.place_id;
currentPlace.name= place.name;
currentPlace.address = place.formatted_address;
currentPlace.site=place.website;
currentPlace.type = " ";
currentPlace.state= "0";
currentPlace.street="";
currentPlace.country=" ";
currentPlace.city="";
var i=0;

while(i<place.address_components.length )
{

console.log(place.address_components[i]);
//currentPlace.country =
if(place.address_components[i].types.indexOf("country")!=-1) 
{ currentPlace.country =place.address_components[i].short_name;
}
 if((place.address_components[i].types.indexOf("route")!=-1)||(place.address_components[i].types.indexOf("street_number")!=-1))
{ currentPlace.street +=place.address_components[i].short_name +" ";
}
if(place.address_components[i].types.indexOf("locality")!=-1)
{ currentPlace.city =place.address_components[i].short_name;
}

i++;
}
i=0;

console.log(currentPlace.country );
console.log(currentPlace.city );
console.log(currentPlace.street );

//street_address 
    if (!place.geometry) {
      // User entered the name of a Place that was not suggested and
      // pressed the Enter key, or the Place Details request failed.
      window.alert("No details available for input: '" + place.name + "'");
      return;
    }
    // If the place has a geometry, then present it on a map.
    if (place.geometry.viewport) {
      map.fitBounds(place.geometry.viewport);
    } else {
      map.setCenter(place.geometry.location);
      map.setZoom(17); // Why 17? Because it looks good.
    }
    marker.setIcon(
      /** @type {google.maps.Icon} */ ({
        url: place.icon,
        size: new google.maps.Size(71, 71),
        origin: new google.maps.Point(0, 0),
        anchor: new google.maps.Point(17, 34),
        scaledSize: new google.maps.Size(35, 35),
      })
    );
    marker.setPosition(place.geometry.location);
    marker.setVisible(true);

    var address = '';
    if (place.address_components) {
      address = [
        (place.address_components[0] &&
          place.address_components[0].short_name) ||
          '',
        (place.address_components[1] &&
          place.address_components[1].short_name) ||
          '',
        (place.address_components[2] &&
          place.address_components[2].short_name) ||
          '',
      ].join(' ');
    }

   infowindow2.setContent(
      '<div><strong>'+ place.name + '</strong><br>'+ address );
    infowindow2.open(map, marker);
  });
  // Try HTML5 geolocation.
  if (navigator.geolocation) {
    navigator.geolocation.getCurrentPosition(
      function(position) {
        pos = {
          lat: position.coords.latitude,
          lng: position.coords.longitude,
        };

        //C������ ������ � �������������
        var myMarker = new google.maps.Marker({
          position: pos,
          map: map,
          //draggable: true,
          animation: google.maps.Animation.BOUNCE,
        });
        infoWindow.setPosition(pos);
        infoWindow.setContent('Location found.');
        map.setCenter(pos);
      },
      function() {
        handleLocationError(true, infoWindow, map.getCenter());
      }
    );
  } else {
    // Browser doesn't support Geolocation
    handleLocationError(false, infoWindow, map.getCenter());
  }

// Find Btn
 const addBtn =document.getElementById("add");
 addBtn.addEventListener('click',send );
// send to                                                                        
function send()
{
if (currentPlace==undefined)
{alert('Место не выбрано');}
else{
var message = JSON.stringify(currentPlace);
window.location.href = 'https://goodzone.international/map/addMarker.php?message='+message;
}}
} ////////initMap end

//fetch('http://goodzone.international/map/indexB.php').then(r => r.text()).catch( alert );
fetch('https://goodzone.international/map/indexB.php')
  .then(function(response) {
    if (response.status !== 200) {
      console.log(
        'Looks like there was a problem. Status Code: ' + response.status
      );
      return;
    }


//Examine the text in the response
    response.json().then(function(data) {
      markers = data;
      initMap();
    });
  })
  .catch(function(err) {
    console.log('Fetch Error :-S', err);
  });

// ��������� ������ � �����������
function handleLocationError(browserHasGeolocation, infoWindow, pos) {
  infoWindow.setPosition(pos);
  infoWindow.setContent(
    browserHasGeolocation
      ? 'Error: The Geolocation service failed.'
      : "Error: Your browser doesn't support geolocation."
  );
}
