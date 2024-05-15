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
		private TextBox textBox;
		private Button calculateButton;
		private NumericUpDown aInput, bInput, cInput, x0Input, xkInput, dxInput;

		public Form1()
		{
			this.Size = new Size(400, 600);
			// Установка начального цвета формы и шрифта
			this.BackColor = Color.White;
			this.Font = new Font("Arial", 10);

			// Создание элементов управления
			aInput = new NumericUpDown() { Location = new Point(10, 10), DecimalPlaces = 2, Increment = 0.01M, Minimum = -10M, Value = -1.25M};
			bInput = new NumericUpDown() { Location = new Point(10, 50), DecimalPlaces = 2, Increment = 0.01M, Minimum = -10M, Value = -1.5M };
			cInput = new NumericUpDown() { Location = new Point(10, 90), DecimalPlaces = 2, Increment = 0.01M, Value = 0.75M };
			x0Input = new NumericUpDown() { Location = new Point(10, 130), DecimalPlaces = 2, Increment = 0.01M, Minimum = -10M,  Value = -1.5M };
			xkInput = new NumericUpDown() { Location = new Point(10, 170), DecimalPlaces = 2, Increment = 0.01M, Value = 3.5M };
			dxInput = new NumericUpDown() { Location = new Point(10, 210), DecimalPlaces = 2, Increment = 0.01M, Value = 0.5M };
			calculateButton = new Button() { Text = "Вычислить", Location = new Point(10, 250) };
			textBox = new TextBox() { Location = new Point(10, 290), Width = 200, Height = 200, Multiline = true, ScrollBars = ScrollBars.Vertical };

			calculateButton.Click += (sender, e) => Calculate();

			this.Controls.Add(aInput);
			this.Controls.Add(bInput);
			this.Controls.Add(cInput);
			this.Controls.Add(x0Input);
			this.Controls.Add(xkInput);
			this.Controls.Add(dxInput);
			this.Controls.Add(calculateButton);
			this.Controls.Add(textBox);
		}

		private void Calculate()
		{
			double a = (double)aInput.Value, b = (double)bInput.Value, c = (double)cInput.Value;
			double x0 = (double)x0Input.Value, xk = (double)xkInput.Value, dx = (double)dxInput.Value;

			textBox.Clear();
			for (double x = x0; x <= xk; x += dx)
			{
				double y = Math.Pow(10, -2) * (b * c / x) + Math.Cos(Math.Sqrt(a * x));
				textBox.AppendText($"x = {x}, y(x) = {y}\r\n");
			}
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}
	}
}
