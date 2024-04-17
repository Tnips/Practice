using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
	class Person
	{
		public string FullName { get; set; }
		public int Age { get; set; }
	}

	class Student : Person
	{
		public string StudentId { get; set; }
		public string Major { get; set; }
	}

	class Teacher : Person
	{
		public string Department { get; set; }
		public string Subject { get; set; }
	}

	class DepartmentChair : Teacher
	{
		public string ChairTitle { get; set; }
	}

	class Program
	{
		static void Main(string[] args)
		{
			var student = new Student
			{
				FullName = "Иван Петров",
				Age = 20,
				StudentId = "12345",
				Major = "Информатика"
			};

			var teacher = new Teacher
			{
				FullName = "Елена Смирнова",
				Age = 35,
				Department = "Компьютерные науки",
				Subject = "Программирование"
			};

			var chair = new DepartmentChair
			{
				FullName = "Алексей Иванов",
				Age = 45,
				Department = "Математика",
				Subject = "Алгебра",
				ChairTitle = "Заведующий кафедрой"
			};

			Console.WriteLine($"Студент: {student.FullName}, Специальность: {student.Major}");
			Console.WriteLine($"Преподаватель: {teacher.FullName}, Предмет: {teacher.Subject}");
			Console.WriteLine($"Заведующий кафедрой: {chair.FullName}, Кафедра: {chair.Department}");
			Console.ReadLine();

		}
	}
}
