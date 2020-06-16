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
            var products = WebServiceFactory.GetBikeStoresWebService().GetAllServiceProducts();

            dtgProductos.DataSource = products; 
        }
    }
}
