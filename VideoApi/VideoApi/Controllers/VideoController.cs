using Microsoft.AspNetCore.Mvc;
using Model;
using Services;
using System.Collections.Generic;

namespace VideoApi.Controllers
{
	[ApiController]
	[Route("api/videos")]
	public class VideoController : ControllerBase
	{
		private readonly VideoService _videoService;

		public VideoController(VideoService videoService)
		{
			_videoService = videoService;
		}

		[HttpGet]
		public IActionResult GetAllVideos()
		{
			List<Video> videoList = _videoService.GetAllVideos();
			return Ok(videoList);
		}
	}
}
