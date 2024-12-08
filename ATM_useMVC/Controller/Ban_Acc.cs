using ATM_useMVC.Models;
using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_useMVC.Controller
{
    internal class Ban_Acc
    {
        DatabaseDataContext db = new DatabaseDataContext();

        public FunctionResult<Boolean> Ban_acc(string Accno)
        {
            FunctionResult<Boolean> result = new FunctionResult<Boolean>();
            var checkCardNo = db.Accounts.FirstOrDefault(Card => Card.AccNo == Accno);
            checkCardNo.AtmStatus = "Banned";
            db.SubmitChanges();
            result.ErrCode = EnumErrCode.Success;
            result.ErrMsg = "Tài khoản đã tạm thời bị khóa";
            result.Data = true;
            return result;

        }

        public FunctionResult<Boolean> Unlock_acc(string Accno)
        {
            FunctionResult<Boolean> result = new FunctionResult<Boolean>();
            var checkCardNo = db.Accounts.FirstOrDefault(Card => Card.AccNo == Accno);
            checkCardNo.AtmStatus = "Active";
            db.SubmitChanges();
            result.ErrCode = EnumErrCode.Success;
            result.ErrMsg = "Bạn được thử lại một lần nữa!";
            result.Data = true;
            return result;

        }
    }
}
