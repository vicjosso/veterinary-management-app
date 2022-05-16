namespace PT4
{
    partial class Clients
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
            this.label_search = new System.Windows.Forms.Label();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.button_modify = new System.Windows.Forms.Button();
            this.button_addNewClient = new System.Windows.Forms.Button();
            this.dataGridClient = new System.Windows.Forms.DataGridView();
            this.panel_main = new System.Windows.Forms.Panel();
            this.button_showAnimals = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridClient)).BeginInit();
            this.panel_main.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_search
            // 
            this.label_search.AutoSize = true;
            this.label_search.Location = new System.Drawing.Point(973, 408);
            this.label_search.Name = "label_search";
            this.label_search.Size = new System.Drawing.Size(107, 13);
            this.label_search.TabIndex = 17;
            this.label_search.Text = "Recherche par nom :";
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(1079, 405);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(100, 20);
            this.searchBox.TabIndex = 6;
            this.searchBox.TextChanged += new System.EventHandler(this.searchBox_TextChanged);
            // 
            // button_modify
            // 
            this.button_modify.ForeColor = System.Drawing.Color.Transparent;
            this.button_modify.Location = new System.Drawing.Point(138, 405);
            this.button_modify.Name = "button_modify";
            this.button_modify.Size = new System.Drawing.Size(120, 20);
            this.button_modify.TabIndex = 2;
            this.button_modify.Text = "Modifier";
            this.button_modify.UseVisualStyleBackColor = true;
            this.button_modify.Click += new System.EventHandler(this.button_modify_Click);
            // 
            // button_addNewClient
            // 
            this.button_addNewClient.ForeColor = System.Drawing.Color.Transparent;
            this.button_addNewClient.Location = new System.Drawing.Point(12, 405);
            this.button_addNewClient.Name = "button_addNewClient";
            this.button_addNewClient.Size = new System.Drawing.Size(120, 20);
            this.button_addNewClient.TabIndex = 1;
            this.button_addNewClient.Text = "+";
            this.button_addNewClient.UseVisualStyleBackColor = true;
            this.button_addNewClient.Click += new System.EventHandler(this.button_addNewClient_Click);
            // 
            // dataGridClient
            // 
            this.dataGridClient.AllowUserToAddRows = false;
            this.dataGridClient.AllowUserToDeleteRows = false;
            this.dataGridClient.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataGridClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridClient.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridClient.Location = new System.Drawing.Point(0, 0);
            this.dataGridClient.Name = "dataGridClient";
            this.dataGridClient.ReadOnly = true;
            this.dataGridClient.RowHeadersVisible = false;
            this.dataGridClient.Size = new System.Drawing.Size(1190, 390);
            this.dataGridClient.TabIndex = 16;
            // 
            // panel_main
            // 
            this.panel_main.Controls.Add(this.button_showAnimals);
            this.panel_main.Controls.Add(this.dataGridClient);
            this.panel_main.Controls.Add(this.button_addNewClient);
            this.panel_main.Controls.Add(this.button_modify);
            this.panel_main.Controls.Add(this.searchBox);
            this.panel_main.Controls.Add(this.label_search);
            this.panel_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_main.Location = new System.Drawing.Point(0, 0);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(1190, 446);
            this.panel_main.TabIndex = 17;
            // 
            // button_showAnimals
            // 
            this.button_showAnimals.ForeColor = System.Drawing.Color.Transparent;
            this.button_showAnimals.Location = new System.Drawing.Point(264, 405);
            this.button_showAnimals.Name = "button_showAnimals";
            this.button_showAnimals.Size = new System.Drawing.Size(120, 20);
            this.button_showAnimals.TabIndex = 18;
            this.button_showAnimals.Text = "Voir animaux";
            this.button_showAnimals.UseVisualStyleBackColor = true;
            this.button_showAnimals.Click += new System.EventHandler(this.button_showAnimals_Click);
            // 
            // Clients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1190, 446);
            this.Controls.Add(this.panel_main);
            this.Name = "Clients";
            this.Text = "Liste des clients";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridClient)).EndInit();
            this.panel_main.ResumeLayout(false);
            this.panel_main.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Button button_addNewClient;
        private System.Windows.Forms.Button button_modify;
        private System.Windows.Forms.DataGridView dataGridClient;
        private System.Windows.Forms.Panel panel_main;
        private System.Windows.Forms.Label label_search;
        private System.Windows.Forms.Button button_showAnimals;
    }
}