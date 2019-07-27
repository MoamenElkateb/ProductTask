using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccessLayer.Repositry
{
    public interface IRepositry<T>
    {
        IQueryable<T> GetAll();
        T GetById(params object[] id);
        T Add(T t);
        T Update(T t);
        bool Delete(T t);
        T Save(T t);
     
    }
}
