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
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			foreach (var item in listBox1.Items)
			{
				string binaryString = item.ToString();
				int zeroCount = binaryString.Count(c => c == '0');
				int oneCount = binaryString.Count(c => c == '1');

				label1.Text += $"Строка: {binaryString}, Нулей: {zeroCount}, Единиц: {oneCount}\n";

			}
		}
	}
}
