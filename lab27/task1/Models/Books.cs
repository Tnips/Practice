	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using System.Threading.Tasks;

	namespace task1.Models
	{
		internal class Books
		{
			public string Title { get; set; } // Название книги
			public string Author { get; set; } // Автор книги
			public double Year { get; set; } // Год издания

			public override string ToString()
			{
				return new StringBuilder()
					.AppendLine($"---> Название книги: {Title}")
					.AppendLine($"\t Автор: {Author}")
					.AppendLine($"\t Год издания: {Year}")
					.ToString();
			}
		}
	}
