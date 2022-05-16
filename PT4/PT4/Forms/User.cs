using System.Drawing;
using System.Windows.Forms;

namespace PT4
{
    public partial class User : Form
    {
        public User()
        {
            InitializeComponent();
            InitTags();
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);

        }

        #region InitMethods
        private void InitTags()
        {
            pictureBox_previousPassword.Tag = textBoxLastPassword;
            pictureBox_newPassword.Tag = textBoxNewPassword;
            pictureBox_confirmNewPassword.Tag = textBoxConfirmNewPassword;
        }
        public void InitLabels()
        {
            labelFirstName.Text = PageManager.salarie.login;
            labelAddress.Text = PageManager.salarie.adresse;
            labelTel.Text = PageManager.salarie.telephone;
            labelMail.Text = PageManager.salarie.mail;
        }
        #endregion

        #region Events

        private void User_Load(object sender, System.EventArgs e)
        {
            InitLabels();
        }

        private void button_confirmPassword_Click(object sender, System.EventArgs e)
        {
            if (textBoxNewPassword.Text.Equals(textBoxConfirmNewPassword.Text) && !string.IsNullOrWhiteSpace(textBoxNewPassword.Text) && !string.IsNullOrWhiteSpace(textBoxConfirmNewPassword.Text))
            {
                if (DataBase.Instance.changeUserPassword(PageManager.salarie, textBoxLastPassword.Text, textBoxConfirmNewPassword.Text))
                {
                    label_error.ForeColor = System.Drawing.Color.Green;
                    label_error.Text = "Changement de mot de passe effectué avec succès";
                }
                else
                {
                    label_error.ForeColor = System.Drawing.Color.Red;
                    label_error.Text = "Ancien mot de passe incorrect";
                }
            }
            else
            {
                label_error.ForeColor = System.Drawing.Color.Red;
                label_error.Text = "Les nouveaux mots de passe ne correspondent pas";
            }
            ClearTextBox();
        }

        private void pictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            PictureBox pictureBox = sender as PictureBox;
            TextBox textbox = pictureBox.Tag as TextBox;
            textbox.PasswordChar = '\0';
        }

        private void pictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            PictureBox pictureBox = sender as PictureBox;
            TextBox textbox = pictureBox.Tag as TextBox;
            textbox.PasswordChar = '*';
        }
        #endregion

        private void ClearTextBox()
        {
            textBoxLastPassword.Text = "";
            textBoxNewPassword.Text = "";
            textBoxConfirmNewPassword.Text = "";
        }


    }
}
