namespace NinjaApp.Winform.Forms
{
    partial class AdminForm
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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            dataGridView1 = new DataGridView();
            dataGridView2 = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            txtSelectedProduct = new TextBox();
            txtSelectedPrice = new TextBox();
            label3 = new Label();
            label4 = new Label();
            btnUpdate = new Button();
            comboBox1 = new ComboBox();
            label5 = new Label();
            btnBack = new Button();
            panel1 = new Panel();
            button5 = new Button();
            btnSuplier = new Button();
            btnAdmin = new Button();
            panel2 = new Panel();
            lblAdmin = new Label();
            pictureBox1 = new PictureBox();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.BackgroundColor = SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = SystemColors.Control;
            dataGridViewCellStyle5.Font = new Font("Consolas", 14.2641506F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.MenuHighlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = SystemColors.Window;
            dataGridViewCellStyle6.Font = new Font("Consolas", 10.18868F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle6;
            dataGridView1.GridColor = SystemColors.GradientInactiveCaption;
            dataGridView1.Location = new Point(364, 52);
            dataGridView1.Margin = new Padding(4, 5, 4, 5);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 45;
            dataGridView1.RowTemplate.Height = 27;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(550, 316);
            dataGridView1.TabIndex = 0;
            // 
            // dataGridView2
            // 
            dataGridView2.BackgroundColor = SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = SystemColors.Control;
            dataGridViewCellStyle7.Font = new Font("Consolas", 14.2641506F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = Color.White;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = SystemColors.Window;
            dataGridViewCellStyle8.Font = new Font("Consolas", 10.18868F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = Color.Red;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            dataGridView2.DefaultCellStyle = dataGridViewCellStyle8;
            dataGridView2.Location = new Point(364, 423);
            dataGridView2.Margin = new Padding(4, 5, 4, 5);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 45;
            dataGridView2.RowTemplate.Height = 27;
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.Size = new Size(550, 316);
            dataGridView2.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(494, 20);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(250, 24);
            label1.TabIndex = 1;
            label1.Text = "Stok Bilgisi Tablosu";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(448, 391);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(358, 24);
            label2.TabIndex = 1;
            label2.Text = "Ürün Fiyat Güncelleme Tablosu";
            // 
            // chart1
            // 
            chart1.BackColor = SystemColors.ControlLightLight;
            chart1.BorderlineColor = Color.Transparent;
            chart1.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea2.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            chart1.Legends.Add(legend2);
            chart1.Location = new Point(927, 55);
            chart1.Margin = new Padding(4, 5, 4, 5);
            chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            chart1.Series.Add(series2);
            chart1.Size = new Size(421, 316);
            chart1.TabIndex = 2;
            chart1.Text = "chart1";
            // 
            // txtSelectedProduct
            // 
            txtSelectedProduct.Location = new Point(922, 623);
            txtSelectedProduct.Margin = new Padding(4, 5, 4, 5);
            txtSelectedProduct.Name = "txtSelectedProduct";
            txtSelectedProduct.Size = new Size(418, 31);
            txtSelectedProduct.TabIndex = 3;
            // 
            // txtSelectedPrice
            // 
            txtSelectedPrice.Location = new Point(927, 555);
            txtSelectedPrice.Margin = new Padding(4, 5, 4, 5);
            txtSelectedPrice.Name = "txtSelectedPrice";
            txtSelectedPrice.Size = new Size(421, 31);
            txtSelectedPrice.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(1040, 591);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(154, 24);
            label3.TabIndex = 4;
            label3.Text = "Seçilen Ürün";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(1052, 526);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(142, 24);
            label4.TabIndex = 4;
            label4.Text = "Ürün Fiyatı";
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = SystemColors.ActiveCaption;
            btnUpdate.Location = new Point(922, 666);
            btnUpdate.Margin = new Padding(4, 5, 4, 5);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(273, 73);
            btnUpdate.TabIndex = 5;
            btnUpdate.Text = "Fiyat Güncelle";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // comboBox1
            // 
            comboBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(927, 474);
            comboBox1.Margin = new Padding(4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(418, 31);
            comboBox1.TabIndex = 7;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(998, 446);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(298, 24);
            label5.TabIndex = 8;
            label5.Text = "Satılan Ürünleri Listele";
            // 
            // btnBack
            // 
            btnBack.BackColor = SystemColors.ActiveCaption;
            btnBack.Location = new Point(1202, 666);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(138, 73);
            btnBack.TabIndex = 9;
            btnBack.Text = "Çıkış";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(button5);
            panel1.Controls.Add(btnSuplier);
            panel1.Controls.Add(btnAdmin);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(350, 751);
            panel1.TabIndex = 10;
            // 
            // button5
            // 
            button5.Dock = DockStyle.Bottom;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Location = new Point(0, 688);
            button5.Name = "button5";
            button5.Size = new Size(350, 63);
            button5.TabIndex = 1;
            button5.Text = "ninjaApp v1.0";
            button5.TextImageRelation = TextImageRelation.ImageBeforeText;
            button5.UseVisualStyleBackColor = true;
            // 
            // btnSuplier
            // 
            btnSuplier.Dock = DockStyle.Top;
            btnSuplier.FlatAppearance.BorderSize = 0;
            btnSuplier.FlatStyle = FlatStyle.Flat;
            btnSuplier.Image = Properties.Resources.inventory;
            btnSuplier.Location = new Point(0, 232);
            btnSuplier.Name = "btnSuplier";
            btnSuplier.Size = new Size(350, 47);
            btnSuplier.TabIndex = 1;
            btnSuplier.Text = "Tedarikçi Sayfası";
            btnSuplier.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnSuplier.UseVisualStyleBackColor = true;
            btnSuplier.Click += btnSuplier_Click;
            // 
            // btnAdmin
            // 
            btnAdmin.Dock = DockStyle.Top;
            btnAdmin.FlatAppearance.BorderSize = 0;
            btnAdmin.FlatStyle = FlatStyle.Flat;
            btnAdmin.Image = Properties.Resources.user_gear;
            btnAdmin.Location = new Point(0, 185);
            btnAdmin.Name = "btnAdmin";
            btnAdmin.Size = new Size(350, 47);
            btnAdmin.TabIndex = 1;
            btnAdmin.Text = "Yönetici Paneli";
            btnAdmin.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnAdmin.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(lblAdmin);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(350, 185);
            panel2.TabIndex = 0;
            // 
            // lblAdmin
            // 
            lblAdmin.AutoSize = true;
            lblAdmin.Font = new Font("Consolas", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblAdmin.Location = new Point(27, 158);
            lblAdmin.Name = "lblAdmin";
            lblAdmin.Size = new Size(310, 24);
            lblAdmin.TabIndex = 1;
            lblAdmin.Text = "NinjaShop Yönetici Paneli";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.user_interface;
            pictureBox1.Location = new Point(90, 23);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(157, 120);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(1010, 23);
            label6.Name = "label6";
            label6.Size = new Size(286, 24);
            label6.TabIndex = 11;
            label6.Text = "Satılan Ürünler Grafiği";
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(1402, 751);
            Controls.Add(label6);
            Controls.Add(panel1);
            Controls.Add(btnBack);
            Controls.Add(label5);
            Controls.Add(comboBox1);
            Controls.Add(btnUpdate);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtSelectedPrice);
            Controls.Add(txtSelectedProduct);
            Controls.Add(chart1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView2);
            Controls.Add(dataGridView1);
            Font = new Font("Consolas", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "AdminForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminForm";
            Load += AdminForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private Label label1;
        private Label label2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private TextBox txtSelectedProduct;
        private TextBox txtSelectedPrice;
        private Label label3;
        private Label label4;
        private Button btnUpdate;
        private ComboBox comboBox1;
        private Label label5;
        private Button btnBack;
        private Panel panel1;
        private Panel panel2;
        private Label lblAdmin;
        private PictureBox pictureBox1;
        private Button btnAdmin;
        private Button button5;
        private Button btnSuplier;
        private Label label6;
    }
}