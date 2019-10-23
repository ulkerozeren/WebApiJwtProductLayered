using System;
using System.Collections.Generic;
using System.Text;

namespace testJWTConsumer.Data.Interfaces
{
    public interface IUnitOfWork:IDisposable
    {
        int Complete();
        IProductRepository ProductRepository { get; set; }
    }
}
