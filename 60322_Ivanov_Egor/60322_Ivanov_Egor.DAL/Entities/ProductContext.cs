using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _60322_Ivanov_Egor.DAL.Entities
{
    class ProductContext: DbContext
    {
        public ProductContext (string name) : base(name)
        {
            Database.SetInitializer(new ProductContextInitializer());
        }
        public DbSet<Product> Products { get; set; }

    }
}
