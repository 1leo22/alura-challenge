using Dao.Interfaces;
using Model;
using Services.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace Services
{
	public class VideoService : IVideoService
	{
		private readonly IAbstractDao<Video> _videoDao;

		public VideoService(IAbstractDao<Video> videoDao)
		{
			_videoDao = videoDao;
		}

		public List<Video> GetAllVideos()
		{
			List<Video> videoList = _videoDao.GetAll().ToList();

			return videoList;
		}

		public Video GetVideoById(int id)
		{
			Video video = _videoDao.Get(id);

			return video;
		}

		public void AddVideo(Video video)
		{
			_videoDao.Add(video);
		}

		public void DeleteVideo(Video video)
		{
			_videoDao.Remove(video);
		}

		public void UpdateVideo(Video video)
		{
			_videoDao.Update(video);
		}

	}
}
