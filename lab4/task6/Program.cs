using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task6 
//1.Операция деления выполняется внутри блока try.
// f = 1, так как оно инициализируется вне цикла и умножается на i внутри цикла.
// f - 1 = 0, и деление на ноль не происходит.
//Поэтому исключение DivideByZeroException не генерируется.

{
	internal class Program
	{
		static void Main()
		{
			try
			{
				genException();
			}
			catch (DivideByZeroException)
			{
				Console.WriteLine("Обработка исключения: Деление на 0");
			}
			catch
			{
				Console.WriteLine("НЕИСПРАВИМАЯ ОШИБКА!!!");
			}
			Console.ReadLine();
		}

		static void genException()
		{
			Console.WriteLine("a = ");
			double a = double.Parse(Console.ReadLine());
			Console.WriteLine("b = ");
			double b = double.Parse(Console.ReadLine());
			int f = 1;
			try
			{
				for (double i = a; i <= b; ++i)
				{
					try
					{
						f = checked((int)(f * i));
						double result = 100 / (f - 1);
						if (Math.Abs(f - 1) < 0.000001)
						{
							throw new DivideByZeroException();
						}
						Console.WriteLine("y({0}) = {1:f6}", i, result);
					}
					catch (DivideByZeroException)
					{
						Console.WriteLine("y({0}) = Деление на 0", i);
					}
				}
			}
			catch (ArithmeticException)
			{
				Console.WriteLine("ERROR");
				throw; 
			}
		}
	}
}

