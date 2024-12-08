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
    public partial class Check_Reports : Form
    {
        public Check_Reports()
        {
            InitializeComponent();
        }
        Check_Report_ctrl check = new Check_Report_ctrl();
        private void btnToday_Click(object sender, EventArgs e)
        {
            var rs = check.report("today");
            switch (rs.ErrCode)
            {
                case Models.EnumErrCode.Success:
                    MessageBox.Show(rs.ErrMsg, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridView1.DataSource = rs.Data;
                    
               
                    break;
                case Models.EnumErrCode.Error:
                    MessageBox.Show(rs.ErrMsg, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
            }
        }

        private void btnYesterday_Click(object sender, EventArgs e)
        {
            var rs = check.report("yesterday");
            switch (rs.ErrCode)
            {
                case Models.EnumErrCode.Success:
                    MessageBox.Show(rs.ErrMsg, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridView1.DataSource = rs.Data;


                    break;
                case Models.EnumErrCode.Error:
                    MessageBox.Show(rs.ErrMsg, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
            }
        }

        private void btnLastWeek_Click(object sender, EventArgs e)
        {
            var rs = check.report(null);
            switch (rs.ErrCode)
            {
                case Models.EnumErrCode.Success:
                    MessageBox.Show(rs.ErrMsg, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridView1.DataSource = rs.Data;


                    break;
                case Models.EnumErrCode.Error:
                    MessageBox.Show(rs.ErrMsg, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Admin_dashboard admin_Dashboard = new Admin_dashboard();
            admin_Dashboard.Show();
            this.Hide();
        }
    }
}
