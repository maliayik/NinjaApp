namespace NinjaApp.Winform.Forms
{
    partial class ShoppingForm
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
            dataGridView1 = new DataGridView();
            cmbCategories = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            txtSelectedProduct = new TextBox();
            label3 = new Label();
            btnAdd = new Button();
            btnRemove = new Button();
            dataGridView2 = new DataGridView();
            label5 = new Label();
            lblUser = new Label();
            label4 = new Label();
            cmbUnit = new ComboBox();
            label6 = new Label();
            btnPay = new Button();
            lblTotal = new Label();
            lblBalance = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(14, 220);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 45;
            dataGridView1.RowTemplate.Height = 27;
            dataGridView1.Size = new Size(585, 734);
            dataGridView1.TabIndex = 0;
            // 
            // cmbCategories
            // 
            cmbCategories.FormattingEnabled = true;
            cmbCategories.Location = new Point(408, 164);
            cmbCategories.Name = "cmbCategories";
            cmbCategories.Size = new Size(191, 26);
            cmbCategories.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(182, 167);
            label1.Name = "label1";
            label1.Size = new Size(208, 18);
            label1.TabIndex = 2;
            label1.Text = "Ürün Kategorisi Seçiniz :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(895, 592);
            label2.Name = "label2";
            label2.Size = new Size(80, 18);
            label2.TabIndex = 4;
            label2.Text = "SELF-KASA";
            // 
            // txtSelectedProduct
            // 
            txtSelectedProduct.Location = new Point(1258, 258);
            txtSelectedProduct.Name = "txtSelectedProduct";
            txtSelectedProduct.Size = new Size(226, 25);
            txtSelectedProduct.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(1115, 258);
            label3.Name = "label3";
            label3.Size = new Size(120, 18);
            label3.TabIndex = 6;
            label3.Text = "Seçilen Ürün :";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(1250, 364);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(95, 26);
            btnAdd.TabIndex = 7;
            btnAdd.Text = "Ekle";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(1389, 364);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(95, 26);
            btnRemove.TabIndex = 7;
            btnRemove.Text = "Çıkar";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(981, 396);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 45;
            dataGridView2.RowTemplate.Height = 27;
            dataGridView2.Size = new Size(525, 466);
            dataGridView2.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Consolas", 14.2641506F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(713, 10);
            label5.Name = "label5";
            label5.Size = new Size(226, 24);
            label5.TabIndex = 10;
            label5.Text = "NİNJA SUPER MARKET";
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Location = new Point(1404, 10);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(80, 18);
            lblUser.TabIndex = 11;
            lblUser.Text = "Kullanıcı";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(1274, 306);
            label4.Name = "label4";
            label4.Size = new Size(56, 18);
            label4.TabIndex = 14;
            label4.Text = "Adet :";
            // 
            // cmbUnit
            // 
            cmbUnit.FormattingEnabled = true;
            cmbUnit.Location = new Point(1356, 303);
            cmbUnit.Name = "cmbUnit";
            cmbUnit.Size = new Size(128, 26);
            cmbUnit.TabIndex = 15;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(1271, 885);
            label6.Name = "label6";
            label6.Size = new Size(112, 18);
            label6.TabIndex = 16;
            label6.Text = "Toplam Tutar:";
            // 
            // btnPay
            // 
            btnPay.Location = new Point(1373, 916);
            btnPay.Name = "btnPay";
            btnPay.Size = new Size(83, 38);
            btnPay.TabIndex = 17;
            btnPay.Text = "Öde";
            btnPay.UseVisualStyleBackColor = true;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(1389, 885);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(56, 18);
            lblTotal.TabIndex = 16;
            lblTotal.Text = "label6";
            // 
            // lblBalance
            // 
            lblBalance.AutoSize = true;
            lblBalance.Location = new Point(1428, 38);
            lblBalance.Name = "lblBalance";
            lblBalance.Size = new Size(56, 18);
            lblBalance.TabIndex = 18;
            lblBalance.Text = "Bakiye";
            // 
            // ShoppingForm
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1502, 953);
            Controls.Add(lblBalance);
            Controls.Add(btnPay);
            Controls.Add(lblTotal);
            Controls.Add(label6);
            Controls.Add(cmbUnit);
            Controls.Add(label4);
            Controls.Add(lblUser);
            Controls.Add(label5);
            Controls.Add(dataGridView2);
            Controls.Add(btnRemove);
            Controls.Add(btnAdd);
            Controls.Add(label3);
            Controls.Add(txtSelectedProduct);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cmbCategories);
            Controls.Add(dataGridView1);
            Font = new Font("Consolas", 10.18868F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "ShoppingForm";
            Text = "ShoppingForm";
            Load += ShoppingForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private ComboBox cmbCategories;
        private Label label1;
        private Label label2;
        private TextBox txtSelectedProduct;
        private Label label3;
        private Button btnAdd;
        private Button btnRemove;
        private DataGridView dataGridView2;
        private Label label5;
        private Label lblUser;
        private Label label4;
        private ComboBox cmbUnit;
        private Label label6;
        private Button btnPay;
        private Label lblTotal;
        private Label lblBalance;
    }
}