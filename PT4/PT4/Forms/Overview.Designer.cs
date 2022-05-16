
namespace PT4
{
    partial class Overview
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.listBoxTodayAppointments = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_rdvtoday = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // monthCalendar
            // 
            this.monthCalendar.Location = new System.Drawing.Point(839, 146);
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.ShowTodayCircle = false;
            this.monthCalendar.TabIndex = 2;
            // 
            // listBoxTodayAppointments
            // 
            this.listBoxTodayAppointments.FormattingEnabled = true;
            this.listBoxTodayAppointments.Location = new System.Drawing.Point(61, 146);
            this.listBoxTodayAppointments.Name = "listBoxTodayAppointments";
            this.listBoxTodayAppointments.Size = new System.Drawing.Size(457, 160);
            this.listBoxTodayAppointments.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label_rdvtoday);
            this.panel1.Controls.Add(this.monthCalendar);
            this.panel1.Controls.Add(this.listBoxTodayAppointments);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1187, 446);
            this.panel1.TabIndex = 5;
            // 
            // label_rdvtoday
            // 
            this.label_rdvtoday.AutoSize = true;
            this.label_rdvtoday.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_rdvtoday.ForeColor = System.Drawing.Color.White;
            this.label_rdvtoday.Location = new System.Drawing.Point(56, 118);
            this.label_rdvtoday.Name = "label_rdvtoday";
            this.label_rdvtoday.Size = new System.Drawing.Size(223, 25);
            this.label_rdvtoday.TabIndex = 4;
            this.label_rdvtoday.Text = "Rendez-vous du jour :";
            // 
            // Overview
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1187, 446);
            this.Controls.Add(this.panel1);
            this.Name = "Overview";
            this.Text = "Accueil";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox listBoxTodayAppointments;
        private System.Windows.Forms.MonthCalendar monthCalendar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_rdvtoday;
    }
}