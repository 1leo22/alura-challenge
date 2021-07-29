using Dao.Interfaces;
using Model;
using Services.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace Services
{
	public class VideoService : IVideoService
	{
		private readonly IVideoDao _videoDao;

		public VideoService(IVideoDao videoDao)
		{
			_videoDao = videoDao;
		}

		public List<Video> GetAllVideos()
		{
			List<Video> videoList = _videoDao.GetAllVideosIQueryable().ToList();

			return videoList;
		}

		public Video GetVideoById(int id)
		{
			Video video = _videoDao.GetVideoById(id);

			return video;
		}

		public void AddVideo(Video video)
		{
			_videoDao.AddVideo(video);
		}

		public void DeleteVideo(Video video)
		{
			_videoDao.DeleteVideo(video);
		}
	}
}
