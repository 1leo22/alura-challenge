using Model;
using System.Linq;

namespace Dao.Interfaces
{
	public interface IVideoDao
	{

		public IQueryable<Video> GetAllVideosIQueryable();

		public Video GetVideoById(int id);

		public void AddVideo(Video video);

		public void DeleteVideo(Video video);

		public void UpdateVideo(Video video);
	}
}
