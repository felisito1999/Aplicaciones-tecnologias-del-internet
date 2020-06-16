using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BikeDataLibrary.Services.ServicesContracts;
using BikeDataLibrary.ServiceModels;
using BikeDataLibrary.BikeStoresData;

namespace BikeDataLibrary.Services
{
    public class ProductModelServiceModelConverter : IServiceModelConverter<ServiceProduct, product>
    {
        public List<ServiceProduct> ConvertModelCollectionToServiceModelCollection(List<product> productCollection)
        {
            List<ServiceProduct> serviceProducts = new List<ServiceProduct>(); 

            foreach(var product in productCollection)
            {
                var serviceProduct = ConvertModelToServiceModel(product);
                serviceProducts.Add(serviceProduct);
            }
            return serviceProducts; 
        }

        public ServiceProduct ConvertModelToServiceModel(product product)
        {
            ServiceProduct serviceProduct = new ServiceProduct
            {
                ProductId = product.product_id,
                ProductName = product.product_name,
                ModelYear = product.model_year,
                ListPrice = product.list_price,
                BrandId = product.brand_id,
                CategoryId = product.category_id
            };
            return serviceProduct; 
        }

        public product ConvertServiceModelToModel(ServiceProduct serviceProduct)
        {
            product product = new product
            {
                product_id = serviceProduct.ProductId,
                product_name = serviceProduct.ProductName,
                model_year = serviceProduct.ModelYear,
                list_price = serviceProduct.ListPrice,
                brand_id = serviceProduct.BrandId,
                category_id = serviceProduct.CategoryId,
            };
            return product; 
        }

        public List<product> ConvertServiceModelCollecitonToModelCollection(List<ServiceProduct> serviceProductCollection)
        {
            List<product> products = new List<product>();

            foreach(var serviceProduct in serviceProductCollection)
            {
                var product = ConvertServiceModelToModel(serviceProduct);
                products.Add(product);
            }
            return products;
        }
    }
}
