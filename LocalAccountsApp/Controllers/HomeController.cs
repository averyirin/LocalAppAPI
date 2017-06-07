using LocalAccountsApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LocalAccountsApp.Controllers
{
    public class HomeController : Controller
    {
        ApplicationDbContext context;

        public ActionResult Index()
        {

            context = new ApplicationDbContext();
            ViewBag.Title = "Home Page";
            ViewBag.Name = new SelectList(context.Roles.Where(u => !u.Name.Contains("Admin"))
                                            .ToList(), "Name", "Name");
            return View();
        }
    }
}
