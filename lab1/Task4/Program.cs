using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
	internal class Program
	{
		static void Main(string[] args)
		{
			PrintNumberSeriesUsingWhile();
			Console.WriteLine(); 

			PrintNumberSeriesUsingDoWhile();
			Console.WriteLine(); 

			PrintNumberSeriesUsingFor();
			Console.WriteLine();

			Console.ReadLine();
		}

		static void PrintNumberSeriesUsingWhile()
		{
			int number = 1;
			while (number <= 101)
			{
				Console.Write($"{number} ");
				number += 2;
			}
		}

		static void PrintNumberSeriesUsingDoWhile()
		{
			int number = 1;
			do
			{
				Console.Write($"{number} ");
				number += 2;
			} while (number <= 101);
		}

		static void PrintNumberSeriesUsingFor()
		{
			for (int number = 1; number <= 101; number += 2)
			{
				Console.Write($"{number} ");
			}
		}
	}
}
