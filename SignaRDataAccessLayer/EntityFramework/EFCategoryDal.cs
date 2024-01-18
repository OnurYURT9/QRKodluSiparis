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
    public class EFCategoryDal : GenericRepostiory<Category>, ICategoryDal
    {
        public EFCategoryDal(SignalRContext context) : base(context)
        {
        }

		public int ActiveCategoryCount()
		{
			using var context = new SignalRContext();
			return context.Categories.Where(x=>x.CategoryStatus==true).Count();	
		}

		public int CategoryCount()
		{
			using var context = new SignalRContext();
			return context.Categories.Count();
		}

		public int PassiveCategoryCount()
		{
			using var context = new SignalRContext();
			return context.Categories.Where(x => x.CategoryStatus == false).Count();
		}
	}
}
