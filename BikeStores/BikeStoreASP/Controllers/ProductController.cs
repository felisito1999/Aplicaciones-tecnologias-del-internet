using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BikeDataLibrary.Services;
using BikeDataLibrary.ViewModels;

namespace BikeStoreASP.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult AllProducts()
        {
            var product = GetService.GetProductService().GetAll();
            var productViewModels = GetService.GetProductoModelConverterService().ConvertModelCollectionToViewModelCollection(product);

            return View(productViewModels);
        }
        public ActionResult AddProduct()
        {
            return View(); 
        }
        [HttpPost]
        public ActionResult AddProduct(ProductViewModel productViewModel)
        {
            if(ModelState.IsValid)
            {
                try
                {
                    var producto = GetService.GetProductoModelConverterService().ConvertViewModelToModel(productViewModel);
                    GetService.GetProductService().Insert(producto);

                    return RedirectToAction("AllProducts");
                }
                catch (Exception)
                {
                    return View(); 
                }
            }
            else
            {
                return View();
            }
        }
        public ActionResult UpdateProduct(int id)
        {
            var product = GetService.GetProductService().GetById(id);

            if(product != null)
            {
                var productViewModel = GetService.GetProductoModelConverterService().ConvertModelToViewModel(product);
                return View(productViewModel);
            }
            else
            {
                return View("AllProducts");
            }
        }
        [HttpPost]
        public ActionResult UpdateProduct(ProductViewModel productoViewModel)
        {
            if(ModelState.IsValid)
            {
                try
                {
                    var modifiedProduct = GetService.GetProductoModelConverterService().ConvertViewModelToModel(productoViewModel);
                    GetService.GetProductService().Update(modifiedProduct);

                    return View("AllProducts");
                }
                catch (Exception)
                {
                    return View(); 
                }
            }
            else
            {
                return View(); 
            }
        }
    }
}