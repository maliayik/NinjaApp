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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            label1 = new Label();
            label2 = new Label();
            txtUserName = new TextBox();
            txtPass = new TextBox();
            btnLogin = new Button();
            btnRegister = new Button();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            label3 = new Label();
            btnChangedPassword = new Button();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 174);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(181, 27);
            label1.TabIndex = 0;
            label1.Text = "Kullanıcı Adı";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 261);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(77, 27);
            label2.TabIndex = 0;
            label2.Text = "Şifre";
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(30, 205);
            txtUserName.Margin = new Padding(5, 4, 5, 4);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(352, 34);
            txtUserName.TabIndex = 1;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(30, 292);
            txtPass.Margin = new Padding(5, 4, 5, 4);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(352, 34);
            txtPass.TabIndex = 2;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.ForestGreen;
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(28, 342);
            btnLogin.Margin = new Padding(5, 4, 5, 4);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(354, 39);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "Giriş Yap";
            btnLogin.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = SystemColors.GradientInactiveCaption;
            btnRegister.Cursor = Cursors.Hand;
            btnRegister.FlatAppearance.BorderSize = 0;
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.Location = new Point(30, 395);
            btnRegister.Margin = new Padding(5, 4, 5, 4);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(140, 39);
            btnRegister.TabIndex = 5;
            btnRegister.Text = "Kayıt Ol";
            btnRegister.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(159, 14);
            pictureBox1.Margin = new Padding(5, 4, 5, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(98, 85);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.GradientInactiveCaption;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(btnRegister);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtUserName);
            panel1.Controls.Add(btnChangedPassword);
            panel1.Controls.Add(txtPass);
            panel1.Location = new Point(-3, 33);
            panel1.Name = "panel1";
            panel1.Size = new Size(407, 458);
            panel1.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(41, 119);
            label3.Name = "label3";
            label3.Size = new Size(324, 27);
            label3.TabIndex = 7;
            label3.Text = "Hesabınıza Giriş Yapınız";
            // 
            // btnChangedPassword
            // 
            btnChangedPassword.BackColor = Color.Transparent;
            btnChangedPassword.Cursor = Cursors.Hand;
            btnChangedPassword.FlatAppearance.BorderSize = 0;
            btnChangedPassword.FlatStyle = FlatStyle.Flat;
            btnChangedPassword.ForeColor = Color.ForestGreen;
            btnChangedPassword.Location = new Point(180, 389);
            btnChangedPassword.Margin = new Padding(5, 4, 5, 4);
            btnChangedPassword.Name = "btnChangedPassword";
            btnChangedPassword.Size = new Size(202, 50);
            btnChangedPassword.TabIndex = 5;
            btnChangedPassword.Text = "Şifre Değiştir";
            btnChangedPassword.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnChangedPassword.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Red;
            label4.Cursor = Cursors.Hand;
            label4.Font = new Font("Georgia", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(368, -1);
            label4.Name = "label4";
            label4.Size = new Size(36, 35);
            label4.TabIndex = 8;
            label4.Text = "X";
            
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(13F, 27F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(404, 489);
            Controls.Add(label4);
            Controls.Add(panel1);
            Font = new Font("Consolas", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(5, 4, 5, 4);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginForm";
            FormClosed += LoginForm_FormClosed;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtUserName;
        private TextBox txtPass;
        private Button btnLogin;
        private Button btnRegister;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Button btnChangedPassword;
        private Label label3;
        private Label label4;
    }
}