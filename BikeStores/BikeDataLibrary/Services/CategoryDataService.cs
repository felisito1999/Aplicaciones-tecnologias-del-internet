using BikeDataLibrary.BikeStoresData;
using BikeDataLibrary.Services.ServicesContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BikeDataLibrary.Services
{
    public class CategoryDataService : IDataService<category>
    {
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<category> GetAll()
        {
            using(var context = new BikeStoresEntities())
            {
                var categories = context.categories.ToList();

                return categories; 
            }
        }

        public category GetById(int id)
        {
            using(var context = new BikeStoresEntities())
            {
                var category = context.categories.Find(id);

                return category;
            }
        }

        public void Insert(category @object)
        {
            throw new NotImplementedException();
        }

        public void Update(category @object)
        {
            throw new NotImplementedException();
        }
    }
}
