using AutoMapper;
using SignalRDtoLayer.SocialMediaDto;
using SignalRDtoLayer.TestiMonialDto;
using SignalREntityLayer.Entities;

namespace SignalRApi.Mapping
{
    public class TestiMonialMapping :Profile
    {
        public TestiMonialMapping()
        {
            CreateMap<TestiMonial, ResultTestiMonialDto>().ReverseMap();
            CreateMap<TestiMonial, CreateTestiMonialDto>().ReverseMap();
            CreateMap<TestiMonial, UpdateTestiMonialDto>().ReverseMap();
            CreateMap<TestiMonial, ResultTestiMonialDto>().ReverseMap();
        }
    }
}
