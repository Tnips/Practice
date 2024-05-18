using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using Microsoft.Extensions.Logging;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using task1.Interfaces;
using task1.Share;
using task1.Models;
using Microsoft.Win32;

namespace task1
{
	/// <summary>
	/// Логика взаимодействия для MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		private readonly IXmlWorker _worker;
		private readonly ILogger _logger;
		public bool IsFileOpened = false;
		private string _xmlFilePath;

		public MainWindow()
		{
			InitializeComponent();
			_logger = LoggerFactory.Create(builder => builder.SetMinimumLevel(LogLevel.Information)) .CreateLogger<MainWindow>();
			XmlDocumentWorker xmlDocumentWorker = new XmlDocumentWorker(_logger);
			_worker = (IXmlWorker)xmlDocumentWorker;

		}

		private void buttonFindCountryName_Click(object sender, RoutedEventArgs e)
		{
			var books = _worker.GetAll().Find(book => book.Title == textBoxCountryName.Text);
			PrintBooks(books);
		}

		private void buttonAdd_Click(object sender, RoutedEventArgs e)
		{
			AddBooks addBooks = new AddBooks();
			addBooks.Show();
			PrintBookss(_worker.GetAll());
		}

		private void buttonExit_Click(object sender, RoutedEventArgs e)
		{
			this.Close();
		}

		private void buttonDelete_Click(object sender, RoutedEventArgs e)
		{
			string titleToDelete = textBoxDeleteCountryName.Text.Trim();
			if (string.IsNullOrWhiteSpace(titleToDelete))
			{
				MessageBox.Show("Введите название книги для удаления.");
				return;
			}

			try
			{
				_worker.Delete(titleToDelete);
				PrintBookss(_worker.GetAll());
				MessageBox.Show("Книга успешно удалена.");
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Ошибка при удалении книги: {ex.Message}");
			}
		}

		private void PrintBooks(Books books)
		{
			textBlockXMLFileContent.Text = "=====Books====="
				+Environment.NewLine;
			textBlockXMLFileContent.Text += books?.ToString() ?? "Книга не найдена";

		}
		private void PrintBookss(List<Books> bookss)
		{
			StringBuilder sb = new StringBuilder();
			sb.AppendLine("=====Bookss=====");
			sb.AppendLine();

			foreach (var books in bookss)
			{
				sb.AppendLine(books.ToString());
			}

			textBlockXMLFileContent.Text = sb.ToString(); // Заменяем текст в TextBlock на новый
		}


		private void buttonOpenFile_Click(object sender, RoutedEventArgs e)
		{
			var dialog = new OpenFileDialog();
			dialog.InitialDirectory = Directory.GetParent(AppContext.BaseDirectory)
				.Parent
				.Parent
				.FullName;
			dialog.DefaultExt = ".xml";
			dialog.Filter = "xml documents (.xml)|*.xml";
			var result = dialog.ShowDialog();
			if (result.HasValue && result.Value)
			{
				_xmlFilePath = dialog.FileName;
				textBlockXMLPathFile.Text = _xmlFilePath;
				_worker.Load(_xmlFilePath);
				PrintBookss(_worker.GetAll());
			}
		}
	}
}
