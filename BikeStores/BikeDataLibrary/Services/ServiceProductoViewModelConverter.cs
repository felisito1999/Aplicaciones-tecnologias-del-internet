using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BikeDataLibrary.Services.ServicesContracts;
using BikeDataLibrary.ServiceViewModels;
using BikeDataLibrary.ServiceModels;

namespace BikeDataLibrary.Services
{
    public class ServiceProductoViewModelConverter : IModelViewModelConverter<ServiceProduct, ServiceProductViewModel>
    {
        public IEnumerable<ServiceProductViewModel> ConvertModelCollectionToViewModelCollection(IEnumerable<ServiceProduct> serviceProductCollection)
        {
            List<ServiceProductViewModel> serviceProductViewModels = new List<ServiceProductViewModel>();

            foreach(var serviceProduct in serviceProductCollection)
            {
                var serviceProductViewModel = ConvertModelToViewModel(serviceProduct);
                serviceProductViewModels.Add(serviceProductViewModel);
            }

            return serviceProductViewModels;
        }

        public ServiceProductViewModel ConvertModelToViewModel(ServiceProduct serviceProduct)
        {
            var brand = GetService.GetBrandDataService().GetById(serviceProduct.BrandId);
            var category = GetService.GetCategoryDataService().GetById(serviceProduct.CategoryId);

            ServiceProductViewModel serviceProductViewModel = new ServiceProductViewModel
            {
                ProductId = serviceProduct.ProductId,
                ProductName = serviceProduct.ProductName,
                ModelYear = serviceProduct.ModelYear,
                ListPrice = serviceProduct.ListPrice,
                BrandId = brand.brand_id,
                BrandName = brand.brand_name,
                CategoryId = category.category_id,
                CategoryName = category.category_name,
            };

            return serviceProductViewModel;
        }

        public IEnumerable<ServiceProduct> ConvertViewModelCollectionToModelCollection(IEnumerable<ServiceProductViewModel> serviceProductviewModelCollection)
        {
            throw new NotImplementedException();
        }

        public ServiceProduct ConvertViewModelToModel(ServiceProductViewModel serviceProductviewModel)
        {
            throw new NotImplementedException();
        }
    }
}
