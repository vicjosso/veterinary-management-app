namespace PT4
{
    partial class Connexion
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_connexion = new System.Windows.Forms.Button();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelLogin = new System.Windows.Forms.Label();
            this.panel_main = new System.Windows.Forms.Panel();
            this.pictureBox_Password = new System.Windows.Forms.PictureBox();
            this.labelHello = new System.Windows.Forms.Label();
            this.panel_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Password)).BeginInit();
            this.SuspendLayout();
            // 
            // button_connexion
            // 
            this.button_connexion.ForeColor = System.Drawing.Color.Transparent;
            this.button_connexion.Location = new System.Drawing.Point(407, 214);
            this.button_connexion.Name = "button_connexion";
            this.button_connexion.Size = new System.Drawing.Size(113, 24);
            this.button_connexion.TabIndex = 5;
            this.button_connexion.Text = "Connexion";
            this.button_connexion.UseVisualStyleBackColor = true;
            this.button_connexion.Click += new System.EventHandler(this.button_connexion_Click);
            // 
            // labelPassword
            // 
            this.labelPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.Location = new System.Drawing.Point(296, 188);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(105, 20);
            this.labelPassword.TabIndex = 2;
            this.labelPassword.Text = "Mot de passe";
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.ForeColor = System.Drawing.Color.Black;
            this.textBoxLogin.Location = new System.Drawing.Point(407, 160);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(113, 20);
            this.textBoxLogin.TabIndex = 3;
            this.textBoxLogin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Connexion_KeyPress);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxPassword.ForeColor = System.Drawing.Color.Black;
            this.textBoxPassword.Location = new System.Drawing.Point(407, 188);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(113, 20);
            this.textBoxPassword.TabIndex = 4;
            this.textBoxPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Connexion_KeyPress);
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLogin.Location = new System.Drawing.Point(321, 158);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(80, 20);
            this.labelLogin.TabIndex = 5;
            this.labelLogin.Text = "Identifiant";
            // 
            // panel_main
            // 
            this.panel_main.Controls.Add(this.pictureBox_Password);
            this.panel_main.Controls.Add(this.textBoxPassword);
            this.panel_main.Controls.Add(this.labelLogin);
            this.panel_main.Controls.Add(this.button_connexion);
            this.panel_main.Controls.Add(this.labelPassword);
            this.panel_main.Controls.Add(this.textBoxLogin);
            this.panel_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_main.Location = new System.Drawing.Point(0, 0);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(838, 427);
            this.panel_main.TabIndex = 6;
            // 
            // pictureBox_Password
            // 
            this.pictureBox_Password.Image = global::PT4.Properties.Resources.icon_showPassword;
            this.pictureBox_Password.Location = new System.Drawing.Point(526, 184);
            this.pictureBox_Password.Name = "pictureBox_Password";
            this.pictureBox_Password.Size = new System.Drawing.Size(24, 24);
            this.pictureBox_Password.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox_Password.TabIndex = 6;
            this.pictureBox_Password.TabStop = false;
            this.pictureBox_Password.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_Password_MouseDown);
            this.pictureBox_Password.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox_Password_MouseUp);
            // 
            // labelHello
            // 
            this.labelHello.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelHello.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHello.Location = new System.Drawing.Point(0, 0);
            this.labelHello.Name = "labelHello";
            this.labelHello.Size = new System.Drawing.Size(838, 25);
            this.labelHello.TabIndex = 1;
            this.labelHello.Text = "Bonjour";
            this.labelHello.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Connexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(838, 427);
            this.Controls.Add(this.labelHello);
            this.Controls.Add(this.panel_main);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Name = "Connexion";
            this.Text = "Connexion";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Connexion_KeyPress);
            this.panel_main.ResumeLayout(false);
            this.panel_main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Password)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_connexion;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Panel panel_main;
        private System.Windows.Forms.Label labelHello;
        private System.Windows.Forms.PictureBox pictureBox_Password;
    }
}

