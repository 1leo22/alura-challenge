﻿using Dao;
using Model;
using System.Collections.Generic;
using System.Linq;

namespace Services
{
	public class VideoService
	{
		private readonly VideoDao _videoDao;

		public VideoService(VideoDao videoDao)
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
	}
}
