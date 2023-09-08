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
            listView1 = new ListView();
            ÜrünAdı = new ColumnHeader();
            Birim = new ColumnHeader();
            Fiyat = new ColumnHeader();
            label2 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 208);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 45;
            dataGridView1.RowTemplate.Height = 27;
            dataGridView1.Size = new Size(634, 693);
            dataGridView1.TabIndex = 0;
            // 
            // cmbCategories
            // 
            cmbCategories.FormattingEnabled = true;
            cmbCategories.Location = new Point(478, 147);
            cmbCategories.Name = "cmbCategories";
            cmbCategories.Size = new Size(168, 25);
            cmbCategories.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(323, 150);
            label1.Name = "label1";
            label1.Size = new Size(149, 17);
            label1.TabIndex = 2;
            label1.Text = "Ürün Kategorisi Seçiniz :";
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { ÜrünAdı, Birim, Fiyat });
            listView1.Location = new Point(1251, 369);
            listView1.Name = "listView1";
            listView1.Size = new Size(470, 532);
            listView1.TabIndex = 3;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1453, 369);
            label2.Name = "label2";
            label2.Size = new Size(70, 17);
            label2.TabIndex = 4;
            label2.Text = "SELF-KASA";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(1523, 271);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(198, 25);
            textBox1.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(1412, 274);
            label3.Name = "label3";
            label3.Size = new Size(87, 17);
            label3.TabIndex = 6;
            label3.Text = "Seçilen Ürün :";
            // 
            // button1
            // 
            button1.Location = new Point(1523, 317);
            button1.Name = "button1";
            button1.Size = new Size(83, 25);
            button1.TabIndex = 7;
            button1.Text = "Ekle";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(1638, 317);
            button2.Name = "button2";
            button2.Size = new Size(83, 25);
            button2.TabIndex = 7;
            button2.Text = "Çıkar";
            button2.UseVisualStyleBackColor = true;
            // 
            // ShoppingForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1808, 1011);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(listView1);
            Controls.Add(label1);
            Controls.Add(cmbCategories);
            Controls.Add(dataGridView1);
            Name = "ShoppingForm";
            Text = "ShoppingForm";
            Load += ShoppingForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private ComboBox cmbCategories;
        private Label label1;
        private ListView listView1;
        private ColumnHeader ÜrünAdı;
        private ColumnHeader Birim;
        private ColumnHeader Fiyat;
        private Label label2;
        private TextBox textBox1;
        private Label label3;
        private Button button1;
        private Button button2;
    }
}