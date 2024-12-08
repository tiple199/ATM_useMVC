namespace ATM_useMVC.View
{
    partial class Balance
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
            this.btnPrintRecipt = new System.Windows.Forms.Button();
            this.txtbalance = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Gray;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(72, 444);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(148, 65);
            this.btnBack.TabIndex = 32;
            this.btnBack.Text = "Quay lại";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnPrintRecipt
            // 
            this.btnPrintRecipt.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnPrintRecipt.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintRecipt.ForeColor = System.Drawing.Color.White;
            this.btnPrintRecipt.Location = new System.Drawing.Point(173, 272);
            this.btnPrintRecipt.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrintRecipt.Name = "btnPrintRecipt";
            this.btnPrintRecipt.Size = new System.Drawing.Size(445, 76);
            this.btnPrintRecipt.TabIndex = 31;
            this.btnPrintRecipt.Text = "In Hóa đơn";
            this.btnPrintRecipt.UseVisualStyleBackColor = false;
            this.btnPrintRecipt.Click += new System.EventHandler(this.btnPrintRecipt_Click);
            // 
            // txtbalance
            // 
            this.txtbalance.AutoSize = true;
            this.txtbalance.BackColor = System.Drawing.Color.White;
            this.txtbalance.Font = new System.Drawing.Font("Segoe UI", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbalance.ForeColor = System.Drawing.Color.Gray;
            this.txtbalance.Location = new System.Drawing.Point(419, 190);
            this.txtbalance.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtbalance.Name = "txtbalance";
            this.txtbalance.Size = new System.Drawing.Size(187, 59);
            this.txtbalance.TabIndex = 30;
            this.txtbalance.Text = "0000.00";
            this.txtbalance.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(166, 190);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 59);
            this.label2.TabIndex = 29;
            this.label2.Text = "Số dư:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label3.Location = new System.Drawing.Point(255, 68);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(563, 72);
            this.label3.TabIndex = 28;
            this.label3.Text = "Tiền trong tài khoản:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Balance
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnPrintRecipt);
            this.Controls.Add(this.txtbalance);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Balance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Số dư";
            this.Load += new System.EventHandler(this.Balance_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnPrintRecipt;
        private System.Windows.Forms.Label txtbalance;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}