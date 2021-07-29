using Dao.Context;
using Dao.Interfaces;
using Model;
using System.Linq;

namespace Dao
{
	public class VideoDao : IVideoDao
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
			_context.Videos.Add(video);
			_context.SaveChanges();
		}

		public void DeleteVideo(Video video)
		{
			_context.Videos.Remove(video);
			_context.SaveChanges();
		}

		public void UpdateVideo(Video video)
		{
			_context.Videos.Update(video);
			_context.SaveChanges();
		}
	}
}
