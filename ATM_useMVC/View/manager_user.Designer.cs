namespace ATM_useMVC.View
{
    partial class manager_user
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.tbSothe = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPin = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbBalance = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(280, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản lý tài khoản";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(103, 301);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(575, 189);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_add.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btn_add.ForeColor = System.Drawing.Color.White;
            this.btn_add.Location = new System.Drawing.Point(532, 95);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(120, 40);
            this.btn_add.TabIndex = 2;
            this.btn_add.Text = "Thêm";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.BackColor = System.Drawing.Color.Orange;
            this.btn_edit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btn_edit.ForeColor = System.Drawing.Color.White;
            this.btn_edit.Location = new System.Drawing.Point(532, 169);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(120, 40);
            this.btn_edit.TabIndex = 3;
            this.btn_edit.Text = "Sửa";
            this.btn_edit.UseVisualStyleBackColor = false;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.Red;
            this.btn_delete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btn_delete.ForeColor = System.Drawing.Color.White;
            this.btn_delete.Location = new System.Drawing.Point(532, 245);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(120, 40);
            this.btn_delete.TabIndex = 4;
            this.btn_delete.Text = "Xóa";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.Gray;
            this.btn_back.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btn_back.Location = new System.Drawing.Point(44, 506);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(120, 40);
            this.btn_back.TabIndex = 5;
            this.btn_back.Text = "Quay lại";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // tbSothe
            // 
            this.tbSothe.BackColor = System.Drawing.Color.LightGray;
            this.tbSothe.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tbSothe.ForeColor = System.Drawing.Color.Black;
            this.tbSothe.Location = new System.Drawing.Point(234, 101);
            this.tbSothe.Name = "tbSothe";
            this.tbSothe.Size = new System.Drawing.Size(200, 34);
            this.tbSothe.TabIndex = 6;
            this.tbSothe.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tbSothe_MouseClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(104, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 28);
            this.label2.TabIndex = 7;
            this.label2.Text = "Số thẻ";
            // 
            // tbPin
            // 
            this.tbPin.BackColor = System.Drawing.Color.LightGray;
            this.tbPin.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tbPin.ForeColor = System.Drawing.Color.Black;
            this.tbPin.Location = new System.Drawing.Point(234, 151);
            this.tbPin.Name = "tbPin";
            this.tbPin.Size = new System.Drawing.Size(200, 34);
            this.tbPin.TabIndex = 8;
            this.tbPin.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tbPin_MouseClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(104, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 28);
            this.label3.TabIndex = 9;
            this.label3.Text = "PIN";
            // 
            // tbName
            // 
            this.tbName.BackColor = System.Drawing.Color.LightGray;
            this.tbName.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tbName.ForeColor = System.Drawing.Color.Black;
            this.tbName.Location = new System.Drawing.Point(234, 201);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(200, 34);
            this.tbName.TabIndex = 10;
            this.tbName.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tbName_MouseClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(104, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 28);
            this.label4.TabIndex = 11;
            this.label4.Text = "Tên";
            // 
            // tbBalance
            // 
            this.tbBalance.BackColor = System.Drawing.Color.LightGray;
            this.tbBalance.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tbBalance.ForeColor = System.Drawing.Color.Black;
            this.tbBalance.Location = new System.Drawing.Point(234, 251);
            this.tbBalance.Name = "tbBalance";
            this.tbBalance.Size = new System.Drawing.Size(200, 34);
            this.tbBalance.TabIndex = 12;
            this.tbBalance.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tbBalance_MouseClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(104, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 28);
            this.label5.TabIndex = 13;
            this.label5.Text = "Số dư";
            // 
            // manager_user
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbBalance);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbPin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbSothe);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "manager_user";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý tài khoản người dùng";
            this.Load += new System.EventHandler(this.manager_user_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.TextBox tbSothe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbPin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbBalance;
        private System.Windows.Forms.Label label5;
    }
}