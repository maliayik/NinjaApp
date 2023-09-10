namespace NinjaApp.Winform.Forms
{
    partial class UserForm
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
            userLogin = new Label();
            label1 = new Label();
            txtBalance = new TextBox();
            txtUserLogin = new TextBox();
            btnAddMoney = new Button();
            btnChangePassword = new Button();
            btnShopping = new Button();
            panel1 = new Panel();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.GradientInactiveCaption;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(11, 141);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 45;
            dataGridView1.RowTemplate.Height = 27;
            dataGridView1.Size = new Size(644, 257);
            dataGridView1.TabIndex = 0;
            // 
            // userLogin
            // 
            userLogin.AutoSize = true;
            userLogin.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            userLogin.ForeColor = Color.Black;
            userLogin.Location = new Point(11, 17);
            userLogin.Name = "userLogin";
            userLogin.Size = new Size(109, 23);
            userLogin.TabIndex = 1;
            userLogin.Text = "Kullanıcı";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(11, 77);
            label1.Name = "label1";
            label1.Size = new Size(76, 23);
            label1.TabIndex = 2;
            label1.Text = "Bakiye";
            // 
            // txtBalance
            // 
            txtBalance.Location = new Point(11, 103);
            txtBalance.Name = "txtBalance";
            txtBalance.Size = new Size(228, 27);
            txtBalance.TabIndex = 2;
            // 
            // txtUserLogin
            // 
            txtUserLogin.Location = new Point(11, 43);
            txtUserLogin.Name = "txtUserLogin";
            txtUserLogin.Size = new Size(228, 27);
            txtUserLogin.TabIndex = 1;
            // 
            // btnAddMoney
            // 
            btnAddMoney.BackColor = Color.FromArgb(0, 73, 175);
            btnAddMoney.FlatAppearance.BorderSize = 0;
            btnAddMoney.FlatStyle = FlatStyle.Flat;
            btnAddMoney.Font = new Font("Consolas", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddMoney.ForeColor = Color.White;
            btnAddMoney.Location = new Point(245, 43);
            btnAddMoney.Name = "btnAddMoney";
            btnAddMoney.Size = new Size(195, 87);
            btnAddMoney.TabIndex = 3;
            btnAddMoney.Text = "Bakiye Yükle";
            btnAddMoney.UseVisualStyleBackColor = false;
            btnAddMoney.Click += btnAddMoney_Click;
            // 
            // btnChangePassword
            // 
            btnChangePassword.BackColor = Color.Orange;
            btnChangePassword.FlatAppearance.BorderSize = 0;
            btnChangePassword.FlatStyle = FlatStyle.Flat;
            btnChangePassword.Font = new Font("Consolas", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnChangePassword.ForeColor = Color.White;
            btnChangePassword.Location = new Point(446, 43);
            btnChangePassword.Name = "btnChangePassword";
            btnChangePassword.Size = new Size(209, 87);
            btnChangePassword.TabIndex = 4;
            btnChangePassword.Text = "Şifre Değiştir";
            btnChangePassword.UseVisualStyleBackColor = false;
            btnChangePassword.Click += btnChangePassword_Click;
            // 
            // btnShopping
            // 
            btnShopping.BackColor = Color.Indigo;
            btnShopping.FlatAppearance.BorderSize = 0;
            btnShopping.FlatStyle = FlatStyle.Flat;
            btnShopping.Font = new Font("Consolas", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnShopping.ForeColor = Color.White;
            btnShopping.Location = new Point(11, 404);
            btnShopping.Name = "btnShopping";
            btnShopping.Size = new Size(644, 49);
            btnShopping.TabIndex = 5;
            btnShopping.Text = "Alışverişe Geri Dön";
            btnShopping.UseVisualStyleBackColor = false;
            btnShopping.Click += btnShopping_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(btnAddMoney);
            panel1.Controls.Add(btnShopping);
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(btnChangePassword);
            panel1.Controls.Add(userLogin);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtUserLogin);
            panel1.Controls.Add(txtBalance);
            panel1.Location = new Point(0, 164);
            panel1.Name = "panel1";
            panel1.Size = new Size(659, 461);
            panel1.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Consolas", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(194, 113);
            label2.Name = "label2";
            label2.Size = new Size(300, 33);
            label2.TabIndex = 7;
            label2.Text = "KULLANICI İŞLEMLERİ";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.operation;
            pictureBox1.Location = new Point(150, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(392, 98);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // UserForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(660, 625);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(panel1);
            Font = new Font("Consolas", 10.18868F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UserForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UserForm";
            Load += UserForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label userLogin;
        private Label label1;
        private TextBox txtBalance;
        private TextBox txtUserLogin;
        private Button btnAddMoney;
        private Button btnShopping;
        private Button btnChangePassword;
        private Panel panel1;
        private Label label2;
        private PictureBox pictureBox1;
    }
}