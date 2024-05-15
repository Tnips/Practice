using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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

		private void button1_Click(object sender, EventArgs e)
		{
			treeView1.Nodes.Clear();

			treeView1.Nodes.Add("Фамилия: " + textBox1.Text);
			treeView1.Nodes.Add("Имя: " + textBox2.Text);
			treeView1.Nodes.Add("Отчество: " + textBox3.Text);

			if (radioButton1.Checked)
				treeView1.Nodes.Add("Пол: женский");
			if (radioButton2.Checked)
				treeView1.Nodes.Add("Пол: мужской");

			string day = comboBox1.SelectedItem.ToString();
			string month = comboBox2.SelectedItem.ToString();
			string year = comboBox3.SelectedItem.ToString();
			TreeNode birthdayNode = new TreeNode("День рождения: " + day + " " + month + " " + year);
			treeView1.Nodes.Add(birthdayNode);
			string adres = comboBox4.SelectedItem.ToString();
			TreeNode adresnode = new TreeNode("Адрес проживания: " + adres);
			treeView1.Nodes.Add("Email" + textBox4.Text);
			string tel = comboBox5.SelectedItem.ToString();
			TreeNode telnode= new TreeNode("Мобильный телефон: " + tel);
			treeView1.Nodes.Add("Номер телефона: " + textBox5.Text);

			if (radioButton3.Checked)
				treeView1.Nodes.Add("Прежде не работал");
			if (radioButton4.Checked)
				treeView1.Nodes.Add("Меньше 1 года");
			if (radioButton5.Checked)
				treeView1.Nodes.Add("от 1 года до 5 лет");
			if (radioButton6.Checked)
				treeView1.Nodes.Add("От 5 до 9 лет");
			if (radioButton7.Checked)
				treeView1.Nodes.Add("10 лет и более");
			if (checkBox1.Checked)
			{
				TreeNode node = new TreeNode(checkBox1.Text);
				treeView1.Nodes.Add("Наличие личного авто");
			}
			if (checkBox2.Checked)
			{
				TreeNode node = new TreeNode(checkBox2.Text);
				treeView1.Nodes.Add("Водительское удостоверение");
			}
			if (checkBox3.Checked)
			{
				TreeNode node = new TreeNode(checkBox1.Text);
				treeView1.Nodes.Add("Категоря a");
			}
			if (checkBox4.Checked)
			{
				TreeNode node = new TreeNode(checkBox2.Text);
				treeView1.Nodes.Add("Категоря B");
			}
			if (checkBox5.Checked)
			{
				TreeNode node = new TreeNode(checkBox1.Text);
				treeView1.Nodes.Add("Категория C");
			}
			if (checkBox6.Checked)
			{
				TreeNode node = new TreeNode(checkBox2.Text);
				treeView1.Nodes.Add("Категория D");
			}
			int value = (int)numericUpDown1.Value;
			TreeNode nodenumer = new TreeNode("объем заработной платы от: " + value.ToString());
			treeView1.Nodes.Add(nodenumer);
			int values = (int)numericUpDown2.Value;
			TreeNode nodenumers = new TreeNode("объем заработной платы До: " + value.ToString());
			treeView1.Nodes.Add(nodenumers);
			if (radioButton8.Checked)
				treeView1.Nodes.Add("Полная занятость");
			if (radioButton9.Checked)
				treeView1.Nodes.Add("Частичная занятость");
			if (radioButton10.Checked)
				treeView1.Nodes.Add("Работа на дому");
			if (radioButton11.Checked)
				treeView1.Nodes.Add("Посменная работа");
		}

		private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
		{

		}

		private void button2_Click(object sender, EventArgs e)
		{
			textBox1.Clear();
			textBox2.Clear();
			textBox3.Clear();
			textBox4.Clear();
			textBox5.Clear();

			radioButton1.Checked = false;
			radioButton2.Checked = false;
			radioButton3.Checked = false;
			radioButton4.Checked = false;
			radioButton5.Checked = false;
			radioButton6.Checked = false;
			radioButton7.Checked = false;
			radioButton8.Checked = false;
			radioButton9.Checked = false;
			radioButton10.Checked = false;
			radioButton11.Checked = false;

			checkBox1.Checked = false;
			checkBox2.Checked = false;
			checkBox3.Checked = false;
			checkBox4.Checked = false;
			checkBox5.Checked = false;
			checkBox6.Checked = false;

			comboBox1.SelectedIndex = -1;
			comboBox2.SelectedIndex = -1;
			comboBox3.SelectedIndex = -1;
			comboBox4.SelectedIndex = -1;
			comboBox5.SelectedIndex = -1;

			numericUpDown1.Value = numericUpDown1.Minimum;
			numericUpDown2.Value = numericUpDown2.Minimum;

			treeView1.Nodes.Clear();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
