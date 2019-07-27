using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccessLayer.Repositry
{
    public class Repositry<T> : IRepositry<T> where T : class
    {
        protected DbSet<T> DbSet { get; set; }
        private ProductTask DbContext { get; }

        public Repositry(ProductTask dbContext)
        {
            DbContext = dbContext;
            DbSet = DbContext.Set<T>();
        }    
        public T Add(T t)
        {
            DbSet.Add(t);
            return DbContext.SaveChanges() > 0 ? t : null;
        }
        public T Update(T t)
        {
            DbContext.Entry(t).State = EntityState.Modified;
            return DbContext.SaveChanges() > 0 ? t : null;
        }
        public bool Delete(T t)
        {
            DbSet.Remove(t);
            return DbContext.SaveChanges() > 0;
        }
        public T GetById(params object[] id)
        {
            return DbSet.Find(id);
        }
        public IQueryable<T> GetAll()
        {
            return DbSet;
        }
        public T Save(T t)
        {
            throw new NotImplementedException();
        }
    }
}
