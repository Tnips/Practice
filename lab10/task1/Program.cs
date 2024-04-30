using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
	public class Apartment
	{
		public string Name { get; set; }
		public double CostPerSquareMeter { get; set; }
		public double Area { get; set; }

		public double TotalCost()
		{
			return CostPerSquareMeter * Area;
		}
	}

	public class CentralApartment : Apartment
	{
		public string DistrictName { get; set; }

		public new double TotalCost()
		{
			return base.TotalCost() * 1.01; 
		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			CentralApartment centralApartment = new CentralApartment();

			Console.Write("Введите название квартиры: ");
			centralApartment.Name = Console.ReadLine();

			Console.Write("Введите стоимость за квадратный метр: ");
			centralApartment.CostPerSquareMeter = Convert.ToDouble(Console.ReadLine());

			Console.Write("Введите площадь квартиры: ");
			centralApartment.Area = Convert.ToDouble(Console.ReadLine());

			Console.Write("Введите название района: ");
			centralApartment.DistrictName = Console.ReadLine();

			Console.WriteLine($"Общая стоимость квартиры {centralApartment.Name}, расположенной в районе {centralApartment.DistrictName}, составляет {centralApartment.TotalCost()}");
			Console.ReadLine();
		}
	}
}
