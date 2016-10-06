using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using MVCreview.Models;

namespace MVCreview.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Index()
        {
            return View();
        }
        //GET:/Account/Login
        [AllowAnonymous]
        public ActionResult Login(string returnURL)
        {
            ViewBag.ReturnUrl = returnURL;
            return View(returnURL);
        }
        //POST:/Acount/Register/LoginViewModel
        [HttpPost]
        [AllowAnonymous]
        public ActionResult Login(LoginViewModel model, string returnURL)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    DatabaseContext db = new DatabaseContext();
                    var res = from cus in db.Customers
                              where cus.CustomerUserName == model.CustomerUserName
                              || cus.CustomerPassword == model.CustomerPassword
                              select cus.CustomerName;
                    if (res != null)
                    {
                        Session["userName"]= res;
                        ViewBag.Name = res;
                        return RedirectToAction(returnURL);
                        //
                    }
                    return View("Index","Home");
                }
                else
                {
                    return View(ModelState);
                }
            }

            catch
            {
                return View(ModelState);
            }
        }
        // GET: /Account/Register
        [AllowAnonymous]
        public ActionResult Register()
        {
            return View();
        }
        //POST:/Account/Register/RegisterViewModel   
       
        [HttpPost]
        public ActionResult Register(RegisterViewModel model)
        {
            try
            {
                // TODO: Add insert logic here    
                if (ModelState.IsValid)
                {
                    DatabaseContext db = new DatabaseContext();
                    var customer = new Customer {CustomerName=model.CustomerName,CustomerAddress=model.CustomerAddress,
                    CustomerPhone=model.CustomerPhone,CustomerEmail=model.CustomerEmail,CustomerUserName=model.CustomerUserName,CustomerPassword=model.CustomerPassword};
                    db.Customers.Add(customer);
                    db.SaveChanges();

                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    return View(model);
                }
            }
            catch
            {
                return View(model);
            }
        }

        // GET: Account/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Account/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }


       
    }
}
