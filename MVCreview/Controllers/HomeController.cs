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

        [HttpGet]
        // GET: Menu
        public ActionResult Menu()
        {
            DatabaseContext db = new DatabaseContext();

            //var dishes =(db.Dishes.Select(c=> new {c.DishID,c.DishName,c.Price,c.Description,c.ImageLink,c.Availability}));
            //List<Dish> dishes = (from c in db.Dishes select new { DishID = c.DishID, DishName = c.DishName, Price = c.Price, Description = c.Description, ImageLink = c.ImageLink, Availability = c.Availability });
            List<Dish> dishes = new List<Dish>( (from c in db.Dishes select c));

            List<DishViewModel> menu= new List<DishViewModel>();
            //menu = new <DishViewModel>(dishes.ToList());
            foreach (Dish i in dishes)
            {
                DishViewModel menuItem = new DishViewModel();
                menuItem.Availability = i.Availability;
                menuItem.Description = i.Description;
                menuItem.DishID = i.DishID;
                menuItem.DishName = i.DishName;
                menuItem.ImageLink = i.ImageLink;
                menuItem.Price = i.Price;
                menu.Add(menuItem);     
            }   
            return View(menu);
        }            
        
        [HttpPost]
        public ActionResult Menu(int dishID, string dishname, decimal price, decimal quantity)
        {
          
            List<ShoppingCartViewModel> cart;
            if (Session["shoppingCart"] == null)
            {
                cart = new List<ShoppingCartViewModel>();
                //Session["shoppingCart"] = cart;
            }
            else
            {
                cart = (List<ShoppingCartViewModel>)Session["shoppingCart"];
            }

            ShoppingCartViewModel item = new ShoppingCartViewModel();
            item.dishID = dishID;
            item.dishName = dishname;
            item.dishPrice = price;
            item.quantity = 1;
            cart.Add(item);
            Session["shoppingCart"] = cart;
            return RedirectToAction("Menu");
         
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
