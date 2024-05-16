using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Forms;

namespace task2
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void StartButton_Click_1(object sender, EventArgs e)
		{
			double xmin = double.Parse(xminBox.Text);
			double xmax = double.Parse(xmaxBox.Text);
			double h = double.Parse(stepBox.Text);

			double a = 1.0;
			double b = 0.0;

			chart.Series["Series1"].Points.Clear();

			for (double x = xmin; x <= xmax; x += h)
			{
				double y = a * x + b;
				chart.Series["Series1"].Points.AddXY(x, y);
			}
		}
	}
}
