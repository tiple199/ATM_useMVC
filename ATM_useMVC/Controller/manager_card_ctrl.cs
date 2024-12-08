using ATM_useMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_useMVC.Controller
{
    internal class manager_card_ctrl
    {
        DatabaseDataContext db = new DatabaseDataContext();

        public FunctionResult<Account> GetCard(string sothe)
        {
            FunctionResult<Account> rs = new FunctionResult<Account>();
            try
            {
                var qr = db.Accounts.FirstOrDefault(o => o.AccNo == sothe);
                if (qr != null)
                {
                    // error code = success
                    rs.ErrCode = EnumErrCode.Success;
                    rs.ErrMsg = "Lấy dữ liệu thành công";
                    rs.Data = qr;
                }
                else
                {
                    // error code = Empty
                    rs.ErrCode = EnumErrCode.Empty;
                    rs.ErrMsg = "Không tồn tại số thẻ";
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
        public FunctionResult<Account> Active(string tk)
        {
            FunctionResult<Account> rs = new FunctionResult<Account>();

            try
            {
                // Tìm tài khoản cần xóa trong cơ sở dữ liệu
                var accountToActive = db.Accounts.FirstOrDefault(acc => acc.AccNo == tk);
                if (accountToActive == null)
                {
                    rs.ErrCode = EnumErrCode.Account_not_found;
                    rs.ErrMsg = "Không tìm thấy số tài khoản để xóa";
                    rs.Data = null;
                    return rs;
                }
                // Kích hoạt tài khoản nếu tìm thấy
                accountToActive.AtmStatus = "Active";
                db.SubmitChanges();

                rs.ErrCode = EnumErrCode.Success;
                rs.ErrMsg = "Kích hoạt tài khoản thành công";
                rs.Data = accountToActive;
            }
            catch (Exception ex)
            {
                rs.ErrCode = EnumErrCode.Error;
                rs.ErrMsg = "Có lỗi xáy ra trong quá trình kích hoạt tài khoản: " + ex.Message;
                rs.Data = null;
            }
            return rs;
        }
        public FunctionResult<Account> Ban(string tk)
        {
            FunctionResult<Account> rs = new FunctionResult<Account>();

            try
            {
                // Tìm tài khoản cần xóa trong cơ sở dữ liệu
                var accountToActive = db.Accounts.FirstOrDefault(acc => acc.AccNo == tk);
                if (accountToActive == null)
                {
                    rs.ErrCode = EnumErrCode.Account_not_found;
                    rs.ErrMsg = "Không tìm thấy số tài khoản để Cấm";
                    rs.Data = null;
                    return rs;
                }
                // Kích hoạt tài khoản nếu tìm thấy
                accountToActive.AtmStatus = "Banned";
                db.SubmitChanges();

                rs.ErrCode = EnumErrCode.Success;
                rs.ErrMsg = "Cấm hoạt tài khoản thành công";
                rs.Data = accountToActive;
            }
            catch (Exception ex)
            {
                rs.ErrCode = EnumErrCode.Error;
                rs.ErrMsg = "Có lỗi xáy ra trong quá trình cấm tài khoản: " + ex.Message;
                rs.Data = null;
            }
            return rs;
        }
    }
}
