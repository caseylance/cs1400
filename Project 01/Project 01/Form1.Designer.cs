//Firstname Lastname
//CS 1400
//Project # (or Lab #)
//---------------------------------------------------------------------

namespace Project_01
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.numOneTxtBox = new System.Windows.Forms.TextBox();
            this.sumButton = new System.Windows.Forms.Button();
            this.prodButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.numTwoTxtBox = new System.Windows.Forms.TextBox();
            this.diffButton = new System.Windows.Forms.Button();
            this.qoutButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.resultTxtBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // numOneTxtBox
            // 
            this.numOneTxtBox.Location = new System.Drawing.Point(87, 55);
            this.numOneTxtBox.Name = "numOneTxtBox";
            this.numOneTxtBox.Size = new System.Drawing.Size(100, 20);
            this.numOneTxtBox.TabIndex = 0;
            // 
            // sumButton
            // 
            this.sumButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sumButton.Location = new System.Drawing.Point(426, 37);
            this.sumButton.Name = "sumButton";
            this.sumButton.Size = new System.Drawing.Size(21, 21);
            this.sumButton.TabIndex = 1;
            this.sumButton.Text = "+";
            this.sumButton.UseVisualStyleBackColor = true;
            this.sumButton.Click += new System.EventHandler(this.sumButton_Click_1);
            // 
            // prodButton
            // 
            this.prodButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prodButton.Location = new System.Drawing.Point(408, 55);
            this.prodButton.Name = "prodButton";
            this.prodButton.Size = new System.Drawing.Size(21, 21);
            this.prodButton.TabIndex = 2;
            this.prodButton.Text = "*";
            this.prodButton.UseVisualStyleBackColor = true;
            this.prodButton.Click += new System.EventHandler(this.prodButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.Location = new System.Drawing.Point(286, 108);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(100, 25);
            this.clearButton.TabIndex = 3;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // numTwoTxtBox
            // 
            this.numTwoTxtBox.Location = new System.Drawing.Point(286, 55);
            this.numTwoTxtBox.Name = "numTwoTxtBox";
            this.numTwoTxtBox.Size = new System.Drawing.Size(100, 20);
            this.numTwoTxtBox.TabIndex = 4;
            // 
            // diffButton
            // 
            this.diffButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diffButton.Location = new System.Drawing.Point(426, 73);
            this.diffButton.Name = "diffButton";
            this.diffButton.Size = new System.Drawing.Size(21, 21);
            this.diffButton.TabIndex = 5;
            this.diffButton.Text = "-";
            this.diffButton.UseVisualStyleBackColor = true;
            this.diffButton.Click += new System.EventHandler(this.diffButton_Click);
            // 
            // qoutButton
            // 
            this.qoutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qoutButton.Location = new System.Drawing.Point(444, 55);
            this.qoutButton.Name = "qoutButton";
            this.qoutButton.Size = new System.Drawing.Size(21, 21);
            this.qoutButton.TabIndex = 6;
            this.qoutButton.Text = "/";
            this.qoutButton.UseVisualStyleBackColor = true;
            this.qoutButton.Click += new System.EventHandler(this.qoutButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "First Number:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(193, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Second Number:";
            // 
            // resultTxtBox
            // 
            this.resultTxtBox.Location = new System.Drawing.Point(530, 55);
            this.resultTxtBox.Name = "resultTxtBox";
            this.resultTxtBox.Size = new System.Drawing.Size(100, 20);
            this.resultTxtBox.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(484, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Result:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(648, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 160);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.resultTxtBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.qoutButton);
            this.Controls.Add(this.diffButton);
            this.Controls.Add(this.numTwoTxtBox);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.prodButton);
            this.Controls.Add(this.sumButton);
            this.Controls.Add(this.numOneTxtBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox numOneTxtBox;
        private System.Windows.Forms.Button sumButton;
        private System.Windows.Forms.Button prodButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.TextBox numTwoTxtBox;
        private System.Windows.Forms.Button diffButton;
        private System.Windows.Forms.Button qoutButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox resultTxtBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

