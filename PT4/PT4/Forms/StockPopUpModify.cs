using System;
using System.Drawing;
using System.Windows.Forms;

namespace PT4
{
    public partial class StockPopUpModify : Form
    {
        public produit produit { get; set; }
        public StockPopUpModify(produit produit)
        {
            this.produit = produit;
            InitializeComponent();
            InitText();
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);

        }
        #region Init Methods
        private void InitText()
        {
            textBox_name.Text = produit.nomProduit;
            textBox_description.Text = produit.description;
            numericUpDown_quantity.Value = produit.quantiteStock;
            numericUpDown_unitPrice.Value = produit.prixVenteClient;
            numericUpDown_buyPrice.Value = produit.prixAchat;
        }
        #endregion

        #region Events

        private void button_OK_Click(object sender, EventArgs e)
        {
            if (Valid())
            {
                this.DialogResult = DialogResult.OK;
                produit.nomProduit = textBox_name.Text;
                produit.quantiteStock = Int32.Parse(numericUpDown_quantity.Value.ToString());
                produit.description = textBox_description.Text;
                produit.prixAchat = numericUpDown_buyPrice.Value;
                produit.prixVenteClient = numericUpDown_unitPrice.Value;
                this.Close();
            }
            else
            {
                label_error.Text = "Impossible de modifier : Des informations sont incorrectes";
            }

        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            string message = "Voulez-vous vraiment supprimer ce produit?";
            string caption = "Suppression produit";
            var response = MessageBox.Show(message, caption,
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);
            if (response == DialogResult.Yes)
            {
                this.DialogResult = DialogResult.Retry;
                this.Close();
            }
        }
        #endregion

        private bool Valid()
        {
            return !String.IsNullOrWhiteSpace(textBox_name.Text)
                && !String.IsNullOrWhiteSpace(textBox_description.Text)
                && numericUpDown_quantity.Value > 0
                && numericUpDown_unitPrice.Value > 0
                && numericUpDown_buyPrice.Value > 0
                && numericUpDown_unitPrice.Value >= numericUpDown_buyPrice.Value;
        }
    }
}
