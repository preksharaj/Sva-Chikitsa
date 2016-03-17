using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using System.IO.IsolatedStorage;
using System.IO;

namespace _8th_Sem_Project.Sva_Chikitsa
{
    public partial class Medicines : PhoneApplicationPage
    {
        IsolatedStorageFile ISOFile = IsolatedStorageFile.GetUserStoreForApplication();
        public static string medicine;
        public Medicines()
        {
            InitializeComponent();
        }
        private void asp(object sender, System.Windows.RoutedEventArgs e)
        {
            // TODO: Add event handler implementation here.
        }
        private void abcd(object sender, System.EventArgs e)
        {
            NavigationService.Navigate(new Uri("/MainPage.xaml", UriKind.Relative));
            // TODO: Add event handler implementation here.
        }
        void Medication(object sender, RoutedEventArgs e)
{
    RadioButton li = (sender as RadioButton);
    medicine = li.Content.ToString();
    NavigationService.Navigate(new Uri("/Sva-Chikitsa/Medication/Med.xaml", UriKind.Relative));
}
        private void ini(object sender, System.Windows.Input.GestureEventArgs e)
        {
            medicine = textbox.Text;
            NavigationService.Navigate(new Uri("/Sva-Chikitsa/Medication/Med.xaml", UriKind.Relative));
        }

       
    }
}