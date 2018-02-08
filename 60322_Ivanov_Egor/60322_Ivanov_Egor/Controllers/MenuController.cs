using _60322_Ivanov_Egor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using _60322_Ivanov_Egor.DAL.Interfaces;
using System.Web.Mvc;
using _60322_Ivanov_Egor.DAL.Entities;

namespace _60322_Ivanov_Egor.Controllers
{
    public class MenuController : Controller
    {
        // GET: Menu
        List<MenuItem> items;
        IRepository<Product> repository;

        public MenuController(IRepository<Product> repo)
        {
            repository = repo;
            items = new List<MenuItem>
            {
                new MenuItem {Name="Главная", Controller="Home", Action="Index", Active=string.Empty},
                new MenuItem {Name="Каталог", Controller="Product", Action="List", Active=string.Empty},
                new MenuItem {Name="Администрирование", Controller="Admin", Action="Index", Active=string.Empty}
            };
        }

        public PartialViewResult Main(string c)
        {
            items.First(m => m.Controller == c).Active = "active";
            return PartialView(items);
        }
        public PartialViewResult UserInfo()
        {
            return PartialView();
        }
        public PartialViewResult Side()
        {
            var groups = repository
                        .GetAll()
                        .Select(d => d.ProdCategory)
                        .Distinct();
            return PartialView(groups);
        }
        public PartialViewResult Map(string c)
        {
            items.First(m => m.Controller == c).Active = "active";
            return PartialView(items);
        }
    }
}