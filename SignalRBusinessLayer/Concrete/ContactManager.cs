using SignalRBusinessLayer.Abstract;
using SignalREntityLayer.Entities;
using SignaRDataAccessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalRBusinessLayer.Concrete
{
    public class ContactManager : IContactService
    {
        private readonly IContactDal _contactDal;

        public ContactManager(IContactDal contactDal)
        {
            _contactDal = contactDal;
        }

        public void TAdd(Contact entity)
        {
          _contactDal.Add(entity);
        }

        public void TDelete(Contact entity)
        {
           _contactDal.Delete(entity);
        }

        public Contact TGetByID(int id)
        {
           return _contactDal.GetByID(id);
        }

        public List<Contact> TGetListAll()
        {
            return _contactDal.GetListAll();
        }

        public void TUpdate(Contact entity)
        {
            _contactDal.Update(entity);
        }
    }
}
