namespace PT4
{
    partial class Appointment
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
            this.scheduleControl1 = new Syncfusion.Windows.Forms.Schedule.ScheduleControl();
            this.SuspendLayout();
            // 
            // scheduleControl1
            // 
            this.scheduleControl1.Appearance.WeekHeaderFormat = "MMMM dd";
            this.scheduleControl1.Appearance.WeekMonthFullFormat = "dddd, dd MMMM yyyy";
            this.scheduleControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(201)))), ((int)(((byte)(219)))));
            this.scheduleControl1.Culture = new System.Globalization.CultureInfo("");
            this.scheduleControl1.DataSource = null;
            this.scheduleControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scheduleControl1.ISO8601CalenderFormat = false;
            this.scheduleControl1.Location = new System.Drawing.Point(0, 0);
            this.scheduleControl1.Name = "scheduleControl1";
            this.scheduleControl1.Size = new System.Drawing.Size(800, 450);
            this.scheduleControl1.TabIndex = 0;
            this.scheduleControl1.ShowingAppointmentForm += new Syncfusion.Windows.Forms.Schedule.ShowingAppointmentFormHandler(this.scheduleControl1_ShowingAppointmentForm);
            // 
            // Appointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.scheduleControl1);
            this.Name = "Appointment";
            this.Text = "Rendez-vous";
            this.ResumeLayout(false);

        }

        #endregion

        private Syncfusion.Windows.Forms.Schedule.ScheduleControl scheduleControl1;
    }
}