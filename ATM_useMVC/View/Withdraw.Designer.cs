namespace ATM_useMVC.View
{
    partial class Withdraw
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
            this.btnBack = new System.Windows.Forms.Button();
            this.btnWithdraw = new System.Windows.Forms.Button();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn1000000 = new System.Windows.Forms.Button();
            this.btn500000 = new System.Windows.Forms.Button();
            this.btn200000 = new System.Windows.Forms.Button();
            this.btn100000 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Gray;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(74, 452);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(130, 55);
            this.btnBack.TabIndex = 53;
            this.btnBack.Text = "Quay lại";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnWithdraw
            // 
            this.btnWithdraw.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnWithdraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWithdraw.ForeColor = System.Drawing.Color.White;
            this.btnWithdraw.Location = new System.Drawing.Point(251, 375);
            this.btnWithdraw.Margin = new System.Windows.Forms.Padding(4);
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.Size = new System.Drawing.Size(273, 60);
            this.btnWithdraw.TabIndex = 52;
            this.btnWithdraw.Text = "Rút tiền";
            this.btnWithdraw.UseVisualStyleBackColor = false;
            this.btnWithdraw.Click += new System.EventHandler(this.btnWithdraw_Click);
            // 
            // txtAmount
            // 
            this.txtAmount.BackColor = System.Drawing.Color.LightGray;
            this.txtAmount.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmount.ForeColor = System.Drawing.Color.Black;
            this.txtAmount.Location = new System.Drawing.Point(180, 318);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(430, 57);
            this.txtAmount.TabIndex = 51;
            this.txtAmount.Text = "000.000";
            this.txtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtAmount.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtAmount_MouseClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(285, 268);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(426, 59);
            this.label3.TabIndex = 50;
            this.label3.Text = "Nhập tiền muốn rút";
            // 
            // btn1000000
            // 
            this.btn1000000.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn1000000.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1000000.ForeColor = System.Drawing.Color.White;
            this.btn1000000.Location = new System.Drawing.Point(616, 156);
            this.btn1000000.Margin = new System.Windows.Forms.Padding(4);
            this.btn1000000.Name = "btn1000000";
            this.btn1000000.Size = new System.Drawing.Size(158, 76);
            this.btn1000000.TabIndex = 49;
            this.btn1000000.Text = "1.000.000 đ";
            this.btn1000000.UseVisualStyleBackColor = false;
            this.btn1000000.Click += new System.EventHandler(this.btn1000000_Click);
            // 
            // btn500000
            // 
            this.btn500000.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn500000.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn500000.ForeColor = System.Drawing.Color.White;
            this.btn500000.Location = new System.Drawing.Point(429, 156);
            this.btn500000.Margin = new System.Windows.Forms.Padding(4);
            this.btn500000.Name = "btn500000";
            this.btn500000.Size = new System.Drawing.Size(158, 76);
            this.btn500000.TabIndex = 48;
            this.btn500000.Text = "500.000 đ";
            this.btn500000.UseVisualStyleBackColor = false;
            this.btn500000.Click += new System.EventHandler(this.btn500000_Click);
            // 
            // btn200000
            // 
            this.btn200000.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn200000.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn200000.ForeColor = System.Drawing.Color.White;
            this.btn200000.Location = new System.Drawing.Point(223, 156);
            this.btn200000.Margin = new System.Windows.Forms.Padding(4);
            this.btn200000.Name = "btn200000";
            this.btn200000.Size = new System.Drawing.Size(158, 76);
            this.btn200000.TabIndex = 47;
            this.btn200000.Text = "200.000 đ";
            this.btn200000.UseVisualStyleBackColor = false;
            this.btn200000.Click += new System.EventHandler(this.btn200000_Click);
            // 
            // btn100000
            // 
            this.btn100000.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn100000.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn100000.ForeColor = System.Drawing.Color.White;
            this.btn100000.Location = new System.Drawing.Point(22, 156);
            this.btn100000.Margin = new System.Windows.Forms.Padding(4);
            this.btn100000.Name = "btn100000";
            this.btn100000.Size = new System.Drawing.Size(158, 76);
            this.btn100000.TabIndex = 46;
            this.btn100000.Text = "100.000 đ";
            this.btn100000.UseVisualStyleBackColor = false;
            this.btn100000.Click += new System.EventHandler(this.btn100000_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(230, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(724, 99);
            this.label2.TabIndex = 45;
            this.label2.Text = "Chọn tiền muốn rút";
            // 
            // Withdraw
            // 
            this.AcceptButton = this.btnWithdraw;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(969, 673);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnWithdraw);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn1000000);
            this.Controls.Add(this.btn500000);
            this.Controls.Add(this.btn200000);
            this.Controls.Add(this.btn100000);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Withdraw";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rút tiền";
            this.Load += new System.EventHandler(this.Withdraw_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnWithdraw;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn1000000;
        private System.Windows.Forms.Button btn500000;
        private System.Windows.Forms.Button btn200000;
        private System.Windows.Forms.Button btn100000;
        private System.Windows.Forms.Label label2;
    }
}