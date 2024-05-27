using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1.Models
{
	[Table(Name = "Оплата")]
	internal class payment
	{
		[Column(Name = "Код оплаты", IsPrimaryKey = true, IsDbGenerated = true)]
		public int Id { get; set; }

		[Column(Name = "Код путевки")]
		public string IDvoucher { get; set; }

		[Column(Name = "Дата оплаты")]
		public string Dateofpayment { get; set; }

		[Column(Name = "Сумма")]
		public string Sum { get; set; }

	}
}
