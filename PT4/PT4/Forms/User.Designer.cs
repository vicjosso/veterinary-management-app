namespace PT4
{
    partial class User
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
            this.labelFirstName = new System.Windows.Forms.Label();
            this.labelTel = new System.Windows.Forms.Label();
            this.labelAddress = new System.Windows.Forms.Label();
            this.labelMail = new System.Windows.Forms.Label();
            this.labelChangeInfos = new System.Windows.Forms.Label();
            this.labelLastPassword = new System.Windows.Forms.Label();
            this.labelConfirmNewPassword = new System.Windows.Forms.Label();
            this.textBoxLastPassword = new System.Windows.Forms.TextBox();
            this.labelNewPassword = new System.Windows.Forms.Label();
            this.textBoxNewPassword = new System.Windows.Forms.TextBox();
            this.textBoxConfirmNewPassword = new System.Windows.Forms.TextBox();
            this.button_confirmPassword = new System.Windows.Forms.Button();
            this.label_error = new System.Windows.Forms.Label();
            this.pictureBox_confirmNewPassword = new System.Windows.Forms.PictureBox();
            this.pictureBox_newPassword = new System.Windows.Forms.PictureBox();
            this.pictureBox_previousPassword = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_confirmNewPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_newPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_previousPassword)).BeginInit();
            this.SuspendLayout();
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFirstName.ForeColor = System.Drawing.Color.White;
            this.labelFirstName.Location = new System.Drawing.Point(25, 24);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(42, 20);
            this.labelFirstName.TabIndex = 2;
            this.labelFirstName.Text = "Nom";
            // 
            // labelTel
            // 
            this.labelTel.AutoSize = true;
            this.labelTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTel.ForeColor = System.Drawing.Color.White;
            this.labelTel.Location = new System.Drawing.Point(25, 185);
            this.labelTel.Name = "labelTel";
            this.labelTel.Size = new System.Drawing.Size(30, 20);
            this.labelTel.TabIndex = 3;
            this.labelTel.Text = "Tel";
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddress.ForeColor = System.Drawing.Color.White;
            this.labelAddress.Location = new System.Drawing.Point(25, 80);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(68, 20);
            this.labelAddress.TabIndex = 4;
            this.labelAddress.Text = "Adresse";
            // 
            // labelMail
            // 
            this.labelMail.AutoSize = true;
            this.labelMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMail.ForeColor = System.Drawing.Color.White;
            this.labelMail.Location = new System.Drawing.Point(25, 138);
            this.labelMail.Name = "labelMail";
            this.labelMail.Size = new System.Drawing.Size(37, 20);
            this.labelMail.TabIndex = 5;
            this.labelMail.Text = "Mail";
            // 
            // labelChangeInfos
            // 
            this.labelChangeInfos.AutoSize = true;
            this.labelChangeInfos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChangeInfos.ForeColor = System.Drawing.Color.White;
            this.labelChangeInfos.Location = new System.Drawing.Point(940, 239);
            this.labelChangeInfos.Name = "labelChangeInfos";
            this.labelChangeInfos.Size = new System.Drawing.Size(173, 20);
            this.labelChangeInfos.TabIndex = 7;
            this.labelChangeInfos.Text = "Modifier mot de passe :";
            // 
            // labelLastPassword
            // 
            this.labelLastPassword.AutoSize = true;
            this.labelLastPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLastPassword.ForeColor = System.Drawing.Color.White;
            this.labelLastPassword.Location = new System.Drawing.Point(876, 288);
            this.labelLastPassword.Name = "labelLastPassword";
            this.labelLastPassword.Size = new System.Drawing.Size(121, 15);
            this.labelLastPassword.TabIndex = 8;
            this.labelLastPassword.Text = "Ancien mot de passe";
            // 
            // labelConfirmNewPassword
            // 
            this.labelConfirmNewPassword.AutoSize = true;
            this.labelConfirmNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConfirmNewPassword.ForeColor = System.Drawing.Color.White;
            this.labelConfirmNewPassword.Location = new System.Drawing.Point(796, 366);
            this.labelConfirmNewPassword.Name = "labelConfirmNewPassword";
            this.labelConfirmNewPassword.Size = new System.Drawing.Size(201, 15);
            this.labelConfirmNewPassword.TabIndex = 9;
            this.labelConfirmNewPassword.Text = "Confirmer le nouveau mot de passe";
            // 
            // textBoxLastPassword
            // 
            this.textBoxLastPassword.Location = new System.Drawing.Point(1013, 288);
            this.textBoxLastPassword.Name = "textBoxLastPassword";
            this.textBoxLastPassword.PasswordChar = '*';
            this.textBoxLastPassword.Size = new System.Drawing.Size(100, 20);
            this.textBoxLastPassword.TabIndex = 10;
            // 
            // labelNewPassword
            // 
            this.labelNewPassword.AutoSize = true;
            this.labelNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNewPassword.ForeColor = System.Drawing.Color.White;
            this.labelNewPassword.Location = new System.Drawing.Point(866, 327);
            this.labelNewPassword.Name = "labelNewPassword";
            this.labelNewPassword.Size = new System.Drawing.Size(133, 15);
            this.labelNewPassword.TabIndex = 11;
            this.labelNewPassword.Text = "Nouveau mot de passe";
            // 
            // textBoxNewPassword
            // 
            this.textBoxNewPassword.Location = new System.Drawing.Point(1013, 327);
            this.textBoxNewPassword.Name = "textBoxNewPassword";
            this.textBoxNewPassword.PasswordChar = '*';
            this.textBoxNewPassword.Size = new System.Drawing.Size(100, 20);
            this.textBoxNewPassword.TabIndex = 12;
            // 
            // textBoxConfirmNewPassword
            // 
            this.textBoxConfirmNewPassword.Location = new System.Drawing.Point(1013, 365);
            this.textBoxConfirmNewPassword.Name = "textBoxConfirmNewPassword";
            this.textBoxConfirmNewPassword.PasswordChar = '*';
            this.textBoxConfirmNewPassword.Size = new System.Drawing.Size(100, 20);
            this.textBoxConfirmNewPassword.TabIndex = 13;
            // 
            // button_confirmPassword
            // 
            this.button_confirmPassword.Location = new System.Drawing.Point(1025, 406);
            this.button_confirmPassword.Name = "button_confirmPassword";
            this.button_confirmPassword.Size = new System.Drawing.Size(75, 23);
            this.button_confirmPassword.TabIndex = 14;
            this.button_confirmPassword.Text = "Confirmer";
            this.button_confirmPassword.UseVisualStyleBackColor = true;
            this.button_confirmPassword.Click += new System.EventHandler(this.button_confirmPassword_Click);
            // 
            // label_error
            // 
            this.label_error.AutoSize = true;
            this.label_error.ForeColor = System.Drawing.Color.Red;
            this.label_error.Location = new System.Drawing.Point(964, 265);
            this.label_error.Name = "label_error";
            this.label_error.Size = new System.Drawing.Size(0, 13);
            this.label_error.TabIndex = 15;
            // 
            // pictureBox_confirmNewPassword
            // 
            this.pictureBox_confirmNewPassword.Image = global::PT4.Properties.Resources.icon_showPassword;
            this.pictureBox_confirmNewPassword.Location = new System.Drawing.Point(1119, 365);
            this.pictureBox_confirmNewPassword.Name = "pictureBox_confirmNewPassword";
            this.pictureBox_confirmNewPassword.Size = new System.Drawing.Size(24, 24);
            this.pictureBox_confirmNewPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox_confirmNewPassword.TabIndex = 18;
            this.pictureBox_confirmNewPassword.TabStop = false;
            this.pictureBox_confirmNewPassword.Tag = "";
            this.pictureBox_confirmNewPassword.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseDown);
            this.pictureBox_confirmNewPassword.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseUp);
            // 
            // pictureBox_newPassword
            // 
            this.pictureBox_newPassword.Image = global::PT4.Properties.Resources.icon_showPassword;
            this.pictureBox_newPassword.Location = new System.Drawing.Point(1119, 323);
            this.pictureBox_newPassword.Name = "pictureBox_newPassword";
            this.pictureBox_newPassword.Size = new System.Drawing.Size(24, 24);
            this.pictureBox_newPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox_newPassword.TabIndex = 17;
            this.pictureBox_newPassword.TabStop = false;
            this.pictureBox_newPassword.Tag = "";
            this.pictureBox_newPassword.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseDown);
            this.pictureBox_newPassword.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseUp);
            // 
            // pictureBox_previousPassword
            // 
            this.pictureBox_previousPassword.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox_previousPassword.Image = global::PT4.Properties.Resources.icon_showPassword;
            this.pictureBox_previousPassword.Location = new System.Drawing.Point(1119, 284);
            this.pictureBox_previousPassword.Name = "pictureBox_previousPassword";
            this.pictureBox_previousPassword.Size = new System.Drawing.Size(24, 24);
            this.pictureBox_previousPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox_previousPassword.TabIndex = 16;
            this.pictureBox_previousPassword.TabStop = false;
            this.pictureBox_previousPassword.Tag = "";
            this.pictureBox_previousPassword.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseDown);
            this.pictureBox_previousPassword.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseUp);
            // 
            // User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1187, 446);
            this.Controls.Add(this.pictureBox_confirmNewPassword);
            this.Controls.Add(this.pictureBox_newPassword);
            this.Controls.Add(this.pictureBox_previousPassword);
            this.Controls.Add(this.label_error);
            this.Controls.Add(this.button_confirmPassword);
            this.Controls.Add(this.textBoxConfirmNewPassword);
            this.Controls.Add(this.textBoxNewPassword);
            this.Controls.Add(this.labelNewPassword);
            this.Controls.Add(this.textBoxLastPassword);
            this.Controls.Add(this.labelConfirmNewPassword);
            this.Controls.Add(this.labelLastPassword);
            this.Controls.Add(this.labelChangeInfos);
            this.Controls.Add(this.labelMail);
            this.Controls.Add(this.labelAddress);
            this.Controls.Add(this.labelTel);
            this.Controls.Add(this.labelFirstName);
            this.Name = "User";
            this.Text = "Compte utilisateur";
            this.Load += new System.EventHandler(this.User_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_confirmNewPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_newPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_previousPassword)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.Label labelTel;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.Label labelMail;
        private System.Windows.Forms.Label labelChangeInfos;
        private System.Windows.Forms.Label labelLastPassword;
        private System.Windows.Forms.Label labelConfirmNewPassword;
        private System.Windows.Forms.TextBox textBoxLastPassword;
        private System.Windows.Forms.Label labelNewPassword;
        private System.Windows.Forms.TextBox textBoxNewPassword;
        private System.Windows.Forms.TextBox textBoxConfirmNewPassword;
        private System.Windows.Forms.Button button_confirmPassword;
        private System.Windows.Forms.Label label_error;
        private System.Windows.Forms.PictureBox pictureBox_previousPassword;
        private System.Windows.Forms.PictureBox pictureBox_newPassword;
        private System.Windows.Forms.PictureBox pictureBox_confirmNewPassword;
    }
}