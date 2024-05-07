using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
	public class animal
	{
		public string Name { get; set; }

		public animal(string name)
		{
			Name = name;
		}

		public virtual void Void()
		{
			Console.WriteLine("Животное издает звук");
		}
	}

	public class dog :animal
	{
		public dog(string name) : base(name)
		{
		}

		public override void Void()
		{
			Console.WriteLine($"{Name} говорит: Гав-гав!");
		}
	}

	public class cat : animal
	{
		public cat(string name) : base(name)
		{
		}

		public override void Void()
		{
			Console.WriteLine($"{Name} говорит: Мяу-мяу!");
		}
	}
}

