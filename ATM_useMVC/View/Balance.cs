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
    public partial class Balance : Form
    {
        public Balance()
        {
            InitializeComponent();
        }
        Print p = new Print();
        private void btnBack_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Hide();
        }

        private void Balance_Load(object sender, EventArgs e)
        {
            txtbalance.Text = Accounts.balance.ToString("N0") + " đ";
            
        }
        
        private void btnPrintRecipt_Click(object sender, EventArgs e)
        {
            var rs = p.f_print(txtbalance.Text);

            switch (rs.ErrCode)
            {
                case Models.EnumErrCode.Success:
                    MessageBox.Show(rs.ErrMsg, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    break;
                case Models.EnumErrCode.Error:
                    MessageBox.Show(rs.ErrMsg, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;

            }

            txtbalance.Text = Accounts.balance.ToString("N0") + " đ";
        }
    }
}
