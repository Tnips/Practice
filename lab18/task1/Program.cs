using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
	internal class Program
	{
		static void Main()
		{
			string input = "abc#d##c";
			Console.WriteLine("текст: " + input);
			Console.WriteLine("обработанный текст: " + ProcessString(input));
			Console.ReadLine();
		}

		static string ProcessString(string input)
		{
			Stack<char> stack = new Stack<char>();

			foreach (char c in input)
			{
				if (c == '#')
				{
					if (stack.Count > 0)
					{
						stack.Pop();
					}
				}
				else
				{
					stack.Push(c);
				}
			}

			char[] arr = stack.ToArray();
			Array.Reverse(arr);
			return new string(arr);
		}
	}
}
