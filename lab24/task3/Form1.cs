﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task3
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();

			CustomLabel customLabel = new CustomLabel();
			customLabel.Text = "Привет, мир!";
			customLabel.Location = new Point(50, 50);

			this.Controls.Add(customLabel);
		}
	}
}
