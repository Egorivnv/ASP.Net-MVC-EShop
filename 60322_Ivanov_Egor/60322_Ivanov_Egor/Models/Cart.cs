using _60322_Ivanov_Egor.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _60322_Ivanov_Egor.Models
{
    public class Cart
    {
        List<CartItem> items;
        public Cart()
        {
            items = new List<CartItem>();
        }
        /// <summary>
        /// Добавить в корзину
        /// </summary>
        /// <param name="prod">объект для добавления</param>
        public void AddItem(Product prod)
        {
            var item = items.Find(i => i.Product.ProdId == prod.ProdId);
            if (item == null)
            {
                items.Add(new CartItem { Product = prod, Quantity = 1 });
            }
            else
                item.Quantity += 1;
        }
        /// <summary>
        /// Удалить из корзины
        /// </summary>
        /// <param name="Product">Объект для удаления</param>
        public void RemoveItem(Product prod)
        {
            var item = items.Find(i => i.Product.ProdId == prod.ProdId);
            if (item.Quantity == 1)
                items.Remove(item);
            else
                item.Quantity -= 1;
        }
        /// <summary>
        /// Очистить корзину
        /// </summary>
        public void Clear()
        {
            items.Clear();
        }
        /// <summary>
        /// Получение суммы заказа
        /// </summary>
        /// <returns></returns>
        public decimal GetTotal()
        {
            return items.Sum(i => i.Product.ProdPrice * i.Quantity);
        }
        /// <summary>
        /// Получение содержимого корзины
        /// </summary>
        /// <returns></returns>
        public IEnumerable<CartItem> GetItems()
        {
            return items;
        }
    }
    public class CartItem
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }
    }
}