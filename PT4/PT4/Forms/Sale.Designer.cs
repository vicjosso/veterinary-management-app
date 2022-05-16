namespace PT4
{
    partial class Sale
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
            this.labelSale = new System.Windows.Forms.Label();
            this.labelCustomer = new System.Windows.Forms.Label();
            this.comboBox_customers = new System.Windows.Forms.ComboBox();
            this.comboBox_products = new System.Windows.Forms.ComboBox();
            this.label_product = new System.Windows.Forms.Label();
            this.button_addProduct = new System.Windows.Forms.Button();
            this.button_confirm = new System.Windows.Forms.Button();
            this.label_amount = new System.Windows.Forms.Label();
            this.label_products = new System.Windows.Forms.Label();
            this.panel_main = new System.Windows.Forms.Panel();
            this.panel_listProducts = new System.Windows.Forms.Panel();
            this.button_deleteProductList = new System.Windows.Forms.Button();
            this.dataGridView_buyList = new System.Windows.Forms.DataGridView();
            this.panel_sells = new System.Windows.Forms.Panel();
            this.panel_products = new System.Windows.Forms.Panel();
            this.panel_quantity = new System.Windows.Forms.Panel();
            this.numericUpDown_amount = new System.Windows.Forms.NumericUpDown();
            this.button_change = new System.Windows.Forms.Button();
            this.panel_bottom = new System.Windows.Forms.Panel();
            this.label_totalEuro = new System.Windows.Forms.Label();
            this.label_total = new System.Windows.Forms.Label();
            this.panel_main.SuspendLayout();
            this.panel_listProducts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_buyList)).BeginInit();
            this.panel_sells.SuspendLayout();
            this.panel_products.SuspendLayout();
            this.panel_quantity.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_amount)).BeginInit();
            this.panel_bottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelSale
            // 
            this.labelSale.AutoSize = true;
            this.labelSale.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSale.ForeColor = System.Drawing.Color.White;
            this.labelSale.Location = new System.Drawing.Point(30, 27);
            this.labelSale.Name = "labelSale";
            this.labelSale.Size = new System.Drawing.Size(60, 24);
            this.labelSale.TabIndex = 0;
            this.labelSale.Text = "Vente";
            // 
            // labelCustomer
            // 
            this.labelCustomer.AutoSize = true;
            this.labelCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCustomer.ForeColor = System.Drawing.Color.White;
            this.labelCustomer.Location = new System.Drawing.Point(31, 65);
            this.labelCustomer.Name = "labelCustomer";
            this.labelCustomer.Size = new System.Drawing.Size(40, 16);
            this.labelCustomer.TabIndex = 1;
            this.labelCustomer.Text = "Client";
            // 
            // comboBox_customers
            // 
            this.comboBox_customers.FormattingEnabled = true;
            this.comboBox_customers.Location = new System.Drawing.Point(34, 84);
            this.comboBox_customers.Name = "comboBox_customers";
            this.comboBox_customers.Size = new System.Drawing.Size(121, 21);
            this.comboBox_customers.TabIndex = 3;
            this.comboBox_customers.SelectedValueChanged += new System.EventHandler(this.comboBox_customers_SelectedValueChanged);
            // 
            // comboBox_products
            // 
            this.comboBox_products.FormattingEnabled = true;
            this.comboBox_products.Location = new System.Drawing.Point(12, 40);
            this.comboBox_products.Name = "comboBox_products";
            this.comboBox_products.Size = new System.Drawing.Size(121, 21);
            this.comboBox_products.TabIndex = 5;
            this.comboBox_products.SelectedValueChanged += new System.EventHandler(this.comboBox_products_SelectedValueChanged);
            // 
            // label_product
            // 
            this.label_product.AutoSize = true;
            this.label_product.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_product.ForeColor = System.Drawing.Color.White;
            this.label_product.Location = new System.Drawing.Point(9, 15);
            this.label_product.Name = "label_product";
            this.label_product.Size = new System.Drawing.Size(49, 16);
            this.label_product.TabIndex = 4;
            this.label_product.Text = "Produit";
            // 
            // button_addProduct
            // 
            this.button_addProduct.ForeColor = System.Drawing.Color.Transparent;
            this.button_addProduct.Location = new System.Drawing.Point(70, 34);
            this.button_addProduct.Name = "button_addProduct";
            this.button_addProduct.Size = new System.Drawing.Size(26, 23);
            this.button_addProduct.TabIndex = 9;
            this.button_addProduct.Text = "+";
            this.button_addProduct.UseVisualStyleBackColor = true;
            this.button_addProduct.Click += new System.EventHandler(this.button_addProduct_Click);
            // 
            // button_confirm
            // 
            this.button_confirm.Enabled = false;
            this.button_confirm.ForeColor = System.Drawing.Color.Transparent;
            this.button_confirm.Location = new System.Drawing.Point(493, 40);
            this.button_confirm.MaximumSize = new System.Drawing.Size(200, 200);
            this.button_confirm.Name = "button_confirm";
            this.button_confirm.Size = new System.Drawing.Size(200, 20);
            this.button_confirm.TabIndex = 12;
            this.button_confirm.Text = "Confirmer";
            this.button_confirm.UseVisualStyleBackColor = true;
            this.button_confirm.Click += new System.EventHandler(this.button_confirm_Click);
            // 
            // label_amount
            // 
            this.label_amount.AutoSize = true;
            this.label_amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_amount.ForeColor = System.Drawing.Color.White;
            this.label_amount.Location = new System.Drawing.Point(3, 9);
            this.label_amount.Name = "label_amount";
            this.label_amount.Size = new System.Drawing.Size(56, 16);
            this.label_amount.TabIndex = 13;
            this.label_amount.Text = "Quantité";
            // 
            // label_products
            // 
            this.label_products.AutoSize = true;
            this.label_products.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_products.ForeColor = System.Drawing.Color.White;
            this.label_products.Location = new System.Drawing.Point(22, 27);
            this.label_products.Name = "label_products";
            this.label_products.Size = new System.Drawing.Size(75, 20);
            this.label_products.TabIndex = 15;
            this.label_products.Text = "Produits :";
            // 
            // panel_main
            // 
            this.panel_main.Controls.Add(this.panel_listProducts);
            this.panel_main.Controls.Add(this.panel_sells);
            this.panel_main.Controls.Add(this.panel_bottom);
            this.panel_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_main.Location = new System.Drawing.Point(0, 0);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(1187, 446);
            this.panel_main.TabIndex = 16;
            // 
            // panel_listProducts
            // 
            this.panel_listProducts.Controls.Add(this.button_deleteProductList);
            this.panel_listProducts.Controls.Add(this.dataGridView_buyList);
            this.panel_listProducts.Controls.Add(this.label_products);
            this.panel_listProducts.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_listProducts.Location = new System.Drawing.Point(0, 0);
            this.panel_listProducts.Name = "panel_listProducts";
            this.panel_listProducts.Size = new System.Drawing.Size(591, 374);
            this.panel_listProducts.TabIndex = 19;
            // 
            // button_deleteProductList
            // 
            this.button_deleteProductList.ForeColor = System.Drawing.Color.Transparent;
            this.button_deleteProductList.Location = new System.Drawing.Point(482, 336);
            this.button_deleteProductList.Name = "button_deleteProductList";
            this.button_deleteProductList.Size = new System.Drawing.Size(75, 23);
            this.button_deleteProductList.TabIndex = 17;
            this.button_deleteProductList.Text = "Supprimer";
            this.button_deleteProductList.UseVisualStyleBackColor = true;
            this.button_deleteProductList.Click += new System.EventHandler(this.button_deleteProductList_Click);
            // 
            // dataGridView_buyList
            // 
            this.dataGridView_buyList.AllowUserToAddRows = false;
            this.dataGridView_buyList.AllowUserToDeleteRows = false;
            this.dataGridView_buyList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataGridView_buyList.CausesValidation = false;
            this.dataGridView_buyList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_buyList.Location = new System.Drawing.Point(26, 65);
            this.dataGridView_buyList.MultiSelect = false;
            this.dataGridView_buyList.Name = "dataGridView_buyList";
            this.dataGridView_buyList.ReadOnly = true;
            this.dataGridView_buyList.RowHeadersVisible = false;
            this.dataGridView_buyList.Size = new System.Drawing.Size(531, 230);
            this.dataGridView_buyList.TabIndex = 16;
            // 
            // panel_sells
            // 
            this.panel_sells.Controls.Add(this.panel_products);
            this.panel_sells.Controls.Add(this.button_change);
            this.panel_sells.Controls.Add(this.comboBox_customers);
            this.panel_sells.Controls.Add(this.labelSale);
            this.panel_sells.Controls.Add(this.labelCustomer);
            this.panel_sells.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_sells.Location = new System.Drawing.Point(589, 0);
            this.panel_sells.Name = "panel_sells";
            this.panel_sells.Size = new System.Drawing.Size(598, 374);
            this.panel_sells.TabIndex = 18;
            // 
            // panel_products
            // 
            this.panel_products.Controls.Add(this.panel_quantity);
            this.panel_products.Controls.Add(this.label_product);
            this.panel_products.Controls.Add(this.comboBox_products);
            this.panel_products.Location = new System.Drawing.Point(22, 135);
            this.panel_products.Name = "panel_products";
            this.panel_products.Size = new System.Drawing.Size(266, 72);
            this.panel_products.TabIndex = 17;
            this.panel_products.Visible = false;
            // 
            // panel_quantity
            // 
            this.panel_quantity.Controls.Add(this.label_amount);
            this.panel_quantity.Controls.Add(this.button_addProduct);
            this.panel_quantity.Controls.Add(this.numericUpDown_amount);
            this.panel_quantity.Location = new System.Drawing.Point(160, 3);
            this.panel_quantity.Name = "panel_quantity";
            this.panel_quantity.Size = new System.Drawing.Size(103, 65);
            this.panel_quantity.TabIndex = 16;
            this.panel_quantity.Visible = false;
            // 
            // numericUpDown_amount
            // 
            this.numericUpDown_amount.Location = new System.Drawing.Point(6, 34);
            this.numericUpDown_amount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_amount.Name = "numericUpDown_amount";
            this.numericUpDown_amount.Size = new System.Drawing.Size(38, 20);
            this.numericUpDown_amount.TabIndex = 15;
            this.numericUpDown_amount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // button_change
            // 
            this.button_change.Location = new System.Drawing.Point(193, 82);
            this.button_change.Name = "button_change";
            this.button_change.Size = new System.Drawing.Size(75, 23);
            this.button_change.TabIndex = 16;
            this.button_change.Text = "Changer";
            this.button_change.UseVisualStyleBackColor = true;
            this.button_change.Visible = false;
            this.button_change.Click += new System.EventHandler(this.button_change_Click);
            // 
            // panel_bottom
            // 
            this.panel_bottom.Controls.Add(this.label_totalEuro);
            this.panel_bottom.Controls.Add(this.label_total);
            this.panel_bottom.Controls.Add(this.button_confirm);
            this.panel_bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_bottom.Location = new System.Drawing.Point(0, 374);
            this.panel_bottom.Name = "panel_bottom";
            this.panel_bottom.Size = new System.Drawing.Size(1187, 72);
            this.panel_bottom.TabIndex = 17;
            // 
            // label_totalEuro
            // 
            this.label_totalEuro.AutoSize = true;
            this.label_totalEuro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_totalEuro.ForeColor = System.Drawing.Color.Red;
            this.label_totalEuro.Location = new System.Drawing.Point(585, 15);
            this.label_totalEuro.Name = "label_totalEuro";
            this.label_totalEuro.Size = new System.Drawing.Size(27, 20);
            this.label_totalEuro.TabIndex = 17;
            this.label_totalEuro.Text = "0€";
            // 
            // label_total
            // 
            this.label_total.AutoSize = true;
            this.label_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_total.ForeColor = System.Drawing.Color.White;
            this.label_total.Location = new System.Drawing.Point(546, 18);
            this.label_total.MaximumSize = new System.Drawing.Size(200, 0);
            this.label_total.Name = "label_total";
            this.label_total.Size = new System.Drawing.Size(44, 16);
            this.label_total.TabIndex = 16;
            this.label_total.Text = "Total :";
            // 
            // Sale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1187, 446);
            this.Controls.Add(this.panel_main);
            this.Name = "Sale";
            this.Text = "Ventes";
            this.panel_main.ResumeLayout(false);
            this.panel_listProducts.ResumeLayout(false);
            this.panel_listProducts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_buyList)).EndInit();
            this.panel_sells.ResumeLayout(false);
            this.panel_sells.PerformLayout();
            this.panel_products.ResumeLayout(false);
            this.panel_products.PerformLayout();
            this.panel_quantity.ResumeLayout(false);
            this.panel_quantity.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_amount)).EndInit();
            this.panel_bottom.ResumeLayout(false);
            this.panel_bottom.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelSale;
        private System.Windows.Forms.Label labelCustomer;
        private System.Windows.Forms.ComboBox comboBox_customers;
        private System.Windows.Forms.ComboBox comboBox_products;
        private System.Windows.Forms.Label label_product;
        private System.Windows.Forms.Button button_addProduct;
        private System.Windows.Forms.Button button_confirm;
        private System.Windows.Forms.Label label_amount;
        private System.Windows.Forms.Label label_products;
        private System.Windows.Forms.Panel panel_main;
        private System.Windows.Forms.Panel panel_bottom;
        private System.Windows.Forms.Label label_total;
        private System.Windows.Forms.Panel panel_listProducts;
        private System.Windows.Forms.Panel panel_sells;
        private System.Windows.Forms.NumericUpDown numericUpDown_amount;
        private System.Windows.Forms.DataGridView dataGridView_buyList;
        private System.Windows.Forms.Button button_deleteProductList;
        private System.Windows.Forms.Button button_change;
        private System.Windows.Forms.Panel panel_products;
        private System.Windows.Forms.Label label_totalEuro;
        private System.Windows.Forms.Panel panel_quantity;
    }
}