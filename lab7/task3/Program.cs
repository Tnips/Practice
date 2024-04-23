﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace task3
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Введите текст:");
			string text = Console.ReadLine(); 

			Regex regex = new Regex(@"\b([1-9][0-9]?|100)\b");

			MatchCollection matches = regex.Matches(text);
			foreach (Match match in matches)
			{
				Console.WriteLine(match.Value);
			}

			Console.ReadLine();
		}
	}
}
