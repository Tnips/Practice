using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
	internal class Program
	{
		static void Main()
		{
			int[] array = { 4, 2, 9, 6, 1, 5 }; 

			int largest = array[0]; 
			int largestIndex = 0; 
			for (int i = 1; i < array.Length; i++)
			{
				if (array[i] > largest)
				{
					largest = array[i];
					largestIndex = i;
				}
			}

			int temp = array[0];
			array[0] = largest;
			array[largestIndex] = temp;

			Console.WriteLine($"Наибольший элемент: {largest}");
			Console.WriteLine($"Массив после обмена: [{string.Join(", ", array)}]");
			Console.ReadLine();
		}
	}
}
