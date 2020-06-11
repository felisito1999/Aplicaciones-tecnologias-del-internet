using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BikeDataLibrary.BikeStoresData;

namespace BikeDataLibrary.Services
{
    public class ProductsDataService : IDataService<product>
    {
        public void Insert(product product)
        {
            using (var context = new  BikeStoresEntities())
            {
                context.products.Add(product);
                context.SaveChanges();
            }
        }
        public IEnumerable<product> GetAll()
        {
            using (var context = new BikeStoresEntities())
            {
                var products = context.products.ToList();

                return products;
            }
        }
        public product GetById(int id)
        {
            using (var context = new BikeStoresEntities())
            {
                var product = context.products.Find(id);
                return product;
            }
        }
        public void Update(product updatedProduct)
        {
            using (var context = new BikeStoresEntities())
            {
                var originalProduct = context.products.Find(updatedProduct.product_id);

                if (originalProduct != null)
                {
                    originalProduct = updatedProduct;
                    context.SaveChanges();
                }
            }
        }
        public void Delete(int id)
        {
            using (var context = new BikeStoresEntities())
            {
                var product = context.products.Find(id);

                if (product != null)
                {
                    context.products.Remove(product);
                    context.SaveChanges(); 
                }
            }
        }
    }
}
