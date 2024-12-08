using ATM_useMVC.Controller;
using ATM_useMVC.Models;
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
    public partial class manager_card : Form
    {
        public manager_card()
        {
            InitializeComponent();
        }
        manager_card_ctrl m_card = new manager_card_ctrl();
        public void show_inf()
        {
            string sothe = tb_sotaikhoan.Text;
            var rs = m_card.GetCard(sothe);

            switch (rs.ErrCode)
            {
                case EnumErrCode.Error:
                    MessageBox.Show("Không thể lấy được giá trị", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case EnumErrCode.Empty:
                    MessageBox.Show("Thẻ chưa được cấp hãy nhập lại số thẻ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case EnumErrCode.Success:
                    // Gắn giá trị trong thẻ vào label
                    lb_accNo.Text = rs.Data.AccNo;
                    lb_accNo.Show();
                    lb_name.Text = rs.Data.Title;
                    lb_name.Show();
                    lb_balace.Text = rs.Data.Balance.ToString();
                    lb_balace.Show();
                    lb_status.Text = rs.Data.AtmStatus;
                    lb_status.Show();
                    break;
            }
        }

        private void tb_sotaikhoan_MouseClick(object sender, MouseEventArgs e)
        {
            tb_sotaikhoan.Text = "";
            tb_sotaikhoan.ForeColor = Color.Black;
        }

        private void btn_fetchData_Click(object sender, EventArgs e)
        {
            show_inf();
        }

        private void manager_card_Load(object sender, EventArgs e)
        {

        }

        private void btn_ban_Click(object sender, EventArgs e)
        {
            string sotaikhoan = tb_sotaikhoan.Text;

            if (sotaikhoan == "")
            {
                MessageBox.Show("Chưa nhập số tài khoản", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tb_sotaikhoan.Focus();
            }
            else
            {
                var rs = m_card.Ban(sotaikhoan);

                switch (rs.ErrCode)
                {
                    case Models.EnumErrCode.Success:
                        MessageBox.Show("Cấm tài khoản thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        show_inf();
                        break;
                    case Models.EnumErrCode.Error:
                        MessageBox.Show(rs.ErrMsg, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    case Models.EnumErrCode.Account_not_found:
                        MessageBox.Show(rs.ErrMsg, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }
            }
        }

        private void btn_active_Click(object sender, EventArgs e)
        {
            string sotaikhoan = tb_sotaikhoan.Text;

            if (sotaikhoan == "")
            {
                MessageBox.Show("Chưa nhập số tài khoản", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tb_sotaikhoan.Focus();
            }
            else
            {
                var rs = m_card.Active(sotaikhoan);

                switch (rs.ErrCode)
                {
                    case Models.EnumErrCode.Success:
                        MessageBox.Show("Kích hoạt tài khoản thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        show_inf();
                        break;
                    case Models.EnumErrCode.Error:
                        MessageBox.Show(rs.ErrMsg, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    case Models.EnumErrCode.Account_not_found:
                        MessageBox.Show(rs.ErrMsg, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Admin_dashboard admin_Dashboard = new Admin_dashboard();
            admin_Dashboard.Show();
            this.Hide();
        }

        private void tb_sotaikhoan_TextChanged(object sender, EventArgs e)
        {

        }

        private void lb_balace_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void lb_name_Click(object sender, EventArgs e)
        {

        }
    }
}
