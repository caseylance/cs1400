//Casey Lance
//CS 1400
//Project #2
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

namespace Project_2
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
       
        //Display personal information when user clicks "About" in the File drop down menu 
       private void about_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Casey Lance\nCS1400\nProject #2");
        }
       
        // Close application when user click "Close" in the File drop down menu
       private void close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        //Calculate and display the number of rotations per mile when the user clicks "Calculate" button
        private void calculateButton_Click(object sender, RoutedEventArgs e)
        {
            //Store inches per mile
            const double INCHES_PER_MILE = 63360;
            
            //User enteres wheel diameter in the Wheel Diameter Text Box.  
            //Inches per mile is divided by the diameter multiplied by PI and displayed
            //in the Turns Per Mile Text Box
         
            turnsPerMileTxtBox.Text = string.Format("{0:F}",
            INCHES_PER_MILE / ((double.Parse(wheelDiameterTxtBox.Text)) * Math.PI));


        }

        //Clears text boxes when user clicks reset button
        private void resetButton_Click(object sender, RoutedEventArgs e)
        {
            wheelDiameterTxtBox.Text = String.Empty;
            turnsPerMileTxtBox.Text = String.Empty;
        }

        //Closes the application when the user clicks the exit button
        private void exitButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
               
    }
}
