using Dao.Context;
using Microsoft.EntityFrameworkCore;
using Model;

namespace Dao
{
	public class CategoriaDao : AbstractDao<Categoria>
	{
		public CategoriaDao(DbSet<Categoria> context, ApiModelContext modelContext) : base(context, modelContext)
		{
		}
	}
}
