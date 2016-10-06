using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCreview.Models;

namespace MVCreview.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        // GET: Menu
        public ActionResult Menu()
        {
            DatabaseContext db = new DatabaseContext();

            var menu =db.Dishes.Select(c=> new {c.DishID,c.DishName,c.Price,c.Description,c.ImageLink,c.Availability});  
            return View(menu);
        }
        // GET: Catering
        public ActionResult Catering()
        {
            return View();
        }
        // GET: Location
        public ActionResult Location()
        {
            return View();
        }
        // GET: Contact
        public ActionResult Contact()
        {
            return View();
        }


    }
}
