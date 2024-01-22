using SignalREntityLayer.Entities;
using SignaRDataAccessLayer.Abstract;
using SignaRDataAccessLayer.Concrete;
using SignaRDataAccessLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignaRDataAccessLayer.EntityFramework
{
	public class EFOrderDal : GenericRepostiory<Order>, IOrderDal
	{
		public EFOrderDal(SignalRContext context) : base(context)
		{

		}

		public int ActiveOrderCount()
		{
			using var context = new SignalRContext();
			return context.Orders.Where(x => x.Description == "Müşteri Masada").Count();
		}

		public decimal LastOrderPrice()
		{
			using var context = new SignalRContext();
			return context.Orders.OrderByDescending(x => x.OrderId).Take(1).Select(y => y.TotalPrice).FirstOrDefault();
		}

		public decimal TodayTotalPrice()
		{
			return 0;

		}

		public int TotalOrderCount()
		{
			using var context = new SignalRContext();
			return context.Orders.Count();
		}
	}
}
