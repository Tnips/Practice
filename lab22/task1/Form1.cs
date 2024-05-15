using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task1
{
	public partial class Form1 : Form
	{
		private TextBox xTextBox;
		private TextBox yTextBox;
		private TextBox zTextBox;
		private TextBox tTextBox;
		private Button calculateButton;
		public Form1()
		{
			this.Text = "Вычисление формулы";

			Label xLabel = new Label { Text = "Введите x:", Left = 50, Top = 20 };
			xTextBox = new TextBox { Left = 150, Top = 20, Width = 100 };

			Label yLabel = new Label { Text = "Введите y:", Left = 50, Top = 50 };
			yTextBox = new TextBox { Left = 150, Top = 50, Width = 100 };

			Label zLabel = new Label { Text = "Введите z:", Left = 50, Top = 80 };
			zTextBox = new TextBox { Left = 150, Top = 80, Width = 100 };

			Label tLabel = new Label { Text = "Результат (t):", Left = 50, Top = 110 };
			tTextBox = new TextBox { Left = 150, Top = 110, Width = 100 };

			calculateButton = new Button { Text = "Вычислить", Left = 50, Top = 140, Width = 100 };

			this.Controls.Add(xLabel);
			this.Controls.Add(xTextBox);
			this.Controls.Add(yLabel);
			this.Controls.Add(yTextBox);
			this.Controls.Add(zLabel);
			this.Controls.Add(zTextBox);
			this.Controls.Add(tLabel);
			this.Controls.Add(tTextBox);
			this.Controls.Add(calculateButton);

			calculateButton.Click += new EventHandler(calculateButton_Click);
		}

		private void calculateButton_Click(object sender, EventArgs e)
		{
			try
			{
				double x = double.Parse(xTextBox.Text);
				double y = double.Parse(yTextBox.Text);
				double z = double.Parse(zTextBox.Text) * Math.Pow(10, -2);

				double t = 2 * Math.Cos((x - Math.PI) / 6) * (1 + Math.Pow(z, 2) / (3 - Math.Pow(z, 2) / 5)) / (0.5 + Math.Pow(Math.Sin(y), 2));

				tTextBox.Text = t.ToString();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Ошибка: " + ex.Message);
			}
		}
		private void Form1_Load(object sender, EventArgs e)
		{

		}

	}
}
