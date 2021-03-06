﻿using Xamarin.Forms;
using Xamarin.Forms.Xaml;

/*
Glyphish icons from
	http://www.glyphish.com/
under
	http://creativecommons.org/licenses/by/3.0/us/
support them by buying the full set / Retina versions
*/

[assembly:XamlCompilation(XamlCompilationOptions.Compile)]
namespace WorkingWithMaps
{
    public class App : Application // superclass new in 1.3
    {
        public App()
        {

            var tabs = new TabbedPage();

            // demonstrates the map control with zooming and map-types
            tabs.Children.Add(new MapPage { Title = "Map/Zoom", IconImageSource = "glyphish_74_location.png" });

            // demonstrates the map control with zooming and map-types
            tabs.Children.Add(new PinPage { Title = "Pins", IconImageSource = "glyphish_07_map_marker.png" });

            // demonstrates the map control with the pins coming from a collection
            tabs.Children.Add(new PinItemsSourcePage());

            // demonstrates the Geocoder class
            tabs.Children.Add(new GeocoderPage { Title = "Geocode", IconImageSource = "glyphish_13_target.png" });

            // opens the platform's native Map app
            tabs.Children.Add(new MapAppPage { Title = "Map App", IconImageSource = "glyphish_103_map.png" });

            MainPage = tabs;
        }
    }
}
