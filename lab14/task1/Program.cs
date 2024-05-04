using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace task1
{
	internal class Program
	{

	static AutoResetEvent autoEvent = new AutoResetEvent(false);

	static void Main()
	{
		Thread t1 = new Thread(PrintNumbers);
		t1.Name = "Thread1";
		t1.Priority = ThreadPriority.Highest;

		Thread t2 = new Thread(PrintNumbers);
		t2.Name = "Thread2";
		t2.Priority = ThreadPriority.AboveNormal;

		Thread t3 = new Thread(PrintNumbers);
		t3.Name = "Thread3";
		t3.Priority = ThreadPriority.Normal;

		t1.Start(0);
		t2.Start(10);
		t3.Start(20);

		Console.ReadLine();
	}

	static void PrintNumbers(object start)
	{
		int startIndex = (int)start;
		for (int i = startIndex; i < startIndex + 10; i++)
		{
			Console.WriteLine($"{Thread.CurrentThread.Name}: {i}");
			Thread.Sleep(1000);
			if (i == startIndex + 9)
			{
				autoEvent.Set();
			}
		}
		autoEvent.WaitOne();
	}
}
}
