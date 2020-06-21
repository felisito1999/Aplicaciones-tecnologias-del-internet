using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BikeDataLibrary.Services;
using BikeDataLibrary.ServiceModels;


namespace BikeStoresApi.Controllers
{
    public class ProductController : ApiController
    {
        [HttpGet]
        public IEnumerable<ServiceProduct> GetAllProduct()
        {
            var products = GetService.GetProductService().GetAll().ToList();
            var serviceProducts = GetService.GetProductModelServiceModelConverter().ConvertModelCollectionToServiceModelCollection(products);

            return serviceProducts;
        }
        [HttpGet]
        public ServiceProduct GetProductById(int id)
        {
            var product = GetService.GetProductService().GetById(id);
            var serviceProduct = GetService.GetProductModelServiceModelConverter().ConvertModelToServiceModel(product);


            return serviceProduct;
        }
        public void InsertProduct(ServiceProduct serviceProduct)
        {
            var product = GetService.GetProductModelServiceModelConverter().ConvertServiceModelToModel(serviceProduct);
            GetService.GetProductService().Insert(product);
        }
        [HttpPut]
        public void UpdateProduct(int id, ServiceProduct serviceProduct)
        {
            var product = GetService.GetProductService().GetById(id);
            
        }
        [HttpDelete]
        public void deleteProduct(int id)
        {
            GetService.GetProductService().Delete(id);
        }
        //public IHttpActionResult PutUpdate(ProductViewModel productViewModel)
        //{
        //    try
        //    {
        //        var produc
        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }
        //}
    }
}
