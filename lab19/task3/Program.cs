using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
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
		/// Оператор сложения двух матриц.
		/// </summary>
		/// <param name="a">Первая матрица.</param>
		/// <param name="b">Вторая матрица.</param>
		/// <returns>Результат сложения двух матриц.</returns>
		public static Matrix operator +(Matrix a, Matrix b)
		{
			if (a.data.GetLength(0) != b.data.GetLength(0) || a.data.GetLength(1) != b.data.GetLength(1))
				throw new ArgumentException("Матрицы должны быть одинакового размера.");

			var result = new Matrix(a.data.GetLength(0), a.data.GetLength(1));
			for (int i = 0; i < a.data.GetLength(0); i++)
			{
				for (int j = 0; j < a.data.GetLength(1); j++)
				{
					result[i, j] = a[i, j] + b[i, j];
				}
			}
			return result;
		}

		/// <summary>
		/// Оператор вычитания двух матриц.
		/// </summary>
		/// <param name="a">Первая матрица.</param>
		/// <param name="b">Вторая матрица.</param>
		/// <returns>Результат вычитания двух матриц.</returns>
		public static Matrix operator -(Matrix a, Matrix b)
		{
			if (a.data.GetLength(0) != b.data.GetLength(0) || a.data.GetLength(1) != b.data.GetLength(1))
				throw new ArgumentException("Матрицы должны быть одинакового размера.");

			var result = new Matrix(a.data.GetLength(0), a.data.GetLength(1));
			for (int i = 0; i < a.data.GetLength(0); i++)
			{
				for (int j = 0; j < a.data.GetLength(1); j++)
				{
					result[i, j] = a[i, j] - b[i, j];
				}
			}
			return result;
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
	}

	/// <summary>
	/// Главный класс программы.
	/// </summary>
	internal class Program
	{
		/// <summary>
		/// Главная точка входа для приложения.
		/// </summary>
		static void Main()
		{
			var matrix1 = new Matrix(2, 2);
			matrix1[0, 0] = 1;
			matrix1[0, 1] = 2;
			matrix1[1, 0] = 3;
			matrix1[1, 1] = 4;

			var matrix2 = new Matrix(2, 2);
			matrix2[0, 0] = 5;
			matrix2[0, 1] = 6;
			matrix2[1, 0] = 7;
			matrix2[1, 1] = 8;

			var sumMatrix = matrix1 + matrix2;
			var diffMatrix = matrix1 - matrix2;

			Console.WriteLine("Сумма матриц:");
			sumMatrix.Print();

			Console.WriteLine("Разность матриц:");
			diffMatrix.Print();
			Console.ReadLine();
		}
	}
}
