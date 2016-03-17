using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Microsoft.Phone.Tasks;

namespace _8th_Sem_Project.Sva_Chikitsa
{
    public partial class Appointment : PhoneApplicationPage
    {
        public Appointment()
        {
            InitializeComponent();
        }

        private void Send_Mail(object sender, System.Windows.RoutedEventArgs e)
        {
            // TODO: Add event handler implementation here.
            EmailComposeTask emailComposeTask = new EmailComposeTask()
            {
                Subject = "Book Appointment",
                Body = "Date: " + date.Text + Environment.NewLine +"Time: " + time.Text + Environment.NewLine + "Patient: " + Patient_Views.UserDetails.UserName,
                To = "amishchandra@live.com",
                Cc = "cc@example.com",
                Bcc = "bcc@example.com",
            };
            emailComposeTask.Show();
        }
    }
}