using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Model;
using Model.Dto;
using Services.Interfaces;
using System.Collections.Generic;

namespace VideoApi.Controllers
{
	[ApiController]
	[Route("api/videos")]
	public class VideoController : ControllerBase
	{
		private readonly IVideoService _videoService;

		private readonly IMapper _mapper;

		public VideoController(IVideoService videoService, IMapper mapper)
		{
			_videoService = videoService;
			_mapper = mapper;
		}

		[HttpGet]
		public IActionResult GetAllVideos()
		{
			List<Video> videoList = _videoService.GetAllVideos();
			return Ok(videoList);
		}

		[HttpPost]
		public IActionResult AddVideo([FromBody] CreateVideoDto videoDto)
		{
			Video video = _mapper.Map<Video>(videoDto);
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

		[HttpPut("{id}")]
		public IActionResult UpdateVideo(int id, [FromBody] UpdateVideoDto videoDto)
		{
			Video video = _videoService.GetVideoById(id);

			if (video is null)
			{
				return NotFound();
			}

			_mapper.Map(videoDto, video);
			_videoService.UpdateVideo(video);

			return NoContent();
		}
	}
}
