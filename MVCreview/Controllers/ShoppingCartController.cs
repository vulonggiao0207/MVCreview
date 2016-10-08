using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCreview.Models;

namespace MVCreview.Controllers
{
    public class ShoppingCartController : Controller
    {
        // GET: ShoppingCart
        public ActionResult Index()
        {
            try
            {
                if (Session["shoppingCart"] != null)
                { 
                    var cart = (List<ShoppingCartViewModel>)Session["shoppingCart"];
                    return View(cart);
                }
                return RedirectToAction("Menu","Home");
            }
            catch {
                return RedirectToAction("Error");
            }               
        }
        [HttpGet]
        public ActionResult Checkout(List<ShoppingCartViewModel> cart)
        {
            return View();   
        }


    }
}
