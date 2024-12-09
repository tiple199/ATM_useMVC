using ATM_useMVC.Models;
using ATM_useMVC.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM_useMVC.Controller
{
    internal class Trans_ctrl
    {
        DatabaseDataContext db = new DatabaseDataContext();
        public FunctionResult<Boolean> f_Trans(string txtaccno,int amount)
        {
            FunctionResult<Boolean> result = new FunctionResult<Boolean>();
            
            try
            {
                var checkAccNo = db.Accounts.FirstOrDefault(o => o.AccNo == txtaccno);
                if (checkAccNo != null && checkAccNo.AccNo != Accounts.AccNo)
                {
                    if (amount < Accounts.balance && amount > 0)
                    {
                        // Chèn dữ liệu vào trấnction
                        Transaction trans = new Transaction();
                        trans.Type = "TRANSFER_MONEY";
                        trans.Amount = amount;
                        trans.aFrom = Accounts.AccNo;
                        trans.bTo = txtaccno;
                        trans.Date = DateTime.Now.Date;
                        trans.Time = DateTime.Now.TimeOfDay;
                        trans.MachineID = Machine.MachineID;

                        db.Transactions.InsertOnSubmit(trans);

                        // Xử lý đối phương nhận được tiền
                        checkAccNo.Balance += amount;
                        // Xử lý mình giảm tiền
                        Accounts.balance -= amount;
                        var thisAccount = db.Accounts.FirstOrDefault(o => o.AccNo == Accounts.AccNo);
                        thisAccount.Balance = Accounts.balance;
                        db.SubmitChanges();

                        result.ErrCode = EnumErrCode.Success;
                        result.ErrMsg = "Giao dịch thành công!, Bạn có muốn tiếp tục không?";
                        result.Data = true;

                    }
                    else
                    {
                        result.ErrCode = EnumErrCode.Error;
                        result.ErrMsg = "Số dư tài khoản của bạn không đủ hoặc giá trị chuyển tiền không hợp lệ";
                        result.Data = false;
                    }
                }
                else
                {
                    result.ErrCode = EnumErrCode.Error;
                    result.ErrMsg = "Không tồn tại số tài khoản này hoặc Thẻ không hợp lệ!";
                    result.Data = false;
                }
            }
            catch (Exception ex) {
                result.ErrCode = EnumErrCode.Error;
                result.ErrMsg = ex.Message;
                result.Data = false;
            }
            return result;
        }
    }
}
