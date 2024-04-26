using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
	public struct Student
	{
		public string FullName;
		public int GroupNumber;
		public int[] Performance;
	}

	internal class Program
	{
		static void Main()
		{
			Student[] students = new Student[10];

			for (int i = 0; i < 10; i++)
			{
				Console.WriteLine("Введите фамилию и инициалы студента:");
				string fullName = Console.ReadLine();

				Console.WriteLine("Введите номер группы:");
				int groupNumber = int.Parse(Console.ReadLine());

				Console.WriteLine("Введите оценки студента (5 чисел через пробел):");
				int[] performance = Console.ReadLine().Split().Select(int.Parse).ToArray();

				students[i] = new Student { FullName = fullName, GroupNumber = groupNumber, Performance = performance };
			}

			students = students.OrderBy(s => s.GroupNumber).ToArray();

			bool found = false;
			foreach (var student in students)
			{
				double average = student.Performance.Average();
				if (average > 4.0)
				{
					Console.WriteLine($"Студент: {student.FullName}, Группа: {student.GroupNumber}");
					found = true;
				}
			}

			if (!found)
			{
				Console.WriteLine("Студентов со средним баллом больше 4.0 не найдено.");
			}
		}
	}
}
