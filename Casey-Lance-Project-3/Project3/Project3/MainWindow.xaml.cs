//Casey Lance
//CS 1400
//Project #3
//---------------------------------------------------------------------


// I declare that the following source code was written by me, or provided
// by the instructor for this project. I understand that copying 
// source code from any other source constitutes cheating, and that I will
// receive a zero grade on this project if I am found in violation of
// this policy.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Project3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, RoutedEventArgs e)
        {
            //Declare Constants
            const int HUN_PART = 100;
            const int HOUR_TO_MINUTES = 60;
            const int NEW_TIME_CONVERSION = 4;
            
            //Get departure time
            int departureTime = int.Parse(departureTimeTxtBox.Text);
            
            //Get hours of departure time
            int departureHours = departureTime / HUN_PART;
            
            //Get minutes of departure time
            int departureMinutes = departureTime % HUN_PART;
            
            //Convert number of departure hours to minutes
            int convertedDepartureHours = departureHours * HOUR_TO_MINUTES;
           
            //Get total minutes
            int totalDepartureTime = convertedDepartureHours + departureMinutes;


            //Get old arrival time
            int oldArrivalTime = int.Parse(oldArrivalTxtBox.Text);
            
            //Get hours of old arrival time
            int oldArrivalHours = oldArrivalTime / HUN_PART;
            
            //Get minutes of arrival time
            int oldArrivalMinutes = oldArrivalTime % HUN_PART;
            
            //Convert departure hours to minutes
            int convertedOldArrivalHours = oldArrivalHours * HOUR_TO_MINUTES;
            
            
            //Get total minutes since midnight for arrival time
            int totalOldArrivalTime = convertedOldArrivalHours + oldArrivalMinutes;

            //Get old trip duration
            int oldTripDuration = totalOldArrivalTime - totalDepartureTime;
            
            //Get new trip duration
            int newTripDuration = ((oldTripDuration / NEW_TIME_CONVERSION)+(oldTripDuration % NEW_TIME_CONVERSION)+oldTripDuration);

            //Add trip duration to depature time
            int newArrivalByMinutes = totalDepartureTime + newTripDuration;
            
            //Get number of hours since midnight
            int newArrivalHours = (newArrivalByMinutes / HOUR_TO_MINUTES) * HUN_PART;
            
            //Get number of minutes
            int newArrivalMinutes = (newArrivalByMinutes % HOUR_TO_MINUTES);
            
            //Get new arrival time by adding hours to minutes
            int newArrivalTime = newArrivalHours + newArrivalMinutes;

            //Display new arrival time
            newArrivalTimeTxtBox.Text = string.Format("{0:d4}", newArrivalTime);





            }

        //Display personal information when user clicks "About" in the File drop down menu 
        private void about_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Casey Lance\nCS1400\nProject #3");
        }

        // Close application when user click "Close" in the File drop down menu
        private void close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        //Clear all text boxes when user clicks "reset"
        private void clearButton_Click(object sender, RoutedEventArgs e)
        {
            departureTimeTxtBox.Text = String.Empty;
            oldArrivalTxtBox.Text = String.Empty;
            newArrivalTimeTxtBox.Text = String.Empty;
        }

        //Close application when uses clicks "exit"
        private void exitButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

    }
}
