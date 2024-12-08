using ATM_useMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_useMVC.Controller
{
    internal class manager_User_Ctrl
    {
        DatabaseDataContext db = new DatabaseDataContext();

        public FunctionResult<List<Account>> GetAll()
        {
            FunctionResult<List<Account>> rs = new FunctionResult<List<Account>>();
            try
            {
                var qr = db.Accounts;
                if (qr.Any())
                {
                    // error code = success
                    rs.ErrCode = EnumErrCode.Success;
                    rs.ErrMsg = "Lấy dữ liệu thành công";
                    rs.Data = qr.ToList();
                }
                else
                {
                    // error code = Empty
                    rs.ErrCode = EnumErrCode.Empty;
                    rs.ErrMsg = "Không có dữ liệu trong CSDL";
                    rs.Data = null;
                }
            }
            catch (Exception ex)
            {
                rs.ErrCode = EnumErrCode.Error;
                rs.ErrMsg = "Có lỗi xáy ra trong quá trình lấy dữ liệu";
                rs.Data = null;
            }
            return rs;
        }


        public FunctionResult<List<Account>> Add(string tk, string mk, string name, int balance)
        {
            FunctionResult<List<Account>> rs = new FunctionResult<List<Account>>();
            try
            {
                // Validate input
                if (string.IsNullOrEmpty(tk) || string.IsNullOrEmpty(mk) || string.IsNullOrEmpty(name) || string.IsNullOrEmpty(balance.ToString()))
                {
                    rs.ErrCode = EnumErrCode.Invalid_input;
                    rs.ErrMsg = "Vui lòng nhập các trường dữ liệu";
                    rs.Data = null;
                    return rs;
                }

                // Kiểm tra xem số tài khoản đã tồn tại chưa
                var existingAccount = db.Accounts.SingleOrDefault(a => a.AccNo == tk);
                if (existingAccount != null)
                {
                    rs.ErrCode = EnumErrCode.Duplicate_account;
                    rs.ErrMsg = "Số tài khoản này đã tồn tại";
                    rs.Data = null;
                    return rs;
                }

                Account obj = new Account();
                // Thuật toán thêm mới
                obj.AccNo = tk;
                obj.PIN = mk;
                obj.Title = name;
                obj.Balance = balance;

                // Thêm tài khoản mới vào cơ sở dữ liệu
                db.Accounts.InsertOnSubmit(obj);
                db.SubmitChanges();

                rs.ErrCode = EnumErrCode.Success;
                rs.ErrMsg = "Thêm tài khoản thành công";
                rs.Data = new List<Account> { obj };
            }
            catch (Exception ex)
            {
                rs.ErrCode = EnumErrCode.Error;
                rs.ErrMsg = "Có lỗi xáy ra trong quá trình thêm dữ liệu: " + ex.Message;
                rs.Data = null;
            }
            return rs;
        }


        public FunctionResult<List<Account>> Edit(string tk, string mk, string name, int balance)
        {
            FunctionResult<List<Account>> rs = new FunctionResult<List<Account>>();
            try
            {
                // Validate input
                if (string.IsNullOrEmpty(tk) || string.IsNullOrEmpty(mk) || string.IsNullOrEmpty(name) || string.IsNullOrEmpty(balance.ToString()))
                {
                    rs.ErrCode = EnumErrCode.Invalid_input;
                    rs.ErrMsg = "Vui lòng nhập các trường dữ liệu";
                    rs.Data = null;
                    return rs;
                }

                // Kiểm tra xem số tài khoản có tồn tại hay không
                var existingAccount = db.Accounts.SingleOrDefault(a => a.AccNo == tk);
                if (existingAccount == null)
                {
                    rs.ErrCode = EnumErrCode.Account_not_found;
                    rs.ErrMsg = "Không tìm thấy số tài khoản này";
                    rs.Data = null;
                    return rs;
                }

                // Cập nhật thông tin tài khoản
                existingAccount.PIN = mk;
                existingAccount.Title = name;
                existingAccount.Balance = balance;

                // Lưu thay đổi vào cơ sở dữ liệu
                db.SubmitChanges();

                rs.ErrCode = EnumErrCode.Success;
                rs.ErrMsg = "Sửa tài khoản thành công";
                rs.Data = new List<Account> { existingAccount };
            }
            catch (Exception ex)
            {
                rs.ErrCode = EnumErrCode.Error;
                rs.ErrMsg = "Có lỗi xáy ra trong quá trình sửa tài khoản: " + ex.Message;
                rs.Data = null;
            }
            return rs;
        }



        public FunctionResult<List<Account>> Delete(string tk)
        {
            FunctionResult<List<Account>> rs = new FunctionResult<List<Account>>();

            try
            {
                // Tìm tài khoản cần xóa trong cơ sở dữ liệu
                var accountToDelete = db.Accounts.FirstOrDefault(acc => acc.AccNo == tk);
                if (accountToDelete == null)
                {
                    rs.ErrCode = EnumErrCode.Account_not_found;
                    rs.ErrMsg = "Không tìm thấy số tài khoản để Kích hoạt";
                    rs.Data = null;
                    return rs;
                }
                // Xóa tài khoản nếu tìm thấy
                db.Accounts.DeleteOnSubmit(accountToDelete);
                db.SubmitChanges();

                rs.ErrCode = EnumErrCode.Success;
                rs.ErrMsg = "Xóa tài khoản thành công";
                rs.Data = null;
            }
            catch (Exception ex)
            {
                rs.ErrCode = EnumErrCode.Error;
                rs.ErrMsg = "Có lỗi xáy ra trong quá trình sửa tài khoản: " + ex.Message;
                rs.Data = null;
            }
            return rs;
        }

    }
}
