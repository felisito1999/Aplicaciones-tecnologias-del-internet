using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BikeDataLibrary.Services.ServicesContracts;
using BikeDataLibrary.BikeStoresData;
using BikeDataLibrary.ServiceModels;

namespace BikeDataLibrary.Services
{
    public class BrandModelServiceModelConverter : IServiceModelConverter<ServiceBrand, brand>
    {
        public List<ServiceBrand> ConvertModelCollectionToServiceModelCollection(List<brand> brandCollection)
        {
            List<ServiceBrand> serviceBrands = new List<ServiceBrand>();

            foreach(var brand in brandCollection)
            {
                var serviceBrand = ConvertModelToServiceModel(brand);

                serviceBrands.Add(serviceBrand);
            }

            return serviceBrands;
        }

        public ServiceBrand ConvertModelToServiceModel(brand brand)
        {
            ServiceBrand serviceBrand = new ServiceBrand
            {
                BrandId = brand.brand_id,
                BrandName = brand.brand_name
            };

            return serviceBrand;
        }

        public List<brand> ConvertServiceModelCollectionToModelCollection(List<ServiceBrand> serviceBrandCollection)
        {
            List<brand> brands = new List<brand>();

            foreach(var serviceBrand in serviceBrandCollection)
            {
                var brand = ConvertServiceModelToModel(serviceBrand);
                brands.Add(brand);
            }

            return brands; 
        }

        public brand ConvertServiceModelToModel(ServiceBrand serviceBrand)
        {
            brand brand = new brand
            {
                brand_id = serviceBrand.BrandId,
                brand_name = serviceBrand.BrandName
            };

            return brand;
        }
    }
}
