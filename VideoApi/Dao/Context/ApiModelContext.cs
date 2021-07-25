using Microsoft.EntityFrameworkCore;
using Model;

namespace Dao.Context
{
	public class ApiModelContext : DbContext
	{
		public ApiModelContext(DbContextOptions<ApiModelContext> options) : base(options)
		{
			this.Database.Migrate();
		}

		public DbSet<Video> Videos { get; set; }
	}
}
