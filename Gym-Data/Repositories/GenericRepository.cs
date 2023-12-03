using System;
using Gym_Data.Concrete;
using Gym_Data.Abstract;

namespace Gym_Data.Repositories
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        public void Delete(T obj)
        {
            var c = new Context();
            c.Set<T>().Remove(obj);
            c.SaveChanges();
        }

        public T GetByID(int ID)
        {
            var c = new Context();
            return c.Set<T>().Find(ID);
        }

        public List<T> GetList()
        {
            var c = new Context();
            return c.Set<T>().ToList();
        }

        public void Insert(T obj)
        {
            var c = new Context();
            c.Set<T>().Add(obj);
            c.SaveChanges();
        }

        public void Update(T obj)
        {
            var c = new Context();
            c.Set<T>().Update(obj);
            c.SaveChanges();
        }
    }
}

