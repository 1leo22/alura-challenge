using Dao.Context;
using Model;

namespace Dao
{
	public class VideoDao : AbstractDao<Video>
	{

		public VideoDao(ApiModelContext context) : base(context.Videos, context)
		{
		}
	}
}
