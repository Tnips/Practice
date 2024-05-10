using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
	public class Task
	{
		private int number;

		public Task(int number)
		{
			if (number < 1000 || number > 9999)
			{
				throw new ArgumentException("Номер должен быть четырехзначным.");
			}
			this.number = number;
		}

		public int SumDigits()
		{
			int sum = 0;
			int n = number;
			while (n != 0)
			{
				sum += n % 10;
				n /= 10;
			}
			return sum;
		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			Task task1 = new Task(1234);
			Console.WriteLine(task1.SumDigits());

			Task task2 = new Task(5678);
			Console.WriteLine(task2.SumDigits());

			Task task3 = new Task(9012);
			Console.WriteLine(task3.SumDigits());
			Console.ReadLine();
		}
	}
}
