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
            label1 = new Label();
            label2 = new Label();
            txtUserName = new TextBox();
            txtPass = new TextBox();
            btnLogin = new Button();
            btnClose = new Button();
            btnRegister = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(61, 78);
            label1.Name = "label1";
            label1.Size = new Size(95, 20);
            label1.TabIndex = 0;
            label1.Text = "Kullanıcı Adı:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(114, 108);
            label2.Name = "label2";
            label2.Size = new Size(42, 20);
            label2.TabIndex = 0;
            label2.Text = "Şifre:";
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(165, 78);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(218, 27);
            txtUserName.TabIndex = 1;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(165, 108);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(218, 27);
            txtPass.TabIndex = 2;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(165, 141);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(113, 29);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "Giriş Yap";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(284, 141);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(99, 29);
            btnClose.TabIndex = 4;
            btnClose.Text = "Çıkış";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(165, 176);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(218, 29);
            btnRegister.TabIndex = 5;
            btnRegister.Text = "Kayıt Ol";
            btnRegister.UseVisualStyleBackColor = true;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(509, 293);
            Controls.Add(btnRegister);
            Controls.Add(btnClose);
            Controls.Add(btnLogin);
            Controls.Add(txtPass);
            Controls.Add(txtUserName);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "LoginForm";
            Text = "LoginForm";
            FormClosed += LoginForm_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtUserName;
        private TextBox txtPass;
        private Button btnLogin;
        private Button btnClose;
        private Button btnRegister;
    }
}