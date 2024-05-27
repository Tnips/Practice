using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1.Models
{
	internal class PaymentDBContext: DataContext
	{
		public PaymentDBContext(string connectionString) : base(connectionString)
		{

		}
		public Table<payment> PaymentTurist { get; set; }

	}
}
