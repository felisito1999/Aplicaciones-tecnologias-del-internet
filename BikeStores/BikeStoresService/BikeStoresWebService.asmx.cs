using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using BikeDataLibrary.BikeStoresData;
using BikeDataLibrary.Services;
using BikeDataLibrary.ViewModels;
using BikeDataLibrary.ServiceModels;

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
        public List<ServiceProduct> GetAllServiceProducts()
        {
            var product = BikeDataLibrary.Services.GetService.GetProductService().GetAll().ToList();
            var serviceProducts = BikeDataLibrary.Services.GetService.GetProductModelServiceModelConverter().ConvertModelCollectionToServiceModelCollection(product);

            return serviceProducts; 
        }
        [WebMethod]
        public ServiceProduct GetById(int id)
        {
            var product = BikeDataLibrary.Services.GetService.GetProductService().GetById(id);
            var serviceProduct = BikeDataLibrary.Services.GetService.GetProductModelServiceModelConverter().ConvertModelToServiceModel(product);

            return serviceProduct; 
        }
        [WebMethod]
        public void Insert(ServiceProduct serviceProduct)
        {
            var product = BikeDataLibrary.Services.GetService.GetProductModelServiceModelConverter().ConvertServiceModelToModel(serviceProduct);
            BikeDataLibrary.Services.GetService.GetProductService().Insert(product);
        }
        [WebMethod]
        public void Update(ServiceProduct serviceProduct)
        {
            var product = BikeDataLibrary.Services.GetService.GetProductModelServiceModelConverter().ConvertServiceModelToModel(serviceProduct);
            BikeDataLibrary.Services.GetService.GetProductService().Update(product);
        }
        [WebMethod]
        public void Delete(int id)
        {
            BikeDataLibrary.Services.GetService.GetProductService().Delete(id);
        }
        [WebMethod]
        public List<ServiceBrand> GetAllServiceBrands()
        {
            var brands = BikeDataLibrary.Services.GetService.GetBrandDataService().GetAll().ToList();
            var serviceBrands = BikeDataLibrary.Services.GetService.GetBrandModelServiceModelConverter().ConvertModelCollectionToServiceModelCollection(brands);

            return serviceBrands;
        }
        [WebMethod]
        public ServiceBrand GetServiceBrandById(int id)
        {
            var brand = BikeDataLibrary.Services.GetService.GetBrandDataService().GetById(id);
            var serviceBrand = BikeDataLibrary.Services.GetService.GetBrandModelServiceModelConverter().ConvertModelToServiceModel(brand);

            return serviceBrand;
        }
        [WebMethod]
        public List<ServiceCategory> GetAllServiceCategories()
        {
            var categories = BikeDataLibrary.Services.GetService.GetCategoryDataService().GetAll().ToList();
            var serviceCategories = BikeDataLibrary.Services.GetService.GetCategoryModelServiceModelConverter().ConvertModelCollectionToServiceModelCollection(categories);

            return serviceCategories;
        }
        [WebMethod]
        public ServiceCategory GetServiceCategoryById(int id)
        {
            var category = BikeDataLibrary.Services.GetService.GetCategoryDataService().GetById(id);
            var serviceCategory = BikeDataLibrary.Services.GetService.GetCategoryModelServiceModelConverter().ConvertModelToServiceModel(category);

            return serviceCategory;
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
