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
    public class EFTestiMonialDal : GenericRepostiory<TestiMonial>, ITestiMonialDal
    {
        public EFTestiMonialDal(SignalRContext context) : base(context)
        {
        }
    }
}
