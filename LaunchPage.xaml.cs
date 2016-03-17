using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace _8th_Sem_Project.Sva_Chikitsa.Alarms
{
    public partial class LaunchPage : PhoneApplicationPage
    {
        public LaunchPage()
        {
            InitializeComponent();
        }
        protected override void OnNavigatedTo(System.Windows.Navigation.NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            string param1Value = "";
            string param2Value = "";

            NavigationContext.QueryString.TryGetValue("param1", out param1Value);
            NavigationContext.QueryString.TryGetValue("param2", out param2Value);

            param1TextBlock.Text = param1Value;
            param2TextBlock.Text = param2Value;
        }
    }
}