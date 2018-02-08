using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _60322_Ivanov_Egor.DAL.Entities;
using _60322_Ivanov_Egor.DAL.Repositories;
using _60322_Ivanov_Egor.DAL.Interfaces;

namespace _60322_Ivanov_Egor.Controllers
{
    public class AdminController : Controller
    {
        IRepository<Product> repository;
        public AdminController(IRepository<Product> repo)
        {
            repository = repo;
        }
        // GET: Admin
        public ActionResult Index()
        {
            return View(repository.GetAll());

        }


        // GET: Admin/Create
        public ActionResult Create()
        {
            return View(new Product());
        }

        // POST: Admin/Create
        [HttpPost]
        public ActionResult Create(Product prod, HttpPostedFileBase imageUpload = null)
        {
            if (imageUpload != null)
            {
                var count = imageUpload.ContentLength;
                prod.ProdImage = new byte[count];
                imageUpload.InputStream.Read(prod.ProdImage, 0, (int)count);
                prod.MimeType = imageUpload.ContentType;
            }
            try
            {
                repository.Create(prod);
                return RedirectToAction("Index");
            }
            catch
            {
                return View(prod);
            }
        }

        // GET: Admin/Edit/5
        public ActionResult Edit(int id)
        {
            return View(repository.Get(id));
        }

        // POST: Admin/Edit/5
        [HttpPost]
        public ActionResult Edit(Product product, HttpPostedFileBase imageUpload = null)
        {
            if (ModelState.IsValid)
            {
                if (imageUpload != null)
                {
                    var count = imageUpload.ContentLength;
                    product.ProdImage = new byte[count];
                    imageUpload.InputStream.Read(product.ProdImage, 0, (int)count);
                    product.MimeType = imageUpload.ContentType;
                }
                try
                {
                    repository.Update(product);
                    return RedirectToAction("Index");
                }
                catch
                {
                    return View();
                }
            }
            else
            {
                return View(product);
            }
        }

        // GET: Admin/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Admin/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
