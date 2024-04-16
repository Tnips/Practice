using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
	internal class Program
	{
		static void Main(string[] args)
        {
            Console.WriteLine("Введите количество набранных баллов (от 0 до 100):");
            int score = int.Parse(Console.ReadLine());

            string mark;

            switch (score)
            {
                case int n when (n >= 90 && n <= 100):
                    mark = "отлично";
                    break;
                case int n when (n >= 70 && n < 90):
					mark = "хорошо";
                    break;
                case int n when (n >= 50 && n < 70):
					mark = "удовлетворительно";
                    break;
                default:
					mark = "неудовлетворительно";
                    break;
            }

            Console.WriteLine($"Оценка: {mark}");

            Console.ReadLine();
        }
	}
}
