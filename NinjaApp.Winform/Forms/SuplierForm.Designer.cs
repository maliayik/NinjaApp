namespace NinjaApp.Winform.Forms
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
            ((System.ComponentModel.ISupportInitialize)suplierGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)messageDataGridView).BeginInit();
            SuspendLayout();
            // 
            // suplierGridView
            // 
            suplierGridView.AllowUserToDeleteRows = false;
            suplierGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            suplierGridView.Location = new Point(-1, 115);
            suplierGridView.Name = "suplierGridView";
            suplierGridView.ReadOnly = true;
            suplierGridView.RowHeadersWidth = 45;
            suplierGridView.RowTemplate.Height = 27;
            suplierGridView.Size = new Size(456, 532);
            suplierGridView.TabIndex = 0;
            // 
            // messageDataGridView
            // 
            messageDataGridView.AllowUserToAddRows = false;
            messageDataGridView.AllowUserToDeleteRows = false;
            messageDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            messageDataGridView.Location = new Point(804, 218);
            messageDataGridView.Name = "messageDataGridView";
            messageDataGridView.ReadOnly = true;
            messageDataGridView.RowHeadersWidth = 45;
            messageDataGridView.RowTemplate.Height = 27;
            messageDataGridView.Size = new Size(425, 429);
            messageDataGridView.TabIndex = 1;
            // 
            // txtSelectedProduct
            // 
            txtSelectedProduct.Location = new Point(529, 239);
            txtSelectedProduct.Name = "txtSelectedProduct";
            txtSelectedProduct.Size = new Size(134, 25);
            txtSelectedProduct.TabIndex = 3;
            // 
            // txtUnit
            // 
            txtUnit.Location = new Point(529, 312);
            txtUnit.Name = "txtUnit";
            txtUnit.Size = new Size(134, 25);
            txtUnit.TabIndex = 3;
            // 
            // cmbSelectedCategory
            // 
            cmbSelectedCategory.FormattingEnabled = true;
            cmbSelectedCategory.Location = new Point(247, 84);
            cmbSelectedCategory.Name = "cmbSelectedCategory";
            cmbSelectedCategory.Size = new Size(208, 25);
            cmbSelectedCategory.TabIndex = 4;
            cmbSelectedCategory.SelectedIndexChanged += cmbSelectedCategory_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(529, 219);
            label1.Name = "label1";
            label1.Size = new Size(77, 17);
            label1.TabIndex = 5;
            label1.Text = "secilen ürün";
            // 
            // btnBuy
            // 
            btnBuy.Location = new Point(529, 405);
            btnBuy.Name = "btnBuy";
            btnBuy.Size = new Size(134, 25);
            btnBuy.TabIndex = 6;
            btnBuy.Text = "al";
            btnBuy.UseVisualStyleBackColor = true;
            btnBuy.Click += btnBuy_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(529, 292);
            label2.Name = "label2";
            label2.Size = new Size(65, 17);
            label2.TabIndex = 5;
            label2.Text = "stok adeti";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(529, 365);
            label3.Name = "label3";
            label3.Size = new Size(41, 17);
            label3.TabIndex = 5;
            label3.Text = "Fiyat :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(247, 51);
            label4.Name = "label4";
            label4.Size = new Size(122, 17);
            label4.TabIndex = 5;
            label4.Text = "Tedarikçi Kategorisi";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(585, 365);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(43, 17);
            lblTotal.TabIndex = 7;
            lblTotal.Text = "label5";
            // 
            // SuplierForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1229, 647);
            Controls.Add(lblTotal);
            Controls.Add(btnBuy);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(cmbSelectedCategory);
            Controls.Add(txtUnit);
            Controls.Add(txtSelectedProduct);
            Controls.Add(messageDataGridView);
            Controls.Add(suplierGridView);
            Name = "SuplierForm";
            Text = "SuplierForm";
            Load += SuplierForm_Load;
            ((System.ComponentModel.ISupportInitialize)suplierGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)messageDataGridView).EndInit();
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
    }
}