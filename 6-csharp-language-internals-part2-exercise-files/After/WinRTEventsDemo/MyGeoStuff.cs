using Windows.Devices.Geolocation;

namespace WinRTEventsDemo
{
    public sealed class MyGeoStuff
    {
        private Geolocator geo;

        public MyGeoStuff()
        {
            geo = new Geolocator();
        }

        public void Start()
        {
            geo.PositionChanged += geo_PositionChanged;
        }

        public void Stop()
        {
            geo.PositionChanged -= geo_PositionChanged;
        }

        void geo_PositionChanged(Windows.Devices.Geolocation.Geolocator sender, Windows.Devices.Geolocation.PositionChangedEventArgs args)
        {
            // TODO
        }
    }
}
