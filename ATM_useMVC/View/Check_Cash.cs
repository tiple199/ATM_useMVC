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
    public partial class Check_Cash : Form
    {
        public Check_Cash()
        {
            InitializeComponent();
        }
        Check_Cash_ctrl check = new Check_Cash_ctrl();
        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        public void reload()
        {
            label50000.Text = Machine.n50000.ToString();
            label100000.Text = Machine.n100000.ToString();
            label200000.Text = Machine.n200000.ToString();
            label500000.Text = Machine.n500000.ToString();
            lbAvailable.Text = Machine.totalPrice.ToString("N0") + " đ";
        }
        private void Check_Cash_Load(object sender, EventArgs e)
        {
            reload();
            
        }

        private void btn50000_Click(object sender, EventArgs e)
        {
            try
            {
                var rs = check.AddCash(Convert.ToInt32(tb50000.Text), 50000);
                switch (rs.ErrCode)
                {
                    case Models.EnumErrCode.Success:
                        MessageBox.Show(rs.ErrMsg, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        reload();
                        lbprice50000.Text = (Convert.ToInt32(lbprice50000.Text) + Convert.ToInt32(tb50000.Text)).ToString("N0") + " đ";
                        tb50000.Text = "";
                        break;
                    case Models.EnumErrCode.Error:
                        MessageBox.Show(rs.ErrMsg, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        tb50000.Text = "";
                        break;
                }
            }
            catch (Exception ex) { 
                MessageBox.Show(ex.Message,"Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn100000_Click(object sender, EventArgs e)
        {
            try
            {
                var rs = check.AddCash(Convert.ToInt32(tb100000.Text), 100000);
                switch (rs.ErrCode)
                {
                    case Models.EnumErrCode.Success:
                        MessageBox.Show(rs.ErrMsg, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                        reload();
                        lbprice100000.Text = (Convert.ToInt32(lbprice100000.Text) + Convert.ToInt32(tb100000.Text)).ToString("N0") + " đ";
                        tb100000.Text = "";
                        break;
                    case Models.EnumErrCode.Error:
                        MessageBox.Show(rs.ErrMsg, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        tb100000.Text = "";
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn200000_Click(object sender, EventArgs e)
        {
            try
            {
                var rs = check.AddCash(Convert.ToInt32(tb200000.Text), 200000);
                switch (rs.ErrCode)
                {
                    case Models.EnumErrCode.Success:
                        MessageBox.Show(rs.ErrMsg, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                        reload();
                        
                        lbprice200000.Text = (Convert.ToInt32(lbprice200000.Text) + Convert.ToInt32(tb200000.Text)).ToString("N0") + " đ";
                        tb200000.Text = "";
                        break;
                    case Models.EnumErrCode.Error:
                        MessageBox.Show(rs.ErrMsg, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        tb200000.Text = "";
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn500000_Click(object sender, EventArgs e)
        {
            try
            {
                var rs = check.AddCash(Convert.ToInt32(tb500000.Text), 500000);
                switch (rs.ErrCode)
                {
                    case Models.EnumErrCode.Success:
                        MessageBox.Show(rs.ErrMsg, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                        reload();
                        lbprice500000.Text = (Convert.ToInt32(lbprice500000.Text) + Convert.ToInt32(tb500000.Text)).ToString("N0") + " đ";
                        tb500000.Text = "";
                        break;
                    case Models.EnumErrCode.Error:
                        MessageBox.Show(rs.ErrMsg, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        tb500000.Text = "";
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Admin_dashboard admin_Dashboard = new Admin_dashboard();
            admin_Dashboard.Show();
            this.Hide();
        }

        private void tb50000_MouseClick(object sender, MouseEventArgs e)
        {
            tb50000.Text = "";
            tb50000.ForeColor = Color.Black;
        }

        private void tb100000_MouseClick(object sender, MouseEventArgs e)
        {
            tb100000.Text = "";
            tb100000.ForeColor = Color.Black;
        }

        private void tb200000_MouseClick(object sender, MouseEventArgs e)
        {
            tb200000.Text = "";
            tb200000.ForeColor = Color.Black;
        }

        private void tb500000_MouseClick(object sender, MouseEventArgs e)
        {
            tb200000.Text = "";
            tb200000.ForeColor = Color.Black;
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lbAvailable_Click(object sender, EventArgs e)
        {

        }
    }
}
