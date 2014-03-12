//Casey Lance
//CS 1400
//Project #6
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

namespace project6
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ShippingCost aShippingCostObjectRef;

        public MainWindow()
        {
            InitializeComponent();
        }

        string speed = null;
        string surcharge = null;
        string unit = null;

        private void StandardShipping_Selected(object sender, RoutedEventArgs e)
        {
            speed = "standard";
        }

        private void ExpressShipping_Selected(object sender, RoutedEventArgs e)
        {
            speed = "express";
        }

        private void SameDayShipping_Selected(object sender, RoutedEventArgs e)
        {
            speed = "same_day";
        }

        private void SurchargeTrue_Checked(object sender, RoutedEventArgs e)
        {
            surcharge = "true";
        }

        private void SurchargeFalse_Checked(object sender, RoutedEventArgs e)
        {
            surcharge = "false";
        }

        private void ByWeight_Selected(object sender, RoutedEventArgs e)
        {
            unit = "weight";
            UnitsLabelTxtBox.Text = "Shipment Weight:";
        }

        private void ByItem_Selected(object sender, RoutedEventArgs e)
        {
            unit = "item";
            UnitsLabelTxtBox.Text = "Items to Ship:";
        }

        private void CalculateButton_Click(object sender, RoutedEventArgs e)
        {
            string numberOfItemsString = ItemsTxtBox.Text;
            double numberOfItems;

            bool res = double.TryParse(numberOfItemsString, out numberOfItems);
            if (res == false)
            {
                MessageBox.Show("You must enter a number in the Items to Ship/Shipment Weight Field.");
            }

            if (unit == null || speed == null || surcharge == null)
            {
                MessageBox.Show("You must complete all fields!");
            }
            else
            {
                aShippingCostObjectRef = new ShippingCost(speed, surcharge, unit, numberOfItems);
                double shippingCostResult = aShippingCostObjectRef.CalcShippingCost();
                ShippingCostTxtBox.Text = string.Format("${0:f2}", shippingCostResult);
            }
        }

        private void about_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Casey Lance\nCS1400\nProject #6");
        }

        private void close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}    

        
        

        
        

        
        

     
                
        
    
