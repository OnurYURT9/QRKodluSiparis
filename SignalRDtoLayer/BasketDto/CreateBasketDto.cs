using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalRDtoLayer.BasketDto
{
	public class CreateBasketDto
	{
		
		public int ProductId { get; set; }
		public decimal Price { get; set; }
		public decimal Count { get; set; }
		public decimal TotalPrice { get; set; }
		
		public int MenuTableId { get; set; }
		
	}
}
