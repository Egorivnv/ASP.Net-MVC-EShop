using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _60322_Ivanov_Egor.DAL.Interfaces
{
    public interface IRepository<T> where T: class
    {
        IEnumerable<T> GetAll();
        T Get(int id);
        Task<T> GetAsync(int id);
        IEnumerable<T> Find(Func<T, bool> predicate);
        //IEnumerable<T> Find1(Predicate<T> predicate); - alternative
        void Create(T t);
        void Update(T t);
        void Delete(int id);
    }
}
