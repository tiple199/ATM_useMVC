namespace ATM_useMVC.View
{
    partial class Login
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
            this.lg = new System.Windows.Forms.Button();
            this.txtPin = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCardNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lg
            // 
            this.lg.BackColor = System.Drawing.Color.DodgerBlue;
            this.lg.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lg.ForeColor = System.Drawing.Color.White;
            this.lg.Location = new System.Drawing.Point(307, 425);
            this.lg.Name = "lg";
            this.lg.Size = new System.Drawing.Size(186, 53);
            this.lg.TabIndex = 17;
            this.lg.Text = "Đăng nhập";
            this.lg.UseVisualStyleBackColor = false;
            this.lg.Click += new System.EventHandler(this.lg_Click);
            // 
            // txtPin
            // 
            this.txtPin.BackColor = System.Drawing.Color.LightGray;
            this.txtPin.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtPin.ForeColor = System.Drawing.Color.Black;
            this.txtPin.Location = new System.Drawing.Point(219, 319);
            this.txtPin.Name = "txtPin";
            this.txtPin.PasswordChar = '●';
            this.txtPin.Size = new System.Drawing.Size(350, 50);
            this.txtPin.TabIndex = 16;
            this.txtPin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPin.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtPin_MouseClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label3.Location = new System.Drawing.Point(219, 287);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 45);
            this.label3.TabIndex = 19;
            this.label3.Text = "Nhập PIN:";
            // 
            // txtCardNo
            // 
            this.txtCardNo.BackColor = System.Drawing.Color.LightGray;
            this.txtCardNo.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtCardNo.ForeColor = System.Drawing.Color.Black;
            this.txtCardNo.Location = new System.Drawing.Point(219, 212);
            this.txtCardNo.Name = "txtCardNo";
            this.txtCardNo.Size = new System.Drawing.Size(350, 50);
            this.txtCardNo.TabIndex = 15;
            this.txtCardNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCardNo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtCardNo_MouseClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(219, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(292, 45);
            this.label2.TabIndex = 18;
            this.label2.Text = "Số thẻ ngân hàng:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(299, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 72);
            this.label1.TabIndex = 20;
            this.label1.Text = "Đăng nhập";
            // 
            // Login
            // 
            this.AcceptButton = this.lg;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(804, 600);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lg);
            this.Controls.Add(this.txtPin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCardNo);
            this.Controls.Add(this.label2);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button lg;
        private System.Windows.Forms.TextBox txtPin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCardNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
