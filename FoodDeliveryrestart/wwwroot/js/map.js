(function(){
  var map, marker;
  window.fdMap = {
    init: function(lat, lng){
      if (!window.L) {
        console.error('Leaflet not loaded');
        return;
      }
      var el = document.getElementById('map');
      if (!el) return;
      map = L.map(el).setView([lat, lng], 16);
      L.tileLayer('https://{s}.tile.openstreetmap.org/{z}/{x}/{y}.png', {
        maxZoom: 19,
        attribution: '&copy; OpenStreetMap contributors'
      }).addTo(map);
      marker = L.marker([lat, lng]).addTo(map);
      setTimeout(function(){ if (map) map.invalidateSize(true); }, 0);
    },
    update: function(lat, lng){
      if (!map) return;
      map.setView([lat, lng], map.getZoom());
      if (marker) {
        marker.setLatLng([lat, lng]);
      } else {
        marker = L.marker([lat, lng]).addTo(map);
      }
      setTimeout(function(){ if (map) map.invalidateSize(true); }, 0);
    }
  };
})();
