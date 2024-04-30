using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
	public class Apartment
	{
		private string name;
		private double costPerSquareMeter;
		private double area;

		public Apartment(string name, double costPerSquareMeter, double area)
		{
			this.name = name;
			this.costPerSquareMeter = costPerSquareMeter;
			this.area = area;
		}

		public double GetCost()
		{
			return costPerSquareMeter * area;
		}

		public void Display()
		{
			Console.WriteLine($"Название: {name}, Стоимость за квадратный метр: {costPerSquareMeter}, Площадь: {area}");
		}
	}

	public class CentralApartment : Apartment
	{
		private string districtName;

		public CentralApartment(string name, double costPerSquareMeter, double area, string districtName)
			: base(name, costPerSquareMeter, area)
		{
			this.districtName = districtName;
		}

		public new double GetCost()
		{
			return base.GetCost() * 1.01;
		}

		public new void Display()
		{
			base.Display();
			Console.WriteLine($"Район: {districtName}");
		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			Apartment apt = new Apartment("Квартира 1", 1000, 50);
			apt.Display();
			Console.WriteLine($"Стоимость: {apt.GetCost()}");

			CentralApartment centralApt = new CentralApartment("Центральная квартира 1", 1000, 50, "Центральный район");
			centralApt.Display();
			Console.WriteLine($"Стоимость: {centralApt.GetCost()}");
			Console.ReadLine();
		}
	}
}
