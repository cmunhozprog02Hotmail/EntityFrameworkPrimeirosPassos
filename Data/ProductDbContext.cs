using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace Data
{
    public class ProductDbContext : DbContext
    {
        public ProductDbContext()
            : base("name=ProductDB")
        {
            Database.SetInitializer<ProductDbContext>(
                new CreateDatabaseIfNotExists<ProductDbContext>());
            Database.Initialize(false);
        }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Loja> Lojas { get; set; }
    }
}
