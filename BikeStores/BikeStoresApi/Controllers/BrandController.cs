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
    public class BrandController : ApiController
    {
        public IEnumerable<ServiceBrand> GetAllProduct()
        {
            var brands = GetService.GetBrandDataService().GetAll().ToList();
            var serviceBrands = GetService.GetBrandModelServiceModelConverter().ConvertModelCollectionToServiceModelCollection(brands);

            return serviceBrands;
        }
        public ServiceBrand GetProductById(int id)
        {
            var brand = GetService.GetBrandDataService().GetById(id);
            var serviceBrand = GetService.GetBrandModelServiceModelConverter().ConvertModelToServiceModel(brand);


            return serviceBrand;
        }
    }
}
