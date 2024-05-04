using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
	public class EventClass
	{
		public delegate void MyEventHandler(string message);

		public event MyEventHandler MyEvent;

		public void TriggerEvent(string message)
		{
			MyEvent?.Invoke(message);
		}
	}

	public class Observer1
	{
		public void HandleEvent(string message)
		{
			Console.WriteLine($"Observer1 получил сообщение: {message}");
		}
	}

	public class Observer2
	{
		public void HandleEvent(string message)
		{
			Console.WriteLine($"Observer2 получил сообщение: {message}");
		}
	}

	internal class Program
	{
		static void Main(string[] args)
		{
			EventClass eventClass = new EventClass();
			Observer1 observer1 = new Observer1();
			Observer2 observer2 = new Observer2();

			eventClass.MyEvent += observer1.HandleEvent;
			eventClass.MyEvent += observer1.HandleEvent;

			eventClass.MyEvent += observer2.HandleEvent;

			eventClass.TriggerEvent("Событие вызвано");

			eventClass.MyEvent -= observer1.HandleEvent;

			eventClass.TriggerEvent("Событие вызвано после удаления обработчика");
			Console.ReadLine();
		}
	}
}
