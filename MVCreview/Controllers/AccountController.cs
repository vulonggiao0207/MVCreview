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
        public ActionResult Login()
        {
            return View();
        }
        //POST:/Acount/Register/LoginViewModel
        [HttpPost]
        [AllowAnonymous]
        public ActionResult Login(LoginViewModel model)
        {
            
                if (ModelState.IsValid)
                {
                    DatabaseContext db = new DatabaseContext();
                   var res = db.Customers.FirstOrDefault(c => c.CustomerUserName == model. CustomerUserName 
                    && c.CustomerPassword == model.CustomerPassword);
               
                if (res != null)
                    {
                        Session["userName"]= res.CustomerName;
                        Session["customerID"] = res.CustomerID;
                        return RedirectToAction("Index", "Home");
                        //
                    }
                    return View();
                }
                else
                {
                    return View("Error");
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
                    return View();
               }
            }
            catch
            {
                return View("Error");
            }
        }

        //GET: Account/Logout
        public ActionResult LogOut()
        {
            Session.Remove("userName");
            Session.Remove("customerID");
            return RedirectToAction("Index", "Home");
        }
      
        [AllowAnonymous]
        //Get: Account/AccountManagement/7
        public ActionResult AccountManagement(int CustomerID)
        {
            try
            {
                if (Session["customerID"] != null)
                {
                    DatabaseContext db = new DatabaseContext();
                    Customer res = db.Customers.FirstOrDefault(c => c.CustomerID == CustomerID);
                    return View(res);
                }
                else
                {
                    return RedirectToAction("Index", "Home");
                }
            }
            catch
            {
                return View("Error");
            }   
        }
        [AllowAnonymous]
        public ActionResult Details(int CustomerID)
        {
            try
            {
                if (Session["customerID"] != null)
                {
                    DatabaseContext db = new DatabaseContext();
                    Customer res = db.Customers.FirstOrDefault(c => c.CustomerID == CustomerID);
                    DetailsViewModel details = new DetailsViewModel();
                    details.CustomerID = res.CustomerID;
                    details.CustomerAddress = res.CustomerAddress;
                    details.CustomerEmail = res.CustomerEmail;
                    details.CustomerName = res.CustomerName;
                    details.CustomerPhone = res.CustomerPhone;                       
                    return View(details);
                }
                else
                {
                    return RedirectToAction("AccountManagement", "Account", new { CustomerID = CustomerID });
                }
            }
            catch
            {
                return View("Error");
            }       
        }
        //POST:/Account/Register/RegisterViewModel   

        [HttpPost]
        [AllowAnonymous]
        public ActionResult Details(DetailsViewModel model)
        {
            try
            {
                // TODO: Add insert logic here    
                if (ModelState.IsValid)
                {
                    DatabaseContext db = new DatabaseContext();
                    Customer customer = db.Customers.FirstOrDefault(c => c.CustomerID == model.CustomerID);

                    customer.CustomerID = model.CustomerID;
                    customer.CustomerName = model.CustomerName;
                    customer.CustomerAddress = model.CustomerAddress;
                    customer.CustomerPhone = model.CustomerPhone;
                    customer.CustomerEmail = model.CustomerEmail;      
                    
                    
                    db.SaveChanges();
                    Session["userName"] = model.CustomerName;
                    return RedirectToAction("AccountManagement", "Account", new { CustomerID = model.CustomerID });
                }
                else
                {
                    return View();
                }
            }
            catch
            {
                return View("Error");
            }
        }
        [AllowAnonymous]
        public ActionResult Password(int CustomerID)
        {
            try
            {
                if (Session["customerID"] != null)
                {
                    DatabaseContext db = new DatabaseContext();
                    Customer res = db.Customers.FirstOrDefault(c => c.CustomerID == CustomerID);
                    PasswordViewModel password = new PasswordViewModel();
                    password.CustomerID = res.CustomerID;
                    password.CustomerUserName = res.CustomerUserName;

                    return View(password);
                }
                else
                {
                    return RedirectToAction("AccountManagement", "Account", new { CustomerID = CustomerID });
                }
            }
            catch
            {
                return View("Error");
            }
        }
        //POST:/Account/Register/RegisterViewModel   

        [HttpPost]
        [AllowAnonymous]
        public ActionResult Password(PasswordViewModel model)
        {
            try
            {
                // TODO: Add insert logic here    
                if (ModelState.IsValid)
                {
                    DatabaseContext db = new DatabaseContext();
                    Customer customer = db.Customers.FirstOrDefault(c => c.CustomerID == model.CustomerID);
                  
                    customer.CustomerID = model.CustomerID;
                    customer.CustomerUserName = model.CustomerUserName;
                    customer.CustomerPassword = model.NewPassword;                        
                    db.SaveChanges();
                    return RedirectToAction("AccountManagement", "Account", new { CustomerID = model.CustomerID });
                }
                else
                {
                    return View();
                }
            }
            catch
            {
                return View("Error");
            }
        }





    }
}
