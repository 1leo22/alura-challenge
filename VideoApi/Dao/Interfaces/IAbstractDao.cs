using System.Linq;

namespace Dao.Interfaces
{
	public interface IAbstractDao<T>
	{
		public IQueryable<T> GetAll();

		public void Add(T bean);

		public void Remove(T bean);

		public T Get(int id);

		public void Update(T bean);
	}
}
