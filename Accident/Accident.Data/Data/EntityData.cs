using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
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

        public List<S> Select<S>(Expression<Func<T, S>> selector)
        {
            using (AccidentEntities context = DbContextFactory.Create())
            {
                return context.Set<T>().Select(selector).ToList();
            }
        }

        public int GetCount(Expression<Func<T, bool>> predicate)
        {
            using (AccidentEntities context = DbContextFactory.Create())
            {
                return context.Set<T>().Count(predicate);
            }
        }

        public void Insert(T entity)
        {
            using (AccidentEntities context = DbContextFactory.Create())
            {
                context.Set<T>().Add(entity);

                context.SaveChanges();
            }
        }

        public void Update(T entity)
        {
            using (AccidentEntities context = DbContextFactory.Create())
            {
                context.Entry(entity).State = EntityState.Modified;

                context.SaveChanges();
            }
        }

        public void Delete(T entity)
        {
            using (AccidentEntities context = DbContextFactory.Create())
            {
                context.Entry(entity).State = EntityState.Deleted;

                context.SaveChanges();
            }
        }
    }
}
