using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
	internal class Program
	{
		delegate int RandomDelegate();

		static void Main(string[] args)
		{
			RandomDelegate[] delegatesArray = new RandomDelegate[5];

			Random random = new Random();
			for (int i = 0; i < delegatesArray.Length; i++)
			{
				delegatesArray[i] = () => random.Next(1, 101);
			}

			Console.WriteLine("Массив случайных чисел:");
			foreach (var del in delegatesArray)
			{
				Console.Write(del.Invoke() + " ");
			}
			Console.WriteLine();

			Func<RandomDelegate[], double> averageMethod = (delegates) =>
			{
				int sum = 0;
				foreach (var del in delegates)
				{
					sum += del.Invoke();
				}
				return (double)sum / delegates.Length;
			};

			double average = averageMethod(delegatesArray);
			Console.WriteLine($"Среднее арифметическое: {average}");

			Console.ReadLine();
		}
	}
}
