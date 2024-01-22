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
	public class EfMoneyCaseDal : GenericRepostiory<MoneyCase>, IMoneyCaseDal
	{
		public EfMoneyCaseDal(SignalRContext context) : base(context)
		{
		}

		public decimal TotalMoneyCaseAmount()
		{
			using var context = new SignalRContext();
			return context.MoneyCases.Select(x => x.TotalAmount).FirstOrDefault();
		}
	}
}
