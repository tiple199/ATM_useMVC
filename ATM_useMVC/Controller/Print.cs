using ATM_useMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM_useMVC.Controller
{
    internal class Print
    {
        DatabaseDataContext db = new DatabaseDataContext();
        public FunctionResult<Boolean> f_print(string txtbalance)
        {
            int price_print = 5000;
            FunctionResult<Boolean> result = new FunctionResult<Boolean>();
            try
            {
                if (Accounts.balance > price_print)
                {
                    Transaction trans = new Transaction();
                    trans.Type = "DEDUCTION";
                    trans.Amount = price_print;
                    trans.aFrom = Accounts.AccNo;
                    trans.bTo = String.Empty;
                    trans.Date = DateTime.Now.Date;
                    trans.Time = DateTime.Now.TimeOfDay;
                    trans.MachineID = Machine.MachineID;
                    db.Transactions.InsertOnSubmit(trans);


                    var balance = db.Accounts.FirstOrDefault(o => o.AccNo == Accounts.AccNo);
                    if (balance != null)
                    {
                        balance.Balance -= price_print;
                        Accounts.balance = Convert.ToInt32(balance.Balance.ToString());
                        db.SubmitChanges();
                        txtbalance = balance.Balance.ToString();
                        result.ErrCode = EnumErrCode.Success;
                        result.ErrMsg = "Biên lai đã phát hành!";
                        result.Data = true;
                    }
                    
                }
                else
                {
                    result.ErrCode = EnumErrCode.Error;
                    result.ErrMsg = "Tài khoản bạn cần phải có trên 5000 mới được in hóa đơn";
                    result.Data = true;
                }
            }
            catch (Exception ex)
            {
                result.ErrCode = EnumErrCode.Error;
                result.ErrMsg = ex.Message;
                result.Data = true;

            }
            return result;
        }
    }
}
