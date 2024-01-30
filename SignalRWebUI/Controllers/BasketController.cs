﻿using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SignalRDtoLayer.BasketDto;
using SignalRWebUI.Dtos.BasketDtos;
using System.Text;

namespace SignalRWebUI.Controllers
{
	public class BasketController : Controller
	{
		private readonly IHttpClientFactory _httpClientFactory;

		public BasketController(IHttpClientFactory httpClientFactory)
		{
			_httpClientFactory = httpClientFactory;
		}

		public async Task<IActionResult> Index()
		{
			var client = _httpClientFactory.CreateClient();
			var responseMessage = await client.GetAsync("https://localhost:7195/api/Basket/BasketListByMenuTableWithProductName?id=4");
			if (responseMessage.IsSuccessStatusCode)
			{
				var jsondata = await responseMessage.Content.ReadAsStringAsync();
				var values = JsonConvert.DeserializeObject<List<ResultBasketDtos>>(jsondata);
				return View(values);
			}
			return View();
		}
		public async Task<IActionResult> DeleteBasket(int id)
		{
			var client = _httpClientFactory.CreateClient();
			var responseMessage = await client.DeleteAsync($"https://localhost:7195/api/Basket/{id}");
			if (responseMessage.IsSuccessStatusCode)
			{
				return RedirectToAction("Index");
			}
			return NoContent();
		}
	}
}
