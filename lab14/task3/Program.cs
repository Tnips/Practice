using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace task3
{
	internal class Program
	{
		static object lockObject = new object();

		static void Main()
		{
			Console.Write("Введите значение A: ");
			int A = Convert.ToInt32(Console.ReadLine());

			Console.Write("Введите значение N: ");
			int N = Convert.ToInt32(Console.ReadLine());

			Thread thread1 = new Thread(() => Sum(A, N));
			Thread thread2 = new Thread(() => Sum(A, N));
			Thread thread3 = new Thread(() => Multiply(A, N));

			thread1.Start();
			thread2.Start();
			thread3.Start();

			thread1.Join();
			thread2.Join();
			thread3.Join();
			Console.ReadLine();
		}

		static void Sum(int A, int N)
		{
			int result = 0;
			for (int i = 1; i <= N; i++)
			{
				result += A + i;
			}

			Console.WriteLine($"Сумма: {result}");
		}

		static void Multiply(int A, int N)
		{
			lock (lockObject)
			{
				int result = 1;
				for (int i = 1; i <= N; i++)
				{
					result *= A * i;
				}

				Console.WriteLine($"Произведение: {result}");
			}
		}
	}
}
