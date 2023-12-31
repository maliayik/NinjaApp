﻿namespace NinjaApp.Winform.Forms
{
    partial class SuplierForm
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
            suplierGridView = new DataGridView();
            messageDataGridView = new DataGridView();
            txtSelectedProduct = new TextBox();
            txtUnit = new TextBox();
            cmbSelectedCategory = new ComboBox();
            label1 = new Label();
            btnBuy = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            lblTotal = new Label();
            btnBack = new Button();
            panel1 = new Panel();
            label5 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)suplierGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)messageDataGridView).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // suplierGridView
            // 
            suplierGridView.AllowUserToDeleteRows = false;
            suplierGridView.BackgroundColor = Color.Gainsboro;
            suplierGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            suplierGridView.Location = new Point(5, 60);
            suplierGridView.Name = "suplierGridView";
            suplierGridView.ReadOnly = true;
            suplierGridView.RowHeadersWidth = 45;
            suplierGridView.RowTemplate.Height = 27;
            suplierGridView.Size = new Size(456, 426);
            suplierGridView.TabIndex = 0;
            // 
            // messageDataGridView
            // 
            messageDataGridView.AllowUserToAddRows = false;
            messageDataGridView.AllowUserToDeleteRows = false;
            messageDataGridView.BackgroundColor = Color.Gainsboro;
            messageDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            messageDataGridView.Location = new Point(675, 60);
            messageDataGridView.Name = "messageDataGridView";
            messageDataGridView.ReadOnly = true;
            messageDataGridView.RowHeadersWidth = 45;
            messageDataGridView.RowTemplate.Height = 27;
            messageDataGridView.Size = new Size(425, 426);
            messageDataGridView.TabIndex = 1;
            // 
            // txtSelectedProduct
            // 
            txtSelectedProduct.BackColor = Color.Gainsboro;
            txtSelectedProduct.BorderStyle = BorderStyle.None;
            txtSelectedProduct.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtSelectedProduct.Location = new Point(466, 127);
            txtSelectedProduct.Multiline = true;
            txtSelectedProduct.Name = "txtSelectedProduct";
            txtSelectedProduct.Size = new Size(204, 39);
            txtSelectedProduct.TabIndex = 3;
            // 
            // txtUnit
            // 
            txtUnit.BackColor = Color.Gainsboro;
            txtUnit.BorderStyle = BorderStyle.None;
            txtUnit.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtUnit.Location = new Point(466, 196);
            txtUnit.Multiline = true;
            txtUnit.Name = "txtUnit";
            txtUnit.Size = new Size(204, 39);
            txtUnit.TabIndex = 3;
            // 
            // cmbSelectedCategory
            // 
            cmbSelectedCategory.FormattingEnabled = true;
            cmbSelectedCategory.Location = new Point(249, 29);
            cmbSelectedCategory.Name = "cmbSelectedCategory";
            cmbSelectedCategory.Size = new Size(212, 25);
            cmbSelectedCategory.TabIndex = 4;
            cmbSelectedCategory.SelectedIndexChanged += cmbSelectedCategory_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Consolas", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(466, 100);
            label1.Name = "label1";
            label1.Size = new Size(154, 24);
            label1.TabIndex = 5;
            label1.Text = "Seçilen Ürün";
            // 
            // btnBuy
            // 
            btnBuy.BackColor = Color.FromArgb(81, 80, 75);
            btnBuy.FlatAppearance.BorderSize = 0;
            btnBuy.FlatStyle = FlatStyle.Popup;
            btnBuy.Font = new Font("Consolas", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnBuy.ForeColor = Color.White;
            btnBuy.Location = new Point(467, 264);
            btnBuy.Name = "btnBuy";
            btnBuy.Size = new Size(203, 49);
            btnBuy.TabIndex = 6;
            btnBuy.Text = "SİPARİŞ VER";
            btnBuy.UseVisualStyleBackColor = false;
            btnBuy.Click += btnBuy_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Consolas", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlDarkDark;
            label2.Location = new Point(466, 169);
            label2.Name = "label2";
            label2.Size = new Size(130, 24);
            label2.TabIndex = 5;
            label2.Text = "Stok Adeti";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Consolas", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ControlDarkDark;
            label3.Location = new Point(466, 238);
            label3.Name = "label3";
            label3.Size = new Size(94, 24);
            label3.TabIndex = 5;
            label3.Text = "Fiyat :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Consolas", 12.9056606F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ControlDarkDark;
            label4.Location = new Point(14, 29);
            label4.Name = "label4";
            label4.Size = new Size(210, 22);
            label4.TabIndex = 5;
            label4.Text = "Tedarikçi Kategorisi";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Consolas", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotal.ForeColor = SystemColors.ControlDarkDark;
            lblTotal.Location = new Point(562, 238);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(0, 24);
            lblTotal.TabIndex = 7;
            // 
            // btnBack
            // 
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.ForeColor = Color.Transparent;
            btnBack.Image = Properties.Resources.arrow_left;
            btnBack.Location = new Point(10, 6);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(112, 42);
            btnBack.TabIndex = 8;
            btnBack.TextAlign = ContentAlignment.TopCenter;
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(suplierGridView);
            panel1.Controls.Add(cmbSelectedCategory);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(messageDataGridView);
            panel1.Controls.Add(lblTotal);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnBuy);
            panel1.Controls.Add(txtSelectedProduct);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtUnit);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(-2, 54);
            panel1.Name = "panel1";
            panel1.Size = new Size(1104, 523);
            panel1.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Gainsboro;
            label5.Font = new Font("Courier New", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(353, 12);
            label5.Name = "label5";
            label5.Size = new Size(458, 41);
            label5.TabIndex = 10;
            label5.Text = "NİNJA MARKET TEDARİK";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Consolas", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ControlDarkDark;
            label6.Location = new Point(788, 33);
            label6.Name = "label6";
            label6.Size = new Size(214, 24);
            label6.TabIndex = 5;
            label6.Text = "Gelen Bildirimler";
            // 
            // SuplierForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(1103, 578);
            Controls.Add(label5);
            Controls.Add(panel1);
            Controls.Add(btnBack);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SuplierForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SuplierForm";
            Load += SuplierForm_Load;
            ((System.ComponentModel.ISupportInitialize)suplierGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)messageDataGridView).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView suplierGridView;
        private DataGridView messageDataGridView;
        private TextBox txtSelectedProduct;
        private TextBox txtUnit;
        private ComboBox cmbSelectedCategory;
        private Label label1;
        private Button btnBuy;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label lblTotal;
        private Button btnBack;
        private Panel panel1;
        private Label label5;
        private Label label6;
    }
}