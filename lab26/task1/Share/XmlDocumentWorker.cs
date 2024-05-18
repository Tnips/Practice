using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml;
using task1.Interfaces;
using Microsoft.Extensions.Logging;
using task1.Models;

namespace task1.Share
{
	internal class XmlDocumentWorker: IXmlWorker
	{
		private readonly XmlDocument _document;

		private readonly ILogger _logger;

		private string _xmlFilePath;

		public XmlDocumentWorker(ILogger logger)
		{

			_logger = logger;

			_document = new XmlDocument();
		}

		public void Add(Books books)

		{
			var xRoot = _document.DocumentElement;

			XmlElement booksElem = _document.CreateElement("books");

			XmlAttribute titleAttribute = _document.CreateAttribute("Title");

			XmlText titleText = _document.CreateTextNode(books.Title);
			titleAttribute.AppendChild(titleText);

			XmlElement authorElem = _document.CreateElement("Author");

			XmlText authorText = _document.CreateTextNode(books.Author.ToString());
			authorElem.AppendChild(authorText);
			booksElem.AppendChild(authorElem);

			XmlElement yearElem = _document.CreateElement("Year");

			XmlText yearText = _document.CreateTextNode(books.Year.ToString());

			yearElem.AppendChild(yearText);

			booksElem.AppendChild(yearElem);
			xRoot.AppendChild(booksElem);

			_document.Save(_xmlFilePath);
		}
		public void Delete(string title)
		{
			var xRoot = _document.DocumentElement;
			if (xRoot == null)
			{
				_logger.LogWarning("Document root is null.");
				return;
			}

			foreach (XmlNode bookNode in xRoot.SelectNodes("//Book"))
			{
				var titleNode = bookNode.SelectSingleNode("Title");
				if (titleNode != null && titleNode.InnerText == title)
				{
					xRoot.RemoveChild(bookNode);
					_document.Save(_xmlFilePath); // Save changes after deletion
					_logger.LogInformation($"Book with title '{title}' removed.");
					return;
				}
			}

			_logger.LogWarning($"Book with title '{title}' not found.");
		}


		public Books FindBy(string title)
		{
			Books books = null;

			var xRoot = _document.DocumentElement;

			if (xRoot == null)
			{
				_logger.LogWarning("Document root is null. Ensure the XML document is loaded properly.");
				return null;
			}

			foreach (XmlNode xmlNode in xRoot.ChildNodes)
			{
				books = GetBooks(xmlNode);

				if (books != null && books.Title != null && books.Title.Equals(title))
				{
					return books;
				}
			}

			return null;

		}
		public List<Books> GetAll()
		{

			List<Books> booksList = new List<Books>();

			var xRoot = _document.DocumentElement;

			if (xRoot == null)
			{
				_logger.LogWarning("Document root is null. Ensure the XML document is loaded properly.");
				return booksList;
			}

			foreach (XmlNode node in xRoot.ChildNodes)
			{
				var book = GetBooks(node);
				booksList.Add(book);
			}

			return booksList;

		}
		public void Load(string xmlFilePath)

		{

			_xmlFilePath = xmlFilePath;

			_document.Load(xmlFilePath);

		}
		private Books GetBooks(XmlNode node)

		{

			var books = new Books();

			if (node.Attributes.Count > 0)

			{

				var attributeTitle = node.Attributes.GetNamedItem("Title");

				books.Title = attributeTitle?.Value;

			}

			foreach (XmlNode childNode in node.ChildNodes)

			{

				try

				{
					if (childNode.Name.Equals("Title"))
					{
						books.Title = childNode.InnerText;
					}
					if (childNode.Name.Equals("Author"))

					{

						books.Author = (childNode.InnerText).ToString();

					}
					if (childNode.Name.Equals("Year"))

					{

						books.Year = double.Parse(childNode.InnerText);

					}

				}

				catch (Exception ex) when (ex is FormatException || ex is NullReferenceException)

				{

					_logger.LogError(ex.Message, ex.StackTrace, nameof(childNode.InnerText));

				}

			}
			return books;
			
		}
	}
}
