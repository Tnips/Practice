using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace task1
{
	public partial class AddBooks : Form
	{
		public AddBooks()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			// Считываем данные из элементов интерфейса
			string title = textBox1.Text;
			string author = textBox2.Text;
			string yearString = comboBox1.SelectedItem.ToString();
			double year;

			if (!double.TryParse(yearString, out year))
			{
				MessageBox.Show("Invalid year format.");
				return;
			}

			string xmlFilePath = "Books.xml";

			// Создаем новый XML документ или загружаем существующий
			XmlDocument xmlDoc = new XmlDocument();
			if (File.Exists(xmlFilePath))
			{
				xmlDoc.Load(xmlFilePath);
			}
			else
			{
				XmlDeclaration xmlDeclaration = xmlDoc.CreateXmlDeclaration("1.0", "UTF-8", null);
				XmlElement root = xmlDoc.DocumentElement;
				xmlDoc.InsertBefore(xmlDeclaration, root);

				XmlElement newRoot = xmlDoc.CreateElement(string.Empty, "Books", string.Empty);
				xmlDoc.AppendChild(newRoot);
			}

			// Создаем новый элемент книги
			XmlElement bookElement = xmlDoc.CreateElement("Book");

			XmlElement titleElement = xmlDoc.CreateElement("Title");
			titleElement.InnerText = title;
			bookElement.AppendChild(titleElement);

			XmlElement authorElement = xmlDoc.CreateElement("Author");
			authorElement.InnerText = author;
			bookElement.AppendChild(authorElement);

			XmlElement yearElement = xmlDoc.CreateElement("Year");
			yearElement.InnerText = year.ToString();
			bookElement.AppendChild(yearElement);

			// Добавляем элемент книги к корневому элементу
			XmlElement rootElement = xmlDoc.DocumentElement;
			rootElement.AppendChild(bookElement);

			// Сохраняем изменения в файл
			xmlDoc.Save(xmlFilePath);

			MessageBox.Show("Book added successfully.");

			this.Close();
		}
	}
}
