using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace PT4
{
    public partial class Clients : Form
    {
        private List<client> ClientsList = new List<client>();
        public Clients()
        {
            InitializeComponent();
            InitDataGrid();
            RefreshDataGrid();
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
        }

        #region Init Methods
        private void InitDataGrid()
        {
            dataGridClient.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridClient.MultiSelect = false;
            dataGridClient.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void RefreshDataGrid()
        {
            ClientsList = DataBase.Instance.getClients("");
            dataGridClient.DataSource = ClientsList;
            for (int i = dataGridClient.Columns.Count - 1; i >= dataGridClient.Columns.Count - 3; i--)
            {
                dataGridClient.Columns[i].Visible = false;
            }
        }
        #endregion

        #region Events
        private void button_addNewClient_Click(object sender, EventArgs e)
        {
            using (var form = new ClientsPopUp())
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    DataBase.Instance.createClient(form.client);
                    RefreshDataGrid();
                }
            }
        }

        private void button_modify_Click(object sender, EventArgs e)
        {
            if (dataGridClient.SelectedRows.Count == 0)
            {
                return;
            }
            client c = dataGridClient.SelectedRows[0].DataBoundItem as client;
            using (var form = new ClientPopUpModify(c))
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    c = form.client;
                    DataBase.Instance.updateClient(c);
                    RefreshDataGrid();
                }
                else if (result == DialogResult.Retry)
                {
                    DataBase.Instance.removeClient(c.idClient);
                    RefreshDataGrid();
                }
            }
        }

        private void button_showAnimals_Click(object sender, EventArgs e)
        {
            if (dataGridClient.SelectedRows.Count == 0)
            {
                return;
            }
            client c = dataGridClient.SelectedRows[0].DataBoundItem as client;
            using (var form = new animals(c))
            {
                var result = form.ShowDialog();
            }
        }


        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            searchClient(searchBox.Text);
        }
        #endregion

        private void searchClient(String name)
        {
            List<client> SearchedClients = ClientsList.FindAll(c => c.nomClient.Contains(name));
            dataGridClient.DataSource = SearchedClients;
        }
    }
}
