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

		[HttpPost]
		public IActionResult AddVideo([FromBody] Video video)
		{
			_videoService.AddVideo(video);

			return CreatedAtAction(nameof(GetVideoById), new { video.Id }, video);
		}

		[HttpGet("{id}")]
		public IActionResult GetVideoById(int id)
		{
			Video video = _videoService.GetVideoById(id);

			if (video is not null)
			{
				return Ok(video);
			}

			return NotFound();
		}

		[HttpDelete]
		public IActionResult DeleteVideo(int id)
		{
			Video video = _videoService.GetVideoById(id);

			if (video is null)
			{
				return NotFound();
			}

			_videoService.DeleteVideo(video);
			return NoContent();
		}
	}
}
