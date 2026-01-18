window.getCurrentPositionAndReverseGeocode = async () => {
    if (!navigator.geolocation) {
        return { success: false, message: 'Geolocation not supported' };
    }

    return new Promise((resolve) => {
        navigator.geolocation.getCurrentPosition(async (pos) => {
            try {
                const lat = pos.coords.latitude;
                const lon = pos.coords.longitude;

                // Use Nominatim reverse geocoding (OpenStreetMap) - no API key required for light usage
                const url = `https://nominatim.openstreetmap.org/reverse?format=jsonv2&lat=${lat}&lon=${lon}`;
                const resp = await fetch(url, { headers: { 'Accept': 'application/json' } });
                const data = await resp.json();

                const display = data.display_name || data.address?.city || data.address?.town || data.address?.village || `${lat.toFixed(5)}, ${lon.toFixed(5)}`;

                resolve({ success: true, display, lat, lon });
            }
            catch (err) {
                resolve({ success: false, message: err?.toString() || 'Reverse geocode failed' });
            }
        }, (err) => {
            resolve({ success: false, message: err?.message || 'Permission denied' });
        }, { enableHighAccuracy: true, timeout: 10000 });
    });
};
