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
    public partial class Mini : Form
    {
        public Mini()
        {
            InitializeComponent();
        }
        DatabaseDataContext db = new DatabaseDataContext();
        private void btnBack_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Hide();
        }
        Print P = new Print();
        private void btnPrint_Click(object sender, EventArgs e)
        {
            string tmp = "";
            var rs = P.f_print(tmp);
            switch (rs.ErrCode)
            {
                case Models.EnumErrCode.Success:
                    MessageBox.Show(rs.ErrMsg, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    break;
                case Models.EnumErrCode.Error:
                    MessageBox.Show(rs.ErrMsg, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;

            }
        }
        Mini_load M = new Mini_load();

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void Mini_Load(object sender, EventArgs e)
        {
            var rs = M.f_miniload();
            switch (rs.ErrCode)
            {
                case Models.EnumErrCode.Success:
                    dataGridView1.DataSource = rs.Data;
                    break;
                case Models.EnumErrCode.Empty:
                    MessageBox.Show(rs.ErrMsg, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case Models.EnumErrCode.Error:
                    MessageBox.Show(rs.ErrMsg, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;

            }
        }

        private void pbReturnCard_Click(object sender, EventArgs e)
        {
            Landing_Page page = new Landing_Page();
            page.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Landing_Page page = new Landing_Page();
            page.Show();
            this.Hide();
        }

        
    }
}