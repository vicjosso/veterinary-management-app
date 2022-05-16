using System;
using System.Drawing;
using System.Windows.Forms;

namespace PT4
{
    public partial class ClientsPopUp : Form
    {
        public client client { get; set; }

        public ClientsPopUp()
        {
            InitializeComponent();
            InitPanel();
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);

        }
        #region Init Methods
        private void InitPanel()
        {
            panel_main.Location = new Point(this.ClientSize.Width / 2 - panel_main.Size.Width / 2, this.ClientSize.Height / 2 - panel_main.Size.Height / 2);
            panel_main.Anchor = AnchorStyles.None;
        }
        #endregion

        #region Boutons Events

        private void button_OK_Click(object sender, EventArgs e)
        {
            if (Valid())
            {
                client = new client
                {
                    nomClient = textBox_LastName.Text,
                    prenomClient = textBox_firstName.Text,
                    numeroClient = textBox_num.Text
                };

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
            return !(String.IsNullOrWhiteSpace(textBox_firstName.Text)
                || String.IsNullOrWhiteSpace(textBox_LastName.Text)
                || String.IsNullOrWhiteSpace(textBox_num.Text))
                && Utils.IsPhoneNumber(textBox_num.Text);
        }
    }
}
