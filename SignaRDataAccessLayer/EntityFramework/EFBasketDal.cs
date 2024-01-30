using Microsoft.EntityFrameworkCore;
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

	public class EfBasketDal : GenericRepostiory<Basket>, IBasketDal
	{
		public EfBasketDal (SignalRContext context) : base (context)
		{

		}

		public List<Basket> GetBasketByMenuTableNumber(int id)
		{
			using var context = new SignalRContext();
			var values = context.Baskets.Where(x => x.MenuTableId == id).Include(y=>y.Product).ToList();
			return values;
		}
	}
}