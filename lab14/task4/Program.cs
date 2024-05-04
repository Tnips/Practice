using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
	internal class Program
	{
		static void Main()
		{
			int n = 100; 
			int[] numbers = Enumerable.Range(1, n).ToArray(); 
			int numberOfThreads = Environment.ProcessorCount; 

			Task<int>[] tasks = new Task<int>[numberOfThreads];
			for (int i = 0; i < numberOfThreads; i++)
			{
				int start = i * numbers.Length / numberOfThreads;
				int end = (i + 1) * numbers.Length / numberOfThreads;
				tasks[i] = Task.Run(() => SumEvenNumbers(numbers, start, end));
			}

			Task.WaitAll(tasks);

			int totalSum = tasks.Sum(t => t.Result);
			Console.WriteLine($"Общая сумма: {totalSum}");
			Console.ReadLine();
		}

		static int SumEvenNumbers(int[] numbers, int start, int end)
		{
			int sum = 0;
			for (int i = start; i < end; i++)
			{
				if (numbers[i] % 2 == 0)
				{
					sum += numbers[i];
				}
			}
			return sum;
		}
	}
}
