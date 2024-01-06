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
    public class EFAboutDal : GenericRepostiory<About>, IAboutDal
    {
        public EFAboutDal(SignalRContext context) : base(context)
        {
        }
    }
}
