using Microsoft.EntityFrameworkCore;
using Model;

namespace Dao.Context
{
	public class ApiModelContext : DbContext
	{
		public ApiModelContext(DbContextOptions<ApiModelContext> options) : base(options)
		{

		}

		public DbSet<Video> Videos { get; set; }

		public DbSet<Categoria> Categorias { get; set; }
	}
}
