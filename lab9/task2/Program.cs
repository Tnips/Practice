using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
	public class Vector : IComparable<Vector>
	{
		private int[] array;

		public Vector(int size)
		{
			array = new int[size];
		}

		public int this[int index]
		{
			get
			{
				if (index >= 0 && index < array.Length)
					return array[index];
				else
					throw new IndexOutOfRangeException();
			}
			set
			{
				if (index >= 0 && index < array.Length)
					array[index] = value;
				else
					throw new IndexOutOfRangeException();
			}
		}

		public static Vector operator +(Vector a, Vector b)
		{
			if (a.array.Length != b.array.Length)
				throw new ArgumentException("Vectors must be of the same size");

			Vector result = new Vector(a.array.Length);
			for (int i = 0; i < a.array.Length; i++)
				result[i] = a[i] + b[i];

			return result;
		}

		public static Vector operator -(Vector a, Vector b)
		{
			if (a.array.Length != b.array.Length)
				throw new ArgumentException("Vectors must be of the same size");

			Vector result = new Vector(a.array.Length);
			for (int i = 0; i < a.array.Length; i++)
				result[i] = a[i] - b[i];

			return result;
		}

		public void Print()
		{
			foreach (var item in array)
				Console.Write(item + " ");
			Console.WriteLine();
		}

		public int CompareTo(Vector other)
		{
			if (other == null) return 1;

			if (this.array.Length > other.array.Length)
				return 1;
			else if (this.array.Length < other.array.Length)
				return -1;
			else
				return 0;
		}
	}

	internal class Program
	{
		static void Main(string[] args)
		{
			Vector v1 = new Vector(5);
			Vector v2 = new Vector(5);

			for (int i = 0; i < 5; i++)
			{
				v1[i] = i;
				v2[i] = i * 2;
			}

			Console.WriteLine("Вектор v1:");
			v1.Print();

			Console.WriteLine("Вектор v2:");
			v2.Print();

			Vector v3 = v1 + v2;
			Console.WriteLine("v1 + v2:");
			v3.Print();

			Vector v4 = v1 - v2;
			Console.WriteLine("v1 - v2:");
			v4.Print();
			Console.ReadLine();
		}
	}
}
