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
            label4 = new Label();
            cmbUnit = new ComboBox();
            label6 = new Label();
            btnPay = new Button();
            lblTotal = new Label();
            lblBalance = new Label();
            linkLabelUser = new LinkLabel();
            panel1 = new Panel();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.BackgroundColor = Color.FromArgb(255, 192, 128);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(2, 103);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 45;
            dataGridView1.RowTemplate.Height = 27;
            dataGridView1.Size = new Size(518, 557);
            dataGridView1.TabIndex = 0;
            // 
            // cmbCategories
            // 
            cmbCategories.FormattingEnabled = true;
            cmbCategories.Location = new Point(10, 60);
            cmbCategories.Name = "cmbCategories";
            cmbCategories.Size = new Size(191, 26);
            cmbCategories.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(7, 30);
            label1.Name = "label1";
            label1.Size = new Size(178, 24);
            label1.TabIndex = 2;
            label1.Text = "Kategori Seçin";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Consolas", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(779, 268);
            label2.Name = "label2";
            label2.Size = new Size(155, 28);
            label2.TabIndex = 4;
            label2.Text = "ÜRÜN SEPETİ";
            // 
            // txtSelectedProduct
            // 
            txtSelectedProduct.Location = new Point(160, 16);
            txtSelectedProduct.Name = "txtSelectedProduct";
            txtSelectedProduct.Size = new Size(226, 25);
            txtSelectedProduct.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 16);
            label3.Name = "label3";
            label3.Size = new Size(120, 18);
            label3.TabIndex = 6;
            label3.Text = "Seçilen Ürün :";
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(255, 224, 192);
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Consolas", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdd.ForeColor = Color.Black;
            btnAdd.Image = Properties.Resources.add_to_cart__2_;
            btnAdd.Location = new Point(392, 16);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(143, 61);
            btnAdd.TabIndex = 7;
            btnAdd.Text = "Ekle";
            btnAdd.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnRemove
            // 
            btnRemove.BackColor = Color.FromArgb(255, 224, 192);
            btnRemove.Cursor = Cursors.Hand;
            btnRemove.FlatAppearance.BorderSize = 0;
            btnRemove.FlatStyle = FlatStyle.Flat;
            btnRemove.Font = new Font("Consolas", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnRemove.ForeColor = Color.Black;
            btnRemove.Image = Properties.Resources.rubbish_bin;
            btnRemove.Location = new Point(10, 271);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(135, 66);
            btnRemove.TabIndex = 7;
            btnRemove.Text = "Çıkar";
            btnRemove.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRemove.UseVisualStyleBackColor = false;
            btnRemove.Click += btnRemove_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.BackgroundColor = Color.FromArgb(255, 224, 192);
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(10, 93);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 45;
            dataGridView2.RowTemplate.Height = 27;
            dataGridView2.Size = new Size(525, 172);
            dataGridView2.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Consolas", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(646, 14);
            label5.Name = "label5";
            label5.Size = new Size(378, 42);
            label5.TabIndex = 10;
            label5.Text = "NİNJA SANAL MARKET";
    
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(82, 49);
            label4.Name = "label4";
            label4.Size = new Size(56, 18);
            label4.TabIndex = 14;
            label4.Text = "Adet :";
            // 
            // cmbUnit
            // 
            cmbUnit.FormattingEnabled = true;
            cmbUnit.Location = new Point(160, 49);
            cmbUnit.Name = "cmbUnit";
            cmbUnit.Size = new Size(226, 26);
            cmbUnit.TabIndex = 15;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(286, 266);
            label6.Name = "label6";
            label6.Size = new Size(140, 22);
            label6.TabIndex = 16;
            label6.Text = "Toplam Tutar:";
            // 
            // btnPay
            // 
            btnPay.BackColor = Color.FromArgb(0, 73, 175);
            btnPay.FlatAppearance.BorderSize = 0;
            btnPay.FlatStyle = FlatStyle.Flat;
            btnPay.Font = new Font("Consolas", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnPay.ForeColor = Color.White;
            btnPay.Location = new Point(392, 296);
            btnPay.Name = "btnPay";
            btnPay.Size = new Size(143, 41);
            btnPay.TabIndex = 17;
            btnPay.Text = "Öde";
            btnPay.UseVisualStyleBackColor = false;
            btnPay.Click += btnPay_Click;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Consolas", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblTotal.Location = new Point(445, 266);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(82, 24);
            lblTotal.TabIndex = 16;
            lblTotal.Text = "label6";
            // 
            // lblBalance
            // 
            lblBalance.AutoSize = true;
            lblBalance.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblBalance.Location = new Point(216, 60);
            lblBalance.Name = "lblBalance";
            lblBalance.Size = new Size(70, 22);
            lblBalance.TabIndex = 18;
            lblBalance.Text = "Bakiye";
            // 
            // linkLabelUser
            // 
            linkLabelUser.AutoSize = true;
            linkLabelUser.Cursor = Cursors.Hand;
            linkLabelUser.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            linkLabelUser.LinkColor = Color.Black;
            linkLabelUser.Location = new Point(250, 30);
            linkLabelUser.Name = "linkLabelUser";
            linkLabelUser.Size = new Size(100, 22);
            linkLabelUser.TabIndex = 19;
            linkLabelUser.TabStop = true;
            linkLabelUser.Text = "Kullanıcı";
            linkLabelUser.LinkClicked += linkLabelUser_LinkClicked;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 224, 192);
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(linkLabelUser);
            panel1.Controls.Add(lblBalance);
            panel1.Controls.Add(cmbCategories);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(520, 657);
            panel1.TabIndex = 20;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 192, 128);
            panel2.Controls.Add(dataGridView2);
            panel2.Controls.Add(btnPay);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(txtSelectedProduct);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(cmbUnit);
            panel2.Controls.Add(lblTotal);
            panel2.Controls.Add(btnAdd);
            panel2.Controls.Add(btnRemove);
            panel2.Controls.Add(label6);
            panel2.Location = new Point(589, 313);
            panel2.Name = "panel2";
            panel2.Size = new Size(543, 347);
            panel2.TabIndex = 21;
            // 
            // ShoppingForm
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1133, 657);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label5);
            Controls.Add(label2);
            DoubleBuffered = true;
            Font = new Font("Consolas", 10.18868F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "ShoppingForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ShoppingForm";
            Load += ShoppingForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
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
        private Label label4;
        private ComboBox cmbUnit;
        private Label label6;
        private Button btnPay;
        private Label lblTotal;
        private Label lblBalance;
        private LinkLabel linkLabelUser;
        private Panel panel1;
        private Panel panel2;
    }
}