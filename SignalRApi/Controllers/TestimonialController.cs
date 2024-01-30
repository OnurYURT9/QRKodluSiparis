using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalRBusinessLayer.Abstract;
using SignalRDtoLayer.ProductDto;
using SignalRDtoLayer.TestiMonialDto;
using SignalREntityLayer.Entities;

namespace SignalRApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestiMonialController : ControllerBase
    {
        private readonly ITestiMonialService _testiMonialService;
        private readonly IMapper _mapper;

        public TestiMonialController(ITestiMonialService testiMonialService, IMapper mapper)
        {
            _testiMonialService = testiMonialService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult TestiMonialList()
        {
            var value = _mapper.Map<List<ResultTestiMonialDto>>(_testiMonialService.TGetListAll());
            return Ok(value);
        }
        [HttpPost]
        public IActionResult CreateTestiMonial(CreateTestiMonialDto createTestiMonialDto)
        {
            _testiMonialService.TAdd(new TestiMonial()
            {
                Comment= createTestiMonialDto.Comment,
                ImageUrl= createTestiMonialDto.ImageUrl,
                Name= createTestiMonialDto.Name,
                Status= createTestiMonialDto.Status,
                Title = createTestiMonialDto.Title,
            });
            return Ok("Müşteri Yorum Bilgisi Eklendi");
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteTestiMonial(int id)
        {
            var value = _testiMonialService.TGetByID(id);
            _testiMonialService.TDelete(value);
            return Ok("Müşteri Yorum bilgisi Silindi");
        }
        [HttpGet("{id}")]
        public IActionResult GetTestiMonial(int id)
        {
            var value = _testiMonialService.TGetByID(id);

            return Ok(value);
        }
        [HttpPut]
        public IActionResult UpdateTestiMonial(UpdateTestiMonialDto updateTestiMonialDto)
        {
            _testiMonialService.TUpdate(new TestiMonial()
            {
                Name= updateTestiMonialDto.Name,
                Title= updateTestiMonialDto.Title,
                Comment= updateTestiMonialDto.Comment,
                ImageUrl = updateTestiMonialDto.ImageUrl,
                Status= updateTestiMonialDto.Status,
                TestiMonialID = updateTestiMonialDto.TestiMonialID
            });
            return Ok("Müşteri Yorum bilgisi Güncellendi");
        }
    }
}
