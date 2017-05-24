using Negarandeh.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Negarandeh.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }


        public ActionResult Logout()
        {
            Session["Username"] = null;
            return RedirectToAction("Login");
        }
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login([Bind(Include = "Username,Password")] Person person)
        {
            using (var db = new MainModel())
            {
                if (db.People.Where(x => x.Username == person.Username && x.Password == person.Password).FirstOrDefault() != null)
                {
                    Session["Username"] = person.Username;
                    return RedirectToAction("Index", "Books");
                }
                else
                {
                    ViewBag.Message = "Invalid Username or Password";
                    return View();
                }
            }
        }
    }
}