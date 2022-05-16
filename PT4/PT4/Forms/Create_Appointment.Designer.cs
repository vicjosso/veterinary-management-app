namespace PT4
{
    partial class Create_Appointment
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
            this.label_title = new System.Windows.Forms.Label();
            this.label_clients = new System.Windows.Forms.Label();
            this.label_date = new System.Windows.Forms.Label();
            this.comboBox_clients = new System.Windows.Forms.ComboBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.button_Confirm = new System.Windows.Forms.Button();
            this.textBox_Reason = new System.Windows.Forms.TextBox();
            this.label_reason = new System.Windows.Forms.Label();
            this.label_duration = new System.Windows.Forms.Label();
            this.comboBox_duration = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.label_title.ForeColor = System.Drawing.Color.White;
            this.label_title.Location = new System.Drawing.Point(89, 33);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(216, 25);
            this.label_title.TabIndex = 0;
            this.label_title.Text = "Prise de rendez-vous";
            // 
            // label_clients
            // 
            this.label_clients.AutoSize = true;
            this.label_clients.ForeColor = System.Drawing.Color.White;
            this.label_clients.Location = new System.Drawing.Point(43, 108);
            this.label_clients.Name = "label_clients";
            this.label_clients.Size = new System.Drawing.Size(38, 13);
            this.label_clients.TabIndex = 1;
            this.label_clients.Text = "Clients";
            // 
            // label_date
            // 
            this.label_date.AutoSize = true;
            this.label_date.ForeColor = System.Drawing.Color.White;
            this.label_date.Location = new System.Drawing.Point(51, 146);
            this.label_date.Name = "label_date";
            this.label_date.Size = new System.Drawing.Size(30, 13);
            this.label_date.TabIndex = 2;
            this.label_date.Text = "Date";
            // 
            // comboBox_clients
            // 
            this.comboBox_clients.FormattingEnabled = true;
            this.comboBox_clients.Location = new System.Drawing.Point(94, 105);
            this.comboBox_clients.Name = "comboBox_clients";
            this.comboBox_clients.Size = new System.Drawing.Size(184, 21);
            this.comboBox_clients.TabIndex = 3;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker.Location = new System.Drawing.Point(94, 146);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker.TabIndex = 4;
            // 
            // button_Cancel
            // 
            this.button_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_Cancel.Location = new System.Drawing.Point(127, 322);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(75, 23);
            this.button_Cancel.TabIndex = 9;
            this.button_Cancel.Text = "Annuler";
            this.button_Cancel.UseVisualStyleBackColor = true;
            // 
            // button_Confirm
            // 
            this.button_Confirm.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button_Confirm.Location = new System.Drawing.Point(230, 322);
            this.button_Confirm.Name = "button_Confirm";
            this.button_Confirm.Size = new System.Drawing.Size(75, 23);
            this.button_Confirm.TabIndex = 10;
            this.button_Confirm.Text = "Confirmer";
            this.button_Confirm.UseVisualStyleBackColor = true;
            this.button_Confirm.Click += new System.EventHandler(this.button_Confirm_Click);
            // 
            // textBox_Reason
            // 
            this.textBox_Reason.Location = new System.Drawing.Point(93, 212);
            this.textBox_Reason.Multiline = true;
            this.textBox_Reason.Name = "textBox_Reason";
            this.textBox_Reason.Size = new System.Drawing.Size(255, 45);
            this.textBox_Reason.TabIndex = 11;
            // 
            // label_reason
            // 
            this.label_reason.AutoSize = true;
            this.label_reason.ForeColor = System.Drawing.Color.White;
            this.label_reason.Location = new System.Drawing.Point(41, 234);
            this.label_reason.Name = "label_reason";
            this.label_reason.Size = new System.Drawing.Size(40, 13);
            this.label_reason.TabIndex = 12;
            this.label_reason.Text = "Raison";
            // 
            // label_duration
            // 
            this.label_duration.AutoSize = true;
            this.label_duration.ForeColor = System.Drawing.Color.White;
            this.label_duration.Location = new System.Drawing.Point(19, 185);
            this.label_duration.Name = "label_duration";
            this.label_duration.Size = new System.Drawing.Size(62, 13);
            this.label_duration.TabIndex = 13;
            this.label_duration.Text = "Durée RDV";
            // 
            // comboBox_duration
            // 
            this.comboBox_duration.FormattingEnabled = true;
            this.comboBox_duration.Items.AddRange(new object[] {
            "30 minutes",
            "1 heure",
            "1 heure 30 minutes",
            "2 heures",
            "2 heures 30 minutes",
            "3 heures"});
            this.comboBox_duration.Location = new System.Drawing.Point(93, 182);
            this.comboBox_duration.Name = "comboBox_duration";
            this.comboBox_duration.Size = new System.Drawing.Size(190, 21);
            this.comboBox_duration.TabIndex = 14;
            // 
            // Create_Appointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(468, 450);
            this.Controls.Add(this.comboBox_duration);
            this.Controls.Add(this.label_duration);
            this.Controls.Add(this.label_reason);
            this.Controls.Add(this.textBox_Reason);
            this.Controls.Add(this.button_Confirm);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.comboBox_clients);
            this.Controls.Add(this.label_date);
            this.Controls.Add(this.label_clients);
            this.Controls.Add(this.label_title);
            this.Name = "Create_Appointment";
            this.Text = "Créer un rendez-vous";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.Label label_clients;
        private System.Windows.Forms.Label label_date;
        private System.Windows.Forms.ComboBox comboBox_clients;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.Button button_Confirm;
        private System.Windows.Forms.TextBox textBox_Reason;
        private System.Windows.Forms.Label label_reason;
        private System.Windows.Forms.Label label_duration;
        private System.Windows.Forms.ComboBox comboBox_duration;
    }
}