namespace ATM_useMVC.View
{
    partial class Admin_dashboard
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
            this.labelTitle = new System.Windows.Forms.Label();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnAddCash = new System.Windows.Forms.Button();
            this.btnMngAcc = new System.Windows.Forms.Button();
            this.btnMngCard = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.labelTitle.ForeColor = System.Drawing.Color.DodgerBlue;
            this.labelTitle.Location = new System.Drawing.Point(270, 50);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(327, 54);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Bảng điều khiển";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnReport
            // 
            this.btnReport.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnReport.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnReport.ForeColor = System.Drawing.Color.White;
            this.btnReport.Location = new System.Drawing.Point(445, 150);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(200, 100);
            this.btnReport.TabIndex = 1;
            this.btnReport.Text = "Quản lý giao dịch";
            this.btnReport.UseVisualStyleBackColor = false;
            this.btnReport.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAddCash
            // 
            this.btnAddCash.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAddCash.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnAddCash.ForeColor = System.Drawing.Color.White;
            this.btnAddCash.Location = new System.Drawing.Point(445, 300);
            this.btnAddCash.Name = "btnAddCash";
            this.btnAddCash.Size = new System.Drawing.Size(200, 100);
            this.btnAddCash.TabIndex = 2;
            this.btnAddCash.Text = "Quản lý tiền ATM";
            this.btnAddCash.UseVisualStyleBackColor = false;
            this.btnAddCash.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnMngAcc
            // 
            this.btnMngAcc.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnMngAcc.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnMngAcc.ForeColor = System.Drawing.Color.White;
            this.btnMngAcc.Location = new System.Drawing.Point(136, 150);
            this.btnMngAcc.Name = "btnMngAcc";
            this.btnMngAcc.Size = new System.Drawing.Size(200, 100);
            this.btnMngAcc.TabIndex = 3;
            this.btnMngAcc.Text = "Quản lý tài khoản";
            this.btnMngAcc.UseVisualStyleBackColor = false;
            this.btnMngAcc.Click += new System.EventHandler(this.btnMngAcc_Click);
            // 
            // btnMngCard
            // 
            this.btnMngCard.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnMngCard.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnMngCard.ForeColor = System.Drawing.Color.White;
            this.btnMngCard.Location = new System.Drawing.Point(136, 300);
            this.btnMngCard.Name = "btnMngCard";
            this.btnMngCard.Size = new System.Drawing.Size(200, 100);
            this.btnMngCard.TabIndex = 4;
            this.btnMngCard.Text = "Quản lý thẻ";
            this.btnMngCard.UseVisualStyleBackColor = false;
            this.btnMngCard.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.LightGray;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnLogout.ForeColor = System.Drawing.Color.Black;
            this.btnLogout.Location = new System.Drawing.Point(317, 448);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(150, 50);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.Text = "Đăng xuất";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // Admin_dashboard
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnMngCard);
            this.Controls.Add(this.btnMngAcc);
            this.Controls.Add(this.btnAddCash);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.labelTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Admin_dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bảng điều khiển Admin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button btnAddCash;
        private System.Windows.Forms.Button btnMngAcc;
        private System.Windows.Forms.Button btnMngCard;
        private System.Windows.Forms.Button btnLogout;
    }
}
