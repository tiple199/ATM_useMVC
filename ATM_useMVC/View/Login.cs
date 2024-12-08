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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            
        }
        int count = 1;
        Check_login check_Login = new Check_login();
        Ban_Acc Ban_Acc = new Ban_Acc();
        private void txtCardNo_MouseClick(object sender, MouseEventArgs e)
        {
            txtCardNo.Text = "";
        }

        private void txtPin_MouseClick(object sender, MouseEventArgs e)
        {
            txtPin.Text = "";
        }

        private void lg_Click(object sender, EventArgs e)
        {
           if (txtCardNo.Text == "" || txtCardNo.Text == "xxxx-xxxx-xxxx")
            {
                MessageBox.Show("Vui lòng nhập mã thẻ!", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCardNo.Focus();
            }
            else
            {
                if(txtPin.Text == "" || txtPin.Text == "xxxx")
                {
                    MessageBox.Show("Vui lòng nhập mã pin!", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPin.Focus();
                }
                else
                {
                    var rs = check_Login.CheckLogin(txtCardNo.Text, txtPin.Text);
                    switch (rs.ErrCode)
                    {
                        case Models.EnumErrCode.Success:
                            MessageBox.Show(rs.ErrMsg, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Dashboard dashboard = new Dashboard();
                            dashboard.Show();
                            this.Hide();
                            break;
                        case Models.EnumErrCode.Error:
                            
                            MessageBox.Show(rs.ErrMsg, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            if(rs.ErrMsg == "ID thẻ không chính xác!")
                            {
                                txtCardNo.Focus();
                            }
                            else if(rs.ErrMsg == "Mật khẩu không chính xác!")
                            {
                                txtPin.Focus();
                                MessageBox.Show($"Bạn đã nhập sai {count} lần. Tài khoản sẽ bị khóa sau {3 - count} lần sai nữa.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                count++;
                                if (count == 4)
                                {
                                    var rs1 = Ban_Acc.Ban_acc(txtCardNo.Text);
                                    switch(rs1.ErrCode)
                                    {
                                        case Models.EnumErrCode.Success:
                                            MessageBox.Show(rs1.ErrMsg, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            Ban_Acc.Ban_acc(txtCardNo.Text);
                                        break;
                                    }    
                                }

                            }
                            break;

                    }

                }
            }


        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
