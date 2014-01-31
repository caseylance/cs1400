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

       private void about_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Casey Lance\nCS1400\nProject #2");
        }

       private void close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void calculateButton_Click(object sender, RoutedEventArgs e)
        {
            const double INCHES_PER_MILE = 63360;

            turnsPerMileTxtBox.Text = string.Format("{0:F}",
            INCHES_PER_MILE / ((double.Parse(wheelDiameterTxtBox.Text)) * Math.PI));


        }

        private void resetButton_Click(object sender, RoutedEventArgs e)
        {
            wheelDiameterTxtBox.Text = String.Empty;
            turnsPerMileTxtBox.Text = String.Empty;
        }

        private void exitButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
               
    }
}
