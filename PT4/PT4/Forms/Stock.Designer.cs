namespace PT4
{
    partial class Stock
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
            this.searchBox = new System.Windows.Forms.TextBox();
            this.dataGridProduct = new System.Windows.Forms.DataGridView();
            this.button_addNewStock = new System.Windows.Forms.Button();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_modify = new System.Windows.Forms.Button();
            this.label_search = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProduct)).BeginInit();
            this.panelMain.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(1078, 11);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(100, 20);
            this.searchBox.TabIndex = 6;
            this.searchBox.TextChanged += new System.EventHandler(this.searchBox_TextChanged);
            // 
            // dataGridProduct
            // 
            this.dataGridProduct.AllowUserToAddRows = false;
            this.dataGridProduct.AllowUserToDeleteRows = false;
            this.dataGridProduct.AllowUserToResizeColumns = false;
            this.dataGridProduct.AllowUserToResizeRows = false;
            this.dataGridProduct.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataGridProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridProduct.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridProduct.Location = new System.Drawing.Point(0, 0);
            this.dataGridProduct.Name = "dataGridProduct";
            this.dataGridProduct.ReadOnly = true;
            this.dataGridProduct.RowHeadersVisible = false;
            this.dataGridProduct.Size = new System.Drawing.Size(1187, 406);
            this.dataGridProduct.TabIndex = 4;
            // 
            // button_addNewStock
            // 
            this.button_addNewStock.ForeColor = System.Drawing.Color.Transparent;
            this.button_addNewStock.Location = new System.Drawing.Point(12, 11);
            this.button_addNewStock.Name = "button_addNewStock";
            this.button_addNewStock.Size = new System.Drawing.Size(120, 20);
            this.button_addNewStock.TabIndex = 1;
            this.button_addNewStock.Text = "+";
            this.button_addNewStock.UseVisualStyleBackColor = true;
            this.button_addNewStock.Click += new System.EventHandler(this.button_addNewStock_Click);
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.panel1);
            this.panelMain.Controls.Add(this.dataGridProduct);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1187, 446);
            this.panelMain.TabIndex = 16;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button_modify);
            this.panel1.Controls.Add(this.label_search);
            this.panel1.Controls.Add(this.button_addNewStock);
            this.panel1.Controls.Add(this.searchBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 406);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1187, 40);
            this.panel1.TabIndex = 18;
            // 
            // button_modify
            // 
            this.button_modify.ForeColor = System.Drawing.Color.Transparent;
            this.button_modify.Location = new System.Drawing.Point(138, 11);
            this.button_modify.Name = "button_modify";
            this.button_modify.Size = new System.Drawing.Size(120, 20);
            this.button_modify.TabIndex = 16;
            this.button_modify.Text = "Modifier";
            this.button_modify.UseVisualStyleBackColor = true;
            this.button_modify.MouseCaptureChanged += new System.EventHandler(this.button_Modify_Click);
            // 
            // label_search
            // 
            this.label_search.AutoSize = true;
            this.label_search.Location = new System.Drawing.Point(968, 14);
            this.label_search.Name = "label_search";
            this.label_search.Size = new System.Drawing.Size(107, 13);
            this.label_search.TabIndex = 17;
            this.label_search.Text = "Recherche par nom :";
            // 
            // Stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1187, 446);
            this.Controls.Add(this.panelMain);
            this.Name = "Stock";
            this.Text = "Liste des stocks";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProduct)).EndInit();
            this.panelMain.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.DataGridView dataGridProduct;
        private System.Windows.Forms.Button button_addNewStock;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Button button_modify;
        private System.Windows.Forms.Label label_search;
        private System.Windows.Forms.Panel panel1;
    }
}