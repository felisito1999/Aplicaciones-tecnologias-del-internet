using BikeDataLibrary.ServiceModels;
using BikeDataLibrary.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BikeStoresApi.Controllers
{
    public class CategoryController : ApiController
    {
        public IEnumerable<ServiceCategory> GetAll()
        {
            var categories = GetService.GetCategoryDataService().GetAll().ToList();
            var serviceCategories = GetService.GetCategoryModelServiceModelConverter().ConvertModelCollectionToServiceModelCollection(categories);
            
            return serviceCategories;
        }
    }
}
