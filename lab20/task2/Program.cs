using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace task2
{
	public class TaskObject
	{
		private double alpha;

		public TaskObject(double alpha)
		{
			this.alpha = alpha;
		}

		public double CalculateFunction1()
		{
			Thread.Sleep(1000); 
			return Math.Sin(Math.PI / 2 + 3 * alpha) / (1 - Math.Sin(3 * alpha - Math.PI));
		}

		public double CalculateFunction2()
		{
			Thread.Sleep(2000); 
			return Math.Pow(1 / Math.Tan((5.0 / 2) * Math.PI + alpha), 3);
		}
	}

	internal class Program
	{
		static void Main(string[] args)
		{
			TaskObject[] tasks = new TaskObject[2]
			{
			new TaskObject(0.5),
			new TaskObject(1.0)
			};

			Task[] taskArray = new Task[2]
			{
			Task.Run(() => Console.WriteLine($"Результат 1: {tasks[0].CalculateFunction1()}")),
			Task.Run(() => Console.WriteLine($"Результат 2: {tasks[1].CalculateFunction2()}"))
			};

			Task.WaitAll(taskArray);
			Console.WriteLine("Все задачи выполнены");

			Task.WaitAny(taskArray);
			Console.WriteLine("Хотя бы одна задача выполнена");
			Console.ReadLine();
		}
	}
}
