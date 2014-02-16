//Casey Lance
//CS 1400
//Project #4
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

namespace project4
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

        private void CalculateButton_Click(object sender, RoutedEventArgs e)
        {
            const double CONVERSION_TO_RADIANS = 180;
            double sideA = double.Parse(sideATxtBox.Text);
            double sideB = double.Parse(sideBTxtBox.Text);
            double angleC = double.Parse(angleCTxtBox.Text);
            double cosC = Math.Cos(Math.PI * (angleC / CONVERSION_TO_RADIANS));
            double sideC = CalculateSideC(sideA, sideB, cosC);
            sideCTxtBox.Text = string.Format("{0:f2}", sideC);

        }
        
        static double CalculateSideC(double side1, double side2, double cos1)
        {
            const double MULTIPLICATION_FACTOR = 2;
            double squaredResult = (side1 * side1) + (side2 * side2) - (MULTIPLICATION_FACTOR * side1 * side2 * cos1);
            double result = Math.Sqrt(squaredResult);
            return result;    
        }

        private void about_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Casey Lance\nCS1400\nProject #4");
        }

        private void close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void ResetButton_Click(object sender, RoutedEventArgs e)
        {
            sideATxtBox.Text = string.Empty;
            sideBTxtBox.Text = string.Empty;
            sideCTxtBox.Text = string.Empty;
            angleCTxtBox.Text = string.Empty;
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
