using _60322_Ivanov_Egor.DAL.Entities;
using _60322_Ivanov_Egor.DAL.Interfaces;
using _60322_Ivanov_Egor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Mvc;

namespace _60322_Ivanov_Egor.Controllers
{
    public class CartController : Controller
    {
        IRepository<Product> repository;
        public CartController(IRepository<Product> repo)
        {
            repository = repo;
        }
        public ActionResult Index(string returnUrl)
        {
            TempData["returnUrl"] = returnUrl;
            return View(GetCart());
        }
        public Cart GetCart()
        {
            Cart cart = Session["Cart"] as Cart;
            if (cart == null)
            {
                cart = new Cart();
                Session["Cart"] = cart;
            }
            return cart;
        }
        /// <summary>
        /// Добавление товара в корзину
        /// </summary>
        /// <param name="id">id добавляемого элемента</param>
        /// <param name="returnUrl">URL страницы для возврата</param>
        /// <returns></returns>
        public RedirectResult AddToCart(int id, string returnUrl)
        {
            var item = repository.Get(id);
            if (item != null)
                GetCart().AddItem(item);
            return Redirect(returnUrl);
        }

        public PartialViewResult CartSummary(string returnUrl)
        {
            TempData["returnUrl"] = returnUrl;
            return PartialView(GetCart());
        }
    }
}
