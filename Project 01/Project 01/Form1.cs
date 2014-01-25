//Casey Lance
//CS 1400
//Project #1
//---------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_01
{
    public partial class Form1 : Form
    {
        
        
        public Form1()
        {
            InitializeComponent();
            


        }

        
        //Returns result from adding two doubles
        private void sumButton_Click_1(object sender, EventArgs e)
        {
            //Gets numOne from user input and converts to a double
            double numOne = double.Parse(numOneTxtBox.Text);
            //Gets numTwo from user input and converts to a double
            double numTwo = double.Parse(numTwoTxtBox.Text);
            //Adds numOne and numTwo
            double sum = numOne + numTwo;
            //Converts result to a string with two decimal places
            string result = string.Format("{0:0.00}", sum);
            //Displays result in resultTxtBox
            resultTxtBox.Text = result;
        }

        //Returns result from multiplying two doubles
        private void prodButton_Click(object sender, EventArgs e)
        {
            //Gets numOne from user input and converts to a double
            double numOne = double.Parse(numOneTxtBox.Text);
            //Gets numTwo from user input and converts to a double
            double numTwo = double.Parse(numTwoTxtBox.Text);
            //Multiplies numOne and numTwo
            double prod = numOne * numTwo;
            //Converts result to a string with two decimal places
            string result = string.Format("{0:0.00}", prod);
            //Displays result in resultTxtBox
            resultTxtBox.Text = result;
        }

        //Returns result from dividing two numbers
        private void qoutButton_Click(object sender, EventArgs e)
        {
            //Gets numOne from user input and converts to a double
            double numOne = double.Parse(numOneTxtBox.Text);
            //Gets numTwo from user input and converts to a double
            double numTwo = double.Parse(numTwoTxtBox.Text);
            //Divides numOne by numTwo
            double quot = numOne / numTwo;
            //Converts result to a string with two decimal places
            string result = string.Format("{0:0.00}", quot);
            //Displays result in resultTxtBox
            resultTxtBox.Text = result;
        }

        private void diffButton_Click(object sender, EventArgs e)
        {
            //Gets numOne from user input and converts to a double
            double numOne = double.Parse(numOneTxtBox.Text);
            //Gets numTwo from user input and converts to a double
            double numTwo = double.Parse(numTwoTxtBox.Text);
            //Subtracts numTwo from numOne
            double diff = numOne - numTwo;
            //Converts result to a string with two decimal places
            string result = string.Format("{0:0.00}", diff);
            //Displays result in resultTxtBox
            resultTxtBox.Text = result;
        }

        //Clears all boxes when clear button is clicked
        private void clearButton_Click(object sender, EventArgs e)
        {
            //Clears numOneTxtBox
            numOneTxtBox.Text = String.Empty;
            //Clears numTwoTxtBox 
            numTwoTxtBox.Text = String.Empty;
            //Clears resultTxtBox
            resultTxtBox.Text = string.Empty;
        }

        //Displays my personal information
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Casey Lance\nCS1400\nProject #1");
        }

        //Exits the application
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
