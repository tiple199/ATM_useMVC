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
    public partial class Withdraw : Form
    {
        public Withdraw()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Hide();
        }

        private void btn100000_Click(object sender, EventArgs e)
        {
            txtAmount.Text = btn100000.Text.Replace(" đ","");
            txtAmount.ForeColor = Color.Black;
        }

        private void btn200000_Click(object sender, EventArgs e)
        {
            txtAmount.Text = btn200000.Text.Replace(" đ", "");
            txtAmount.ForeColor = Color.Black;
        }

        private void btn500000_Click(object sender, EventArgs e)
        {
            txtAmount.Text = btn500000.Text.Replace(" đ", "");
            txtAmount.ForeColor = Color.Black;
        }

        private void btn1000000_Click(object sender, EventArgs e)
        {
            txtAmount.Text = btn1000000.Text.Replace(" đ", "");
            txtAmount.ForeColor = Color.Black;
        }

        private void pbReturnCard_Click(object sender, EventArgs e)
        {
            Landing_Page landing = new Landing_Page();
            landing.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Landing_Page landing = new Landing_Page();
            landing.Show();
            this.Hide();
        }
        Withdraw_ctrl w = new Withdraw_ctrl();
        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            string input = txtAmount.Text;
            string cleanedInput = input.Replace(".", "");
            var rs = w.f_withdraw(cleanedInput);
            switch (rs.ErrCode)
            {
                case Models.EnumErrCode.Success:
                    MessageBox.Show(rs.ErrMsg, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtAmount.Text = "";
                    break;
                case Models.EnumErrCode.Error:
                    MessageBox.Show(rs.ErrMsg, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtAmount.Text = "";
                    break;

            }
            
        }

        private void txtAmount_MouseClick(object sender, MouseEventArgs e)
        {
            txtAmount.Text = "";
        }

        private void Withdraw_Load(object sender, EventArgs e)
        {

        }
    }
}
