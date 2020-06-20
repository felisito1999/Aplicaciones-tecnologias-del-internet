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
            PopulateProductIds();
            LoadDtgProducts();
            LoadCbBrands();
            LoadCbCategories();
            
            BtnUnselect_Click(sender, e);
        }
        private void LoadDtgProducts()
        {
            var products = WebServiceFactory.GetBikeStoresClient().GetAllServiceProducts();
            DtgProducts.DataSource = products;
        }
        private void LoadCbBrands()
        {
            var brands = WebServiceFactory.GetBikeStoresClient().GetAllServiceBrands();
            
            CbBrands.DataSource = brands;
            CbBrands.DisplayMember = "BrandName";
            CbBrands.ValueMember = "BrandId";         
        }
        private void LoadCbCategories()
        {
            var categories = WebServiceFactory.GetBikeStoresClient().GetAllServiceCategories();
            
            CbCategories.DataSource = categories;
            CbCategories.DisplayMember = "CategoryName";
            CbCategories.ValueMember = "CategoryId";
        }
        private void InsertProduct(string productName, decimal listPrice, short modelYear, int brandId, int categoryId)
        {
            ServiceProduct serviceProduct = new ServiceProduct
            {
                ProductName = productName,
                ModelYear = modelYear,
                ListPrice = listPrice,
                BrandId = brandId,
                CategoryId = categoryId
            };

            WebServiceFactory.GetBikeStoresClient().Insert(serviceProduct);
        }
        private void UpdateProduct(int productId, string productName, decimal listPrice, short modelYear, int brandId, int categoryId)
        {
            ServiceProduct serviceProduct = new ServiceProduct
            {
                ProductId = productId,
                ProductName = productName,
                ModelYear = modelYear,
                ListPrice = listPrice,
                BrandId = brandId,
                CategoryId = categoryId
            };

            WebServiceFactory.GetBikeStoresClient().Update(serviceProduct);
        }
        private void DeleteProduct(int id)
        {
            WebServiceFactory.GetBikeStoresClient().Delete(id);
        }
        private void PopulateProductIds()
        {
            var serviceProducts = WebServiceFactory.GetBikeStoresClient().GetAllServiceProducts();
            if(productIds != null)
            {
                productIds.Clear();
                foreach (var product in serviceProducts)
                {
                    productIds.Add(product.ProductId);
                }
            }
            else
            {
                foreach(var product in serviceProducts)
                {
                    productIds.Add(product.ProductId);
                }
            }
        }
        public List<int> productIds = new List<int>();
        public int selectedProductId; 
        private void BtnSave_Click(object sender, EventArgs e)
        {
            if(DtgProducts.SelectedRows.Count > 0)
            {
                if(string.IsNullOrWhiteSpace(TxtProductName.Text) == false &&
                string.IsNullOrWhiteSpace(TxtModelYear.Text) == false &&
                string.IsNullOrWhiteSpace(TxtListPrice.Text) == false &&
                decimal.TryParse(TxtListPrice.Text, out decimal listPrice) == true &&
                short.TryParse(TxtModelYear.Text, out short modelYear) == true)
                {
                    try
                    {
                        var productName = TxtProductName.Text;
                        var brandId = (int)CbBrands.SelectedValue;
                        var categoryId = (int)CbCategories.SelectedValue;

                        UpdateProduct(selectedProductId, productName, listPrice, modelYear, brandId, categoryId);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Some error has occurred, so the product has not been saved.");
                    }
                    finally
                    {
                        ProductsHome_Load(sender, e);
                    }
                }
                else
                {
                    MessageBox.Show("All the fields must be filled before trying an operation.");
                }
            }
            else if(DtgProducts.SelectedRows.Count == 0)
            {
                if (string.IsNullOrWhiteSpace(TxtProductName.Text) == false &&
                   string.IsNullOrWhiteSpace(TxtModelYear.Text) == false &&
                   string.IsNullOrWhiteSpace(TxtListPrice.Text) == false &&
                   decimal.TryParse(TxtListPrice.Text, out decimal listPrice) == true &&
                   short.TryParse(TxtModelYear.Text, out short modelYear) == true)
                {
                    try
                    {
                        var productName = TxtProductName.Text;
                        var brandId = (int)CbBrands.SelectedValue;
                        var categoryId = (int)CbCategories.SelectedValue;

                        InsertProduct(productName, listPrice, modelYear, brandId, categoryId);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Some error has occurred, so the product has not been saved.");
                    }
                    finally
                    {
                        
                        ProductsHome_Load(sender, e);
                    }
                }
                else
                {
                    MessageBox.Show("All the fields must be filled before trying an operation.");
                }
            }
        }
        private void ShowMode()
        {
            if(DtgProducts.SelectedRows.Count == 0)
            {
                LblMode.Text = "Insert mode";
            }
            else
            {
                LblMode.Text = "Update mode";
            }
        }
        private void ClearForm()
        {
            foreach(var item in this.Controls)
            {
                if(item is TextBox)
                {
                    ((TextBox)item).Clear();
                }
                if(item is ComboBox)
                {
                    ((ComboBox)item).SelectedIndex = 0;
                }
            }
        }
        private void DtgProducts_SelectionChanged(object sender, EventArgs e)
        {
            ShowMode();
            try
            {
                if(DtgProducts.RowCount > 0)
                {
                    int rowIndex = DtgProducts.CurrentRow.Index;
                    selectedProductId = productIds[rowIndex];
                    var product = WebServiceFactory.GetBikeStoresClient().GetById(selectedProductId);

                    TxtProductName.Text = product.ProductName;
                    TxtModelYear.Text = product.ModelYear.ToString();
                    TxtListPrice.Text = product.ListPrice.ToString();
                    CbBrands.SelectedValue = product.BrandId;
                    CbCategories.SelectedValue = product.CategoryId;
                }
                DtgProducts.Columns["ProductId"].Visible = false;
                DtgProducts.Columns["BrandId"].Visible = false;
                DtgProducts.Columns["CategoryId"].Visible = false;
                DtgProducts.Columns["ProductName"].HeaderText = "Bike name";
                DtgProducts.Columns["BrandName"].HeaderText = "Brand";
                DtgProducts.Columns["CategoryName"].HeaderText = " Bike category";
                DtgProducts.Columns["ModelYear"].HeaderText = "Model year";
                DtgProducts.Columns["ListPrice"].HeaderText = "Price";
            }
            catch (Exception)
            {
                MessageBox.Show("An error has ocurred");
            }
        }
        private void UnselectDataGridView()
        {
            DtgProducts.ClearSelection(); 
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if(selectedProductId != 0)
            {
                try
                {
                    DeleteProduct(selectedProductId);
                }
                catch (Exception)
                {
                    MessageBox.Show("An error has occurred, the product couldn't be deleted");
                }
                finally
                {
                    ProductsHome_Load(sender, e);
                }
            }
        }

        private void BtnUnselect_Click(object sender, EventArgs e)
        {
            UnselectDataGridView();
            ClearForm();
            SetSelectedProductIdToInsertMode(); 
        }
        private void SetSelectedProductIdToInsertMode()
        {
            selectedProductId = 0; 
        }
    }
}
