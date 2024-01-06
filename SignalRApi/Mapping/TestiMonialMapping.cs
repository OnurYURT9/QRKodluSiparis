using AutoMapper;
using SignalRDtoLayer.SocialMediaDto;
using SignalRDtoLayer.TestiMonialDto;

namespace SignalRApi.Mapping
{
    public class TestiMonialMapping :Profile
    {
        public TestiMonialMapping()
        {
            CreateMap<TestiMonialMapping, ResultTestiMonialDto>().ReverseMap();
            CreateMap<TestiMonialMapping, CreateTestiMonialDto>().ReverseMap();
            CreateMap<TestiMonialMapping, UpdateTestiMonialDto>().ReverseMap();
            CreateMap<TestiMonialMapping, ResultTestiMonialDto>().ReverseMap();
        }
    }
}
