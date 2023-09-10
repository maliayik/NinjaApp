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
            panel1 = new Panel();
            label4 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(48, 50);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(294, 31);
            txtPassword.TabIndex = 0;
            // 
            // btnChangePassword
            // 
            btnChangePassword.BackColor = Color.ForestGreen;
            btnChangePassword.Cursor = Cursors.Hand;
            btnChangePassword.FlatAppearance.BorderSize = 0;
            btnChangePassword.FlatStyle = FlatStyle.Popup;
            btnChangePassword.ForeColor = Color.White;
            btnChangePassword.Location = new Point(113, 179);
            btnChangePassword.Name = "btnChangePassword";
            btnChangePassword.Size = new Size(157, 32);
            btnChangePassword.TabIndex = 1;
            btnChangePassword.Text = "Güncelle";
            btnChangePassword.UseVisualStyleBackColor = false;
            btnChangePassword.Click += btnChangePassword_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(48, 23);
            label1.Name = "label1";
            label1.Size = new Size(70, 24);
            label1.TabIndex = 2;
            label1.Text = "Şifre";
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Location = new Point(48, 135);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Size = new Size(294, 31);
            txtConfirmPassword.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(48, 108);
            label2.Name = "label2";
            label2.Size = new Size(154, 24);
            label2.TabIndex = 2;
            label2.Text = "Şifre Tekrar";
            
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.GradientInactiveCaption;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtConfirmPassword);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnChangePassword);
            panel1.Location = new Point(0, 32);
            panel1.Name = "panel1";
            panel1.Size = new Size(396, 242);
            panel1.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Red;
            label4.Cursor = Cursors.Hand;
            label4.Font = new Font("Georgia", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(363, -3);
            label4.Name = "label4";
            label4.Size = new Size(36, 35);
            label4.TabIndex = 9;
            label4.Text = "X";           
            // 
            // ChangePasswordForm
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(396, 274);
            Controls.Add(label4);
            Controls.Add(panel1);
            Font = new Font("Consolas", 12.2264156F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "ChangePasswordForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ChangePasswordForm";
            Load += ChangePasswordForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPassword;
        private Button btnChangePassword;
        private Label label1;
        private TextBox txtConfirmPassword;
        private Label label2;
        private Panel panel1;
        private Label label4;
    }
}