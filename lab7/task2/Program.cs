using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace task2
{
	internal class Program
	{
		static void Main()
		{
			Console.WriteLine("Введите текст:");
			string text = Console.ReadLine(); 

			Regex regex = new Regex(@"\b[а-я]*([а-я])\1[а-я]*\b", RegexOptions.IgnoreCase);

			MatchCollection matches = regex.Matches(text);
			foreach (Match match in matches)
			{
				Console.WriteLine(match.Value);
			}

			Console.ReadLine();
		}
	}
}
