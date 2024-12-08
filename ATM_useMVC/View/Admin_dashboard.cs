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
    public partial class Admin_dashboard : Form
    {
        public Admin_dashboard()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormATM_Admin formATM_Admin = new FormATM_Admin();
            formATM_Admin.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Check_Reports check_Reports = new Check_Reports();
            check_Reports.Show();
            this.Hide();
        }

        private void btnMngAcc_Click(object sender, EventArgs e)
        {
            manager_user manager_User = new manager_user();
            manager_User.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            manager_card maneger_Card = new manager_card();
            maneger_Card.Show();
            this.Hide();
        }
        // Nút Đăng xuất
        private void btnLogout_Click(object sender, EventArgs e)
        {
            // Quay lại màn hình trước đó (ví dụ: Landing_Page)
            Landing_Page landingPage = new Landing_Page();
            landingPage.Show();
            this.Close();
        }

    }
}
