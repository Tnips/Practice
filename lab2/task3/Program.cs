using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
	class DecimalCounter
	{
		private decimal _minValue;
		private decimal _maxValue;
		private decimal _currentValue;

		public DecimalCounter(decimal minValue, decimal maxValue, decimal initialValue)
		{
			if (minValue >= maxValue)
				throw new ArgumentException("Минимальное значение должно быть меньше максимального.");

			_minValue = minValue;
			_maxValue = maxValue;
			_currentValue = Math.Max(minValue, Math.Min(maxValue, initialValue));
		}

		public void Increment()
		{
			_currentValue = Math.Min(_maxValue, _currentValue + 1);
		}

		public void Decrement()
		{
			_currentValue = Math.Max(_minValue, _currentValue - 1);
		}

		public decimal CurrentValue
		{
			get { return _currentValue; }
		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			var counter = new DecimalCounter(0, 100, 50);

			Console.WriteLine($"Текущее значение счетчика: {counter.CurrentValue}");
			counter.Increment();
			Console.WriteLine($"Увеличили счетчик: {counter.CurrentValue}");
			counter.Decrement();
			Console.WriteLine($"Уменьшили счетчик: {counter.CurrentValue}");
			Console.ReadLine();
		}
	}
}
