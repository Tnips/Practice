using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5
{
	/// <summary>
	/// Класс для работы с матрицами.
	/// </summary>
	public class Matrix
	{
		/// <summary>
		/// Двумерный массив для хранения элементов матрицы.
		/// </summary>
		private int[,] data;

		/// <summary>
		/// Конструктор для создания матрицы заданного размера.
		/// </summary>
		/// <param name="rows">Количество строк в матрице.</param>
		/// <param name="columns">Количество столбцов в матрице.</param>
		public Matrix(int rows, int columns)
		{
			data = new int[rows, columns];
		}

		/// <summary>
		/// Индексатор для доступа к элементам матрицы.
		/// </summary>
		/// <param name="row">Индекс строки.</param>
		/// <param name="column">Индекс столбца.</param>
		public int this[int row, int column]
		{
			get => data[row, column];
			set => data[row, column] = value;
		}

		/// <summary>
		/// Метод для вывода матрицы на консоль.
		/// </summary>
		public void Print()
		{
			for (int i = 0; i < data.GetLength(0); i++)
			{
				for (int j = 0; j < data.GetLength(1); j++)
				{
					Console.Write($"{data[i, j]} ");
				}
				Console.WriteLine();
			}
		}

		/// <summary>
		/// Метод для вывода подматрицы на консоль.
		/// </summary>
		/// <param name="startRow">Стартовый индекс строки подматрицы.</param>
		/// <param name="startColumn">Стартовый индекс столбца подматрицы.</param>
		/// <param name="numRows">Количество строк в подматрице.</param>
		/// <param name="numColumns">Количество столбцов в подматрице.</param>
		public void PrintSubmatrix(int startRow, int startColumn, int numRows, int numColumns)
		{
			for (int i = startRow; i < startRow + numRows; i++)
			{
				for (int j = startColumn; j < startColumn + numColumns; j++)
				{
					Console.Write($"{data[i, j]} ");
				}
				Console.WriteLine();
			}
		}
	}

	/// <summary>
	/// Главный класс программы.
	/// </summary>
	internal class program
	{
		/// <summary>
		/// Главная точка входа для приложения.
		/// </summary>
		static void Main()
		{
			var matrix = new Matrix(3, 3);
			matrix[0, 0] = 1;
			matrix[0, 1] = 2;
			matrix[0, 2] = 3;
			matrix[1, 0] = 4;
			matrix[1, 1] = 5;
			matrix[1, 2] = 6;
			matrix[2, 0] = 7;
			matrix[2, 1] = 8;
			matrix[2, 2] = 9;

			Console.WriteLine("Вся матрица:");
			matrix.Print();

			Console.WriteLine("\nПодматрица 2x2:");
			matrix.PrintSubmatrix(1, 0, 2, 2);
			Console.ReadLine();
		}
	}
}
