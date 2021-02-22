using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class Customer10Controller : Controller
    {
        // GET: Customer10
        public ActionResult DisplayCustomer()
        {
            var customer = new Customer10Model(1, "Dalal", 23, "sweleih");

            return View(customer);
        }

        public ActionResult Create()
        {   
            return View();
        }

        [HttpPost]
        public ActionResult Create(Customer10Model cust)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("DisplayCustomer");
            }
           
            return View(cust);
        }
    }
}