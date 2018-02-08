using _60322_Ivanov_Egor.DAL.Entities;
using _60322_Ivanov_Egor.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;

namespace _60322_Ivanov_Egor.DAL.Repositories
{
    public class FakeRepository : IRepository<Product>
    {
        public void Create(Product t)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> Find(Func<Product, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public Product Get(int id)
        {
            return GetAll().Where(x => x.ProdId == id).FirstOrDefault();
             
        }

        public IEnumerable<Product> GetAll()
        {
            return new List<Product>()
            {
                new Product {ProdId = 1, ProdName = "Aaa", ProdCategory = "A", ProdDescription ="AAA", ProdPrice = 5.25M },
                new Product {ProdId = 2, ProdName = "Bbb", ProdCategory = "B", ProdDescription ="BBB", ProdPrice = 8.25M },
                new Product {ProdId = 3, ProdName = "Ccc", ProdCategory = "C", ProdDescription ="CCC", ProdPrice = 10.25M },
                new Product {ProdId = 4, ProdName = "Aaa", ProdCategory = "A", ProdDescription ="AAA", ProdPrice = 5.25M },
                new Product {ProdId = 5, ProdName = "Bbb", ProdCategory = "B", ProdDescription ="BBB", ProdPrice = 8.25M },
                new Product {ProdId = 6, ProdName = "Ccc", ProdCategory = "C", ProdDescription ="CCC", ProdPrice = 10.25M },
                new Product {ProdId = 7, ProdName = "Aaa", ProdCategory = "A", ProdDescription ="AAA", ProdPrice = 5.25M },
                new Product {ProdId = 8, ProdName = "Bbb", ProdCategory = "B", ProdDescription ="BBB", ProdPrice = 8.25M }
            };
        }

        public Task<Product> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Product t)
        {
            throw new NotImplementedException();
        }
    }
}
