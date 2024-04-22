using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Введите фамилию, имя и отчество пользователя:");
			string fullName = Console.ReadLine();

			int personalCode = CalculatePersonalCode(fullName);
			Console.WriteLine($"Код личности: {personalCode}");
			Console.ReadLine();
		}
		

		static int CalculatePersonalCode(string fullName)
		{
			fullName = fullName.Replace(" ", "").ToUpper();

			int sum = 0;
			foreach (char letter in fullName)
			{
				if (char.IsLetter(letter))
				{
					int letterNumber = letter - 'A' + 1;
					sum += letterNumber;
				}
			}

			while (sum >= 10)
			{
				int tempSum = 0;
				while (sum > 0)
				{
					tempSum += sum % 10;
					sum /= 10;
				}
				sum = tempSum;
			}

			return sum;
		}

	}
}

