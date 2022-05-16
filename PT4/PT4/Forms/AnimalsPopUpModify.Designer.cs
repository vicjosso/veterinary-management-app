namespace PT4
{
    partial class AnimalsPopUpModify
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
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.label_LastName = new System.Windows.Forms.Label();
            this.button_OK = new System.Windows.Forms.Button();
            this.button_cancel = new System.Windows.Forms.Button();
            this.label_firstName = new System.Windows.Forms.Label();
            this.textBox_Espece = new System.Windows.Forms.TextBox();
            this.label_num = new System.Windows.Forms.Label();
            this.textBox_Race = new System.Windows.Forms.TextBox();
            this.panel_main = new System.Windows.Forms.Panel();
            this.button_delete = new System.Windows.Forms.Button();
            this.label_birthdate = new System.Windows.Forms.Label();
            this.dateTimePicker_birthdate = new System.Windows.Forms.DateTimePicker();
            this.label_weight = new System.Windows.Forms.Label();
            this.numericUpDown_Weight = new System.Windows.Forms.NumericUpDown();
            this.label_heigth = new System.Windows.Forms.Label();
            this.numericUpDown_Heigth = new System.Windows.Forms.NumericUpDown();
            this.label_error = new System.Windows.Forms.Label();
            this.panel_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Weight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Heigth)).BeginInit();
            this.SuspendLayout();
            // 
            // label_title
            // 
            this.label_title.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_title.ForeColor = System.Drawing.Color.Transparent;
            this.label_title.Location = new System.Drawing.Point(0, 0);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(800, 25);
            this.label_title.TabIndex = 0;
            this.label_title.Text = "Modifier un animal";
            this.label_title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBox_Name
            // 
            this.textBox_Name.Location = new System.Drawing.Point(220, 25);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(120, 20);
            this.textBox_Name.TabIndex = 1;
            // 
            // label_LastName
            // 
            this.label_LastName.AutoSize = true;
            this.label_LastName.ForeColor = System.Drawing.Color.Transparent;
            this.label_LastName.Location = new System.Drawing.Point(185, 28);
            this.label_LastName.Name = "label_LastName";
            this.label_LastName.Size = new System.Drawing.Size(29, 13);
            this.label_LastName.TabIndex = 5;
            this.label_LastName.Text = "Nom";
            // 
            // button_OK
            // 
            this.button_OK.ForeColor = System.Drawing.Color.Transparent;
            this.button_OK.Location = new System.Drawing.Point(479, 191);
            this.button_OK.Name = "button_OK";
            this.button_OK.Size = new System.Drawing.Size(75, 23);
            this.button_OK.TabIndex = 7;
            this.button_OK.Text = "OK";
            this.button_OK.UseVisualStyleBackColor = true;
            this.button_OK.Click += new System.EventHandler(this.button_OK_Click);
            // 
            // button_cancel
            // 
            this.button_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_cancel.ForeColor = System.Drawing.Color.Transparent;
            this.button_cancel.Location = new System.Drawing.Point(265, 191);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(75, 23);
            this.button_cancel.TabIndex = 9;
            this.button_cancel.Text = "Annuler";
            this.button_cancel.UseVisualStyleBackColor = true;
            // 
            // label_firstName
            // 
            this.label_firstName.AutoSize = true;
            this.label_firstName.ForeColor = System.Drawing.Color.Transparent;
            this.label_firstName.Location = new System.Drawing.Point(430, 28);
            this.label_firstName.Name = "label_firstName";
            this.label_firstName.Size = new System.Drawing.Size(43, 13);
            this.label_firstName.TabIndex = 17;
            this.label_firstName.Text = "Espece";
            // 
            // textBox_Espece
            // 
            this.textBox_Espece.Location = new System.Drawing.Point(479, 25);
            this.textBox_Espece.Name = "textBox_Espece";
            this.textBox_Espece.Size = new System.Drawing.Size(120, 20);
            this.textBox_Espece.TabIndex = 2;
            // 
            // label_num
            // 
            this.label_num.AutoSize = true;
            this.label_num.ForeColor = System.Drawing.Color.Transparent;
            this.label_num.Location = new System.Drawing.Point(181, 76);
            this.label_num.Name = "label_num";
            this.label_num.Size = new System.Drawing.Size(33, 13);
            this.label_num.TabIndex = 19;
            this.label_num.Text = "Race";
            // 
            // textBox_Race
            // 
            this.textBox_Race.Location = new System.Drawing.Point(220, 73);
            this.textBox_Race.MaxLength = 12;
            this.textBox_Race.Name = "textBox_Race";
            this.textBox_Race.Size = new System.Drawing.Size(120, 20);
            this.textBox_Race.TabIndex = 3;
            // 
            // panel_main
            // 
            this.panel_main.Controls.Add(this.button_delete);
            this.panel_main.Controls.Add(this.label_birthdate);
            this.panel_main.Controls.Add(this.dateTimePicker_birthdate);
            this.panel_main.Controls.Add(this.label_weight);
            this.panel_main.Controls.Add(this.numericUpDown_Weight);
            this.panel_main.Controls.Add(this.label_heigth);
            this.panel_main.Controls.Add(this.numericUpDown_Heigth);
            this.panel_main.Controls.Add(this.label_error);
            this.panel_main.Controls.Add(this.label_LastName);
            this.panel_main.Controls.Add(this.button_OK);
            this.panel_main.Controls.Add(this.button_cancel);
            this.panel_main.Controls.Add(this.label_firstName);
            this.panel_main.Controls.Add(this.textBox_Espece);
            this.panel_main.Controls.Add(this.label_num);
            this.panel_main.Controls.Add(this.textBox_Race);
            this.panel_main.Controls.Add(this.textBox_Name);
            this.panel_main.Location = new System.Drawing.Point(12, 93);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(776, 234);
            this.panel_main.TabIndex = 20;
            // 
            // button_delete
            // 
            this.button_delete.ForeColor = System.Drawing.Color.Transparent;
            this.button_delete.Location = new System.Drawing.Point(369, 191);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(75, 23);
            this.button_delete.TabIndex = 8;
            this.button_delete.Text = "Supprimer";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // label_birthdate
            // 
            this.label_birthdate.AutoSize = true;
            this.label_birthdate.ForeColor = System.Drawing.Color.Transparent;
            this.label_birthdate.Location = new System.Drawing.Point(376, 119);
            this.label_birthdate.Name = "label_birthdate";
            this.label_birthdate.Size = new System.Drawing.Size(96, 13);
            this.label_birthdate.TabIndex = 26;
            this.label_birthdate.Text = "Date de naissance";
            // 
            // dateTimePicker_birthdate
            // 
            this.dateTimePicker_birthdate.Location = new System.Drawing.Point(479, 116);
            this.dateTimePicker_birthdate.Name = "dateTimePicker_birthdate";
            this.dateTimePicker_birthdate.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker_birthdate.TabIndex = 6;
            // 
            // label_weight
            // 
            this.label_weight.AutoSize = true;
            this.label_weight.ForeColor = System.Drawing.Color.Transparent;
            this.label_weight.Location = new System.Drawing.Point(182, 119);
            this.label_weight.Name = "label_weight";
            this.label_weight.Size = new System.Drawing.Size(33, 13);
            this.label_weight.TabIndex = 24;
            this.label_weight.Text = "Poids";
            // 
            // numericUpDown_Weight
            // 
            this.numericUpDown_Weight.Location = new System.Drawing.Point(220, 116);
            this.numericUpDown_Weight.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numericUpDown_Weight.Name = "numericUpDown_Weight";
            this.numericUpDown_Weight.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_Weight.TabIndex = 5;
            // 
            // label_heigth
            // 
            this.label_heigth.AutoSize = true;
            this.label_heigth.ForeColor = System.Drawing.Color.Transparent;
            this.label_heigth.Location = new System.Drawing.Point(440, 76);
            this.label_heigth.Name = "label_heigth";
            this.label_heigth.Size = new System.Drawing.Size(32, 13);
            this.label_heigth.TabIndex = 22;
            this.label_heigth.Text = "Taille";
            // 
            // numericUpDown_Heigth
            // 
            this.numericUpDown_Heigth.Location = new System.Drawing.Point(478, 73);
            this.numericUpDown_Heigth.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numericUpDown_Heigth.Name = "numericUpDown_Heigth";
            this.numericUpDown_Heigth.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_Heigth.TabIndex = 4;
            // 
            // label_error
            // 
            this.label_error.AutoSize = true;
            this.label_error.ForeColor = System.Drawing.Color.Red;
            this.label_error.Location = new System.Drawing.Point(310, 6);
            this.label_error.Name = "label_error";
            this.label_error.Size = new System.Drawing.Size(0, 13);
            this.label_error.TabIndex = 20;
            // 
            // AnimalsPopUpModify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel_main);
            this.Controls.Add(this.label_title);
            this.Name = "AnimalsPopUpModify";
            this.Text = "Modifier animal";
            this.panel_main.ResumeLayout(false);
            this.panel_main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Weight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Heigth)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.Label label_LastName;
        private System.Windows.Forms.Button button_OK;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.Label label_firstName;
        private System.Windows.Forms.TextBox textBox_Espece;
        private System.Windows.Forms.Label label_num;
        private System.Windows.Forms.TextBox textBox_Race;
        private System.Windows.Forms.Panel panel_main;
        private System.Windows.Forms.Label label_error;
        private System.Windows.Forms.Label label_weight;
        private System.Windows.Forms.NumericUpDown numericUpDown_Weight;
        private System.Windows.Forms.Label label_heigth;
        private System.Windows.Forms.NumericUpDown numericUpDown_Heigth;
        private System.Windows.Forms.Label label_birthdate;
        private System.Windows.Forms.DateTimePicker dateTimePicker_birthdate;
        private System.Windows.Forms.Button button_delete;
    }
}