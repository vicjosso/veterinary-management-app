using System;
using System.Drawing;
using System.Web.Helpers;
using System.Windows.Forms;

namespace PT4
{
    public partial class create_account : Form
    {
        public create_account()
        {
            InitializeComponent();
            InitTags();
            comboBox_admin.SelectedIndex = 0;
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
        }

        #region Init Methods

        private void InitTags()
        {
            pictureBox_showPassword.Tag = textBox_password;
            pictureBox_showConfirmPassword.Tag = textBox_confirmPassword;
        }
        #endregion

        #region Events
        private void button_confirm_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBox_login.Text)
                && !String.IsNullOrEmpty(textBox_password.Text)
                && !String.IsNullOrEmpty(textBox_confirmPassword.Text)
                && !String.IsNullOrEmpty(textBox_mail.Text)
                && !String.IsNullOrEmpty(textBox_address.Text)
                && !String.IsNullOrEmpty(textBox_phone.Text)
                && Utils.IsPhoneNumber(textBox_phone.Text)
                && Utils.IsEmail(textBox_mail.Text)
                && textBox_password.Text.Equals(textBox_confirmPassword.Text))
            {
                salarie user = new salarie
                {
                    login = textBox_login.Text,
                    telephone = textBox_password.Text,
                    mdp = Crypto.HashPassword(textBox_password.Text),
                    adresse = textBox_address.Text,
                    date_naissance_ = dateTimePicker_dateOfBirth.Value,
                    mail = textBox_mail.Text,
                    admin = Convert.ToBoolean(comboBox_admin.SelectedIndex)
                };
                DataBase.Instance.createUser(user);
                System.Windows.Forms.MessageBox.Show("Inscription terminée");
                CleanAllTextBox();
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Informations incorrectes");
            }
        }

        private void showPassword_MouseDown(object sender, MouseEventArgs e)
        {
            PictureBox pictureBox = sender as PictureBox;
            TextBox textbox = pictureBox.Tag as TextBox;
            textbox.PasswordChar = '\0';
        }

        private void showPassword_MouseUp(object sender, MouseEventArgs e)
        {
            PictureBox pictureBox = sender as PictureBox;
            TextBox textbox = pictureBox.Tag as TextBox;
            textbox.PasswordChar = '*';
        }
        #endregion

        private void CleanAllTextBox()
        {
            textBox_login.Text = "";
            textBox_password.Text = "";
            textBox_address.Text = "";
            textBox_confirmPassword.Text = "";
            textBox_phone.Text = "";
            textBox_mail.Text = "";
            comboBox_admin.SelectedIndex = 0;
            dateTimePicker_dateOfBirth.Value = DateTime.Now;
        }
    }
}
