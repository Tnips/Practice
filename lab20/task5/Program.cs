using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace task5
{
	internal class Program
	{
		static void Main(string[] args)
		{
			List<int> numbers = new List<int> { 1, 5, 8, 40, 70 };
			CancellationTokenSource cts = new CancellationTokenSource();

			try
			{
				Parallel.ForEach(numbers, new ParallelOptions { CancellationToken = cts.Token }, num =>
				{
					int sum = 0;
					int product = 1;
					for (int i = 0; i <= num; i++)
					{
						sum += i;
						product *= i > 0 ? i : 1; 

						if (sum > 100 || product > 100)
						{
							Console.WriteLine($"Операция отменена под номером: {num}");
							cts.Cancel();
						}
					}

					if (!cts.Token.IsCancellationRequested)
					{
						Console.WriteLine($"Number: {num}, Sum: {sum}, Product: {product}");
					}
				});
			}
			catch (OperationCanceledException)
			{
				Console.WriteLine("Итерация отменена");
			}
			finally
			{
				cts.Dispose();
			}
			Console.ReadLine();
		}
	}
}
