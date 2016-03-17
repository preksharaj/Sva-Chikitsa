using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Controls.Maps;
using Microsoft.Phone.Controls.Maps.Platform;

namespace _8th_Sem_Project.Sva_Chikitsa
{
    public partial class Locat : PhoneApplicationPage
    {
        public Locat()
        {
            InitializeComponent();
       //Adding pushpin
			Pushpin pushpin = new Pushpin();
			Location location = new Location();
			location.Latitude = 13.0205;
			location.Longitude = 77.5877;
			pushpin.Location = location;
			pushpin.Background = new SolidColorBrush(Colors.Orange);
            pushpin.Content = "M.S Ramaiah Memorial Hospital";
			pushpin.FontSize = 30;
			pushpin.Opacity = .9;

			//Adding polygon
			MapPolygon mapPolygon = new MapPolygon();
			mapPolygon.Fill = new SolidColorBrush(Colors.Purple);
			mapPolygon.Stroke = new SolidColorBrush(Colors.White);
			mapPolygon.Opacity = .7;
			LocationCollection locations = new LocationCollection();
			Location location1 = new Location();
			location1.Latitude = 13.0205;
			location1.Longitude = 77.5877;
			Location location2 = new Location();
			location1.Latitude = 20.0205;
			location1.Longitude = 77.5877;
			locations.Add(location);
			locations.Add(location1);
			locations.Add(location2);
			mapPolygon.Locations = locations;



			//MapControl.Children.Add(pushpin);
			//MapControl.Children.Add(mapPolygon);
		}
	}
}