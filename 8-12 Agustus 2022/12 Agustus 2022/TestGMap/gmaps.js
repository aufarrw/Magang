function initMap(){
    var options = {
        zoom:10,
        center:{lat:-6.9175,lng:107.6191}
    }

    var Map = new google.maps.Map(document.getElementById('map'), options);

    let latitude = document.getElementById("Latitude").value;
    let longitude = document.getElementById("Longitude").value;

  const marker = new google.maps.Marker({
    // The below line is equivalent to writing:
    // position: new google.maps.LatLng(-34.397, 150.644)
    position: {lat: latitude, lng: longitude},
    map: map,
  });

  // You can use a LatLng literal in place of a google.maps.LatLng object when
  // creating the Marker object. Once the Marker object is instantiated, its
  // position will be available as a google.maps.LatLng object. In this case,
  // we retrieve the marker's position using the
  // google.maps.LatLng.getPosition() method.
  const infowindow = new google.maps.InfoWindow({
    content: "<p>Marker Location:" + marker.getPosition() + "</p>",
  });

  google.maps.event.addListener(marker, "click", () => {
    infowindow.open(map, marker);
  });

}