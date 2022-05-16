using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace PT4
{
    public partial class Overview : Form
    {
        public Overview()
        {
            InitializeComponent();
            InitListAndCalendar();
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
        }

        #region Init Methods
        private void InitListAndCalendar()
        {
            List<rendez_vous> Appointments = DataBase.Instance.getAppointments().FindAll(a => a.dateDebut.Day == DateTime.Now.Day);
            if (Appointments.Count == 0)
            {
                listBoxTodayAppointments.Items.Add("Aucun rendez-vous de prévu aujourd'hui");
            }
            foreach (rendez_vous appointment in Appointments)
            {
                listBoxTodayAppointments.Items.Add("Rendez-vous à " + appointment.dateDebut.ToShortTimeString() + " avec " + appointment.client + " pendant " + appointment.dateFin.Subtract(appointment.dateDebut));
                monthCalendar.AddBoldedDate(appointment.dateDebut);
            }
        }
        #endregion
    }
}
