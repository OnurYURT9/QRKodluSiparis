using SignaRDataAccessLayer.Abstract;
using SignaRDataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignaRDataAccessLayer.Repositories
{
    public class GenericRepostiory<T> : IGenericDal<T> where T : class
    {
        private readonly SignalRContext _context;
        public GenericRepostiory(SignalRContext context)
        {
            _context = context;
        }

        public void Add(T entity)
        {
            _context.Add(entity);
            _context.SaveChanges();
        }

        public void Delete(T entity)
        {
            _context.Remove(entity);
            _context.SaveChanges();
        }

        public T GetByID(int id)
        {
            return _context.Set<T>().Find(id);
        }

        public List<T> GetListAll()
        {
           return _context.Set<T>().ToList();   
        }

        public void Update(T entity)
        {
            _context.Update(entity);
            _context.SaveChanges(); 
        }
    }
}
