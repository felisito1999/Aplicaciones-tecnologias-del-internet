using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BikeStoresForms.Services;
using BikeDataLibrary.ServiceViewModels;
using BikeStoresForms.BikeStoresWebService;

namespace BikeStoresForms.Presentacion
{
    public partial class ProductsHome : Form
    {
        public ProductsHome()
        {
            InitializeComponent();
        }

        private void ProductsHome_Load(object sender, EventArgs e)
        {
            loadDtgProducts();
            loadCbBrands();
            loadCbCategories();
        }
        private void loadDtgProducts()
        {
            var products = WebServiceFactory.GetBikeStoresClient().GetAllServiceProducts();

            DtgProducts.DataSource = products;

            PopulateProductIds(products);
        }
        private void loadCbBrands()
        {
            var brands = WebServiceFactory.GetBikeStoresClient().GetAllServiceBrands();
            
            CbBrands.DataSource = brands;
            CbBrands.DisplayMember = "BrandName";
            CbBrands.ValueMember = "BrandId";         
        }
        private void loadCbCategories()
        {
            var categories = WebServiceFactory.GetBikeStoresClient().GetAllServiceCategories();
            
            CbCategories.DataSource = categories;
            CbCategories.DisplayMember = "CategoryName";
            CbCategories.ValueMember = "CategoryId";
        }
        private void InsertProduct(string productName, decimal listPrice, short modelYear, int brandId, int categoryId)
        {
            
        }
        private void PopulateProductIds(ServiceProduct[] serviceProducts)
        {
            ProductIds.Clear();
            foreach (var product in serviceProducts)
            {
                ProductIds.Add(product.ProductId);
            }
        }
        public List<int> ProductIds;
    }
}
