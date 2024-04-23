using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace task4
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Введите текст:");
			string text = Console.ReadLine(); 

			Regex regex = new Regex(@"#\w+");

			MatchCollection matches = regex.Matches(text);
			foreach (Match match in matches)
			{
				Console.WriteLine(match.Value);
			}

			Console.ReadLine();
		}
	}
}
