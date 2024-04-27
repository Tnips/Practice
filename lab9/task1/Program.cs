using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
	internal class Program
	{
		interface Ix
		{
			void IxF0(double w);
			void IxF1();
		}

		interface Iy
		{
			void F0(double w);
			void F1();
		}

		interface Iz
		{
			void F0(double w);
			void F1();
		}

		class TestClass : Ix, Iy, Iz
		{
			double w;

			public void IxF0(double w)
			{
				this.w = w;
				Console.WriteLine(Math.Sqrt(w));
			}

			public void IxF1()
			{
				Console.WriteLine(Math.Sqrt(w));
			}

			public void F0(double w)
			{
				this.w = w;
				Console.WriteLine(Math.Sqrt(w));
			}

			public void F1()
			{
				Console.WriteLine(Math.Sqrt(w));
			}

			void Iz.F0(double w)
			{
				this.w = w;
				Console.WriteLine(w * w + 5);
			}

			void Iz.F1()
			{
				Console.WriteLine(w * w + 5);
			}
		}
		static void Main(string[] args)
		{
			TestClass test = new TestClass();

			test.IxF0(4.0);
			test.IxF1();

			test.F0(9.0);
			test.F1();

			((Iz)test).F0(16.0);
			((Iz)test).F1();
			Console.ReadLine();
		}
	}
}
