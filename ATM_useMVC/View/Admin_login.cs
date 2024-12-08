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
    public partial class Admin_login : Form
    {
        public Admin_login()
        {
            InitializeComponent();
        }

        private void txtUsername_MouseClick(object sender, MouseEventArgs e)
        {
            txtUsername.Text = "";
        }

        private void txtPassword_MouseClick(object sender, MouseEventArgs e)
        {
            txtPassword.Text = "";
        }

        Check_login_admin check_Login_Admin = new Check_login_admin();

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tài khoản!", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsername.Focus();
            }
            else
            {
                if (txtPassword.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập mật khẩu!", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPassword.Focus();
                }
                else
                {
                    var rs = check_Login_Admin.CheckLogin(txtUsername.Text, txtPassword.Text);
                    switch (rs.ErrCode)
                    {
                        case Models.EnumErrCode.Success:
                            Admin_dashboard admin_Dashboard = new Admin_dashboard();
                            admin_Dashboard.Show();
                            this.Hide();
                            break;
                        case Models.EnumErrCode.Error:
                            MessageBox.Show(rs.ErrMsg, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            if (rs.ErrMsg == "ID thẻ không chính xác!")
                            {
                                txtUsername.Focus();
                            }
                            else
                            {
                                txtPassword.Focus();
                            }
                            break;
                    }
                }
            }
        }

        private void Admin_login_Load(object sender, EventArgs e)
        {
        }

        private void Admin_login_Load_1(object sender, EventArgs e)
        {

        }
    }
}
