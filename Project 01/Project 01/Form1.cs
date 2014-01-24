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

        

        private void sumButton_Click_1(object sender, EventArgs e)
        {
            double numOne = double.Parse(numOneTxtBox.Text);
            double numTwo = double.Parse(numTwoTxtBox.Text);
            double sum = numOne + numTwo;
            resultTxtBox.Text = sum.ToString();
        }

        private void prodButton_Click(object sender, EventArgs e)
        {
            double numOne = double.Parse(numOneTxtBox.Text);
            double numTwo = double.Parse(numTwoTxtBox.Text);
            double prod = numOne * numTwo;
            string result = string.Format("{0:D}", prod.ToString());
            resultTxtBox.Text = result;
        }

        private void qoutButton_Click(object sender, EventArgs e)
        {
            double numOne = double.Parse(numOneTxtBox.Text);
            double numTwo = double.Parse(numTwoTxtBox.Text);
            double quot = numOne / numTwo;
            resultTxtBox.Text = quot.ToString();
        }

        private void diffButton_Click(object sender, EventArgs e)
        {
            double numOne = double.Parse(numOneTxtBox.Text);
            double numTwo = double.Parse(numTwoTxtBox.Text);
            double diff = numOne - numTwo;
            resultTxtBox.Text = diff.ToString();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            numOneTxtBox.Text = String.Empty;
            numTwoTxtBox.Text = String.Empty;
            resultTxtBox.Text = string.Empty;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Casey Lance\nCS1400\nProject #1");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
