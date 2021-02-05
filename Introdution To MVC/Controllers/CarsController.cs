using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Introdution_To_MVC.Controllers
{
    [RoutePrefix ("Cars")]
    public class CarsController : Controller
    {
        // GET: Cars
       
       [Route("")]
       [Route("Index")]
        public ContentResult Index()
        {
            return Content("<h1> Attribute based routing Demo </h1>");
        }

        [Route ("Details/{ID:int}")]
        public ContentResult Details(int ID)
        {
            return Content("<h2> Car ID = "+ ID + "</h2>");
        }
        
        [Route("Details/{Name}")]
        public ContentResult Details(string Name)
        {
            return Content("<h2> Car Name = " + Name + "</h2>");
        }
    }
}