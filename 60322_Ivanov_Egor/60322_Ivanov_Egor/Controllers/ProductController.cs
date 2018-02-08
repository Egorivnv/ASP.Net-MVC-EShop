using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _60322_Ivanov_Egor.DAL.Interfaces;
using _60322_Ivanov_Egor.DAL.Entities;
using _60322_Ivanov_Egor.Models;
using System.Threading.Tasks;

namespace _60322_Ivanov_Egor.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        int pageSize = 5; // the qty of elements showed in a page
        IRepository<Product> repository;
        public ProductController(IRepository<Product> repository)
        {
            this.repository = repository;
        }
        public ActionResult List(string group, int page = 1)
        {
            var lst = repository.GetAll()
            .Where(d => group == null
            || d.ProdCategory.Equals(group))
            .OrderBy(d => d.ProdPrice);
            var model = PageListViewModel<Product>.CreatePage(lst, page, pageSize);
            if (Request.IsAjaxRequest())
            {
                return PartialView("_ListPartial", model);
            }
            return View(model);
        }

        public async Task<FileResult> GetImage(int id)
        {
            Product prod = await repository.GetAsync(id);
            if (prod != null)
                return File(prod.ProdImage, prod.MimeType);
            else
                return null;
        }
    }
}