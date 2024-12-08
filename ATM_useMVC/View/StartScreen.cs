using ATM_useMVC.Controller;
using ATM_useMVC.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM_useMVC
{
    public partial class StartScreen : Form
    {
        public StartScreen()
        {
            InitializeComponent();
        }
        Check_ATM Check_ATM = new Check_ATM();
        private void txtMachineNo_MouseClick(object sender, MouseEventArgs e)
        {
            txtMachineNo.Text =  "";
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if(txtMachineNo.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã máy!", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMachineNo.Focus();
                
            }
            else
            {
                var rs = Check_ATM.CheckATM(txtMachineNo.Text);
                switch (rs.ErrCode)
                {
                    case Models.EnumErrCode.Success:
                        MessageBox.Show(rs.ErrMsg, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Landing_Page l = new Landing_Page();
                        l.Show();
                        this.Hide();
                        break;
                    case Models.EnumErrCode.Error:
                        MessageBox.Show(rs.ErrMsg, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtMachineNo.Focus();
                        break;

                }
            }
            
        }

        private void labelMachineNo_Click(object sender, EventArgs e)
        {

        }

        private void StartScreen_Load(object sender, EventArgs e)
        {

        }
    }
}
