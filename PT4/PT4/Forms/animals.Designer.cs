namespace PT4
{
    partial class animals
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
            this.dataGridAnimals = new System.Windows.Forms.DataGridView();
            this.panel_main = new System.Windows.Forms.Panel();
            this.button_modify = new System.Windows.Forms.Button();
            this.button_addAnimals = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAnimals)).BeginInit();
            this.panel_main.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridAnimals
            // 
            this.dataGridAnimals.AllowUserToAddRows = false;
            this.dataGridAnimals.AllowUserToDeleteRows = false;
            this.dataGridAnimals.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataGridAnimals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAnimals.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridAnimals.Location = new System.Drawing.Point(0, 0);
            this.dataGridAnimals.Name = "dataGridAnimals";
            this.dataGridAnimals.ReadOnly = true;
            this.dataGridAnimals.RowHeadersVisible = false;
            this.dataGridAnimals.Size = new System.Drawing.Size(800, 412);
            this.dataGridAnimals.TabIndex = 0;
            // 
            // panel_main
            // 
            this.panel_main.Controls.Add(this.button_modify);
            this.panel_main.Controls.Add(this.button_addAnimals);
            this.panel_main.Controls.Add(this.dataGridAnimals);
            this.panel_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_main.Location = new System.Drawing.Point(0, 0);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(800, 450);
            this.panel_main.TabIndex = 1;
            // 
            // button_modify
            // 
            this.button_modify.Location = new System.Drawing.Point(403, 418);
            this.button_modify.Name = "button_modify";
            this.button_modify.Size = new System.Drawing.Size(87, 20);
            this.button_modify.TabIndex = 2;
            this.button_modify.Text = "Modifier";
            this.button_modify.UseVisualStyleBackColor = true;
            this.button_modify.Click += new System.EventHandler(this.button_modify_Click);
            // 
            // button_addAnimals
            // 
            this.button_addAnimals.Location = new System.Drawing.Point(310, 418);
            this.button_addAnimals.Name = "button_addAnimals";
            this.button_addAnimals.Size = new System.Drawing.Size(87, 20);
            this.button_addAnimals.TabIndex = 1;
            this.button_addAnimals.Text = "Ajouter";
            this.button_addAnimals.UseVisualStyleBackColor = true;
            this.button_addAnimals.Click += new System.EventHandler(this.button_addAnimals_Click);
            // 
            // animals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel_main);
            this.Name = "animals";
            this.Text = "Liste des animaux";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAnimals)).EndInit();
            this.panel_main.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridAnimals;
        private System.Windows.Forms.Panel panel_main;
        private System.Windows.Forms.Button button_modify;
        private System.Windows.Forms.Button button_addAnimals;
    }
}