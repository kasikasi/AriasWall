using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AriasWall.Models;

namespace AriasWall.Controllers
{
    [HandleError]
    public class HomeController : Controller
    {
        private AriasWallDBEntities1 _db = new AriasWallDBEntities1();

        public ActionResult Index()
        {
            ViewData["Message"] = "Welcome to the only place where you can be remembered... or not!";

            return View(_db.Posts.ToList());
        }

        public ActionResult About()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(String text, String author)
        {
            Post post = new Post();

            post.author = author;
            post.message = text;
            post.date = System.DateTime.Now;
            
            _db.AddToPosts(post);

            _db.SaveChanges();

            return RedirectToAction("Index", "Home");
        }
    }
}
