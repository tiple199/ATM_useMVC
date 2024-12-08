namespace ATM_useMVC.View
{
    partial class FormATM_Admin
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
        /// Required method for Designer support - do not modify the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelATMID = new System.Windows.Forms.Label();
            this.tb_ID = new System.Windows.Forms.TextBox();
            this.btnEnter = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.labelTitle.ForeColor = System.Drawing.Color.DodgerBlue;
            this.labelTitle.Location = new System.Drawing.Point(313, 47);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(200, 41);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Quản lý ATM";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelTitle.Click += new System.EventHandler(this.labelTitle_Click);
            // 
            // labelATMID
            // 
            this.labelATMID.AutoSize = true;
            this.labelATMID.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.labelATMID.ForeColor = System.Drawing.Color.Gray;
            this.labelATMID.Location = new System.Drawing.Point(292, 149);
            this.labelATMID.Name = "labelATMID";
            this.labelATMID.Size = new System.Drawing.Size(238, 32);
            this.labelATMID.TabIndex = 1;
            this.labelATMID.Text = "Nhập mã máy ATM:";
            // 
            // tb_ID
            // 
            this.tb_ID.BackColor = System.Drawing.Color.LightGray;
            this.tb_ID.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tb_ID.ForeColor = System.Drawing.Color.Gray;
            this.tb_ID.Location = new System.Drawing.Point(250, 200);
            this.tb_ID.Name = "tb_ID";
            this.tb_ID.Size = new System.Drawing.Size(300, 34);
            this.tb_ID.TabIndex = 2;
            this.tb_ID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_ID.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tb_ID_MouseClick);
            this.tb_ID.TextChanged += new System.EventHandler(this.tb_ID_TextChanged);
            // 
            // btnEnter
            // 
            this.btnEnter.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnEnter.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnEnter.ForeColor = System.Drawing.Color.White;
            this.btnEnter.Location = new System.Drawing.Point(250, 270);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(300, 50);
            this.btnEnter.TabIndex = 3;
            this.btnEnter.Text = "Tiếp tục";
            this.btnEnter.UseVisualStyleBackColor = false;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Gray;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(66, 408);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(150, 60);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "Quay lại";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // FormATM_Admin
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.tb_ID);
            this.Controls.Add(this.labelATMID);
            this.Controls.Add(this.labelTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormATM_Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý ATM";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelATMID;
        private System.Windows.Forms.TextBox tb_ID;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Button btnBack;
    }
}
