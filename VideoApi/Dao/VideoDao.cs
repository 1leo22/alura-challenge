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

		public Video GetVideoById(int id)
		{
			IQueryable<Video> query = _context.Videos;
			return query.Where(video => video.Id == id).FirstOrDefault();
		}

		public void AddVideo(Video video)
		{
			_context.Add(video);
			_context.SaveChanges();
		}
	}
}
