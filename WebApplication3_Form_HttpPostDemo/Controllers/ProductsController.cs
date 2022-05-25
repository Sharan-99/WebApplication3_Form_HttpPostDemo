using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication3_Form_HttpPostDemo.Models;

namespace WebApplication3_Form_HttpPostDemo.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        public ActionResult Add()
        {
            return View();
        }
         
        /*
        public ActionResult Save(int Id, string Name, double Price)
        {
            return Content("Saved the Details of: " + Name);
        }                */

        [HttpPost]
        public ActionResult Add(Product prod)
        {
            return Content("Saved the Details of the Product:" + prod.Name);
        }
    }
}