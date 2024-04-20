using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task6
{
	internal class Program
	{
		static void Main()
		{
			int n = 7; 
			int[,] spiralArray = new int[n, n];
			int num = 1; 

			int rowStart = 0;
			int rowEnd = n - 1;
			int colStart = 0;
			int colEnd = n - 1;

			while (num <= n * n)
			{
				for (int i = colStart; i <= colEnd; i++)
				{
					spiralArray[rowStart, i] = num++;
				}
				rowStart++;

				for (int i = rowStart; i <= rowEnd; i++)
				{
					spiralArray[i, colEnd] = num++;
				}
				colEnd--;

				for (int i = colEnd; i >= colStart; i--)
				{
					spiralArray[rowEnd, i] = num++;
				}
				rowEnd--;

				for (int i = rowEnd; i >= rowStart; i--)
				{
					spiralArray[i, colStart] = num++;
				}
				colStart++;
			}

			for (int i = 0; i < n; i++)
			{
				for (int j = 0; j < n; j++)
				{
					Console.Write(spiralArray[i, j] + "\t");
				}
				Console.WriteLine();
			}
			Console.ReadLine();
		}
	}
}
