﻿using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SignalRDtoLayer.BookingDto;
using System.Net.Http;
using System.Text;

namespace SignalRWebUI.Controllers
{
	public class BookATableController : Controller
	{
        private readonly IHttpClientFactory _httpClientFactory;

        public BookATableController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        [HttpGet]
		public IActionResult Index()
		{
			return View();
		}
        [HttpPost]
        public async Task<IActionResult> Index(CreateBookingDto createBookingDto)
        {
            createBookingDto.PersonCount= 2;
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(createBookingDto);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PostAsync("https://localhost:7195/api/Booking", stringContent);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index","Default");
            }
            return View();
        }
    }
}
