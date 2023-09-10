namespace NinjaApp.Winform.Forms
{
    partial class AddMoneyForm
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
            txtAmound = new TextBox();
            label2 = new Label();
            btnAddedMoney = new Button();
            panel1 = new Panel();
            button1 = new Button();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtAmound
            // 
            txtAmound.Font = new Font("Consolas", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtAmound.Location = new Point(69, 25);
            txtAmound.Name = "txtAmound";
            txtAmound.PlaceholderText = "Lütfen Tutar Giriniz";
            txtAmound.Size = new Size(183, 25);
            txtAmound.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Consolas", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(50, 3);
            label2.Name = "label2";
            label2.Size = new Size(178, 24);
            label2.TabIndex = 2;
            label2.Text = "Bakiye Yükleme";
            // 
            // btnAddedMoney
            // 
            btnAddedMoney.BackColor = Color.ForestGreen;
            btnAddedMoney.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddedMoney.ForeColor = Color.White;
            btnAddedMoney.Location = new Point(69, 56);
            btnAddedMoney.Name = "btnAddedMoney";
            btnAddedMoney.Size = new Size(84, 58);
            btnAddedMoney.TabIndex = 3;
            btnAddedMoney.Text = "Bakiye Yükle";
            btnAddedMoney.UseVisualStyleBackColor = false;
            btnAddedMoney.Click += btnAddedMoney_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.GradientInactiveCaption;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(btnAddedMoney);
            panel1.Controls.Add(txtAmound);
            panel1.Location = new Point(0, 33);
            panel1.Name = "panel1";
            panel1.Size = new Size(327, 141);
            panel1.TabIndex = 4;
            // 
            // button1
            // 
            button1.Location = new Point(169, 56);
            button1.Name = "button1";
            button1.Size = new Size(83, 58);
            button1.TabIndex = 6;
            button1.Text = "Çıkış Yap";
            button1.UseVisualStyleBackColor = true;            
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Red;
            label1.Font = new Font("Consolas", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(297, 0);
            label1.Name = "label1";
            label1.Size = new Size(25, 28);
            label1.TabIndex = 5;
            label1.Text = "X";
            label1.Click += label1_Click;
            // 
            // AddMoneyForm
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(327, 178);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(label2);
            Font = new Font("Consolas", 10.18868F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddMoneyForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddMoneyForm";
            Load += AddMoneyForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtAmound;
        private Label label2;
        private Button btnAddedMoney;
        private Panel panel1;
        private Label label1;
        private Button button1;
    }
}