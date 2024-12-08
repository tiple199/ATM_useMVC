using ATM_useMVC.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM_useMVC.View
{
    public partial class FormATM_Admin : Form
    {
        public FormATM_Admin()
        {
            InitializeComponent();
        }
        Check_ATM check = new Check_ATM();
        private void tb_ID_MouseClick(object sender, MouseEventArgs e)
        {
            tb_ID.Text = "";
            tb_ID.ForeColor = Color.Black;
        }

        private void tb_ID_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (tb_ID.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã máy!", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tb_ID.Focus();

            }
            else
            {
                var rs = check.CheckATM(tb_ID.Text);
                switch (rs.ErrCode)
                {
                    case Models.EnumErrCode.Success:
                        MessageBox.Show(rs.ErrMsg, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Check_Cash check_cash = new Check_Cash();
                        check_cash.Show();
                        this.Hide();
                        break;
                    case Models.EnumErrCode.Error:
                        MessageBox.Show(rs.ErrMsg, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        tb_ID.Focus();
                        break;

                }
            }

        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            // Quay lại màn hình trước (ví dụ: Admin_dashboard)
            Admin_dashboard adminDashboard = new Admin_dashboard();
            adminDashboard.Show();
            this.Close();
        }

        private void labelTitle_Click(object sender, EventArgs e)
        {

        }
    }
}
