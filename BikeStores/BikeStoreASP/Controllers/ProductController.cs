using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BikeDataLibrary.Services;

namespace BikeStoreASP.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult AllProducts()
        {
            var products = GetService.GetProductService().GetAll();
            var productsViewModel = GetService.

            return View(products);
        }
    }
}