using BikeDataLibrary.BikeStoresData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeDataLibrary.Services
{
    public class BrandDataService : IDataService<brand>
    {
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<brand> GetAll()
        {
            using(var context = new BikeStoresEntities())
            {
                var brands = context.brands.ToList();

                return brands; 
            }
        }

        public brand GetById(int id)
        {
            using(var context = new BikeStoresEntities())
            {
                var brand = context.brands.Find(id);

                return brand;
            }
        }

        public void Insert(brand @object)
        {
            throw new NotImplementedException();
        }

        public void Update(brand @object)
        {
            throw new NotImplementedException();
        }
    }
}
