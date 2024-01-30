using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalRBusinessLayer.Abstract;
using SignalRDtoLayer.MenuTableDto;
using SignalREntityLayer.Entities;

namespace SignalRApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class MenuTablesController : ControllerBase
	{
		private readonly IMenuTableService _menuTableService;

		public MenuTablesController(IMenuTableService menuTableService)
		{
			_menuTableService = menuTableService;
		}
		[HttpGet("MenuTableCount")]
		public IActionResult MenuTableCount()
		{
			return Ok(_menuTableService.TMenuTableCount());
		}
		[HttpGet]
		public IActionResult MenuTableList()
		{
			var values = _menuTableService.TGetListAll();
			return Ok(values);
		}
		[HttpPost]
		public IActionResult CreateMenuTable(CreateMenuTableDto createMenuTableDto)
		{
			MenuTable menuTable = new MenuTable()
			{
				Name = createMenuTableDto.Name,
				Status = false,
				 
			};
			_menuTableService.TAdd(menuTable);
			return Ok("Masa başarılı bir şekilde eklendi");
		}

		[HttpDelete("{id}")]
		public IActionResult DeleteMenuTable(int id)
		{
			var value = _menuTableService.TGetByID(id);
			_menuTableService.TDelete(value);
			return Ok("Masa alanı silindi.");
		}
		[HttpPut]
		public IActionResult UpdateMenuTable(UpdateMenuTableDto updateMenuTableDto)
		{
			MenuTable menuTable = new MenuTable()
			{
				Name = updateMenuTableDto.Name,
				Status = false,
				MenuTableId = updateMenuTableDto.MenuTableId,
			};
			_menuTableService.TUpdate(menuTable);
			return Ok("Masa alanı güncellendi");
		}
		[HttpGet("{id}")]
		public IActionResult GetMenuTable(int id)
		{
			var value = _menuTableService.TGetByID(id);
			return Ok(value);
		}
	}
}
