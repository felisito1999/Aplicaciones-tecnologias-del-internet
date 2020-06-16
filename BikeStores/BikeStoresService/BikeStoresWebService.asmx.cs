using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using BikeDataLibrary.BikeStoresData;
using BikeDataLibrary.Services;
using BikeDataLibrary.ViewModels;

namespace BikeStoresService
{
    /// <summary>
    /// Summary description for BikeStoresWebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    [Serializable]
    public class BikeStoresWebService : System.Web.Services.WebService
    {
        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }
        //[WebMethod]
        //public List<ProductViewModel> GetAllProducts()
        //{
        //    using(var context = new BikeStoresEntities())
        //    {
        //        var products = context.products.ToList();
        //        var productsViewModel = BikeDataLibrary.Services.GetService.GetProductoModelConverterService().ConvertModelCollectionToViewModelCollection(products).ToList(); 

        //        return productsViewModel;
        //    }
        //}
        //[WebMethod]
        //public List<product> GetAllProducts()
        //{
        //    List<product> products = new List<product>();
        //    var productsEn = BikeDataLibrary.Services.GetService.GetProductService().GetAll();
        //    foreach(var product in productsEn)
        //    {
        //        products.Add(product);
        //    }
        //    return products; 
        //}
        //[WebMethod]
        //public product GetProductById(int id)
        //{
        //    var product = BikeDataLibrary.Services.GetService.GetProductService().GetById(id);

        //    return product; 
        //}
        //[WebMethod]
        //public void InsertProduct(product product)
        //{
        //    BikeDataLibrary.Services.GetService.GetProductService().Insert(product);
        //}
        //[WebMethod]
        //public void DeleteProduct(int id)
        //{
        //    BikeDataLibrary.Services.GetService.GetProductService().Delete(id);
        //}
        //[WebMethod]
        //public List<brand> GetAllBrands()
        //{
        //    var brands = BikeDataLibrary.Services.GetService.GetBrandDataService().GetAll().ToList();

        //    return brands; 
        //}
        //[WebMethod]
        //public List<category> GetAllCategories()
        //{
        //    var categories = BikeDataLibrary.Services.GetService.GetCategoryDataService().GetAll().ToList();

        //    return categories;
        //}
    }
}
