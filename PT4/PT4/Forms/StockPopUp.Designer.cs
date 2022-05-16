namespace PT4
{
    partial class StockPopUp
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
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.label_name = new System.Windows.Forms.Label();
            this.label_quantity = new System.Windows.Forms.Label();
            this.label_unitPrice = new System.Windows.Forms.Label();
            this.label_buyPrice = new System.Windows.Forms.Label();
            this.button_OK = new System.Windows.Forms.Button();
            this.button_cancel = new System.Windows.Forms.Button();
            this.numericUpDown_quantity = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_buyPrice = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_unitPrice = new System.Windows.Forms.NumericUpDown();
            this.label_euro = new System.Windows.Forms.Label();
            this.label_euro2 = new System.Windows.Forms.Label();
            this.panel_main = new System.Windows.Forms.Panel();
            this.label_title = new System.Windows.Forms.Label();
            this.label_description = new System.Windows.Forms.Label();
            this.textBox_description = new System.Windows.Forms.TextBox();
            this.label_error = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_quantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_buyPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_unitPrice)).BeginInit();
            this.panel_main.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(190, 146);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(120, 20);
            this.textBox_name.TabIndex = 1;
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.ForeColor = System.Drawing.Color.Transparent;
            this.label_name.Location = new System.Drawing.Point(136, 149);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(29, 13);
            this.label_name.TabIndex = 5;
            this.label_name.Text = "Nom";
            this.label_name.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label_quantity
            // 
            this.label_quantity.AutoSize = true;
            this.label_quantity.ForeColor = System.Drawing.Color.Transparent;
            this.label_quantity.Location = new System.Drawing.Point(118, 195);
            this.label_quantity.Name = "label_quantity";
            this.label_quantity.Size = new System.Drawing.Size(47, 13);
            this.label_quantity.TabIndex = 7;
            this.label_quantity.Text = "Quantité";
            // 
            // label_unitPrice
            // 
            this.label_unitPrice.AutoSize = true;
            this.label_unitPrice.ForeColor = System.Drawing.Color.Transparent;
            this.label_unitPrice.Location = new System.Drawing.Point(389, 237);
            this.label_unitPrice.Name = "label_unitPrice";
            this.label_unitPrice.Size = new System.Drawing.Size(111, 13);
            this.label_unitPrice.TabIndex = 9;
            this.label_unitPrice.Text = "Prix unitaire à la vente";
            // 
            // label_buyPrice
            // 
            this.label_buyPrice.AutoSize = true;
            this.label_buyPrice.ForeColor = System.Drawing.Color.Transparent;
            this.label_buyPrice.Location = new System.Drawing.Point(98, 239);
            this.label_buyPrice.Name = "label_buyPrice";
            this.label_buyPrice.Size = new System.Drawing.Size(67, 13);
            this.label_buyPrice.TabIndex = 13;
            this.label_buyPrice.Text = "Prix à l\'achat";
            // 
            // button_OK
            // 
            this.button_OK.ForeColor = System.Drawing.Color.Transparent;
            this.button_OK.Location = new System.Drawing.Point(440, 342);
            this.button_OK.Name = "button_OK";
            this.button_OK.Size = new System.Drawing.Size(75, 23);
            this.button_OK.TabIndex = 6;
            this.button_OK.Text = "OK";
            this.button_OK.UseVisualStyleBackColor = true;
            this.button_OK.Click += new System.EventHandler(this.button_OK_Click);
            // 
            // button_cancel
            // 
            this.button_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_cancel.ForeColor = System.Drawing.Color.Transparent;
            this.button_cancel.Location = new System.Drawing.Point(313, 342);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(75, 23);
            this.button_cancel.TabIndex = 7;
            this.button_cancel.Text = "Annuler";
            this.button_cancel.UseVisualStyleBackColor = true;
            // 
            // numericUpDown_quantity
            // 
            this.numericUpDown_quantity.Location = new System.Drawing.Point(190, 193);
            this.numericUpDown_quantity.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numericUpDown_quantity.Name = "numericUpDown_quantity";
            this.numericUpDown_quantity.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_quantity.TabIndex = 3;
            // 
            // numericUpDown_buyPrice
            // 
            this.numericUpDown_buyPrice.DecimalPlaces = 2;
            this.numericUpDown_buyPrice.Location = new System.Drawing.Point(190, 237);
            this.numericUpDown_buyPrice.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numericUpDown_buyPrice.Name = "numericUpDown_buyPrice";
            this.numericUpDown_buyPrice.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_buyPrice.TabIndex = 4;
            // 
            // numericUpDown_unitPrice
            // 
            this.numericUpDown_unitPrice.DecimalPlaces = 2;
            this.numericUpDown_unitPrice.Location = new System.Drawing.Point(521, 237);
            this.numericUpDown_unitPrice.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numericUpDown_unitPrice.Name = "numericUpDown_unitPrice";
            this.numericUpDown_unitPrice.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_unitPrice.TabIndex = 5;
            // 
            // label_euro
            // 
            this.label_euro.AutoSize = true;
            this.label_euro.ForeColor = System.Drawing.Color.Transparent;
            this.label_euro.Location = new System.Drawing.Point(316, 240);
            this.label_euro.Name = "label_euro";
            this.label_euro.Size = new System.Drawing.Size(13, 13);
            this.label_euro.TabIndex = 16;
            this.label_euro.Text = "€";
            // 
            // label_euro2
            // 
            this.label_euro2.AutoSize = true;
            this.label_euro2.ForeColor = System.Drawing.Color.Transparent;
            this.label_euro2.Location = new System.Drawing.Point(647, 239);
            this.label_euro2.Name = "label_euro2";
            this.label_euro2.Size = new System.Drawing.Size(13, 13);
            this.label_euro2.TabIndex = 17;
            this.label_euro2.Text = "€";
            // 
            // panel_main
            // 
            this.panel_main.Controls.Add(this.label_title);
            this.panel_main.Controls.Add(this.label_description);
            this.panel_main.Controls.Add(this.textBox_description);
            this.panel_main.Controls.Add(this.label_error);
            this.panel_main.Controls.Add(this.textBox_name);
            this.panel_main.Controls.Add(this.button_OK);
            this.panel_main.Controls.Add(this.button_cancel);
            this.panel_main.Controls.Add(this.label_euro2);
            this.panel_main.Controls.Add(this.label_name);
            this.panel_main.Controls.Add(this.numericUpDown_unitPrice);
            this.panel_main.Controls.Add(this.label_euro);
            this.panel_main.Controls.Add(this.label_quantity);
            this.panel_main.Controls.Add(this.numericUpDown_quantity);
            this.panel_main.Controls.Add(this.label_unitPrice);
            this.panel_main.Controls.Add(this.numericUpDown_buyPrice);
            this.panel_main.Controls.Add(this.label_buyPrice);
            this.panel_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_main.Location = new System.Drawing.Point(0, 0);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(799, 424);
            this.panel_main.TabIndex = 18;
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_title.ForeColor = System.Drawing.Color.Transparent;
            this.label_title.Location = new System.Drawing.Point(314, 38);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(163, 25);
            this.label_title.TabIndex = 21;
            this.label_title.Text = "Ajout de produit";
            // 
            // label_description
            // 
            this.label_description.AutoSize = true;
            this.label_description.ForeColor = System.Drawing.Color.Transparent;
            this.label_description.Location = new System.Drawing.Point(455, 149);
            this.label_description.Name = "label_description";
            this.label_description.Size = new System.Drawing.Size(60, 13);
            this.label_description.TabIndex = 20;
            this.label_description.Text = "Description";
            this.label_description.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBox_description
            // 
            this.textBox_description.Location = new System.Drawing.Point(521, 146);
            this.textBox_description.MaxLength = 250;
            this.textBox_description.Multiline = true;
            this.textBox_description.Name = "textBox_description";
            this.textBox_description.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_description.Size = new System.Drawing.Size(120, 67);
            this.textBox_description.TabIndex = 2;
            // 
            // label_error
            // 
            this.label_error.AutoSize = true;
            this.label_error.ForeColor = System.Drawing.Color.Red;
            this.label_error.Location = new System.Drawing.Point(329, 106);
            this.label_error.Name = "label_error";
            this.label_error.Size = new System.Drawing.Size(0, 13);
            this.label_error.TabIndex = 18;
            // 
            // StockPopUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(799, 424);
            this.Controls.Add(this.panel_main);
            this.Name = "StockPopUp";
            this.Text = "Ajout produit";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_quantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_buyPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_unitPrice)).EndInit();
            this.panel_main.ResumeLayout(false);
            this.panel_main.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Label label_quantity;
        private System.Windows.Forms.Label label_unitPrice;
        private System.Windows.Forms.Label label_buyPrice;
        private System.Windows.Forms.Button button_OK;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.NumericUpDown numericUpDown_quantity;
        private System.Windows.Forms.NumericUpDown numericUpDown_buyPrice;
        private System.Windows.Forms.NumericUpDown numericUpDown_unitPrice;
        private System.Windows.Forms.Label label_euro;
        private System.Windows.Forms.Label label_euro2;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.Panel panel_main;
        private System.Windows.Forms.Label label_error;
        private System.Windows.Forms.TextBox textBox_description;
        private System.Windows.Forms.Label label_description;
        private System.Windows.Forms.Label label_title;
    }
}