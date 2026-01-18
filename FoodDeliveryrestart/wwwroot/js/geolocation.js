window.fd = {
  getCurrentPosition: function () {
    return new Promise(function (resolve, reject) {
      if (!navigator.geolocation) {
        reject('Geolocation not supported');
        return;
      }
      navigator.geolocation.getCurrentPosition(function (pos) {
        resolve({
          latitude: pos.coords.latitude,
          longitude: pos.coords.longitude,
          accuracy: pos.coords.accuracy
        });
      }, function (err) {
        reject(err && err.message ? err.message : 'Geolocation error');
      }, { enableHighAccuracy: true, timeout: 10000, maximumAge: 0 });
    });
  }
};
