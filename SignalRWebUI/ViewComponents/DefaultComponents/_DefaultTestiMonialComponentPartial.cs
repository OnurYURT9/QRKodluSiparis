using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SignalRWebUI.Dtos.TestiMonialDtos;

namespace SignalRWebUI.ViewComponents.DefaultComponents
{
    public class _DefaultTestiMonialComponentPartial : ViewComponent
    {
		private readonly IHttpClientFactory _httpClientFactory;

		public _DefaultTestiMonialComponentPartial(IHttpClientFactory httpClientFactory)
		{
			_httpClientFactory = httpClientFactory;
		}


		public async Task<IViewComponentResult> InvokeAsync()
		{
			var client = _httpClientFactory.CreateClient();
			var responseMessage = await client.GetAsync("https://localhost:7195/api/TestiMonial");

			var jsondata = await responseMessage.Content.ReadAsStringAsync();
			var values = JsonConvert.DeserializeObject<List<ResultTestiMonialDto>>(jsondata);
			return View(values);


		}
	}
}
