using ATM_useMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_useMVC.Controller
{
    internal class Check_login_admin
    {
        DatabaseDataContext db = new DatabaseDataContext();
        public FunctionResult<Boolean> CheckLogin(string tk, string mk)
        {
            FunctionResult<Boolean> result = new FunctionResult<Boolean>();
            var checkCardNo = db.Admins.FirstOrDefault(Card => Card.EmpID == tk);

            if (checkCardNo != null)
            {

                if (checkCardNo.PIN == mk)
                {
                    result.ErrCode = EnumErrCode.Success;
                    result.ErrMsg = "Đăng nhập thành công";
                    result.Data = true;

                }
                else
                {
                    result.ErrCode = EnumErrCode.Error;
                    result.ErrMsg = "Mật khẩu không chính xác!";
                    result.Data = false;
                }
            }
            else
            {
                result.ErrCode = EnumErrCode.Error;
                result.ErrMsg = "ID thẻ không chính xác!";
                result.Data = false;
            }
            return result;
        }
    }
}
