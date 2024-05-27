using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq.Mapping;

namespace task1.Models
{
	[Table(Name="Туристы")]
	internal class Turist
	{
		[Column(Name = "Код туриста", IsPrimaryKey = true, IsDbGenerated = true)]
		public int Id { get; set; }

		[Column(Name = "Имя")]
		public string FirstName { get; set; }

		[Column(Name = "Отчество")]
		public string MiddleName { get; set; }
		[Column(Name = "Фамилия")]
		public string LastName { get; set; }
	}
}
