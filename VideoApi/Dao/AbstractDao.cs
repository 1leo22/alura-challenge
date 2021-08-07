using Dao.Context;
using Dao.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Dao
{
	public abstract class AbstractDao<T> : IAbstractDao<T> where T : class
	{
		private DbSet<T> _context;

		private ApiModelContext _modelContext;

		public AbstractDao(DbSet<T> context, ApiModelContext modelContext)
		{
			_context = context;
			_modelContext = modelContext;
		}

		public IQueryable<T> GetAll()
		{
			return _context;
		}

		public void Add(T bean)
		{
			_context.Add(bean);
			_modelContext.SaveChanges();
		}

		public void Remove(T bean)
		{
			_context.Remove(bean);
			_modelContext.SaveChanges();
		}

		public T Get(int id)
		{
			return _context.Find(id);
		}

		public void Update(T bean)
		{
			_context.Update(bean);
			_modelContext.SaveChanges();
		}
	}
}
