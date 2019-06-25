using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accident.Data
{
	public class EntityData<T> where T : class
	{
		public List<T> GetAll()
		{
			using (AccidentEntities context = DbContextFactory.Create())
			{
				return context.Set<T>().ToList();
			}
		}

		public int GetCount()
		{
			using (AccidentEntities context = DbContextFactory.Create())
			{
				return context.Set<T>().Count();
			}
		}
	}
}
