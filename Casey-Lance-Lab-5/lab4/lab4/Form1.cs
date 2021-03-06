﻿//Casey Lance
//CS 1400
//Lab #5
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

namespace lab4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // The exitToolStripMenuItem1 method
        // Purpose: To close the window and terminate the application
        // Parameters: The object generating the event 
        // and the event arguments
        // Returns: None
        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // The aboutToolStripMenuItem method
        // Purpose: To display my intentifying information
        // Parameters: The object generating the event 
        // and the event arguments
        // Returns: Window displaying my contat information

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Casey Lance\nCS1400\nLab #5");
        }

        // The button1_Click Method
        // Purpose: Get a value from the user and display it back again
        // Parameters: The sending object, and the event arguments
        // Returns: none
           
        private void button1_Click(object sender, EventArgs e)
        {
            
            {
                int num = int.Parse(inTxtBox.Text);
                string outStr = string.Format("{0:D}", num);
                outTxtBox.Text = outStr;
            }
        } 
    }
}