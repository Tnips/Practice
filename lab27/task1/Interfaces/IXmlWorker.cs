using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task1.Models;

namespace task1.Interfaces
{
	internal interface IXmlWorker
	{
		void Load(string xmlDocPath);
		void Add(Books books);
		void Delete(string Title);
		Books FindBy(string Title);
		List<Books> GetAll();
	}
}
