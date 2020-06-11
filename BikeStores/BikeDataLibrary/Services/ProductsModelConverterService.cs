using BikeDataLibrary.BikeStoresData;
using BikeDataLibrary.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeDataLibrary.Services
{
    public class ProductsModelConverterService : IModelViewModelConverter<product, ProductViewModel>
    {
        public ProductViewModel ConvertModelToViewModel(product product)
        {
            ProductViewModel productViewModel = new ProductViewModel
            {
                ProductId = product.product_id,
                ProductName = product.product_name,
                BrandId = product.brand_id,
                CategoryId = product.category_id,
                ModelYear = product.model_year,
                ListPrice = product.list_price
            };
            return productViewModel;
        }

        public product ConvertViewModelToModel(ProductViewModel productViewModel)
        {
            product product = new product
            {
                product_id = productViewModel.ProductId,
                product_name = productViewModel.ProductName,
                brand_id = productViewModel.BrandId,
                category_id = productViewModel.CategoryId,
                model_year = productViewModel.ModelYear,
                list_price = productViewModel.ListPrice
            };
            return product;
        }
        public IEnumerable<ProductViewModel> ConvertModelListToViewModelCollection(IEnumerable<product> products)
        {
            List<ProductViewModel> productViewModels = new List<ProductViewModel>();

            foreach(var product in products)
            {
                var productViewModel = ConvertModelToViewModel(product);
                productViewModels.Add(productViewModel);
            }
            return productViewModels;
        }

        public IEnumerable<product> ConvertViewModelToModelCollection(IEnumerable<ProductViewModel> productViewModels)
        {
            List<product> products = new List<product>(); 

            foreach(var productViewModel in productViewModels)
            {
                var product = ConvertViewModelToModel(productViewModel);
                products.Add(product);
            }
            return products;
        }
    }
}
