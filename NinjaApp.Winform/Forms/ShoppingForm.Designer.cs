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
            label4 = new Label();
            cmbUnit = new ComboBox();
            label6 = new Label();
            btnPay = new Button();
            lblTotal = new Label();
            lblBalance = new Label();
            linkLabelUser = new LinkLabel();
            panel1 = new Panel();
            label7 = new Label();
            label8 = new Label();
            panel2 = new Panel();
            btnExit = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(3, 124);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 45;
            dataGridView1.RowTemplate.Height = 27;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(531, 405);
            dataGridView1.TabIndex = 0;
            // 
            // cmbCategories
            // 
            cmbCategories.FormattingEnabled = true;
            cmbCategories.Location = new Point(26, 41);
            cmbCategories.Name = "cmbCategories";
            cmbCategories.Size = new Size(191, 26);
            cmbCategories.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(23, 11);
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
            label2.Location = new Point(840, 337);
            label2.Name = "label2";
            label2.Size = new Size(155, 28);
            label2.TabIndex = 4;
            label2.Text = "ÜRÜN SEPETİ";
            // 
            // txtSelectedProduct
            // 
            txtSelectedProduct.Location = new Point(146, 24);
            txtSelectedProduct.Name = "txtSelectedProduct";
            txtSelectedProduct.Size = new Size(170, 25);
            txtSelectedProduct.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 27);
            label3.Name = "label3";
            label3.Size = new Size(120, 18);
            label3.TabIndex = 6;
            label3.Text = "Seçilen Ürün :";
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.PaleGreen;
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Consolas", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdd.ForeColor = Color.Black;
            btnAdd.Image = Properties.Resources.add_to_cart__2_;
            btnAdd.Location = new Point(146, 83);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(170, 37);
            btnAdd.TabIndex = 7;
            btnAdd.Text = "Ekle";
            btnAdd.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnRemove
            // 
            btnRemove.BackColor = Color.FromArgb(255, 128, 0);
            btnRemove.Cursor = Cursors.Hand;
            btnRemove.FlatAppearance.BorderSize = 0;
            btnRemove.FlatStyle = FlatStyle.Flat;
            btnRemove.Font = new Font("Consolas", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnRemove.ForeColor = Color.Black;
            btnRemove.Image = Properties.Resources.rubbish_bin;
            btnRemove.Location = new Point(3, 474);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(135, 41);
            btnRemove.TabIndex = 7;
            btnRemove.Text = "Çıkar";
            btnRemove.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRemove.UseVisualStyleBackColor = false;
            btnRemove.Click += btnRemove_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.BackgroundColor = Color.White;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(3, 142);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 45;
            dataGridView2.RowTemplate.Height = 27;
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.Size = new Size(326, 276);
            dataGridView2.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(84, 55);
            label4.Name = "label4";
            label4.Size = new Size(56, 18);
            label4.TabIndex = 14;
            label4.Text = "Adet :";
            // 
            // cmbUnit
            // 
            cmbUnit.FormattingEnabled = true;
            cmbUnit.Location = new Point(146, 52);
            cmbUnit.Name = "cmbUnit";
            cmbUnit.Size = new Size(170, 26);
            cmbUnit.TabIndex = 15;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(73, 421);
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
            btnPay.Location = new Point(184, 474);
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
            lblTotal.Location = new Point(232, 421);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(82, 24);
            lblTotal.TabIndex = 16;
            lblTotal.Text = "label6";
            // 
            // lblBalance
            // 
            lblBalance.AutoSize = true;
            lblBalance.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblBalance.Location = new Point(232, 41);
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
            linkLabelUser.Location = new Point(232, 11);
            linkLabelUser.Name = "linkLabelUser";
            linkLabelUser.Size = new Size(100, 22);
            linkLabelUser.TabIndex = 19;
            linkLabelUser.TabStop = true;
            linkLabelUser.Text = "Kullanıcı";
            linkLabelUser.LinkClicked += linkLabelUser_LinkClicked;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(label7);
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(linkLabelUser);
            panel1.Controls.Add(lblBalance);
            panel1.Controls.Add(cmbCategories);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 304);
            panel1.Name = "panel1";
            panel1.Size = new Size(547, 693);
            panel1.TabIndex = 20;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(83, 103);
            label7.Name = "label7";
            label7.Size = new Size(368, 18);
            label7.TabIndex = 20;
            label7.Text = "***Ürün seçmek için lütfen çift tıklayınız...";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(425, 15);
            label8.Name = "label8";
            label8.Size = new Size(64, 18);
            label8.TabIndex = 22;
            label8.Text = "ÜRÜNLER";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 224, 192);
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
            panel2.Location = new Point(735, 368);
            panel2.Name = "panel2";
            panel2.Size = new Size(332, 629);
            panel2.TabIndex = 21;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.FromArgb(255, 255, 192);
            btnExit.Image = Properties.Resources.arrow_left;
            btnExit.ImageAlign = ContentAlignment.TopCenter;
            btnExit.Location = new Point(12, 210);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(97, 41);
            btnExit.TabIndex = 25;
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.NİNJA__4_;
            pictureBox1.Location = new Point(0, -2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1117, 188);
            pictureBox1.TabIndex = 26;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.NİNJA;
            pictureBox2.Location = new Point(820, -2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(247, 188);
            pictureBox2.TabIndex = 27;
            pictureBox2.TabStop = false;
            // 
            // ShoppingForm
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Tan;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1068, 993);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(btnExit);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label2);
            DoubleBuffered = true;
            Font = new Font("Consolas", 10.18868F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ShoppingForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ninja Sanal Market";
            Load += ShoppingForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
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
        private Label label4;
        private ComboBox cmbUnit;
        private Label label6;
        private Button btnPay;
        private Label lblTotal;
        private Label lblBalance;
        private LinkLabel linkLabelUser;
        private Panel panel1;
        private Panel panel2;
        private Label label7;
        private Label label8;
        private Button btnExit;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}