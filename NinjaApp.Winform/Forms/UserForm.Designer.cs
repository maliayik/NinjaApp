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
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.Gainsboro;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(22, 291);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 45;
            dataGridView1.RowTemplate.Height = 27;
            dataGridView1.Size = new Size(485, 307);
            dataGridView1.TabIndex = 0;
            // 
            // userLogin
            // 
            userLogin.AutoSize = true;
            userLogin.Font = new Font("Consolas", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            userLogin.ForeColor = SystemColors.ControlDarkDark;
            userLogin.Location = new Point(22, 139);
            userLogin.Name = "userLogin";
            userLogin.Size = new Size(129, 27);
            userLogin.TabIndex = 1;
            userLogin.Text = "Kullanıcı";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(22, 207);
            label1.Name = "label1";
            label1.Size = new Size(90, 27);
            label1.TabIndex = 2;
            label1.Text = "Bakiye";
            // 
            // txtBalance
            // 
            txtBalance.BackColor = Color.Gainsboro;
            txtBalance.BorderStyle = BorderStyle.None;
            txtBalance.Font = new Font("Consolas", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtBalance.Location = new Point(22, 237);
            txtBalance.Name = "txtBalance";
            txtBalance.Size = new Size(228, 36);
            txtBalance.TabIndex = 2;
            // 
            // txtUserLogin
            // 
            txtUserLogin.BackColor = Color.Gainsboro;
            txtUserLogin.BorderStyle = BorderStyle.None;
            txtUserLogin.Font = new Font("Consolas", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtUserLogin.Location = new Point(22, 165);
            txtUserLogin.Name = "txtUserLogin";
            txtUserLogin.Size = new Size(228, 36);
            txtUserLogin.TabIndex = 1;
            // 
            // btnAddMoney
            // 
            btnAddMoney.BackColor = Color.FromArgb(81, 80, 75);
            btnAddMoney.FlatAppearance.BorderSize = 0;
            btnAddMoney.FlatStyle = FlatStyle.Flat;
            btnAddMoney.Font = new Font("Consolas", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddMoney.ForeColor = Color.White;
            btnAddMoney.Location = new Point(269, 151);
            btnAddMoney.Name = "btnAddMoney";
            btnAddMoney.Size = new Size(238, 50);
            btnAddMoney.TabIndex = 3;
            btnAddMoney.Text = "Bakiye Yükle";
            btnAddMoney.UseVisualStyleBackColor = false;
            btnAddMoney.Click += btnAddMoney_Click;
            // 
            // btnChangePassword
            // 
            btnChangePassword.FlatStyle = FlatStyle.Flat;
            btnChangePassword.Font = new Font("Consolas", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnChangePassword.ForeColor = Color.FromArgb(81, 80, 75);
            btnChangePassword.Location = new Point(269, 207);
            btnChangePassword.Name = "btnChangePassword";
            btnChangePassword.Size = new Size(238, 66);
            btnChangePassword.TabIndex = 4;
            btnChangePassword.Text = "Şifre Değiştir";
            btnChangePassword.UseVisualStyleBackColor = false;
            btnChangePassword.Click += btnChangePassword_Click;
            // 
            // btnShopping
            // 
            btnShopping.BackColor = Color.White;
            btnShopping.FlatStyle = FlatStyle.Popup;
            btnShopping.Font = new Font("Consolas", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnShopping.ForeColor = Color.White;
            btnShopping.Image = Properties.Resources.arrow_left;
            btnShopping.Location = new Point(22, 8);
            btnShopping.Name = "btnShopping";
            btnShopping.Size = new Size(128, 49);
            btnShopping.TabIndex = 5;
            btnShopping.UseVisualStyleBackColor = false;
            btnShopping.Click += btnShopping_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Consolas", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(81, 80, 75);
            label2.Location = new Point(12, 60);
            label2.Name = "label2";
            label2.Size = new Size(478, 51);
            label2.TabIndex = 7;
            label2.Text = "KULLANICI İŞLEMLERİ";
            // 
            // UserForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(527, 626);
            Controls.Add(btnAddMoney);
            Controls.Add(btnShopping);
            Controls.Add(dataGridView1);
            Controls.Add(label2);
            Controls.Add(btnChangePassword);
            Controls.Add(userLogin);
            Controls.Add(txtBalance);
            Controls.Add(label1);
            Controls.Add(txtUserLogin);
            Font = new Font("Consolas", 10.18868F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UserForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UserForm";
            Load += UserForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
        private Label label2;
    }
}