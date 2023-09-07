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
            label1 = new Label();
            label2 = new Label();
            btnAddedMoney = new Button();
            SuspendLayout();
            // 
            // txtAmound
            // 
            txtAmound.Location = new Point(186, 101);
            txtAmound.Name = "txtAmound";
            txtAmound.Size = new Size(148, 25);
            txtAmound.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 104);
            label1.Name = "label1";
            label1.Size = new Size(152, 18);
            label1.TabIndex = 1;
            label1.Text = "Yüklenecek Tutar :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Consolas", 14.2641506F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(127, 9);
            label2.Name = "label2";
            label2.Size = new Size(178, 24);
            label2.TabIndex = 2;
            label2.Text = "Bakiye Yükleme";
            // 
            // btnAddedMoney
            // 
            btnAddedMoney.Location = new Point(186, 153);
            btnAddedMoney.Name = "btnAddedMoney";
            btnAddedMoney.Size = new Size(148, 25);
            btnAddedMoney.TabIndex = 3;
            btnAddedMoney.Text = "Bakiye Yükle";
            btnAddedMoney.UseVisualStyleBackColor = true;
            btnAddedMoney.Click += btnAddedMoney_Click;
            // 
            // AddMoneyForm
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(401, 229);
            Controls.Add(btnAddedMoney);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtAmound);
            Font = new Font("Consolas", 10.18868F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "AddMoneyForm";
            Text = "AddMoneyForm";
            Load += AddMoneyForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtAmound;
        private Label label1;
        private Label label2;
        private Button btnAddedMoney;
    }
}