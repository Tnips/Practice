using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5
{
	internal class Program
	{
		static void Main()
		{
			byte n = 1; byte i;
			try
			{
				checked //блок с проверкой
				{
					for (i = 1; i < 10; i++) n *= i;
					Console.WriteLine("1: {0}", n);
				}
				unchecked //блок без проверки
				{
					n = 1;
					for (i = 1; i < 10; i++) n *= i;
					Console.WriteLine("2:", n);
				}
			}
			catch (OverflowException)
			{
				Console.WriteLine("возникло переполнение");//Теперь, после замены блоков, первый блок будет выполняться с проверкой, а второй без проверки.
			}
			Console.ReadLine();
		}
	}
}
