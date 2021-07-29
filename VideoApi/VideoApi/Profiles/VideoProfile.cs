using AutoMapper;
using Model.Dto;

namespace Model.Profiles
{
	public class VideoProfile : Profile
	{
		public VideoProfile()
		{
			CreateMap<UpdateVideoDto, Video>();
			CreateMap<CreateVideoDto, Video>();
		}
	}
}
