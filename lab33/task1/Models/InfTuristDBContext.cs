using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1.Models
{
	internal class InfTuristDBContext : DataContext
	{
		public InfTuristDBContext(string connectionString) : base(connectionString)
		{

		}
		public Table<InfTurist> InfTurists { get; set; }

	}
}
