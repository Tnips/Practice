using System;
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
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
			using (Graphics g = Graphics.FromImage(bmp))
			{
				Pen pen = new Pen(Color.Black);

				SolidBrush roofBrush = new SolidBrush(Color.Brown); 
				Point[] roofPoints = { new Point(150, 100), new Point(250, 100), new Point(200, 50) };
				g.FillPolygon(roofBrush, roofPoints);
				g.DrawPolygon(pen, roofPoints);

				SolidBrush wallBrush = new SolidBrush(Color.Beige); 
				g.FillRectangle(wallBrush, 150, 100, 100, 100);
				g.DrawRectangle(pen, 150, 100, 100, 100);

				SolidBrush doorBrush = new SolidBrush(Color.Brown); 
				g.FillRectangle(doorBrush, 190, 150, 20, 50);
				g.DrawRectangle(pen, 190, 150, 20, 50);

				SolidBrush windowBrush = new SolidBrush(Color.LightBlue); 
				g.FillRectangle(windowBrush, 220, 120, 20, 20);
				g.DrawRectangle(pen, 220, 120, 20, 20);
			}

			pictureBox1.Image = bmp;

		}
	}
}
