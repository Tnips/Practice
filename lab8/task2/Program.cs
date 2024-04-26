using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
	public enum Post
	{
		Director = 160,
		Manager = 170,
		Engineer = 180,
		Clerk = 190, 
		Intern = 150 
	}

	public class Accountant
	{
		public bool AskForBonus(Post worker, int hours)
		{
			if (hours > (int)worker)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
	}

	internal class Program
	{
		static void Main()
		{
			Accountant accountant = new Accountant();

			Post worker = Post.Engineer;
			int hours = 190;

			bool bonus = accountant.AskForBonus(worker, hours);

			if (bonus)
			{
				Console.WriteLine("Премия выдается.");
			}
			else
			{
				Console.WriteLine("Премия не выдается.");
			}
			Console.ReadLine();
		}
	}

}
