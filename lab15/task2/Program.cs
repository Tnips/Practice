using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
	public class MyDictionary<TKey, TValue>
	{
		private List<TKey> keys;
		private List<TValue> values;

		public MyDictionary()
		{
			keys = new List<TKey>();
			values = new List<TValue>();
		}

		public TValue this[TKey key]
		{
			get
			{
				int index = keys.IndexOf(key);
				if (index == -1)
				{
					throw new ArgumentException("Key not found");
				}
				return values[index];
			}
		}

		public void Add(TKey key, TValue value)
		{
			if (keys.Contains(key))
			{
				throw new ArgumentException("An element with the same key already exists");
			}
			keys.Add(key);
			values.Add(value);
		}

		public int Count
		{
			get { return keys.Count; }
		}
	}

	internal class Program
	{
		static void Main(string[] args)
		{
			MyDictionary<string, int> myDictionary = new MyDictionary<string, int>();
			myDictionary.Add("one", 1);
			myDictionary.Add("two", 2);
			myDictionary.Add("three", 3);

			Console.WriteLine("Count: " + myDictionary.Count);
			Console.WriteLine("Value for 'two': " + myDictionary["two"]);
			Console.ReadLine();
		}
	}
}
