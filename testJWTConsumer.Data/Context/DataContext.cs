using Microsoft.EntityFrameworkCore;
using testJWTConsumer.Data.Models;

namespace testJWTConsumer.Data.Context
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext> dbContextOptions):base(dbContextOptions)
        {

        }

        public DbSet<Product> Products { get; set; }
    }
}
