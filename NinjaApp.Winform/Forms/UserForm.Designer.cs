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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(369, 199);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 45;
            dataGridView1.RowTemplate.Height = 27;
            dataGridView1.Size = new Size(433, 627);
            dataGridView1.TabIndex = 0;
            // 
            // userLogin
            // 
            userLogin.AutoSize = true;
            userLogin.Location = new Point(12, 32);
            userLogin.Name = "userLogin";
            userLogin.Size = new Size(96, 18);
            userLogin.TabIndex = 1;
            userLogin.Text = "Kullanıcı :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(569, 35);
            label1.Name = "label1";
            label1.Size = new Size(72, 18);
            label1.TabIndex = 2;
            label1.Text = "Bakiye :";
            // 
            // txtBalance
            // 
            txtBalance.Location = new Point(647, 32);
            txtBalance.Name = "txtBalance";
            txtBalance.Size = new Size(125, 25);
            txtBalance.TabIndex = 3;
            // 
            // txtUserLogin
            // 
            txtUserLogin.Location = new Point(114, 32);
            txtUserLogin.Name = "txtUserLogin";
            txtUserLogin.Size = new Size(125, 25);
            txtUserLogin.TabIndex = 3;
            // 
            // btnAddMoney
            // 
            btnAddMoney.Location = new Point(59, 252);
            btnAddMoney.Name = "btnAddMoney";
            btnAddMoney.Size = new Size(161, 46);
            btnAddMoney.TabIndex = 4;
            btnAddMoney.Text = "Bakiye Yükle";
            btnAddMoney.UseVisualStyleBackColor = true;
            btnAddMoney.Click += btnAddMoney_Click;
            // 
            // btnChangePassword
            // 
            btnChangePassword.Location = new Point(59, 368);
            btnChangePassword.Name = "btnChangePassword";
            btnChangePassword.Size = new Size(161, 46);
            btnChangePassword.TabIndex = 6;
            btnChangePassword.Text = "Şifre Değiştir";
            btnChangePassword.UseVisualStyleBackColor = true;
            btnChangePassword.Click += btnChangePassword_Click;
            // 
            // UserForm
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(802, 824);
            Controls.Add(btnChangePassword);
            Controls.Add(btnAddMoney);
            Controls.Add(txtUserLogin);
            Controls.Add(txtBalance);
            Controls.Add(label1);
            Controls.Add(userLogin);
            Controls.Add(dataGridView1);
            Font = new Font("Consolas", 10.18868F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "UserForm";
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
        private Button button1;
        private Button btnChangePassword;
    }
}