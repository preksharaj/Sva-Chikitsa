using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;


namespace _8th_Sem_Project.Sva_Chikitsa
{
    public partial class LocationDetails : PhoneApplicationPage
    {
        public LocationDetails()
        {
            InitializeComponent();
        }

       
     private void abcd(object sender, System.EventArgs e)
        {
        	NavigationService.Navigate(new Uri("/MainPage.xaml", UriKind.Relative));
			// TODO: Add event handler implementation here.
        }
    }
}
    