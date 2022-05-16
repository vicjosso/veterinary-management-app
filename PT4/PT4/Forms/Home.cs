using System;
using System.Drawing;
using System.Windows.Forms;

namespace PT4
{
    public partial class Home : Form
    {
        private Form activeForm = null;
        private Button currentPage = null;
        public Home()
        {
            InitializeComponent();
            OpenNewPage(PageManager.overview);
            hightlightButton(button_Overview);
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
        }


        public void Reload()
        {
            label_username.Text = "Bonjour " + PageManager.salarie.login;
            button_createAccount.Visible = PageManager.salarie.admin == true;
        }
        private void OpenNewPage(Form newPage)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            newPage.FormBorderStyle = FormBorderStyle.None;
            newPage.TopLevel = false;
            newPage.Dock = DockStyle.Fill;
            panel_newForm.Controls.Add(newPage);
            panel_newForm.Tag = newPage;
            Text = newPage.Text;
            newPage.BringToFront();
            newPage.Show();
        }

        private void hightlightButton(Button currentButton)
        {
            if (currentPage != null)
            {
                currentPage.ForeColor = SystemColors.ControlText;
            }
            if (currentButton != null)
            {
                currentButton.ForeColor = Color.Red;
            }

            currentPage = currentButton;
        }

        #region Events


        private void Home_Load(object sender, EventArgs e)
        {
            Reload();
        }

        private void button_Clients_Click(object sender, EventArgs e)
        {
            OpenNewPage(PageManager.clients);
            hightlightButton(button_Clients);
        }

        private void button_Stocks_Click(object sender, EventArgs e)
        {
            OpenNewPage(PageManager.stock);
            hightlightButton(button_Stocks);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenNewPage(PageManager.user);
            hightlightButton(null);
        }

        private void button_Sale_Click(object sender, EventArgs e)
        {
            OpenNewPage(PageManager.sale);
            hightlightButton(button_Sale);
        }

        private void button_Overview_Click(object sender, EventArgs e)
        {
            OpenNewPage(PageManager.overview);
            hightlightButton(button_Overview);
        }

        private void pictureBox_Disconnect_Click(object sender, EventArgs e)
        {
            PageManager.salarie = null;
            PageManager.connexion.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenNewPage(new Appointment());
            hightlightButton(button_rdv);
        }

        private void button_createAccount_Click(object sender, EventArgs e)
        {
            OpenNewPage(PageManager.create_Account);
            hightlightButton(button_createAccount);
        }

        #endregion
    }
}