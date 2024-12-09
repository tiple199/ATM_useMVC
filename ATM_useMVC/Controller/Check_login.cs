using ATM_useMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM_useMVC.Controller
{
    internal class Check_login
    {
        DatabaseDataContext db = new DatabaseDataContext();

        public FunctionResult<Boolean> CheckLogin(string cardNo,string Pin)
        {
            FunctionResult<Boolean> result = new FunctionResult<Boolean>();
            var checkCardNo = db.Accounts.FirstOrDefault(Card => Card.AccNo == cardNo);

            if (checkCardNo != null)
            {
                if (checkCardNo.AtmStatus == "Active") {
                    if (checkCardNo.PIN == Pin)
                    {           
                         Accounts.AccNo = cardNo;
                         Accounts.balance = Convert.ToInt32(checkCardNo.Balance);
                         Accounts.AtmStatus = checkCardNo.AtmStatus;
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
                    result.ErrMsg = "Thẻ đã hết hạn hoặc bị khóa";
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
