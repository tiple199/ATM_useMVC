namespace ATM_useMVC
{
    partial class StartScreen
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
            this.labelMachineNo = new System.Windows.Forms.Label();
            this.txtMachineNo = new System.Windows.Forms.TextBox();
            this.btnEnter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.labelTitle.ForeColor = System.Drawing.Color.DodgerBlue;
            this.labelTitle.Location = new System.Drawing.Point(270, 50);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(506, 65);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Chào mừng đến ATM";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelMachineNo
            // 
            this.labelMachineNo.AutoSize = true;
            this.labelMachineNo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelMachineNo.ForeColor = System.Drawing.Color.Gray;
            this.labelMachineNo.Location = new System.Drawing.Point(286, 207);
            this.labelMachineNo.Name = "labelMachineNo";
            this.labelMachineNo.Size = new System.Drawing.Size(430, 37);
            this.labelMachineNo.TabIndex = 1;
            this.labelMachineNo.Text = "Vui lòng nhập mã máy để tiếp tục :";
            this.labelMachineNo.Click += new System.EventHandler(this.labelMachineNo_Click);
            // 
            // txtMachineNo
            // 
            this.txtMachineNo.BackColor = System.Drawing.Color.LightGray;
            this.txtMachineNo.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtMachineNo.ForeColor = System.Drawing.Color.Black;
            this.txtMachineNo.Location = new System.Drawing.Point(277, 250);
            this.txtMachineNo.Name = "txtMachineNo";
            this.txtMachineNo.Size = new System.Drawing.Size(244, 50);
            this.txtMachineNo.TabIndex = 2;
            this.txtMachineNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMachineNo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtMachineNo_MouseClick);
            // 
            // btnEnter
            // 
            this.btnEnter.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnEnter.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnEnter.ForeColor = System.Drawing.Color.White;
            this.btnEnter.Location = new System.Drawing.Point(300, 350);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(200, 50);
            this.btnEnter.TabIndex = 3;
            this.btnEnter.Text = "Tiếp tục";
            this.btnEnter.UseVisualStyleBackColor = false;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // StartScreen
            // 
            this.AcceptButton = this.btnEnter;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.txtMachineNo);
            this.Controls.Add(this.labelMachineNo);
            this.Controls.Add(this.labelTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "StartScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ATM";
            this.Load += new System.EventHandler(this.StartScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelMachineNo;
        private System.Windows.Forms.TextBox txtMachineNo;
        private System.Windows.Forms.Button btnEnter;
    }
}
