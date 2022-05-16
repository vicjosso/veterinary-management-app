using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace PT4
{
    public partial class Create_Appointment : Form
    {
        public rendez_vous Appointment { get; set; }
        public Create_Appointment()
        {
            InitializeComponent();
            InitComboBox();
            Appointment = new rendez_vous();
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
        }

        public Create_Appointment(rendez_vous rendez_Vous)
        {
            InitializeComponent();
            InitComboBox(rendez_Vous);
            Appointment = rendez_Vous;
        }

        #region Init Methods
        private void InitComboBox()
        {
            List<client> clients = DataBase.Instance.getClients("");
            comboBox_clients.Items.AddRange(clients.ToArray());
        }

        private void InitComboBox(rendez_vous rdv)
        {
            comboBox_clients.Items.Add(rdv.client);
            comboBox_clients.SelectedIndex = 0;
            comboBox_clients.Enabled = false;
            dateTimePicker.Value = rdv.dateDebut;
            textBox_Reason.Text = rdv.raison;
        }
        #endregion

        #region Buttons Events
        private void button_Confirm_Click(object sender, EventArgs e)
        {
            if (comboBox_clients.SelectedItem != null &&
                comboBox_duration.SelectedItem != null)
            {
                Appointment.client = comboBox_clients.SelectedItem as client;
                DateTime date = dateTimePicker.Value;
                Appointment.dateDebut = date;
                int index = comboBox_duration.SelectedIndex + 1;
                Appointment.dateFin = date.AddMinutes(index * 30);
                Appointment.raison = textBox_Reason.Text;
            }
            else
            {
                MessageBox.Show("Informations incorrectes");
            }
        }
        #endregion
    }
}
