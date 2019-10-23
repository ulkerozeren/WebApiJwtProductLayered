using System;
using System.Collections.Generic;
using System.Text;
using testJWTConsumer.Data.Context;
using testJWTConsumer.Data.Interfaces;

namespace testJWTConsumer.Service
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DataContext _dataContext;
        public UnitOfWork(DataContext dataContext)
        {
            _dataContext = dataContext;
            ProductRepository = new ProductRepository(dataContext);
        }
        public IProductRepository ProductRepository { get; set; }

        public int Complete()
        {
            return _dataContext.SaveChanges();
        }

        public void Dispose()
        {
            _dataContext.Dispose();
        }
    }
}
