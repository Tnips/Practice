using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task2
{
	public partial class Form1 : Form
	{
		private RadioButton rb1, rb2, rb3;
		private System.Windows.Forms.Label label;
		public Form1()
		{
			this.BackColor = Color.White;
			this.Font = new Font("Arial", 10);

			rb1 = new RadioButton() { Text = "sh(x)", Location = new Point(10, 10) };
			rb2 = new RadioButton() { Text = "x^2", Location = new Point(10, 50) };
			rb3 = new RadioButton() { Text = "e^x", Location = new Point(10, 90) };
			label = new System.Windows.Forms.Label() { Location = new Point(10, 130), Width = 200 }; ;

			rb1.CheckedChanged += (sender, e) => UpdateLabel(Math.Sinh(1)); 
			rb2.CheckedChanged += (sender, e) => UpdateLabel(Math.Pow(1, 2)); 
			rb3.CheckedChanged += (sender, e) => UpdateLabel(Math.Exp(1)); 

			this.Controls.Add(rb1);
			this.Controls.Add(rb2);
			this.Controls.Add(rb3);
			this.Controls.Add(label);
		}

		private void UpdateLabel(double value)
		{
			label.Text = "f(1) = " + value.ToString();
		}


		private void Form1_Load(object sender, EventArgs e)
		{

		}
	}
}
