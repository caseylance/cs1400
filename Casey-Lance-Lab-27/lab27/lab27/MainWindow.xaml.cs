//Casey Lance
//CS 1400
//Lab #27

//I declare that the following source code was written by me, or provided
//by the instructor for this project. I understand that copying 
//source code from any other source constitutes cheating, and that I will
//receive a zero grade on this project if I am found in violation of
// this policy.
//---------------------------------------------------------------------
using System;
using System.IO;
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

namespace lab27
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
            MessageBox.Show("Casey Lance\nCS1400\nLab 27");
        }

        private void close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void open_Click(object sender, RoutedEventArgs e)
        {
            Stream myStream = null;
            Microsoft.Win32.OpenFileDialog openFileDialog1 = new Microsoft.Win32.OpenFileDialog();

            openFileDialog1.InitialDirectory = "c:\\" ;
            openFileDialog1.Filter = "text files (*.txt)|*txt" ;

            Nullable<bool> result = openFileDialog1.ShowDialog();

            if(result == true)
            {
                if ((myStream = openFileDialog1.OpenFile()) != null)
                {
                    StreamReader data = new StreamReader(myStream);
                    textBox.Text = data.ReadLine();
                }
            }
        }
    }
}
