using System;
using System.Drawing;
using System.Windows.Forms;

namespace PT4
{
    public partial class StockPopUp : Form
    {
        public produit produit { get; set; }

        public StockPopUp()
        {
            InitializeComponent();
            InitNumericUpDown();
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
        }

        #region Init Methods
        private void InitNumericUpDown()
        {
            numericUpDown_quantity.Controls.RemoveAt(0);
            numericUpDown_buyPrice.Controls.RemoveAt(0);
            numericUpDown_unitPrice.Controls.RemoveAt(0);
        }
        #endregion
        #region Events
        private void button_OK_Click(object sender, EventArgs e)
        {
            if (Valid())
            {
                produit = new produit();
                produit.nomProduit = textBox_name.Text;
                produit.description = textBox_description.Text;
                produit.quantiteStock = Int32.Parse(numericUpDown_quantity.Value.ToString());
                produit.prixVenteClient = numericUpDown_unitPrice.Value;
                produit.prixAchat = numericUpDown_buyPrice.Value;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                label_error.Text = "Des informations sont incorrectes";
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
