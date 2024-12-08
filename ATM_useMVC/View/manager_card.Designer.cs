namespace ATM_useMVC.View
{
    partial class manager_card
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
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_active = new System.Windows.Forms.Button();
            this.btn_ban = new System.Windows.Forms.Button();
            this.lb_status = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lb_balace = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lb_name = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lb_accNo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_fetchData = new System.Windows.Forms.Button();
            this.tb_sotaikhoan = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.Gray;
            this.btn_back.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btn_back.Location = new System.Drawing.Point(57, 523);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(140, 44);
            this.btn_back.TabIndex = 20;
            this.btn_back.Text = "Quay lại";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_active
            // 
            this.btn_active.BackColor = System.Drawing.Color.Orange;
            this.btn_active.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btn_active.ForeColor = System.Drawing.Color.White;
            this.btn_active.Location = new System.Drawing.Point(576, 318);
            this.btn_active.Name = "btn_active";
            this.btn_active.Size = new System.Drawing.Size(146, 49);
            this.btn_active.TabIndex = 18;
            this.btn_active.Text = "Kích hoạt";
            this.btn_active.UseVisualStyleBackColor = false;
            this.btn_active.Click += new System.EventHandler(this.btn_active_Click);
            // 
            // btn_ban
            // 
            this.btn_ban.BackColor = System.Drawing.Color.Red;
            this.btn_ban.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btn_ban.ForeColor = System.Drawing.Color.White;
            this.btn_ban.Location = new System.Drawing.Point(576, 409);
            this.btn_ban.Name = "btn_ban";
            this.btn_ban.Size = new System.Drawing.Size(146, 49);
            this.btn_ban.TabIndex = 19;
            this.btn_ban.Text = "Khóa thẻ";
            this.btn_ban.UseVisualStyleBackColor = false;
            this.btn_ban.Click += new System.EventHandler(this.btn_ban_Click);
            // 
            // lb_status
            // 
            this.lb_status.AutoSize = true;
            this.lb_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_status.ForeColor = System.Drawing.Color.Gray;
            this.lb_status.Location = new System.Drawing.Point(341, 456);
            this.lb_status.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_status.Name = "lb_status";
            this.lb_status.Size = new System.Drawing.Size(158, 31);
            this.lb_status.TabIndex = 10;
            this.lb_status.Text = "................";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Gray;
            this.label6.Location = new System.Drawing.Point(118, 456);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(155, 31);
            this.label6.TabIndex = 11;
            this.label6.Text = "Trạng thái:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_balace
            // 
            this.lb_balace.AutoSize = true;
            this.lb_balace.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_balace.ForeColor = System.Drawing.Color.Gray;
            this.lb_balace.Location = new System.Drawing.Point(341, 396);
            this.lb_balace.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_balace.Name = "lb_balace";
            this.lb_balace.Size = new System.Drawing.Size(158, 31);
            this.lb_balace.TabIndex = 12;
            this.lb_balace.Text = "................";
            this.lb_balace.Click += new System.EventHandler(this.lb_balace_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(118, 396);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 31);
            this.label5.TabIndex = 13;
            this.label5.Text = "Số dư:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_name
            // 
            this.lb_name.AutoSize = true;
            this.lb_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_name.ForeColor = System.Drawing.Color.Gray;
            this.lb_name.Location = new System.Drawing.Point(341, 336);
            this.lb_name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_name.Name = "lb_name";
            this.lb_name.Size = new System.Drawing.Size(158, 31);
            this.lb_name.TabIndex = 14;
            this.lb_name.Text = "................";
            this.lb_name.Click += new System.EventHandler(this.lb_name_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(118, 336);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(203, 31);
            this.label4.TabIndex = 15;
            this.label4.Text = "Chủ tài khoản:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // lb_accNo
            // 
            this.lb_accNo.AutoSize = true;
            this.lb_accNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_accNo.ForeColor = System.Drawing.Color.Gray;
            this.lb_accNo.Location = new System.Drawing.Point(341, 276);
            this.lb_accNo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_accNo.Name = "lb_accNo";
            this.lb_accNo.Size = new System.Drawing.Size(160, 31);
            this.lb_accNo.TabIndex = 16;
            this.lb_accNo.Text = "xxx-xxx-xxx";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(118, 276);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(193, 31);
            this.label3.TabIndex = 17;
            this.label3.Text = "Số tài khoản: ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_fetchData
            // 
            this.btn_fetchData.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_fetchData.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_fetchData.ForeColor = System.Drawing.Color.Snow;
            this.btn_fetchData.Location = new System.Drawing.Point(576, 159);
            this.btn_fetchData.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_fetchData.Name = "btn_fetchData";
            this.btn_fetchData.Size = new System.Drawing.Size(146, 47);
            this.btn_fetchData.TabIndex = 9;
            this.btn_fetchData.Text = "Lấy dữ liệu";
            this.btn_fetchData.UseVisualStyleBackColor = false;
            this.btn_fetchData.Click += new System.EventHandler(this.btn_fetchData_Click);
            // 
            // tb_sotaikhoan
            // 
            this.tb_sotaikhoan.BackColor = System.Drawing.Color.LightGray;
            this.tb_sotaikhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_sotaikhoan.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.tb_sotaikhoan.Location = new System.Drawing.Point(287, 160);
            this.tb_sotaikhoan.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tb_sotaikhoan.Name = "tb_sotaikhoan";
            this.tb_sotaikhoan.Size = new System.Drawing.Size(236, 45);
            this.tb_sotaikhoan.TabIndex = 8;
            this.tb_sotaikhoan.Text = "xxx-xxx-xxx";
            this.tb_sotaikhoan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_sotaikhoan.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tb_sotaikhoan_MouseClick);
            this.tb_sotaikhoan.TextChanged += new System.EventHandler(this.tb_sotaikhoan_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(15, 168);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(258, 31);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nhập số tài khoản:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(309, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 39);
            this.label1.TabIndex = 7;
            this.label1.Text = "Quản lý thẻ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // manager_card
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_active);
            this.Controls.Add(this.btn_ban);
            this.Controls.Add(this.lb_status);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lb_balace);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lb_name);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lb_accNo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_fetchData);
            this.Controls.Add(this.tb_sotaikhoan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "manager_card";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý thẻ";
            this.Load += new System.EventHandler(this.manager_card_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_active;
        private System.Windows.Forms.Button btn_ban;
        private System.Windows.Forms.Label lb_status;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lb_balace;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lb_name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lb_accNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_fetchData;
        private System.Windows.Forms.TextBox tb_sotaikhoan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}