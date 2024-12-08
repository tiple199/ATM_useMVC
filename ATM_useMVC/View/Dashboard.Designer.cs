using System.IO;
using System.Drawing;
using System;

namespace ATM_useMVC.View
{
    partial class Dashboard
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.btnMiniStatement = new System.Windows.Forms.Button();
            this.btnTransferMoney = new System.Windows.Forms.Button();
            this.btnCashWithdraw = new System.Windows.Forms.Button();
            this.btnBalanceInquiry = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.pbReturnCard = new System.Windows.Forms.PictureBox();
            this.SuspendLayout();

            // Form Properties
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.MaximizeBox = false;
            this.Text = "Bảng điều khiển ATM";

            // label3
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label3.Location = new System.Drawing.Point(305, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(300, 46);
            this.label3.TabIndex = 0;
            this.label3.Text = "Chọn dịch vụ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // btnBalanceInquiry
            this.btnBalanceInquiry.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnBalanceInquiry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBalanceInquiry.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBalanceInquiry.ForeColor = System.Drawing.Color.White;
            this.btnBalanceInquiry.Location = new System.Drawing.Point(100, 150);
            this.btnBalanceInquiry.Name = "btnBalanceInquiry";
            this.btnBalanceInquiry.Size = new System.Drawing.Size(250, 80);
            this.btnBalanceInquiry.TabIndex = 1;
            this.btnBalanceInquiry.Text = "Tra cứu số dư";
            this.btnBalanceInquiry.UseVisualStyleBackColor = false;
            this.btnBalanceInquiry.Click += new System.EventHandler(this.btnBalanceInquiry_Click);

            // btnCashWithdraw
            this.btnCashWithdraw.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnCashWithdraw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCashWithdraw.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCashWithdraw.ForeColor = System.Drawing.Color.White;
            this.btnCashWithdraw.Location = new System.Drawing.Point(450, 150);
            this.btnCashWithdraw.Name = "btnCashWithdraw";
            this.btnCashWithdraw.Size = new System.Drawing.Size(250, 80);
            this.btnCashWithdraw.TabIndex = 2;
            this.btnCashWithdraw.Text = "Rút tiền";
            this.btnCashWithdraw.UseVisualStyleBackColor = false;
            this.btnCashWithdraw.Click += new System.EventHandler(this.btnCashWithdraw_Click);

            // btnTransferMoney
            this.btnTransferMoney.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnTransferMoney.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransferMoney.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransferMoney.ForeColor = System.Drawing.Color.White;
            this.btnTransferMoney.Location = new System.Drawing.Point(100, 300);
            this.btnTransferMoney.Name = "btnTransferMoney";
            this.btnTransferMoney.Size = new System.Drawing.Size(250, 80);
            this.btnTransferMoney.TabIndex = 3;
            this.btnTransferMoney.Text = "Chuyển tiền";
            this.btnTransferMoney.UseVisualStyleBackColor = false;
            this.btnTransferMoney.Click += new System.EventHandler(this.btnTransferMoney_Click);

            // btnMiniStatement
            this.btnMiniStatement.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnMiniStatement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMiniStatement.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMiniStatement.ForeColor = System.Drawing.Color.White;
            this.btnMiniStatement.Location = new System.Drawing.Point(450, 300);
            this.btnMiniStatement.Name = "btnMiniStatement";
            this.btnMiniStatement.Size = new System.Drawing.Size(250, 80);
            this.btnMiniStatement.TabIndex = 4;
            this.btnMiniStatement.Text = "Sao kê";
            this.btnMiniStatement.UseVisualStyleBackColor = false;
            this.btnMiniStatement.Click += new System.EventHandler(this.btnMiniStatement_Click);

            // pbReturnCard
            this.pbReturnCard.Image = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "returnCard.png"));
            this.pbReturnCard.Location = new System.Drawing.Point(650, 450);
            this.pbReturnCard.Size = new System.Drawing.Size(80, 80);
            this.pbReturnCard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbReturnCard.TabIndex = 10;
            this.pbReturnCard.TabStop = false;
            this.pbReturnCard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbReturnCard.Click += new System.EventHandler(this.pbReturnCard_Click);

            // Add controls
            this.Controls.Add(this.pbReturnCard);
            this.Controls.Add(this.btnMiniStatement);
            this.Controls.Add(this.btnTransferMoney);
            this.Controls.Add(this.btnCashWithdraw);
            this.Controls.Add(this.btnBalanceInquiry);
            this.Controls.Add(this.label3);

            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnMiniStatement;
        private System.Windows.Forms.Button btnTransferMoney;
        private System.Windows.Forms.Button btnCashWithdraw;
        private System.Windows.Forms.Button btnBalanceInquiry;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pbReturnCard;
    }
}
