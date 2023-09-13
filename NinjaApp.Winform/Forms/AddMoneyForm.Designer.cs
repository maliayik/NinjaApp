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
            label1 = new Label();
            SuspendLayout();
            // 
            // txtAmound
            // 
            txtAmound.BackColor = Color.Gainsboro;
            txtAmound.BorderStyle = BorderStyle.None;
            txtAmound.Font = new Font("Consolas", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtAmound.Location = new Point(22, 135);
            txtAmound.Multiline = true;
            txtAmound.Name = "txtAmound";
            txtAmound.Size = new Size(310, 40);
            txtAmound.TabIndex = 0;
            txtAmound.WordWrap = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Consolas", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(81, 80, 75);
            label2.Location = new Point(32, 9);
            label2.Name = "label2";
            label2.Size = new Size(272, 45);
            label2.TabIndex = 2;
            label2.Text = "BAKİYE YÜKLE";
            // 
            // btnAddedMoney
            // 
            btnAddedMoney.BackColor = Color.FromArgb(81, 80, 75);
            btnAddedMoney.FlatAppearance.BorderSize = 0;
            btnAddedMoney.FlatStyle = FlatStyle.Flat;
            btnAddedMoney.Font = new Font("Consolas", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddedMoney.ForeColor = Color.White;
            btnAddedMoney.Location = new Point(22, 181);
            btnAddedMoney.Name = "btnAddedMoney";
            btnAddedMoney.Size = new Size(310, 58);
            btnAddedMoney.TabIndex = 3;
            btnAddedMoney.Text = "Bakiye Yükle";
            btnAddedMoney.UseVisualStyleBackColor = false;
            btnAddedMoney.Click += btnAddedMoney_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(22, 105);
            label1.Name = "label1";
            label1.Size = new Size(250, 24);
            label1.TabIndex = 1;
            label1.Text = "Lütfen Tutar Giriniz";
            // 
            // AddMoneyForm
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(354, 263);
            Controls.Add(label1);
            Controls.Add(btnAddedMoney);
            Controls.Add(txtAmound);
            Controls.Add(label2);
            Font = new Font("Consolas", 10.18868F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddMoneyForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddMoneyForm";
            Load += AddMoneyForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtAmound;
        private Label label2;
        private Button btnAddedMoney;
        private Label label1;
    }
}