using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace _60322_Ivanov_Egor.DAL.Entities
{
    class ProductContextInitializer: DropCreateDatabaseIfModelChanges<ProductContext>
    {
        protected override void Seed(ProductContext context)
        {
            List<Product> products = new List<Product>()
            {
                new Product {ProdName = "Aaa", ProdCategory = "A", ProdDescription = "AAA", ProdPrice = 5.25M },
                new Product {ProdName = "Bbb", ProdCategory = "B", ProdDescription = "BBB", ProdPrice = 8.25M },
                new Product {ProdName = "Ccc", ProdCategory = "C", ProdDescription = "CCC", ProdPrice = 10.25M },
                new Product {ProdName = "Aaa", ProdCategory = "A", ProdDescription = "AAA", ProdPrice = 5.25M },
                new Product {ProdName = "Bbb", ProdCategory = "B", ProdDescription = "BBB", ProdPrice = 8.25M },
                new Product {ProdName = "Ccc", ProdCategory = "C", ProdDescription = "CCC", ProdPrice = 10.25M },
                new Product {ProdName = "Aaa", ProdCategory = "A", ProdDescription = "AAA", ProdPrice = 5.25M },
                new Product {ProdName = "Bbb", ProdCategory = "B", ProdDescription = "BBB", ProdPrice = 8.25M }
            };
            context.Products.AddRange(products);
            context.SaveChanges();
        }
    }
}
