using System;
using System.Collections.Generic;
using System.Text;
using testJWTConsumer.Data.Context;
using testJWTConsumer.Data.Interfaces;
using testJWTConsumer.Data.Models;

namespace testJWTConsumer.Service
{
    public class ProductRepository:Repository<Product>,IProductRepository
    {
        private readonly DataContext _dataContext;
        public ProductRepository(DataContext dataContext):base(dataContext)
        {
            _dataContext = dataContext;
        }
    }
}
