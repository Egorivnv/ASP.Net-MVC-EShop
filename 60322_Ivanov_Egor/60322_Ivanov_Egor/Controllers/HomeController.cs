using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _60322_Ivanov_Egor.Models;

namespace _60322_Ivanov_Egor.Controllers
{
    public class HomeController : Controller
    {
        List<User> users = new List<User>() {
            new User { UserId = 1, Name = "GGG" },
            new User {UserId=2, Name="AAA" }
        };
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.MyText = "!!!";

            SelectList listColors = new SelectList (Enum.GetValues(typeof(System.Drawing.KnownColor)));

            SelectList usersList = new SelectList(users, "UserId", "Name");
            ViewBag.Users = usersList;
            ViewBag.ListColors = listColors;
            return View();
        }
    }
}