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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            // Optional: Add initialization logic if needed
        }

        private void btnBalanceInquiry_Click(object sender, EventArgs e)
        {
            Balance balance = new Balance();
            balance.Show();
            this.Hide();
        }

        private void btnCashWithdraw_Click(object sender, EventArgs e)
        {
            Withdraw withdraw = new Withdraw();
            withdraw.Show();
            this.Hide();
        }

        private void btnTransferMoney_Click(object sender, EventArgs e)
        {
            Trans b = new Trans();
            b.Show();
            this.Hide();
        }

        private void btnMiniStatement_Click(object sender, EventArgs e)
        {
            Mini m = new Mini();
            m.Show();
            this.Hide();
        }

        private User LoggedInUser { get; set; }

        // Phương thức kết thúc phiên đăng nhập
        private void EndSession()
        {
            // Xóa thông tin người dùng hiện tại
            LoggedInUser = null;

            // Hiển thị thông báo
            MessageBox.Show("Bạn đã đăng xuất thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Điều hướng về màn hình đăng nhập
            Landing_Page landing_Page = new Landing_Page();
            this.Hide();
            landing_Page.Show();
        }

        // Sự kiện khi nhấn nút "Đăng xuất"
        private void btnLogout_Click(object sender, EventArgs e)
        {
            EndSession();
        }

        // Sự kiện cho "Return Card"
        private void pbReturnCard_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Trả thẻ thành công! Hãy kiểm tra thẻ của bạn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            EndSession();
        }
    }

    // Lớp User đại diện cho thông tin người dùng
    public class User
    {
        public string Name { get; set; }
        public string Email { get; set; }
    }
}
