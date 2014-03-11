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

        double shippingSpeed;
        double surcharge;
        double category;

        private void about_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Casey Lance\nCS1400\nProject #6");
        }

        private void close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void StandardShipping_Selected(object sender, RoutedEventArgs e)
        {
            shippingSpeed = 0;
        }

        private void ExpressShipping_Selected(object sender, RoutedEventArgs e)
        {
            shippingSpeed = 1;
        }

        private void SameDayShipping_Selected(object sender, RoutedEventArgs e)
        {
            shippingSpeed = 2;
        }

        private void SurchargeTrue_Checked(object sender, RoutedEventArgs e)
        {
            surcharge = 1;
        }

        private void SurchargeFalse_Checked(object sender, RoutedEventArgs e)
        {
            surcharge = 0;
        }

        private void CategoryA_Selected(object sender, RoutedEventArgs e)
        {
            category = 0;
            
          
        }

        private void CategoryB_Selected(object sender, RoutedEventArgs e)
        {
            category = 1;
            
            
        }

        private void CalculateButton_Click(object sender, RoutedEventArgs e)
        {
            double numberOfItems = double.Parse(ItemsTxtBox.Text);
            //Create object
            //save shippingCostObjectRef
            aShippingCostObjectRef = new ShippingCost(shippingSpeed, surcharge, category, numberOfItems);

            double shippingCostResult = aShippingCostObjectRef.CalcShippingCost();
            ShippingCostTxtBox.Text = string.Format("${0:f2}", shippingCostResult);
        }


        
        

     
                
        
    }
}
