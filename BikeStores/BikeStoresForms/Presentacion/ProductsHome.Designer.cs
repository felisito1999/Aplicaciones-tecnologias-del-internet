namespace BikeStoresForms.Presentacion
{
    partial class ProductsHome
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DtgProducts = new System.Windows.Forms.DataGridView();
            this.TxtProductName = new System.Windows.Forms.TextBox();
            this.TxtListPrice = new System.Windows.Forms.TextBox();
            this.TxtModelYear = new System.Windows.Forms.TextBox();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnUnselect = new System.Windows.Forms.Button();
            this.Lbl_ProductName = new System.Windows.Forms.Label();
            this.Lbl_ListPrice = new System.Windows.Forms.Label();
            this.Lbl_ModelYear = new System.Windows.Forms.Label();
            this.Lbl_Brand = new System.Windows.Forms.Label();
            this.Lbl_Categories = new System.Windows.Forms.Label();
            this.CbBrands = new System.Windows.Forms.ComboBox();
            this.CbCategories = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.DtgProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // DtgProducts
            // 
            this.DtgProducts.AllowUserToAddRows = false;
            this.DtgProducts.AllowUserToDeleteRows = false;
            this.DtgProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgProducts.Location = new System.Drawing.Point(12, 592);
            this.DtgProducts.Name = "DtgProducts";
            this.DtgProducts.ReadOnly = true;
            this.DtgProducts.RowHeadersWidth = 82;
            this.DtgProducts.RowTemplate.Height = 33;
            this.DtgProducts.Size = new System.Drawing.Size(1842, 828);
            this.DtgProducts.TabIndex = 0;
            // 
            // TxtProductName
            // 
            this.TxtProductName.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtProductName.Location = new System.Drawing.Point(328, 88);
            this.TxtProductName.Name = "TxtProductName";
            this.TxtProductName.Size = new System.Drawing.Size(628, 57);
            this.TxtProductName.TabIndex = 1;
            // 
            // TxtListPrice
            // 
            this.TxtListPrice.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtListPrice.Location = new System.Drawing.Point(328, 184);
            this.TxtListPrice.Name = "TxtListPrice";
            this.TxtListPrice.Size = new System.Drawing.Size(628, 57);
            this.TxtListPrice.TabIndex = 2;
            // 
            // TxtModelYear
            // 
            this.TxtModelYear.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtModelYear.Location = new System.Drawing.Point(328, 280);
            this.TxtModelYear.Name = "TxtModelYear";
            this.TxtModelYear.Size = new System.Drawing.Size(628, 57);
            this.TxtModelYear.TabIndex = 3;
            // 
            // BtnSave
            // 
            this.BtnSave.Font = new System.Drawing.Font("Segoe UI Semibold", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSave.Location = new System.Drawing.Point(1321, 206);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(533, 83);
            this.BtnSave.TabIndex = 5;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            // 
            // BtnDelete
            // 
            this.BtnDelete.Font = new System.Drawing.Font("Segoe UI Semibold", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDelete.Location = new System.Drawing.Point(1321, 321);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(533, 83);
            this.BtnDelete.TabIndex = 6;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = true;
            // 
            // BtnUnselect
            // 
            this.BtnUnselect.Font = new System.Drawing.Font("Segoe UI Semibold", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUnselect.Location = new System.Drawing.Point(1321, 448);
            this.BtnUnselect.Name = "BtnUnselect";
            this.BtnUnselect.Size = new System.Drawing.Size(533, 83);
            this.BtnUnselect.TabIndex = 7;
            this.BtnUnselect.Text = "Unselect ";
            this.BtnUnselect.UseVisualStyleBackColor = true;
            // 
            // Lbl_ProductName
            // 
            this.Lbl_ProductName.AutoSize = true;
            this.Lbl_ProductName.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_ProductName.Location = new System.Drawing.Point(20, 95);
            this.Lbl_ProductName.Name = "Lbl_ProductName";
            this.Lbl_ProductName.Size = new System.Drawing.Size(260, 50);
            this.Lbl_ProductName.TabIndex = 8;
            this.Lbl_ProductName.Text = "Product name:";
            // 
            // Lbl_ListPrice
            // 
            this.Lbl_ListPrice.AutoSize = true;
            this.Lbl_ListPrice.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_ListPrice.Location = new System.Drawing.Point(105, 191);
            this.Lbl_ListPrice.Name = "Lbl_ListPrice";
            this.Lbl_ListPrice.Size = new System.Drawing.Size(175, 50);
            this.Lbl_ListPrice.TabIndex = 9;
            this.Lbl_ListPrice.Text = "List price:";
            // 
            // Lbl_ModelYear
            // 
            this.Lbl_ModelYear.AutoSize = true;
            this.Lbl_ModelYear.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_ModelYear.Location = new System.Drawing.Point(66, 287);
            this.Lbl_ModelYear.Name = "Lbl_ModelYear";
            this.Lbl_ModelYear.Size = new System.Drawing.Size(214, 50);
            this.Lbl_ModelYear.TabIndex = 10;
            this.Lbl_ModelYear.Text = "Model year:";
            // 
            // Lbl_Brand
            // 
            this.Lbl_Brand.AutoSize = true;
            this.Lbl_Brand.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Brand.Location = new System.Drawing.Point(154, 384);
            this.Lbl_Brand.Name = "Lbl_Brand";
            this.Lbl_Brand.Size = new System.Drawing.Size(126, 50);
            this.Lbl_Brand.TabIndex = 11;
            this.Lbl_Brand.Text = "Brand:";
            // 
            // Lbl_Categories
            // 
            this.Lbl_Categories.AutoSize = true;
            this.Lbl_Categories.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Categories.Location = new System.Drawing.Point(75, 481);
            this.Lbl_Categories.Name = "Lbl_Categories";
            this.Lbl_Categories.Size = new System.Drawing.Size(205, 50);
            this.Lbl_Categories.TabIndex = 12;
            this.Lbl_Categories.Text = "Categories:";
            // 
            // CbBrands
            // 
            this.CbBrands.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbBrands.FormattingEnabled = true;
            this.CbBrands.Location = new System.Drawing.Point(328, 376);
            this.CbBrands.Name = "CbBrands";
            this.CbBrands.Size = new System.Drawing.Size(628, 58);
            this.CbBrands.TabIndex = 13;
            // 
            // CbCategories
            // 
            this.CbCategories.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbCategories.FormattingEnabled = true;
            this.CbCategories.Location = new System.Drawing.Point(328, 473);
            this.CbCategories.Name = "CbCategories";
            this.CbCategories.Size = new System.Drawing.Size(628, 58);
            this.CbCategories.TabIndex = 14;
            // 
            // ProductsHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1866, 1432);
            this.Controls.Add(this.CbCategories);
            this.Controls.Add(this.CbBrands);
            this.Controls.Add(this.Lbl_Categories);
            this.Controls.Add(this.Lbl_Brand);
            this.Controls.Add(this.Lbl_ModelYear);
            this.Controls.Add(this.Lbl_ListPrice);
            this.Controls.Add(this.Lbl_ProductName);
            this.Controls.Add(this.BtnUnselect);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.TxtModelYear);
            this.Controls.Add(this.TxtListPrice);
            this.Controls.Add(this.TxtProductName);
            this.Controls.Add(this.DtgProducts);
            this.Name = "ProductsHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProductsHome";
            this.Load += new System.EventHandler(this.ProductsHome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DtgProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DtgProducts;
        private System.Windows.Forms.TextBox TxtProductName;
        private System.Windows.Forms.TextBox TxtListPrice;
        private System.Windows.Forms.TextBox TxtModelYear;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnUnselect;
        private System.Windows.Forms.Label Lbl_ProductName;
        private System.Windows.Forms.Label Lbl_ListPrice;
        private System.Windows.Forms.Label Lbl_ModelYear;
        private System.Windows.Forms.Label Lbl_Brand;
        private System.Windows.Forms.Label Lbl_Categories;
        private System.Windows.Forms.ComboBox CbBrands;
        private System.Windows.Forms.ComboBox CbCategories;
    }
}