using System;

namespace PT4
{
    partial class Home
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.button_Overview = new System.Windows.Forms.Button();
            this.button_Stocks = new System.Windows.Forms.Button();
            this.button_Clients = new System.Windows.Forms.Button();
            this.button_rdv = new System.Windows.Forms.Button();
            this.pictureBox_Disconnect = new System.Windows.Forms.PictureBox();
            this.label_username = new System.Windows.Forms.Label();
            this.button_Sale = new System.Windows.Forms.Button();
            this.pictureBox_User = new System.Windows.Forms.PictureBox();
            this.button_createAccount = new System.Windows.Forms.Button();
            this.panel_newForm = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Disconnect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_User)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.panelMenu.Controls.Add(this.button_Overview);
            this.panelMenu.Controls.Add(this.button_Stocks);
            this.panelMenu.Controls.Add(this.button_Clients);
            this.panelMenu.Controls.Add(this.button_rdv);
            this.panelMenu.Controls.Add(this.pictureBox_Disconnect);
            this.panelMenu.Controls.Add(this.label_username);
            this.panelMenu.Controls.Add(this.button_Sale);
            this.panelMenu.Controls.Add(this.pictureBox_User);
            this.panelMenu.Controls.Add(this.button_createAccount);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(240, 485);
            this.panelMenu.TabIndex = 1;
            // 
            // button_Overview
            // 
            this.button_Overview.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button_Overview.Location = new System.Drawing.Point(0, 245);
            this.button_Overview.Name = "button_Overview";
            this.button_Overview.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button_Overview.Size = new System.Drawing.Size(240, 40);
            this.button_Overview.TabIndex = 10;
            this.button_Overview.Text = "Menu principal";
            this.button_Overview.UseVisualStyleBackColor = true;
            this.button_Overview.Click += new System.EventHandler(this.button_Overview_Click);
            // 
            // button_Stocks
            // 
            this.button_Stocks.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button_Stocks.Location = new System.Drawing.Point(0, 285);
            this.button_Stocks.Name = "button_Stocks";
            this.button_Stocks.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button_Stocks.Size = new System.Drawing.Size(240, 40);
            this.button_Stocks.TabIndex = 6;
            this.button_Stocks.Text = "Stocks";
            this.button_Stocks.UseVisualStyleBackColor = true;
            this.button_Stocks.Click += new System.EventHandler(this.button_Stocks_Click);
            // 
            // button_Clients
            // 
            this.button_Clients.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button_Clients.Location = new System.Drawing.Point(0, 325);
            this.button_Clients.Name = "button_Clients";
            this.button_Clients.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button_Clients.Size = new System.Drawing.Size(240, 40);
            this.button_Clients.TabIndex = 7;
            this.button_Clients.Text = "Clients";
            this.button_Clients.UseVisualStyleBackColor = true;
            this.button_Clients.Click += new System.EventHandler(this.button_Clients_Click);
            // 
            // button_rdv
            // 
            this.button_rdv.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button_rdv.Location = new System.Drawing.Point(0, 365);
            this.button_rdv.Name = "button_rdv";
            this.button_rdv.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button_rdv.Size = new System.Drawing.Size(240, 40);
            this.button_rdv.TabIndex = 13;
            this.button_rdv.Text = "Rendez-vous";
            this.button_rdv.UseVisualStyleBackColor = true;
            this.button_rdv.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox_Disconnect
            // 
            this.pictureBox_Disconnect.Image = global::PT4.Properties.Resources.icon_deconnexion;
            this.pictureBox_Disconnect.Location = new System.Drawing.Point(2, 42);
            this.pictureBox_Disconnect.Name = "pictureBox_Disconnect";
            this.pictureBox_Disconnect.Size = new System.Drawing.Size(32, 32);
            this.pictureBox_Disconnect.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox_Disconnect.TabIndex = 0;
            this.pictureBox_Disconnect.TabStop = false;
            this.pictureBox_Disconnect.Click += new System.EventHandler(this.pictureBox_Disconnect_Click);
            // 
            // label_username
            // 
            this.label_username.Location = new System.Drawing.Point(40, 42);
            this.label_username.Name = "label_username";
            this.label_username.Size = new System.Drawing.Size(197, 32);
            this.label_username.TabIndex = 1;
            this.label_username.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_Sale
            // 
            this.button_Sale.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button_Sale.Location = new System.Drawing.Point(0, 405);
            this.button_Sale.Name = "button_Sale";
            this.button_Sale.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button_Sale.Size = new System.Drawing.Size(240, 40);
            this.button_Sale.TabIndex = 11;
            this.button_Sale.Text = "Vente";
            this.button_Sale.UseVisualStyleBackColor = true;
            this.button_Sale.Click += new System.EventHandler(this.button_Sale_Click);
            // 
            // pictureBox_User
            // 
            this.pictureBox_User.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox_User.Image = global::PT4.Properties.Resources.icon_account;
            this.pictureBox_User.Location = new System.Drawing.Point(0, 0);
            this.pictureBox_User.Name = "pictureBox_User";
            this.pictureBox_User.Size = new System.Drawing.Size(240, 39);
            this.pictureBox_User.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox_User.TabIndex = 9;
            this.pictureBox_User.TabStop = false;
            this.pictureBox_User.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button_createAccount
            // 
            this.button_createAccount.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button_createAccount.Location = new System.Drawing.Point(0, 445);
            this.button_createAccount.Name = "button_createAccount";
            this.button_createAccount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button_createAccount.Size = new System.Drawing.Size(240, 40);
            this.button_createAccount.TabIndex = 12;
            this.button_createAccount.Text = "Creer compte";
            this.button_createAccount.UseVisualStyleBackColor = true;
            this.button_createAccount.Visible = false;
            this.button_createAccount.Click += new System.EventHandler(this.button_createAccount_Click);
            // 
            // panel_newForm
            // 
            this.panel_newForm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_newForm.Location = new System.Drawing.Point(239, 0);
            this.panel_newForm.Name = "panel_newForm";
            this.panel_newForm.Size = new System.Drawing.Size(1203, 485);
            this.panel_newForm.TabIndex = 0;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1439, 485);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panel_newForm);
            this.Name = "Home";
            this.Text = "Accueil";
            this.Load += new System.EventHandler(this.Home_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Disconnect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_User)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panel_newForm;
        private System.Windows.Forms.Button button_Clients;
        private System.Windows.Forms.Button button_Stocks;
        private System.Windows.Forms.Label label_username;
        private System.Windows.Forms.PictureBox pictureBox_User;
        private System.Windows.Forms.Button button_Overview;
        private System.Windows.Forms.Button button_Sale;
        private System.Windows.Forms.PictureBox pictureBox_Disconnect;
        private System.Windows.Forms.Button button_createAccount;
        private System.Windows.Forms.Button button_rdv;
    }
}