using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task9
{
	//<summary>
	//Главный класс программы.
	//</summary>
	//<remarks>
	//Этот класс содержит метод Main, который является точкой входа в программу.
	//</remarks>
	public class Program
	{
		/// <summary>
		/// Делегат для функций генерации случайных чисел.
		/// </summary>
		public delegate int RandomDelegate();

		/// <summary>
		/// Точка входа в программу.
		/// </summary>
		/// <param name="args">Массив аргументов командной строки.</param>
		public static void Main(string[] args)
		{
			/// <summary>
			/// Массив делегатов, каждый из которых генерирует случайное число.
			/// </summary>
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

			/// <summary>
			/// Функция, вычисляющая среднее значение массива случайных чисел.
			/// </summary>
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
