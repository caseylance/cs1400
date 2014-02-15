//Casey Lance
//CS 1400
//Lab 11
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

namespace lab11
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
            double sideA = double.Parse(lineATxtBox.Text);
            double sideB = double.Parse(lineBTextBox.Text);
            double result = CalcHypotenuse(sideA, sideB);
            hypotenusTxtBox.Text = string.Format("{0}", result);

               
        }
        // The CalcHypotenuse Method
        // Purpose: Calculates the hypotenuse of a triangle
        // Parameters: The value of side a and side b of the triangle as doubles
        // Returns: The hypotenuse of the triangle as a double.

        static double CalcHypotenuse(double side1, double side2)
        {
            //square each side
            //total the squares of the sides
            double totalSidesSquared = (side1 * side1) + (side2 * side2);
            //get square root of total, return as value
            double hypotenuse = Math.Sqrt(totalSidesSquared);
            return hypotenuse;
        }

        private void about_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Casey Lance\nCS1400\nLab 11");
        }

        private void close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
