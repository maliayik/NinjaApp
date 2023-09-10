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
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(30, 144);
            txtUserName.Margin = new Padding(5, 4, 5, 4);
            txtUserName.Name = "txtUserName";
            txtUserName.PlaceholderText = "KULLANICI ADI";
            txtUserName.Size = new Size(352, 34);
            txtUserName.TabIndex = 1;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(30, 186);
            txtPass.Margin = new Padding(5, 4, 5, 4);
            txtPass.Name = "txtPass";
            txtPass.PasswordChar = '*';
            txtPass.PlaceholderText = "ŞİFRE";
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
            btnLogin.Location = new Point(28, 236);
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
            btnRegister.BackColor = Color.DarkOrange;
            btnRegister.Cursor = Cursors.Hand;
            btnRegister.FlatAppearance.BorderSize = 0;
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.ForeColor = Color.White;
            btnRegister.Location = new Point(28, 289);
            btnRegister.Margin = new Padding(5, 4, 5, 4);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(354, 39);
            btnRegister.TabIndex = 4;
            btnRegister.Text = "Kayıt Ol";
            btnRegister.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.user;
            pictureBox1.Location = new Point(160, 37);
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
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(btnRegister);
            panel1.Controls.Add(txtUserName);
            panel1.Controls.Add(txtPass);
            panel1.Location = new Point(-3, 33);
            panel1.Name = "panel1";
            panel1.Size = new Size(407, 344);
            panel1.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(111, 3);
            label3.Name = "label3";
            label3.Size = new Size(168, 27);
            label3.TabIndex = 7;
            label3.Text = "GİRİŞ PANELİ";
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
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Consolas", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(3, 380);
            label5.Name = "label5";
            label5.Size = new Size(150, 22);
            label5.TabIndex = 9;
            label5.Text = "Ninja App v1.0";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Consolas", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(157, 380);
            label6.Name = "label6";
            label6.Size = new Size(119, 15);
            label6.TabIndex = 10;
            label6.Text = "Copyright © 2023";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(13F, 27F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(404, 408);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
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
        private TextBox txtUserName;
        private TextBox txtPass;
        private Button btnLogin;
        private Button btnRegister;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}