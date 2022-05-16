using System;
using System.Drawing;
using System.Windows.Forms;

namespace PT4
{
    public partial class Connexion : Form
    {
        public Connexion()
        {
            InitializeComponent();
            InitPanel();
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
        }

        #region Init Methods

        private void InitPanel()
        {
            panel_main.Location = new Point(this.ClientSize.Width / 2 - panel_main.Size.Width / 2,
                this.ClientSize.Height / 2 - panel_main.Size.Height / 2);
            panel_main.Anchor = AnchorStyles.None;
        }
        #endregion

        #region Events

        private void button_connexion_Click(object sender, EventArgs e)
        {
            TryConnexion();
        }
        private void pictureBox_Password_MouseDown(object sender, MouseEventArgs e)
        {
            textBoxPassword.PasswordChar = '\0';
        }

        private void pictureBox_Password_MouseUp(object sender, MouseEventArgs e)
        {
            textBoxPassword.PasswordChar = '*';
        }

        private void Connexion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                TryConnexion();
            }
        }

        #endregion

        private void TryConnexion()
        {
            bool validUser = false;
            String login = textBoxLogin.Text;
            String password = textBoxPassword.Text;

            try
            {
                validUser = DataBase.Instance.verifUser(login, password);
            }
            catch (Exception) { System.Windows.Forms.MessageBox.Show("Base de données non connectée"); }

            if (validUser)
            {
                PageManager.connexion.Hide();
                PageManager.home.Show();
                PageManager.home.Reload();
                PageManager.salarie = DataBase.Instance.getUser(login);
                textBoxLogin.Text = "";
                textBoxPassword.Text = "";
            }
            else { System.Windows.Forms.MessageBox.Show("L'utilisateur n'existe pas, ou le mot de passe est incorrect"); }
        }


    }
}