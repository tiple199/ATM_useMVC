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
    public partial class Trans : Form
    {
        public Trans()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Hide();
        }

        private void txtAccNo_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtAmount_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAccNo_MouseClick(object sender, MouseEventArgs e)
        {
            txtAccNo.Text = "";
        }

        private void txtAmount_MouseClick(object sender, MouseEventArgs e)
        {
            txtAmount.Text = "";
        }

        private void pbReturnCard_Click(object sender, EventArgs e)
        {
            Landing_Page landing_Page = new Landing_Page();
            landing_Page.Show();
            this.Hide();
        }

        private void label1_MouseClick(object sender, MouseEventArgs e)
        {
            Landing_Page landing_Page = new Landing_Page();
            landing_Page.Show();
            this.Hide();
        }

        private void Trans_Load(object sender, EventArgs e)
        {
            txtcurrentbalance.Text = Accounts.balance.ToString("N0") + " đ";
        }
        Trans_ctrl T = new Trans_ctrl();
        private void btnTransfer_Click(object sender, EventArgs e)
        {
            try
            {
                var rs = T.f_Trans(txtAccNo.Text, Convert.ToInt32(txtAmount.Text));
                switch (rs.ErrCode)
                {
                    case Models.EnumErrCode.Success:

                        DialogResult result = MessageBox.Show(rs.ErrMsg, "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        if (result == DialogResult.No)
                        {
                            new Dashboard().Show();
                            this.Hide();
                        }
                        else
                        {
                            txtAccNo.Text = "";
                            txtAmount.Text = "";
                            txtcurrentbalance.Text = Accounts.balance.ToString("N0") + " đ";
                        }
                        break;
                    case Models.EnumErrCode.Error:
                        MessageBox.Show(rs.ErrMsg, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;

                }
            }
            catch(Exception ex) {
                MessageBox.Show("Giá trị truyền vào bị lỗi!","Thông báo lỗi",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            
        }
    }
}
