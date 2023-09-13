namespace NinjaApp.Winform.Forms
{
    partial class ChangePasswordForm
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
            label3 = new Label();
            label2 = new Label();
            txtPassword = new TextBox();
            txtConfirmPassword = new TextBox();
            btnChangePassword = new Button();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Consolas", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ControlDarkDark;
            label3.Location = new Point(12, 140);
            label3.Name = "label3";
            label3.Size = new Size(154, 24);
            label3.TabIndex = 8;
            label3.Text = "ŞİFRE TEKRAR";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Consolas", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlDarkDark;
            label2.Location = new Point(12, 34);
            label2.Name = "label2";
            label2.Size = new Size(130, 24);
            label2.TabIndex = 9;
            label2.Text = "YENİ ŞİFRE";
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.Gainsboro;
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Font = new Font("Consolas", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            txtPassword.Location = new Point(12, 64);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(294, 47);
            txtPassword.TabIndex = 5;
            txtPassword.WordWrap = false;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.BackColor = Color.Gainsboro;
            txtConfirmPassword.BorderStyle = BorderStyle.None;
            txtConfirmPassword.Font = new Font("Consolas", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            txtConfirmPassword.Location = new Point(12, 170);
            txtConfirmPassword.Multiline = true;
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.PasswordChar = '*';
            txtConfirmPassword.Size = new Size(294, 47);
            txtConfirmPassword.TabIndex = 6;
            txtConfirmPassword.WordWrap = false;
            // 
            // btnChangePassword
            // 
            btnChangePassword.BackColor = Color.FromArgb(81, 80, 75);
            btnChangePassword.Cursor = Cursors.Hand;
            btnChangePassword.FlatAppearance.BorderSize = 0;
            btnChangePassword.FlatStyle = FlatStyle.Popup;
            btnChangePassword.Font = new Font("Consolas", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnChangePassword.ForeColor = Color.White;
            btnChangePassword.Location = new Point(12, 240);
            btnChangePassword.Name = "btnChangePassword";
            btnChangePassword.Size = new Size(294, 63);
            btnChangePassword.TabIndex = 7;
            btnChangePassword.Text = "Güncelle";
            btnChangePassword.UseVisualStyleBackColor = false;
            btnChangePassword.Click += btnChangePassword_Click;
            // 
            // ChangePasswordForm
            // 
            AutoScaleDimensions = new SizeF(10F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(324, 335);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtPassword);
            Controls.Add(txtConfirmPassword);
            Controls.Add(btnChangePassword);
            Font = new Font("Consolas", 12.2264156F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "ChangePasswordForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ChangePasswordForm";
            Load += ChangePasswordForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Label label2;
        private TextBox txtPassword;
        private TextBox txtConfirmPassword;
        private Button btnChangePassword;
    }
}