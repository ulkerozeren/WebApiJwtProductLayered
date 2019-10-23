using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using testJWTConsumer.Data.Context;
using testJWTConsumer.Data.Interfaces;

namespace testJWTConsumer.Service
{
    public class Repository<T> : IRepository<T> where T:class
    {
        private readonly DbSet<T> _repository;
        public Repository(DataContext dataContext)
        {
            _repository = dataContext.Set<T>();
        }

        public T Add(T model)
        {
            _repository.Add(model);
            return model;
        }

        public bool Delete(int id)
        {
            bool result = false;
            var model = Find(id);
            if (model!=null)
            {
                result = true;
                _repository.Remove(model);
            }

            return result;
        }

        public T Find(int id)
        {
            return _repository.Find(id);
        }

        public IEnumerable<T> List()
        {
            return _repository.ToList();
        }

        public T Update(T model)
        {
            _repository.Update(model);
            return model;
        }

    }
}
