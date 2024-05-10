using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
	public class TaskObject
	{
		private int number;

		public TaskObject(int number)
		{
			if (number < 10 || number > 99)
			{
				throw new ArgumentException("Число должно быть двухзначным ");
			}
			this.number = number;
		}

		public (int, int) CalculateDigits()
		{
			int firstDigit = number / 10;
			int lastDigit = number % 10;
			return (firstDigit, lastDigit);
		}
	}

	internal class Program
	{
		static void Main(string[] args)
		{
			TaskObject taskObject = new TaskObject(42);

			Task<(int, int)> task1 = Task.Run(() => taskObject.CalculateDigits());

			Task task2 = task1.ContinueWith(t =>
			{
				Console.WriteLine($"Первая цифра: {t.Result.Item1}, Последняя цифра: {t.Result.Item2}");
			});

			Task.WaitAll(task1, task2);
			Console.ReadLine();
		}
	}
}
