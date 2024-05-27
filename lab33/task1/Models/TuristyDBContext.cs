using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1.Models
{
	internal class TuristyDBContext: DataContext
	{
		public TuristyDBContext (string connectionString) : base(connectionString)
		{

		}
		public Table<Turist> Turists { get; set; }

	}
}
