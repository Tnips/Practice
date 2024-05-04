using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
	public class MyInfo
	{
		public delegate void NameChangedEventHandler(object sender, EventArgs e);

		public event NameChangedEventHandler NameChanged;

		private string _name;

		public string Name
		{
			get { return _name; }
			set
			{
				if (_name != value)
				{
					_name = value;

					OnNameChanged(EventArgs.Empty);
				}
			}
		}

		protected virtual void OnNameChanged(EventArgs e)
		{
			NameChanged?.Invoke(this, e);
		}
	}

	internal class Program
	{
		static void Main(string[] args)
		{
			MyInfo myInfo = new MyInfo();
			myInfo.NameChanged += MyInfo_NameChanged;

			Console.WriteLine("Введите новое имя:");
			myInfo.Name = Console.ReadLine();
			Console.ReadLine();
		}

		private static void MyInfo_NameChanged(object sender, EventArgs e)
		{
			Console.WriteLine("Значение поля name было изменено!");
		}
		
	}
}
