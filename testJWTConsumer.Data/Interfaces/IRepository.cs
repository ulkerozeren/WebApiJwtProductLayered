using System;
using System.Collections.Generic;
using System.Text;

namespace testJWTConsumer.Data.Interfaces
{
    public interface IRepository<T> where T:class
    {
        T Find(int id);
        T Add(T model);
        T Update(T model);
        IEnumerable<T> List();
        bool Delete(int id);
    }
}
