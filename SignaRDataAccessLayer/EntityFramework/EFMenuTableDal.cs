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
	public class EFMenuTableDal : GenericRepostiory<MenuTable>, IMenuTableDal
	{
		public EFMenuTableDal(SignalRContext context) : base(context)
		{
		}

		public int MenuTableCount()
		{
			using var context = new SignalRContext();
			return context.MenuTables.Count();
		}
	}
}
