using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
	public class Program
	{
		public static void Main()
		{
			MyList<int> myList = new MyList<int>();
			myList.Add(1);
			myList.Add(2);
			myList.Add(3);

			Console.WriteLine("Элементы в списке:");
			for (int i = 0; i < myList.Count; i++)
			{
				Console.WriteLine(myList[i]);
			}
			Console.ReadLine();
		}
	}

	public class MyList<T>
	{
		private T[] _items;
		private int _count;

		public MyList()
		{
			_items = new T[0];
		}

		public T this[int index]
		{
			get
			{
				if (index < 0 || index >= _count)
				{
					throw new IndexOutOfRangeException();
				}
				return _items[index];
			}
			set
			{
				if (index < 0 || index >= _count)
				{
					throw new IndexOutOfRangeException();
				}
				_items[index] = value;
			}
		}

		public int Count
		{
			get { return _count; }
		}

		public void Add(T item)
		{
			if (_count == _items.Length)
			{
				int newCapacity = _count == 0 ? 4 : _count * 2;
				T[] newItems = new T[newCapacity];
				if (_count > 0)
				{
					Array.Copy(_items, 0, newItems, 0, _count);
				}
				_items = newItems;
			}
			_items[_count] = item;
			_count++;
		}
	}
}
