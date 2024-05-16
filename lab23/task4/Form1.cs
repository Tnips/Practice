using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace task4
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

		private void createButton_Click(object sender, EventArgs e)
		{
			string input = inputBox.Text.ToUpper();
			string xText = xCoordBox.Text;
			string yText = yCoordBox.Text;

			if (string.IsNullOrWhiteSpace(xText) || string.IsNullOrWhiteSpace(yText))
			{
				MessageBox.Show("Пожалуйста, введите координаты.");
				return;
			}

			int x = int.Parse(xText);
			int y = int.Parse(yText);


			Control control = null;

			switch (input)
			{
				case "К":
					control = new Button { Text = "Кнопка", Location = new Point(x, y) };
					break;
				case "П":
					control = new TextBox { Location = new Point(x, y) };
					break;
				case "М":
					control = new Label { Text = "Метка", Location = new Point(x, y) };
					break;
				default:
					MessageBox.Show("Ошибка: неверный ввод. Пожалуйста, введите 'К', 'П' или 'М'.");
					return;
			}

			if (control != null)
			{
				Controls.Add(control);
			}
		}
	}
}
