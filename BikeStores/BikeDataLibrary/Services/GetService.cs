using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BikeDataLibrary.Services;

namespace BikeDataLibrary.Services
{
    public static class GetService
    {
        public static ProductsDataService GetProductService()
        {
            return new ProductsDataService();
        }
        public static ProductModelViewModelConverterService GetProductoModelConverterService()
        {
            return new ProductModelViewModelConverterService();
        }
        public static BrandDataService GetBrandDataService()
        {
            return new BrandDataService();
        }
        public static CategoryDataService GetCategoryDataService()
        {
            return new CategoryDataService();
        }
        public static ProductModelServiceModelConverter GetProductModelServiceModelConverter()
        {
            return new ProductModelServiceModelConverter(); 
        }
    }
}
