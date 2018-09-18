using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab2.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        public ActionResult ProductsIndex()
        {
            return View();
        }

        // GET: Products/Product
        public ActionResult Product(String ProductName)
        {
            ViewBag.ProductName = ProductName;
            return View();
        }
    }
}