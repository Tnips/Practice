using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
	internal class Program
	{
		public delegate string StringDelegate(string s);

		static void Main(string[] args)
		{
			StringDelegate SD = ToUpper;
			Console.WriteLine("Преобразование в верхний регистр: " + SD("Hello, World!"));

			SD = ToLower;
			Console.WriteLine("Преобразование в нижний регистр: " + SD("Hello, World!"));

			SD = Reverse;
			Console.WriteLine("Реверс строки: " + SD("Hello, World!"));
			Console.ReadLine();
		}

		public static string ToUpper(string s)
		{
			return s.ToUpper();
		}
		public static string ToLower(string s)
		{
			return s.ToLower();
		}

		public static string Reverse(string s)
		{
			char[] arr = s.ToCharArray();
			Array.Reverse(arr);
			return new string(arr);
		}
	}
}
