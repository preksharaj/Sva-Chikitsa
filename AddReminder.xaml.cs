using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Microsoft.Phone.Scheduler;

namespace _8th_Sem_Project.Sva_Chikitsa.Alarms
{
    public partial class AddReminder : PhoneApplicationPage
    {
        public AddReminder()
        {
            InitializeComponent();
        }
        public static int IntervalHours;
        public int Frequency;

        private void ApplicationBarSaveButton_Click(object sender, EventArgs e)
        {
            // The code in the following steps goes here.
            String name = System.Guid.NewGuid().ToString();
            DateTime date = (DateTime)beginDatePicker.Value;
            DateTime time = (DateTime)beginTimePicker.Value;
            DateTime beginTime = date + time.TimeOfDay;

            // Make sure that the begin time has not already passed.
            if (beginTime < DateTime.Now)
            {
                MessageBox.Show("the begin date must be in the future.");
                return;
            }

            // Get the expiration time for the notification.
            date = (DateTime)expirationDatePicker.Value;
            time = (DateTime)expirationTimePicker.Value;
            DateTime expirationTime = date + time.TimeOfDay;

            // Make sure that the expiration time is after the begin time.
            if (expirationTime < beginTime)
            {
                MessageBox.Show("expiration time must be after the begin time.");
                return;
            }

            RecurrenceInterval recurrence = RecurrenceInterval.None;
            if (dailyRadioButton.IsChecked == true)
            {
                IntervalHours = 2;
            }
            else if (weeklyRadioButton.IsChecked == true)
            {
                IntervalHours = 4;
            }
            else if (monthlyRadioButton.IsChecked == true)
            {
                IntervalHours = 6;
            }
            else if (endOfMonthRadioButton.IsChecked == true)
            {
                IntervalHours = 8;
            }
            else if (yearlyRadioButton.IsChecked == true)
            {
                IntervalHours = 10;
            }

            string param1Value = param1TextBox.Text;
            string param2Value = param2TextBox.Text;
            string queryString = "";
            if (param1Value != "" && param2Value != "")
            {
                queryString = "?param1=" + param1Value + "&param2=" + param2Value;
            }
            else if (param1Value != "" || param2Value != "")
            {
                queryString = (param1Value != null) ? "?param1=" + param1Value : "?param2=" + param2Value;
            }
            Uri navigationUri = new Uri("/Sva-Chikitsa/Alarms/LaunchPage.xaml" + queryString, UriKind.Relative);

            if ((bool)reminderRadioButton.IsChecked)
            {
                Reminder reminder = new Reminder(name);
                reminder.Title = titleTextBox.Text;
                reminder.Content = contentTextBox.Text;
                reminder.BeginTime = beginTime;
                reminder.ExpirationTime = expirationTime;
                reminder.RecurrenceType = recurrence;
                reminder.NavigationUri = navigationUri;

                // Register the reminder with the system.
                ScheduledActionService.Add(reminder);

                if (IntervalHours > 0)
                {
                    //i is started from 1 as 1 reminder added above
                    for (int i = 1; i < Frequency; i++)
                    {
                        name = System.Guid.NewGuid().ToString();
                        reminder = new Reminder(name);
                        reminder.RecurrenceType = recurrence;
                        reminder.Title = titleTextBox.Text;
                        reminder.Content = contentTextBox.Text;
                        reminder.BeginTime = beginTime.AddHours(IntervalHours * i);
                        reminder.ExpirationTime = expirationTime.AddHours(IntervalHours * i);
                        reminder.RecurrenceType = recurrence;
                        reminder.NavigationUri = navigationUri;
                        ScheduledActionService.Add(reminder);
                    }
                }
            }
            else
            {
                Alarm alarm = new Alarm(name);
                alarm.Content = contentTextBox.Text;
                alarm.Sound = new Uri("/Ringtones/Ring01.wma", UriKind.Relative);
                alarm.BeginTime = beginTime;
                alarm.ExpirationTime = expirationTime;
                alarm.RecurrenceType = recurrence;

                ScheduledActionService.Add(alarm);
            }
            if (IntervalHours > 0)
            {
                //i is started from 1 as 1 reminder added above
                for (int i = 1; i < Frequency; i++)
                {
                    Alarm alarm = new Alarm(name);
                    alarm.Content = contentTextBox.Text;
                    alarm.Sound = new Uri("/Ringtones/Ring01.wma", UriKind.Relative);
                    alarm.BeginTime = beginTime;
                    alarm.ExpirationTime = expirationTime.AddHours(IntervalHours * i);
                    alarm.RecurrenceType = recurrence;
                    ScheduledActionService.Add(alarm);
                }
            }
            NavigationService.GoBack();
        }


    }
}