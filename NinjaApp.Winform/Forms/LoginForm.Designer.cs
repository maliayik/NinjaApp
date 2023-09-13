namespace NinjaApp.Winform.Forms
{
    partial class LoginForm
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
            txtUserName = new TextBox();
            txtPass = new TextBox();
            btnLogin = new Button();
            btnRegister = new Button();
            lblExit = new Label();
            label5 = new Label();
            label6 = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // txtUserName
            // 
            txtUserName.BackColor = Color.Gainsboro;
            txtUserName.BorderStyle = BorderStyle.None;
            txtUserName.Font = new Font("Consolas", 18.3396225F, FontStyle.Regular, GraphicsUnit.Point);
            txtUserName.Location = new Point(24, 189);
            txtUserName.Margin = new Padding(5, 4, 5, 4);
            txtUserName.Multiline = true;
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(290, 46);
            txtUserName.TabIndex = 1;
            txtUserName.WordWrap = false;
            // 
            // txtPass
            // 
            txtPass.BackColor = Color.Gainsboro;
            txtPass.BorderStyle = BorderStyle.None;
            txtPass.Font = new Font("Consolas", 18.3396225F, FontStyle.Regular, GraphicsUnit.Point);
            txtPass.Location = new Point(24, 287);
            txtPass.Margin = new Padding(5, 4, 5, 4);
            txtPass.Multiline = true;
            txtPass.Name = "txtPass";
            txtPass.PasswordChar = '*';
            txtPass.Size = new Size(290, 46);
            txtPass.TabIndex = 2;
            txtPass.WordWrap = false;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(81, 80, 75);
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Consolas", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(24, 362);
            btnLogin.Margin = new Padding(5, 4, 5, 4);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(290, 44);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "GİRİŞ YAP";
            btnLogin.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.White;
            btnRegister.Cursor = Cursors.Hand;
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.Font = new Font("Consolas", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnRegister.ForeColor = Color.FromArgb(81, 80, 75);
            btnRegister.Location = new Point(24, 428);
            btnRegister.Margin = new Padding(5, 4, 5, 4);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(290, 39);
            btnRegister.TabIndex = 4;
            btnRegister.Text = "KAYIT OL";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // lblExit
            // 
            lblExit.AutoSize = true;
            lblExit.BackColor = Color.Red;
            lblExit.Cursor = Cursors.Hand;
            lblExit.Font = new Font("Georgia", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblExit.ForeColor = Color.White;
            lblExit.Location = new Point(298, -1);
            lblExit.Name = "lblExit";
            lblExit.Size = new Size(33, 31);
            lblExit.TabIndex = 8;
            lblExit.Text = "X";
            lblExit.Click += lblExit_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Consolas", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(24, 482);
            label5.Name = "label5";
            label5.Size = new Size(135, 19);
            label5.TabIndex = 9;
            label5.Text = "Ninja App v1.0";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Consolas", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(195, 482);
            label6.Name = "label6";
            label6.Size = new Size(119, 14);
            label6.TabIndex = 10;
            label6.Text = "Copyright © 2023";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(24, 158);
            label1.Name = "label1";
            label1.Size = new Size(166, 24);
            label1.TabIndex = 11;
            label1.Text = "Kullanıcı Adı";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Consolas", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlDarkDark;
            label2.Location = new Point(24, 256);
            label2.Name = "label2";
            label2.Size = new Size(70, 24);
            label2.TabIndex = 11;
            label2.Text = "Şifre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Consolas", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(81, 80, 75);
            label3.Location = new Point(24, 80);
            label3.Name = "label3";
            label3.Size = new Size(209, 45);
            label3.TabIndex = 12;
            label3.Text = "GİRİŞ YAP";
            // 
            // LoginForm
            // 
            AcceptButton = btnLogin;
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(336, 515);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnLogin);
            Controls.Add(label6);
            Controls.Add(btnRegister);
            Controls.Add(label5);
            Controls.Add(txtUserName);
            Controls.Add(txtPass);
            Controls.Add(lblExit);
            Font = new Font("Consolas", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(5, 4, 5, 4);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginForm";
            FormClosed += LoginForm_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtUserName;
        private TextBox txtPass;
        private Button btnLogin;
        private Button btnRegister;
        private Label lblExit;
        private Label label5;
        private Label label6;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}