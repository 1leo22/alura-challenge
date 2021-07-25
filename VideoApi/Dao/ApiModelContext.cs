using Microsoft.EntityFrameworkCore;
using Model;

namespace Dao
{
	public class ApiModelContext : DbContext
	{
		DbSet<Video> Videos { get; set; }

		public ApiModelContext(DbContextOptions<ApiModelContext> options) : base(options)
		{
		}
	}
}
