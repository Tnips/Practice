using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
	public interface IStrategy
	{
		void Execute();
	}

	public class ConcreteStrategyA : IStrategy
	{
		public void Execute()
		{
			Console.WriteLine("Выполнена стратегия A");
		}
	}

	public class ConcreteStrategyB : IStrategy
	{
		public void Execute()
		{
			Console.WriteLine("Выполнена стратегия B");
		}
	}

	public class Context
	{
		private IStrategy _strategy;

		public Context(IStrategy strategy)
		{
			this._strategy = strategy;
		}

		public void SetStrategy(IStrategy strategy)
		{
			this._strategy = strategy;
		}

		public void ExecuteStrategy()
		{
			_strategy.Execute();
		}
	}

	internal class Program
	{
		static void Main(string[] args)
		{
			var context = new Context(new ConcreteStrategyA());
			context.ExecuteStrategy();

			context.SetStrategy(new ConcreteStrategyB());
			context.ExecuteStrategy();

			Console.ReadLine();
		}
	}
}
