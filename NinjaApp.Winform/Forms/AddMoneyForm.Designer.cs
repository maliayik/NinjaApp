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
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtAmound
            // 
            txtAmound.Font = new Font("Consolas", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtAmound.Location = new Point(12, 12);
            txtAmound.Name = "txtAmound";
            txtAmound.PlaceholderText = "Lütfen Tutar Giriniz";
            txtAmound.Size = new Size(303, 27);
            txtAmound.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Consolas", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(50, 3);
            label2.Name = "label2";
            label2.Size = new Size(194, 27);
            label2.TabIndex = 2;
            label2.Text = "Bakiye Yükleme";
            // 
            // btnAddedMoney
            // 
            btnAddedMoney.BackColor = Color.ForestGreen;
            btnAddedMoney.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddedMoney.ForeColor = Color.White;
            btnAddedMoney.Location = new Point(70, 45);
            btnAddedMoney.Name = "btnAddedMoney";
            btnAddedMoney.Size = new Size(174, 73);
            btnAddedMoney.TabIndex = 3;
            btnAddedMoney.Text = "Bakiye Yükle";
            btnAddedMoney.UseVisualStyleBackColor = false;
            btnAddedMoney.Click += btnAddedMoney_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.GradientInactiveCaption;
            panel1.Controls.Add(btnAddedMoney);
            panel1.Controls.Add(txtAmound);
            panel1.Location = new Point(0, 33);
            panel1.Name = "panel1";
            panel1.Size = new Size(327, 141);
            panel1.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Red;
            label1.Font = new Font("Consolas", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(297, 0);
            label1.Name = "label1";
            label1.Size = new Size(30, 33);
            label1.TabIndex = 5;
            label1.Text = "X";
          
            // 
            // AddMoneyForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
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
    }
}