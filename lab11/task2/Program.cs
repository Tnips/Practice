using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
	public abstract class Settlement
	{
		public string Name { get; set; }

		public abstract double PopulationDensity();

		public virtual void Display()
		{
			Console.WriteLine($"Название: {Name}");
		}
	}

	public class Village : Settlement
	{
		public int HouseCount { get; set; }
		public int ResidentsPerHouse { get; set; }
		public double Area { get; set; }

		public override double PopulationDensity()
		{
			return HouseCount * ResidentsPerHouse / Area;
		}

		public override void Display()
		{
			base.Display();
			Console.WriteLine($"Количество домов: {HouseCount}, Жители в доме: {ResidentsPerHouse}, Площадь: {Area}");
		}
	}

	public class City : Settlement
	{
		public int Population { get; set; }
		public double Area { get; set; }

		public override double PopulationDensity()
		{
			return Population / Area;
		}

		public override void Display()
		{
			base.Display();
			Console.WriteLine($"Население: {Population}, Площадь: {Area}");
		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			Settlement[] settlements = new Settlement[5]
			{
			new Village { Name = "Село 1", HouseCount = 50, ResidentsPerHouse = 4, Area = 20.0 },
			new City { Name = "Город 1", Population = 100000, Area = 250.0 },
			new Village { Name = "Село 2", HouseCount = 75, ResidentsPerHouse = 4, Area = 30.0 },
			new City { Name = "Город 2", Population = 500000, Area = 1000.0 },
			new Village { Name = "Село 3", HouseCount = 100, ResidentsPerHouse = 5, Area = 40.0 }
			};

			foreach (var settlement in settlements)
			{
				settlement.Display();
				Console.WriteLine($"Плотность населения: {settlement.PopulationDensity()}\n");
			}

			var minDensitySettlement = settlements.OrderBy(s => s.PopulationDensity()).First();
			Console.WriteLine($"Объект с наименьшей плотностью населения: {minDensitySettlement.Name}, Плотность населения: {minDensitySettlement.PopulationDensity()}");
			Console.ReadLine();
		}
	}
}
