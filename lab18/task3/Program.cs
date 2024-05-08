using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
	public class Plant
	{
		public string Name { get; set; }
		public int? Age { get; set; } // Обнуляемый тип

		public Plant(string name, int? age = null)
		{
			Name = name;
			Age = age;
		}

		public Plant Clone()
		{
			return new Plant(Name, Age);
		}
	}

	public class PlantList
	{
		private List<Plant> plants = new List<Plant>();

		public void Add(Plant plant)
		{
			plants.Add(plant.Clone());
		}

		public bool Remove(Plant plant)
		{
			return plants.Remove(plant);
		}

		public void PrintAll()
		{
			foreach (var plant in plants)
			{
				Console.WriteLine($"Name: {plant.Name}, Age: {plant.Age ?? 0}");
			}
		}
	}

	internal class Program
	{
		static void Main(string[] args)
		{
			PlantList plantList = new PlantList();

			Plant plant1 = new Plant("Rose", 2);
			Plant plant2 = new Plant("Tulip");

			plantList.Add(plant1);
			plantList.Add(plant2);

			plantList.PrintAll();

			plantList.Remove(plant1);

			plantList.PrintAll();
			Console.ReadLine();
		}
	}
}

