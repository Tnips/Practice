using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1.Models
{
	internal class TravelpackagesDBContext: DataContext
	{
		public TravelpackagesDBContext(string connectionString) : base(connectionString)
		{

		}
		public Table<Travelpackages> PackagesTurist { get; set; }
	}
}	
