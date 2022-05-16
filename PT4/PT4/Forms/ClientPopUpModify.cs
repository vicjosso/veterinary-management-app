using System;
using System.Drawing;
using System.Windows.Forms;

namespace PT4
{
    public partial class ClientPopUpModify : Form
    {

        public client client { get; set; }

        public ClientPopUpModify(client c)
        {
            this.client = c;
            InitializeComponent();
            InitPanel();
            InitText();
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
        }

        #region Init Methods
        private void InitText()
        {
            textBox_firstName.Text = client.prenomClient;
            textBox_LastName.Text = client.nomClient;
            textBox_num.Text = client.numeroClient;
        }

        private void InitPanel()
        {
            panel_main.Location = new Point(this.ClientSize.Width / 2 - panel_main.Size.Width / 2, this.ClientSize.Height / 2 - panel_main.Size.Height / 2);
            panel_main.Anchor = AnchorStyles.None;
        }
        #endregion

        #region Buttons Events

        private void button_OK_Click(object sender, EventArgs e)
        {
            if (Valid())
            {
                this.DialogResult = DialogResult.OK;
                client.nomClient = textBox_LastName.Text;
                client.prenomClient = textBox_firstName.Text;
                client.numeroClient = textBox_num.Text;
                this.Close();
            }
            else
            {
                label_error.Text = "Impossible de modifier : Des informations sont incorrectes";
            }

        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            string message = "Voulez-vous vraiment supprimer ce client ?";
            string caption = "Suppression client";
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
            return !(String.IsNullOrWhiteSpace(textBox_firstName.Text)
                || String.IsNullOrWhiteSpace(textBox_LastName.Text)
                || String.IsNullOrWhiteSpace(textBox_num.Text))
                && Utils.IsPhoneNumber(textBox_num.Text);
        }
    }
}
