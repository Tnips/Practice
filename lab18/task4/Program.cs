using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
	class CD
	{
		public string Title { get; set; }
		public Hashtable Songs { get; set; }

		public CD(string title)
		{
			Title = title;
			Songs = new Hashtable();
		}

		public void AddSong(string song)
		{
			if (!Songs.ContainsKey(song))
			{
				Songs.Add(song, song);
			}
		}

		public void RemoveSong(string song)
		{
			if (Songs.ContainsKey(song))
			{
				Songs.Remove(song);
			}
			else
			{
				Console.WriteLine("Песня с таким названием не найдена на диске.");
			}
		}

		public void PrintSongs()
		{
			Console.Write("Песни: ");
			foreach (DictionaryEntry song in Songs)
			{
				Console.Write(song.Value + ", ");
			}
			Console.WriteLine();
		}
	}

	class CDCatalog
	{
		public Hashtable CDs { get; private set; }

		public CDCatalog()
		{
			CDs = new Hashtable();
		}

		public void AddCD(string title)
		{
			if (!CDs.ContainsKey(title))
			{
				CDs.Add(title, new CD(title));
			}
		}

		public void RemoveCD(string title)
		{
			if (CDs.ContainsKey(title))
			{
				CDs.Remove(title);
			}
		}

		public CD GetCD(string title)
		{
			if (CDs.ContainsKey(title))
			{
				return (CD)CDs[title];
			}
			else
			{
				return null;
			}
		}

		public void PrintCatalog()
		{
			foreach (DictionaryEntry cd in CDs)
			{
				Console.WriteLine("Диск: " + ((CD)cd.Value).Title);
				((CD)cd.Value).PrintSongs();
			}
		}
	}

	internal class Program
	{
		static void Main(string[] args)
		{
			CDCatalog catalog = new CDCatalog();

			while (true)
			{
				Console.WriteLine("1. Добавить диск");
				Console.WriteLine("2. Удалить диск");
				Console.WriteLine("3. Добавить песню");
				Console.WriteLine("4. Удалить песню");
				Console.WriteLine("5. Просмотреть каталог");
				Console.WriteLine("6. Выход");

				int choice = Convert.ToInt32(Console.ReadLine());

				switch (choice)
				{
					case 1:
						Console.WriteLine("Введите название диска:");
						string title = Console.ReadLine();
						catalog.AddCD(title);
						break;
					case 2:
						Console.WriteLine("Введите название диска:");
						title = Console.ReadLine();
						catalog.RemoveCD(title);
						break;
					case 3:
						Console.WriteLine("Введите название диска:");
						title = Console.ReadLine();
						CD cd = catalog.GetCD(title);
						if (cd != null)
						{
							Console.WriteLine("Введите название песни:");
							string song = Console.ReadLine();
							cd.AddSong(song);
						}
						else
						{
							Console.WriteLine("Диск с таким названием не найден.");
						}
						break;
					case 4:
						Console.WriteLine("Введите название диска:");
						title = Console.ReadLine();
						cd = catalog.GetCD(title);
						if (cd != null)
						{
							Console.WriteLine("Введите название песни:");
							string song = Console.ReadLine();
							cd.RemoveSong(song);
						}
						else
						{
							Console.WriteLine("Диск с таким названием не найден.");
						}
						break;
					case 5:
						catalog.PrintCatalog();
						break;
					case 6:
						return;
				}
				Console.ReadLine();
			}
		}
	}
}
