using System;
using System.Windows.Forms;
using System.Data;
using System.Diagnostics;

namespace Calculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            button3 = new System.Windows.Forms.Button();
            button4 = new System.Windows.Forms.Button();
            button6 = new System.Windows.Forms.Button();
            button7 = new System.Windows.Forms.Button();
            button8 = new System.Windows.Forms.Button();
            button9 = new System.Windows.Forms.Button();
            button10 = new System.Windows.Forms.Button();
            button11 = new System.Windows.Forms.Button();
            button13 = new System.Windows.Forms.Button();
            button14 = new System.Windows.Forms.Button();
            button15 = new System.Windows.Forms.Button();
            button16 = new System.Windows.Forms.Button();
            button17 = new System.Windows.Forms.Button();
            button5 = new System.Windows.Forms.Button();
            textBox1 = new System.Windows.Forms.TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(21, 64);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(54, 29);
            button1.TabIndex = 0;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Operation;
            // 
            // button2
            // 
            button2.Location = new System.Drawing.Point(21, 99);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(54, 29);
            button2.TabIndex = 1;
            button2.Text = "4";
            button2.UseVisualStyleBackColor = true;
            button2.Click += Operation;
            // 
            // button3
            // 
            button3.Location = new System.Drawing.Point(21, 134);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(54, 29);
            button3.TabIndex = 2;
            button3.Text = "7";
            button3.UseVisualStyleBackColor = true;
            button3.Click += Operation;
            // 
            // button4
            // 
            button4.Location = new System.Drawing.Point(21, 169);
            button4.Name = "button4";
            button4.Size = new System.Drawing.Size(54, 29);
            button4.TabIndex = 3;
            button4.Text = "0";
            button4.UseVisualStyleBackColor = true;
            button4.Click += Operation;
            // 
            // button6
            // 
            button6.Location = new System.Drawing.Point(81, 134);
            button6.Name = "button6";
            button6.Size = new System.Drawing.Size(54, 29);
            button6.TabIndex = 5;
            button6.Text = "8";
            button6.UseVisualStyleBackColor = true;
            button6.Click += Operation;
            // 
            // button7
            // 
            button7.Location = new System.Drawing.Point(81, 99);
            button7.Name = "button7";
            button7.Size = new System.Drawing.Size(54, 29);
            button7.TabIndex = 6;
            button7.Text = "5";
            button7.UseVisualStyleBackColor = true;
            button7.Click += Operation;
            // 
            // button8
            // 
            button8.Location = new System.Drawing.Point(81, 64);
            button8.Name = "button8";
            button8.Size = new System.Drawing.Size(54, 29);
            button8.TabIndex = 7;
            button8.Text = "2";
            button8.UseVisualStyleBackColor = true;
            button8.Click += Operation;
            // 
            // button9
            // 
            button9.Location = new System.Drawing.Point(141, 64);
            button9.Name = "button9";
            button9.Size = new System.Drawing.Size(54, 29);
            button9.TabIndex = 8;
            button9.Text = "3";
            button9.UseVisualStyleBackColor = true;
            button9.Click += Operation;
            // 
            // button10
            // 
            button10.Location = new System.Drawing.Point(141, 99);
            button10.Name = "button10";
            button10.Size = new System.Drawing.Size(54, 29);
            button10.TabIndex = 9;
            button10.Text = "6";
            button10.UseVisualStyleBackColor = true;
            button10.Click += Operation;
            // 
            // button11
            // 
            button11.Location = new System.Drawing.Point(141, 134);
            button11.Name = "button11";
            button11.Size = new System.Drawing.Size(54, 29);
            button11.TabIndex = 10;
            button11.Text = "9";
            button11.UseVisualStyleBackColor = true;
            button11.Click += Operation;
            // 
            // button13
            // 
            button13.Location = new System.Drawing.Point(239, 64);
            button13.Name = "button13";
            button13.Size = new System.Drawing.Size(54, 29);
            button13.TabIndex = 12;
            button13.Text = "+";
            button13.UseVisualStyleBackColor = true;
            button13.Click += Operation;
            // 
            // button14
            // 
            button14.Location = new System.Drawing.Point(239, 99);
            button14.Name = "button14";
            button14.Size = new System.Drawing.Size(54, 29);
            button14.TabIndex = 13;
            button14.Text = "-";
            button14.UseVisualStyleBackColor = true;
            button14.Click += Operation;
            // 
            // button15
            // 
            button15.Location = new System.Drawing.Point(239, 134);
            button15.Name = "button15";
            button15.Size = new System.Drawing.Size(54, 29);
            button15.TabIndex = 14;
            button15.Text = "*";
            button15.UseVisualStyleBackColor = true;
            button15.Click += Operation;
            // 
            // button16
            // 
            button16.Location = new System.Drawing.Point(239, 169);
            button16.Name = "button16";
            button16.Size = new System.Drawing.Size(54, 29);
            button16.TabIndex = 15;
            button16.Text = "/";
            button16.UseVisualStyleBackColor = true;
            button16.Click += Operation;
            // 
            // button17
            // 
            button17.Location = new System.Drawing.Point(81, 169);
            button17.Name = "button17";
            button17.Size = new System.Drawing.Size(114, 29);
            button17.TabIndex = 16;
            button17.Text = "=";
            button17.UseVisualStyleBackColor = true;
            button17.Click += Equals;
            // 
            // button5
            // 
            button5.Location = new System.Drawing.Point(21, 204);
            button5.Name = "button5";
            button5.Size = new System.Drawing.Size(174, 23);
            button5.TabIndex = 17;
            button5.Text = "Clear";
            button5.UseVisualStyleBackColor = true;
            button5.Click += Clear;
            // 
            // textBox1
            // 
            textBox1.Location = new System.Drawing.Point(21, 22);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(272, 23);
            textBox1.TabIndex = 18;
            textBox1.Text = "0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(323, 263);
            Controls.Add(textBox1);
            Controls.Add(button5);
            Controls.Add(button17);
            Controls.Add(button16);
            Controls.Add(button15);
            Controls.Add(button14);
            Controls.Add(button13);
            Controls.Add(button11);
            Controls.Add(button10);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        private string currentCalculation;

        private void Operation(object sender, System.EventArgs e)
        {
            // Each time a button is clicked it appends the name of said button to the 'currentCalculation'
            currentCalculation += (sender as Button).Text;

            // On top of that it also sets the text box to the 'currentCalculation'
            textBox1.Text = currentCalculation;
        }

        private void Equals(object sender, System.EventArgs e)
        {
            try
            {
                // Using DataTable we can pass an operation such as '2*2' and it will compute and return 4 (for this example)
                textBox1.Text = new DataTable().Compute(currentCalculation, null).ToString();

                currentCalculation = textBox1.Text;
            }
            catch (Exception)
            {
                textBox1.Text = "0";
                currentCalculation = "";
            }
        }

        private void Clear(object sender, System.EventArgs e)
        {
            // Self explanatory... it resets all the variables to zero and an empty string
            textBox1.Text = "0";
            currentCalculation = "";
        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox textBox1;
    }
}
