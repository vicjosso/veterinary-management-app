using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace PT4
{
    public partial class animals : Form
    {
        client CurrentClient { get; set; }
        public animals(client c)
        {
            this.CurrentClient = c;
            InitializeComponent();
            InitDataGrid();
            RefreshDataGrid();
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
        }
        #region DataGrid Gestion 
        private void InitDataGrid()
        {
            dataGridAnimals.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridAnimals.MultiSelect = false;
            dataGridAnimals.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void RefreshDataGrid()
        {
            dataGridAnimals.DataSource = CurrentClient.animal.ToList();
            for (int i = dataGridAnimals.Columns.Count - 1; i >= dataGridAnimals.Columns.Count - 3; i--)
            {
                dataGridAnimals.Columns[i].Visible = false;
            }

        }
        #endregion

        #region Buttons Events
        private void button_addAnimals_Click(object sender, EventArgs e)
        {
            using (var form = new AnimalsPopUp(CurrentClient))
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    DataBase.Instance.createAnimal(form.animal);
                    RefreshDataGrid();
                }
            }
        }

        private void button_modify_Click(object sender, EventArgs e)
        {

            if (dataGridAnimals.SelectedRows.Count == 0)
            {
                return;
            }
            animal a = dataGridAnimals.SelectedRows[0].DataBoundItem as animal;
            using (var form = new AnimalsPopUpModify(CurrentClient, a))
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    DataBase.Instance.updateAnimal(form.animal);
                    RefreshDataGrid();
                }
                else if (result == DialogResult.Retry)
                {
                    DataBase.Instance.removeAnimal(form.animal.idAnimal);
                    RefreshDataGrid();
                }
            }
        }
        #endregion


    }

}
