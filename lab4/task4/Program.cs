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
			byte x = 200;
			byte y = 200;
			try
			{
				byte result = checked((byte)(x + y)); //Если результат сложения x+y превышает допустимый диапазон для типа byte, будет выдано сообщение “возникло переполнение”
				Console.WriteLine("1: {0}", result);
			}
			catch (OverflowException)
			{
				Console.WriteLine("возникло переполнение");
			}
			Console.ReadLine();
		}
	}
}
