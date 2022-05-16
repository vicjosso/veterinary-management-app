namespace PT4
{
    partial class StockPopUpModify
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
            this.label_euro2 = new System.Windows.Forms.Label();
            this.label_euro = new System.Windows.Forms.Label();
            this.numericUpDown_unitPrice = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_buyPrice = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_quantity = new System.Windows.Forms.NumericUpDown();
            this.button_cancel = new System.Windows.Forms.Button();
            this.button_OK = new System.Windows.Forms.Button();
            this.label_buyPrice = new System.Windows.Forms.Label();
            this.label_description = new System.Windows.Forms.Label();
            this.textBox_description = new System.Windows.Forms.TextBox();
            this.label_unitPrice = new System.Windows.Forms.Label();
            this.label_quantity = new System.Windows.Forms.Label();
            this.label_name = new System.Windows.Forms.Label();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.button_delete = new System.Windows.Forms.Button();
            this.label_error = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_unitPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_buyPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_quantity)).BeginInit();
            this.SuspendLayout();
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_title.ForeColor = System.Drawing.Color.Transparent;
            this.label_title.Location = new System.Drawing.Point(306, 40);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(215, 25);
            this.label_title.TabIndex = 1;
            this.label_title.Text = "Modification de stock";
            // 
            // label_euro2
            // 
            this.label_euro2.AutoSize = true;
            this.label_euro2.ForeColor = System.Drawing.Color.Transparent;
            this.label_euro2.Location = new System.Drawing.Point(663, 240);
            this.label_euro2.Name = "label_euro2";
            this.label_euro2.Size = new System.Drawing.Size(13, 13);
            this.label_euro2.TabIndex = 31;
            this.label_euro2.Text = "€";
            // 
            // label_euro
            // 
            this.label_euro.AutoSize = true;
            this.label_euro.ForeColor = System.Drawing.Color.Transparent;
            this.label_euro.Location = new System.Drawing.Point(308, 241);
            this.label_euro.Name = "label_euro";
            this.label_euro.Size = new System.Drawing.Size(13, 13);
            this.label_euro.TabIndex = 30;
            this.label_euro.Text = "€";
            // 
            // numericUpDown_unitPrice
            // 
            this.numericUpDown_unitPrice.DecimalPlaces = 2;
            this.numericUpDown_unitPrice.Location = new System.Drawing.Point(537, 238);
            this.numericUpDown_unitPrice.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numericUpDown_unitPrice.Name = "numericUpDown_unitPrice";
            this.numericUpDown_unitPrice.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_unitPrice.TabIndex = 5;
            // 
            // numericUpDown_buyPrice
            // 
            this.numericUpDown_buyPrice.DecimalPlaces = 2;
            this.numericUpDown_buyPrice.Location = new System.Drawing.Point(186, 238);
            this.numericUpDown_buyPrice.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numericUpDown_buyPrice.Name = "numericUpDown_buyPrice";
            this.numericUpDown_buyPrice.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_buyPrice.TabIndex = 4;
            // 
            // numericUpDown_quantity
            // 
            this.numericUpDown_quantity.Location = new System.Drawing.Point(186, 191);
            this.numericUpDown_quantity.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numericUpDown_quantity.Name = "numericUpDown_quantity";
            this.numericUpDown_quantity.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_quantity.TabIndex = 3;
            // 
            // button_cancel
            // 
            this.button_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_cancel.ForeColor = System.Drawing.Color.Transparent;
            this.button_cancel.Location = new System.Drawing.Point(186, 385);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(75, 23);
            this.button_cancel.TabIndex = 8;
            this.button_cancel.Text = "Annuler";
            this.button_cancel.UseVisualStyleBackColor = true;
            // 
            // button_OK
            // 
            this.button_OK.ForeColor = System.Drawing.Color.Transparent;
            this.button_OK.Location = new System.Drawing.Point(574, 385);
            this.button_OK.Name = "button_OK";
            this.button_OK.Size = new System.Drawing.Size(75, 23);
            this.button_OK.TabIndex = 6;
            this.button_OK.Text = "OK";
            this.button_OK.UseVisualStyleBackColor = true;
            this.button_OK.Click += new System.EventHandler(this.button_OK_Click);
            // 
            // label_buyPrice
            // 
            this.label_buyPrice.AutoSize = true;
            this.label_buyPrice.ForeColor = System.Drawing.Color.Transparent;
            this.label_buyPrice.Location = new System.Drawing.Point(98, 238);
            this.label_buyPrice.Name = "label_buyPrice";
            this.label_buyPrice.Size = new System.Drawing.Size(67, 13);
            this.label_buyPrice.TabIndex = 27;
            this.label_buyPrice.Text = "Prix à l\'achat";
            // 
            // label_description
            // 
            this.label_description.AutoSize = true;
            this.label_description.ForeColor = System.Drawing.Color.Transparent;
            this.label_description.Location = new System.Drawing.Point(468, 152);
            this.label_description.Name = "label_description";
            this.label_description.Size = new System.Drawing.Size(60, 13);
            this.label_description.TabIndex = 26;
            this.label_description.Text = "Description";
            // 
            // textBox_description
            // 
            this.textBox_description.Location = new System.Drawing.Point(537, 149);
            this.textBox_description.MaxLength = 250;
            this.textBox_description.Multiline = true;
            this.textBox_description.Name = "textBox_description";
            this.textBox_description.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_description.Size = new System.Drawing.Size(120, 62);
            this.textBox_description.TabIndex = 2;
            // 
            // label_unitPrice
            // 
            this.label_unitPrice.AutoSize = true;
            this.label_unitPrice.ForeColor = System.Drawing.Color.Transparent;
            this.label_unitPrice.Location = new System.Drawing.Point(417, 240);
            this.label_unitPrice.Name = "label_unitPrice";
            this.label_unitPrice.Size = new System.Drawing.Size(111, 13);
            this.label_unitPrice.TabIndex = 25;
            this.label_unitPrice.Text = "Prix unitaire à la vente";
            // 
            // label_quantity
            // 
            this.label_quantity.AutoSize = true;
            this.label_quantity.ForeColor = System.Drawing.Color.Transparent;
            this.label_quantity.Location = new System.Drawing.Point(118, 193);
            this.label_quantity.Name = "label_quantity";
            this.label_quantity.Size = new System.Drawing.Size(47, 13);
            this.label_quantity.TabIndex = 24;
            this.label_quantity.Text = "Quantité";
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.ForeColor = System.Drawing.Color.Transparent;
            this.label_name.Location = new System.Drawing.Point(136, 152);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(29, 13);
            this.label_name.TabIndex = 23;
            this.label_name.Text = "Nom";
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(186, 149);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(120, 20);
            this.textBox_name.TabIndex = 1;
            // 
            // button_delete
            // 
            this.button_delete.ForeColor = System.Drawing.Color.Transparent;
            this.button_delete.Location = new System.Drawing.Point(381, 385);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(75, 23);
            this.button_delete.TabIndex = 7;
            this.button_delete.Text = "Supprimer";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // label_error
            // 
            this.label_error.AutoSize = true;
            this.label_error.ForeColor = System.Drawing.Color.Red;
            this.label_error.Location = new System.Drawing.Point(290, 113);
            this.label_error.Name = "label_error";
            this.label_error.Size = new System.Drawing.Size(0, 13);
            this.label_error.TabIndex = 33;
            // 
            // StockPopUpModify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_error);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.label_euro2);
            this.Controls.Add(this.label_euro);
            this.Controls.Add(this.numericUpDown_unitPrice);
            this.Controls.Add(this.numericUpDown_buyPrice);
            this.Controls.Add(this.numericUpDown_quantity);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_OK);
            this.Controls.Add(this.label_buyPrice);
            this.Controls.Add(this.label_description);
            this.Controls.Add(this.textBox_description);
            this.Controls.Add(this.label_unitPrice);
            this.Controls.Add(this.label_quantity);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.label_title);
            this.Name = "StockPopUpModify";
            this.Text = "Modification produit";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_unitPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_buyPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_quantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.Label label_euro2;
        private System.Windows.Forms.Label label_euro;
        private System.Windows.Forms.NumericUpDown numericUpDown_unitPrice;
        private System.Windows.Forms.NumericUpDown numericUpDown_buyPrice;
        private System.Windows.Forms.NumericUpDown numericUpDown_quantity;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.Button button_OK;
        private System.Windows.Forms.Label label_buyPrice;
        private System.Windows.Forms.Label label_description;
        private System.Windows.Forms.TextBox textBox_description;
        private System.Windows.Forms.Label label_unitPrice;
        private System.Windows.Forms.Label label_quantity;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Label label_error;
    }
}