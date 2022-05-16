using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace PT4
{
    public partial class Sale : Form
    {
        List<DerivedProduct> BuyList = new List<DerivedProduct>();
        client CurrentClient { get; set; } = null;
        produit SelectedProduct { get; set; } = null;

        public Sale()
        {
            InitializeComponent();
            InitDataGrid();
            InitComboBox();
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
        }

        #region Init Methods

        private void InitDataGrid()
        {
            dataGridView_buyList.ColumnCount = 5;
            dataGridView_buyList.Columns[0].Name = "IdProduit";
            dataGridView_buyList.Columns[1].Name = "Nom";
            dataGridView_buyList.Columns[2].Name = "Description";
            dataGridView_buyList.Columns[3].Name = "Quantité";
            dataGridView_buyList.Columns[4].Name = "Prix";
            dataGridView_buyList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView_buyList.MultiSelect = false;
            dataGridView_buyList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void InitComboBox()
        {
            List<client> clients = DataBase.Instance.getClients("");
            comboBox_customers.Items.AddRange(clients.ToArray());
            List<produit> produits = DataBase.Instance.getProducts("");
            comboBox_products.Items.AddRange(produits.ToArray());
        }

        private void RefreshDataGrid()
        {
            dataGridView_buyList.Rows.Clear();
            foreach (DerivedProduct p in BuyList)
            {
                string[] row = { p.produit.idProduit.ToString(), p.produit.nomProduit, p.produit.description, p.boughtQuantity.ToString(), p.produit.prixVenteClient.ToString(), };
                dataGridView_buyList.Rows.Add(row);
            }
            CalcTotal();
        }
        #endregion

        #region Toggle Display Methods
        private void ToggleDisplayProducts()
        {
            if (CurrentClient != null)
            {
                panel_products.Visible = true;
            }
            else
            {
                panel_products.Visible = false;
            }
        }
        private void ToggleDisplayQuantity()
        {
            if (SelectedProduct != null)
            {
                panel_quantity.Visible = true;
            }
            else
            {
                comboBox_products.SelectedItem = null;
                panel_quantity.Visible = false;
            }
        }

        #endregion

        #region button click Events

        private void button_change_Click(object sender, EventArgs e)
        {
            ResetClient();
            RefreshDataGrid();
            ToggleDisplayProducts();
        }
        private void button_addProduct_Click(object sender, EventArgs e)
        {
            produit SelectedProduct = (produit)comboBox_products.SelectedItem;
            if (SelectedProduct != null && !BuyList.Contains(new DerivedProduct() { produit = SelectedProduct }))
            {
                BuyList.Add(new DerivedProduct() { produit = SelectedProduct, boughtQuantity = Int32.Parse(numericUpDown_amount.Value.ToString()) });
                this.SelectedProduct = null;
                ToggleDisplayQuantity();
                RefreshDataGrid();
            }
        }

        private void button_deleteProductList_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView_buyList.SelectedRows)
            {
                int idProduct = Int32.Parse(row.Cells[0].Value.ToString());
                int Index = BuyList.FindIndex(dp => dp.produit.idProduit == idProduct);
                BuyList.RemoveAt(Index);
            }
            RefreshDataGrid();
        }

        private void button_confirm_Click(object sender, EventArgs e)
        {
            string message = "Voulez-vous confirmer cet achat?";
            string caption = "Validation achat";
            var response = MessageBox.Show(message, caption,
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);
            if (response == DialogResult.Yes && CurrentClient != null)
            {
                double totalPrice = double.Parse(label_totalEuro.Text.Split('€')[0]);

                facture_produit facture = new facture_produit
                {
                    idClient = CurrentClient.idClient,
                    montant = totalPrice,
                    date = DateTime.Now,
                    numFacture = DateTime.Now.ToString("MMddyyyyHHmmss") + CurrentClient.idClient
                };
                List<produit> products = new List<produit>();
                foreach (DerivedProduct p in BuyList)
                {
                    products.Add(new produit
                    {
                        idProduit = p.produit.idProduit,
                        quantiteStock = p.boughtQuantity
                    });
                }

                DataBase.Instance.createSale(facture, products);

                InvoiceCreation invoice = new InvoiceCreation();

                invoice.num = facture.numFacture;
                invoice.total = Double.Parse(label_totalEuro.Text.Split('€')[0]);
                invoice.date = DateTime.Now.ToString("dd/MM/yyyy");
                invoice.clientName = CurrentClient.nomClient.ToString() + " " + CurrentClient.prenomClient.ToString();
                invoice.productList = BuyList;

                invoice.Create();

                ResetClient();
                RefreshDataGrid();
                ToggleDisplayProducts();
            }
        }



        #endregion

        #region comboBox Value Changed

        private void comboBox_customers_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboBox_customers.SelectedItem != null)
            {
                ClientSelected();
                ToggleDisplayProducts();
                ToggleDisplayQuantity();
            }
        }

        private void comboBox_products_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboBox_products.SelectedItem != null)
            {
                SelectedProduct = (produit)comboBox_products.SelectedItem;
                numericUpDown_amount.Maximum = SelectedProduct.quantiteStock;
                ToggleDisplayQuantity();
            }

        }
        #endregion


        private void ResetClient()
        {
            CurrentClient = null;
            SelectedProduct = null;
            button_change.Visible = false;
            comboBox_customers.Enabled = true;
            comboBox_customers.SelectedItem = null;
            BuyList.Clear();
        }

        private void ClientSelected()
        {
            CurrentClient = (client)comboBox_customers.SelectedItem;
            button_change.Visible = true;
            comboBox_customers.Enabled = false;
        }

        private void CalcTotal()
        {
            float total = 0;
            if (dataGridView_buyList.RowCount == 0)
            {
                label_totalEuro.Text = "0€";
                button_confirm.Enabled = false;
            }
            else
            {
                foreach (DataGridViewRow row in dataGridView_buyList.Rows)
                {
                    int quantity = Int32.Parse(row.Cells[3].Value.ToString());
                    float price = float.Parse(row.Cells[4].Value.ToString());
                    total += quantity * price;
                }
                label_totalEuro.Text = total + "€";
                button_confirm.Enabled = true;
            }

        }


    }
}
