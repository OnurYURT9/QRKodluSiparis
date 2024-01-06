using SignalRBusinessLayer.Abstract;
using SignalREntityLayer.Entities;
using SignaRDataAccessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalRBusinessLayer.Concrete
{
    public class TestiMonialManager : ITestiMonialService
    {
        private readonly ITestiMonialDal _testiMonialDal;

        public TestiMonialManager(ITestiMonialDal testiMonialDal)
        {
            _testiMonialDal = testiMonialDal;
        }

        public void TAdd(TestiMonial entity)
        {
           _testiMonialDal.Add(entity);
        }

        public void TDelete(TestiMonial entity)
        {
           _testiMonialDal.Delete(entity);
        }

        public TestiMonial TGetByID(int id)
        {
            return _testiMonialDal.GetByID(id);
        }

        public List<TestiMonial> TGetListAll()
        {
            return _testiMonialDal.GetListAll();
        }

        public void TUpdate(TestiMonial entity)
        {
             _testiMonialDal.Update(entity);
        }
    }
}
