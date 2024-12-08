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
    public partial class manager_user : Form
    {
        public manager_user()
        {
            InitializeComponent();
        }
        manager_User_Ctrl m_user = new manager_User_Ctrl();
        private void tbSothe_MouseClick(object sender, MouseEventArgs e)
        {
            
            tbSothe.ForeColor = Color.Black;
        }

        private void tbPin_MouseClick(object sender, MouseEventArgs e)
        {
            
            tbPin.ForeColor = Color.Black;
        }

        private void tbName_MouseClick(object sender, MouseEventArgs e)
        {
            
            tbName.ForeColor = Color.Black;
        }

        private void tbBalance_MouseClick(object sender, MouseEventArgs e)
        {
            
            tbBalance.ForeColor = Color.Black;
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Admin_dashboard admin_Dashboard = new Admin_dashboard();
            admin_Dashboard.Show();
            this.Hide();
        }
        public void LoadData()
        {
            var rs = m_user.GetAll();

            switch (rs.ErrCode)
            {
                case EnumErrCode.Error:
                    MessageBox.Show("Không thể lấy được giá trị", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case EnumErrCode.Empty:
                    MessageBox.Show("Không có giá trị nào trong bảng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case EnumErrCode.Success:
                    dataGridView1.DataSource = rs.Data;
                    break;
            }
        }
        private void manager_user_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            // Thêm tài khoản
            string sothe = tbSothe.Text;
            string pin = tbPin.Text;
            string name = tbName.Text;
            int balance;
            if (int.TryParse(tbBalance.Text, out balance))
            {
                // Thành công, biến tk chứa giá trị int
            }
            else
            {
                // Xử lý trường hợp không phải là số hợp lệ
                MessageBox.Show("Vui lòng nhập một số hợp lệ.");
            }

            var rs = m_user.Add(sothe, pin, name, balance);
            switch (rs.ErrCode)
            {
                case Models.EnumErrCode.Success:
                    //dataGridView1.DataSource = rs.Data;
                    MessageBox.Show("Thêm tài khoản thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                    break;
                case Models.EnumErrCode.Error:
                    MessageBox.Show(rs.ErrMsg, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case Models.EnumErrCode.Empty:
                    MessageBox.Show(rs.ErrMsg, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case Models.EnumErrCode.Invalid_input:
                    MessageBox.Show(rs.ErrMsg, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case Models.EnumErrCode.Duplicate_account:
                    MessageBox.Show(rs.ErrMsg, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }

            // Xóa trống các ô
            tbSothe.Text = "";
            tbPin.Text = "";
            tbName.Text = "";
            tbBalance.Text = "";
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            // Sửa tài khoản
            string sothe = tbSothe.Text;
            string pin = tbPin.Text;
            string name = tbName.Text;
            int balance;
            if (int.TryParse(tbBalance.Text, out balance))
            {
                // Thành công, biến tk chứa giá trị int
            }
            else
            {
                // Xử lý trường hợp không phải là số hợp lệ
                MessageBox.Show("Vui lòng nhập một số hợp lệ.");
            }

            var rs = m_user.Edit(sothe, pin, name, balance);
            switch (rs.ErrCode)
            {
                case Models.EnumErrCode.Success:
                    dataGridView1.DataSource = rs.Data;
                    MessageBox.Show("Sửa tài khoản thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                    break;
                case Models.EnumErrCode.Error:
                    MessageBox.Show(rs.ErrMsg, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case Models.EnumErrCode.Empty:
                    MessageBox.Show(rs.ErrMsg, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case Models.EnumErrCode.Invalid_input:
                    MessageBox.Show(rs.ErrMsg, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case Models.EnumErrCode.Account_not_found:
                    MessageBox.Show(rs.ErrMsg, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            string sothe = tbSothe.Text; // Giả sử tbSothe là nơi người dùng nhập số thẻ cần xóa

            // Kiểm tra nếu số thẻ không rỗng
            if (!String.IsNullOrEmpty(sothe))
            {
                // Hiển thị hộp thoại xác nhận xóa
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa tài khoản này không?",
                                                      "Xác nhận xóa",
                                                      MessageBoxButtons.YesNo,
                                                      MessageBoxIcon.Question);

                // Kiểm tra nếu người dùng chọn Yes
                if (result == DialogResult.Yes)
                {
                    var rs = m_user.Delete(sothe);
                    switch (rs.ErrCode)
                    {
                        case Models.EnumErrCode.Success:
                            dataGridView1.DataSource = rs.Data;
                            MessageBox.Show("Xóa tài khoản thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadData();
                            break;
                        case Models.EnumErrCode.Error:
                            MessageBox.Show(rs.ErrMsg, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        case Models.EnumErrCode.Account_not_found:
                            MessageBox.Show(rs.ErrMsg, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                    }
                    // Xóa trống ô text
                    tbSothe.Text = "";
                    tbPin.Text = "";
                    tbName.Text = "";
                    tbBalance.Text = "";
                }
                else
                {
                    // Nếu người dùng chọn No thì không làm gì
                    MessageBox.Show("Hành động xóa đã bị hủy.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập số thẻ cần xóa.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var r = (DataGridViewRow)dataGridView1.Rows[e.RowIndex];
            tbSothe.Text = r.Cells[0].Value.ToString();
            tbPin.Text = r.Cells[1].Value.ToString();
            tbName.Text = r.Cells[2].Value.ToString();
            tbBalance.Text = r.Cells[3].Value.ToString();
        }
    }
}
