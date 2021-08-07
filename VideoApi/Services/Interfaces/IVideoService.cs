using Model;
using System.Collections.Generic;

namespace Services.Interfaces
{
	public interface IVideoService
	{
		public List<Video> GetAllVideos();

		public Video GetVideoById(int id);

		public void AddVideo(Video video);

		public void DeleteVideo(Video video);

		public void UpdateVideo(Video video);

	}
}
