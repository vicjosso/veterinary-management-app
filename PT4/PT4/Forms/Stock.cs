using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
namespace PT4
{
    public partial class Stock : Form
    {
        private List<produit> ProductsList = new List<produit>();
        public Stock()
        {
            InitializeComponent();
            RefreshDataGrid();
            initDataGrid();
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
        }

        #region Init Methods
        private void initDataGrid()
        {
            dataGridProduct.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridProduct.MultiSelect = false;
            dataGridProduct.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridProduct.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridProduct.Columns[2].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridProduct.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        private void RefreshDataGrid()
        {
            ProductsList = DataBase.Instance.getProducts("");
            dataGridProduct.DataSource = ProductsList;
            for (int i = dataGridProduct.Columns.Count - 1; i >= dataGridProduct.Columns.Count - 4; i--)
            {
                dataGridProduct.Columns[i].Visible = false;
            }
        }
        #endregion

        #region Events
        private void button_addNewStock_Click(object sender, EventArgs e)
        {
            using (StockPopUp form = new StockPopUp())
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    DataBase.Instance.createProduct(form.produit);
                    RefreshDataGrid();
                }
            }
        }

        private void button_Modify_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridProduct.SelectedRows[0];

            if (dataGridProduct.SelectedRows.Count == 0)
                return;
            produit p = dataGridProduct.SelectedRows[0].DataBoundItem as produit;
            using (StockPopUpModify form = new StockPopUpModify(p))
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    p = form.produit;
                    DataBase.Instance.updateProduct(p);
                    RefreshDataGrid();
                }
                else if (result == DialogResult.Retry)
                {
                    p = form.produit;
                    DataBase.Instance.removeProduct(p.idProduit);
                    RefreshDataGrid();
                }
            }
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            searchProduct(searchBox.Text);
        }
        #endregion

        private void searchProduct(String name)
        {
            List<produit> SearchedProducts = ProductsList.FindAll(p => p.nomProduit.Contains(name));
            dataGridProduct.DataSource = SearchedProducts;
        }
    }
}
