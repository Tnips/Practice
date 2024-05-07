using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using task2;
using System.Threading.Tasks;

namespace task2prim
{
	internal class Program
	{
		static void Main()
		{
			Собака собака = new Собака("Бобик");
			Кошка кошка = new Кошка("Мурка");

			собака.Void();
			кошка.Void();

			Console.ReadLine();
		}
	}
}
