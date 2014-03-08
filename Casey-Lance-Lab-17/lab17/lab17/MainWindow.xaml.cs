//Casey Lance
//CS 1400
//Lab #17

//I declare that the following source code was written by me, or provided
//by the instructor for this project. I understand that copying 
//source code from any other source constitutes cheating, and that I will
//receive a zero grade on this project if I am found in violation of
// this policy.
//---------------------------------------------------------------------
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

namespace lab17
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
            MessageBox.Show("Casey Lance\nCS1400\nLab 17");
        }

        private void close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void ExpressShippingBtn_CheckedChanged(object sender, RoutedEventArgs e)
        {
           
                MessageBox.Show("You selected express shipping");
        }

        private void SameDayShippingBtn_Checked(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("You selected same day shipping");
        }

        private void StandardShippingBtn_Checked(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("You selected standard shipping");
        }

        private void CloseBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        
        }
    }

