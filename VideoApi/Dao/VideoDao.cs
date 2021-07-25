using Dao.Context;
using Model;
using System.Linq;

namespace Dao
{
	public class VideoDao
	{
		private readonly ApiModelContext _context;

		public VideoDao(ApiModelContext context)
		{
			_context = context;
		}

		public IQueryable<Video> GetAllVideosIQueryable()
		{
			return _context.Videos;
		}
	}
}
