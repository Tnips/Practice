using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
	public class MyList<T>
	{
		private List<T> elements;

		public MyList()
		{
			elements = new List<T>();
		}

		public void Add(T element)
		{
			elements.Add(element);
		}

		public T this[int index]
		{
			get { return elements[index]; }
		}

		public int Count
		{
			get { return elements.Count; }
		}
	}

	public static class MyListExtensions
	{
		public static T[] GetArray<T>(this MyList<T> list)
		{
			T[] array = new T[list.Count];
			for (int i = 0; i < list.Count; i++)
			{
				array[i] = list[i];
			}
			return array;
		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			MyList<int> myList = new MyList<int>();
			myList.Add(1);
			myList.Add(2);
			myList.Add(3);

			int[] array = myList.GetArray();
			foreach (var item in array)
			{
				Console.WriteLine(item);
			}
			Console.ReadLine();
		}
	}
}
