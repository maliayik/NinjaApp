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
            txtPassword = new TextBox();
            btnChangePassword = new Button();
            label1 = new Label();
            txtConfirmPassword = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(196, 71);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(157, 29);
            txtPassword.TabIndex = 0;
            // 
            // btnChangePassword
            // 
            btnChangePassword.Location = new Point(196, 183);
            btnChangePassword.Name = "btnChangePassword";
            btnChangePassword.Size = new Size(157, 32);
            btnChangePassword.TabIndex = 1;
            btnChangePassword.Text = "Güncelle";
            btnChangePassword.UseVisualStyleBackColor = true;
            btnChangePassword.Click += btnChangePassword_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(95, 74);
            label1.Name = "label1";
            label1.Size = new Size(80, 22);
            label1.TabIndex = 2;
            label1.Text = "Şifre :";
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Location = new Point(196, 128);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Size = new Size(157, 29);
            txtConfirmPassword.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 131);
            label2.Name = "label2";
            label2.Size = new Size(150, 22);
            label2.TabIndex = 2;
            label2.Text = "Şifre Tekrar :";
            // 
            // ChangePasswordForm
            // 
            AutoScaleDimensions = new SizeF(10F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(422, 296);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnChangePassword);
            Controls.Add(txtConfirmPassword);
            Controls.Add(txtPassword);
            Font = new Font("Consolas", 12.2264156F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "ChangePasswordForm";
            Text = "ChangePasswordForm";
            Load += ChangePasswordForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPassword;
        private Button btnChangePassword;
        private Label label1;
        private TextBox txtConfirmPassword;
        private Label label2;
    }
}