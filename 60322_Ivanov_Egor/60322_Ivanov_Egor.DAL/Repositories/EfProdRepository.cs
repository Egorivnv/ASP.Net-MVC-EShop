using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _60322_Ivanov_Egor.DAL.Interfaces;
using _60322_Ivanov_Egor.DAL.Entities;
using System.Data.Entity;

namespace _60322_Ivanov_Egor.DAL.Repositories
{
    public class EfProdRepository : IRepository<Product>
    {
        ProductContext context;
        public EfProdRepository (string name)
        {
            context = new ProductContext(name);
        }
        public void Create(Product t)
        {
            context.Products.Add(t);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            Product item = context.Products.Find(id);
            if (item != null)
            {
                context.Products.Remove(item);
                context.SaveChanges();
            }
        }

        public IEnumerable<Product> Find(Func<Product, bool> predicate)
        {
            return context.Products.Where(predicate).ToList();
        }

        public Product Get(int id)
        {
            return context.Products.Find(id);
        }

        public IEnumerable<Product> GetAll()
        {
            return context.Products;
        }

        public Task<Product> GetAsync(int id)
        {
            return context.Products.FindAsync(id);
        }

        public void Update(Product t)
        {
            context.Entry<Product>(t).State = EntityState.Modified;
            context.SaveChanges();
        }
    }
}
