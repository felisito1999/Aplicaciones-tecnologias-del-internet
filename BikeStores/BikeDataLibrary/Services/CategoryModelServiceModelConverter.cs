using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BikeDataLibrary.BikeStoresData;
using BikeDataLibrary.ServiceModels;
using BikeDataLibrary.Services.ServicesContracts;

namespace BikeDataLibrary.Services
{
    public class CategoryModelServiceModelConverter : IServiceModelConverter<ServiceCategory, category>
    {
        public List<ServiceCategory> ConvertModelCollectionToServiceModelCollection(List<category> categoryCollection)
        {
            List<ServiceCategory> serviceCategories = new List<ServiceCategory>();

            foreach(var category in categoryCollection)
            {
                var serviceCategory = ConvertModelToServiceModel(category);
                serviceCategories.Add(serviceCategory);
            }

            return serviceCategories;
        }

        public ServiceCategory ConvertModelToServiceModel(category categoryModel)
        {
            ServiceCategory serviceCategory = new ServiceCategory
            {
                CategoryId = categoryModel.category_id,
                CategoryName = categoryModel.category_name
            };

            return serviceCategory;
        }

        public List<category> ConvertServiceModelCollectionToModelCollection(List<ServiceCategory> serviceCategoryCollection)
        {
            List<category> categories = new List<category>();

            foreach(var serviceCategory in serviceCategoryCollection)
            {
                var category = ConvertServiceModelToModel(serviceCategory);

                categories.Add(category);
            }

            return categories; 
        }

        public category ConvertServiceModelToModel(ServiceCategory serviceCategoryModel)
        {
            category categoryModel = new category
            {
                category_id = serviceCategoryModel.CategoryId,
                category_name = serviceCategoryModel.CategoryName
            };

            return categoryModel; 
        }
    }
}
