using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Introdution_To_MVC.Models;

namespace Introdution_To_MVC.Controllers
{
    public class ComputerController : Controller
    {
       public ActionResult Display()
        {
            var MyComputer = new ComputerModel
            {
                Name = "Dell",
                Price = 850


            };
            return View(MyComputer);

        }
    }
}