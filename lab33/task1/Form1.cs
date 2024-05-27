using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace task1
{
	public partial class Form1 : Form
	{
		private DataSet dataSet;
		private BindingSource bindingSource1;
		private BindingSource bindingSource2;
		public Form1()
		{
			InitializeComponent();
			InitializeBindings();
			LoadData();
			BindData();
		}

		private void InitializeBindings()
		{
			bindingSource1 = new BindingSource();
			bindingSource2 = new BindingSource();

			dataGridView1.DataSource = bindingSource1;
			dataGridView2.DataSource = bindingSource2;
			bindingNavigator1.BindingSource = bindingSource1;
		}

		private void LoadData()
		{
			string connectionString = ConfigurationManager.ConnectionStrings["DbConnectionString"].ConnectionString;

			using (OleDbConnection connection = new OleDbConnection(connectionString))
			{
				dataSet = new DataSet();
				FillDataSet(connection, "Туристы");
				FillDataSet(connection, "Туры");
			}
		}

		private void FillDataSet(OleDbConnection connection, string tableName)
		{
			OleDbDataAdapter adapter = new OleDbDataAdapter($"SELECT * FROM {tableName}", connection);
			adapter.Fill(dataSet, tableName);
		}

		private void BindData()
		{
			bindingSource1.DataSource = dataSet.Tables["Туристы"];
			bindingSource2.DataSource = dataSet.Tables["Туры"];

			BindTextBox(textBox1, bindingSource1, "Фамилия");
			BindTextBox(textBox2, bindingSource1, "Имя");
			BindTextBox(textBox3, bindingSource1, "Отчество");
		}

		private void BindTextBox(TextBox textBox, BindingSource bindingSource, string dataMember)
		{
			textBox.DataBindings.Clear();
			textBox.DataBindings.Add("Text", bindingSource, dataMember);
		}

		private void dataGridView1_SelectionChanged(object sender, EventArgs e)
		{

		}

		private void UpdateTextBoxes(DataRow row)
		{
			textBox1.Text = row["Фамилия"].ToString();
			textBox2.Text = row["Имя"].ToString();
			textBox3.Text = row["Отчество"].ToString();
		}
	}
}
