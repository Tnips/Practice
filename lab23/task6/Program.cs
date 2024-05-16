using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task6
{
	internal class Program
	{
		static void Main(string[] args)
		{
        Random rand = new Random();
        int[] array = new int[20];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = rand.Next(1, 100); 
        }

        Console.WriteLine("Исходный массив:");
        foreach (int num in array)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();

        int maxIndex = 0;
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > array[maxIndex])
            {
                maxIndex = i;
            }
        }

        int temp = array[0];
        array[0] = array[maxIndex];
        array[maxIndex] = temp;

        Console.WriteLine("Измененный массив:");
        foreach (int num in array)
        {
            Console.Write(num + " ");
        }
			Console.ReadLine();
		}
	}
}
