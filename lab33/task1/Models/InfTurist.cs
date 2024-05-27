using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1.Models
{
	[Table(Name = "Информация о туристах")]
	internal class InfTurist
	{
		[Column(Name = "Код туриста", IsPrimaryKey = true, IsDbGenerated = true)]
		public int Id { get; set; }

		[Column(Name = "Серия паспорта")]
		public string Passport { get; set; }

		[Column(Name = "Город")]
		public string Town { get; set; }
		[Column(Name = "Страна")]
		public string Country { get; set; }
		[Column(Name = "Телефон")]
		public string Telephone { get; set; }
		[Column(Name = "Индекс")]
		public string Index { get; set; }
	}
}
