using AutoMapper;
using SignalRDtoLayer.SocialMediaDto;

namespace SignalRApi.Mapping
{
    public class SocialMediaMapping :Profile
    {
        public SocialMediaMapping()
        {
            CreateMap<SocialMediaMapping,ResultSocialMediaDto>().ReverseMap();
            CreateMap<SocialMediaMapping,CreateSocialMediaDto>().ReverseMap();
            CreateMap<SocialMediaMapping,UpdateSocialMediaDto>().ReverseMap();
            CreateMap<SocialMediaMapping,ResultSocialMediaDto>().ReverseMap();

        }
    }
}
