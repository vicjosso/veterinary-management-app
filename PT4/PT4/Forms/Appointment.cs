using GridScheduleSample;
using Syncfusion.Windows.Forms.Schedule;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace PT4
{
    public partial class Appointment : Form
    {

        List<rendez_vous> AppointmentList = new List<rendez_vous>();
        public Appointment()
        {
            InitializeComponent();
            RefreshSchedule();
            InitSchedule();
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
        }

        #region Init Methods
        private void InitSchedule()
        {
            this.scheduleControl1.GetScheduleHost().Calendar.DateValueChanging += Calendar_DateValueChanging;
            this.scheduleControl1.GetScheduleHost().Schedule.Appearance.VisualStyle = Syncfusion.Windows.Forms.GridVisualStyles.Metro;
            InitContextMenu();
        }

        private void InitContextMenu()
        {
            ContextMenu menu = new ContextMenu();
            MenuItem addItem = new MenuItem("Ajouter rendez-vous", (obj, eventsArgs) => { this.scheduleControl1.PerformNewItemClick(); });
            MenuItem editItem = new MenuItem("Modifier rendez-vous", (obj, eventsArgs) => { this.scheduleControl1.PerformEditItemClick(); });
            MenuItem removeItem = new MenuItem("Retirer rendez-vous", new EventHandler(deleteItemClick));
            menu.MenuItems.Add(addItem);
            menu.MenuItems.Add(editItem);
            menu.MenuItems.Add(removeItem);
            this.scheduleControl1.GetScheduleHost().ContextMenu = menu;
        }
        private void RefreshSchedule()
        {
            AppointmentList = DataBase.Instance.getAppointments();
            SimpleScheduleDataProvider data = new SimpleScheduleDataProvider();
            SimpleScheduleAppointmentList list = new SimpleScheduleAppointmentList();
            foreach (var item in AppointmentList)
            {
                SimpleScheduleAppointment a = new SimpleScheduleAppointment
                {
                    Tag = item,
                    StartTime = item.dateDebut,
                    EndTime = item.dateFin,
                    Subject = "Rendez-vous avec "
                    + item.client.nomClient
                    + " " + item.client.prenomClient
                };
                list.Add(a);
            }
            data.MasterList = list;
            data.FileName = "RENDEZ-VOUS";
            this.scheduleControl1.ScheduleType = ScheduleViewType.Week;
            this.scheduleControl1.DataSource = data;
        }
        #endregion

        #region Events
        private void deleteItemClick(object sender, EventArgs e)
        {
            if (this.scheduleControl1.GetScheduleHost().SelectedAppointments.Count != 0)
            {
                var response = MessageBox.Show("Voulez-vous supprimer ce rendez-vous", "Suppression RDV",
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);
                if (response == DialogResult.Yes)
                {
                    rendez_vous rdv = this.scheduleControl1.GetScheduleHost().SelectedAppointments[0].Tag as rendez_vous;
                    DataBase.Instance.removeAppointment(rdv.idRDV);
                    RefreshSchedule();
                }
            }
        }
        private void scheduleControl1_ShowingAppointmentForm(object sender, ShowingAppointFormEventArgs e)
        {
            e.Cancel = true;
            if (e.Item is SimpleScheduleAppointment)
            {
                var item = e.Item as SimpleScheduleAppointment;
                if (!String.IsNullOrEmpty(item.Subject))
                {
                    using (var form = new Create_Appointment((rendez_vous)item.Tag))
                    {
                        var result = form.ShowDialog();
                        if (result == DialogResult.OK)
                        {
                            DataBase.Instance.updateAppointment(form.Appointment);
                            RefreshSchedule();
                        }
                    }
                }
                else
                {
                    using (var form = new Create_Appointment())
                    {
                        var result = form.ShowDialog();
                        if (result == DialogResult.OK)
                        {
                            DataBase.Instance.CreateAppointment(form.Appointment);
                            RefreshSchedule();
                        }
                    }
                }
            }

        }

        private void Calendar_DateValueChanging(object sender, EventArgs e)
        {
            InitContextMenu();

        }
        #endregion
    }
}
