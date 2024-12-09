using ATM_useMVC.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM_useMVC.Controller
{
    internal class Mini_load
    {
        DatabaseDataContext db = new DatabaseDataContext();
        public FunctionResult<List<Transaction>> f_miniload()
        {
            FunctionResult<List<Transaction>> result = new FunctionResult<List<Transaction>>();
            var qr = db.Transactions.Where(o => o.aFrom == Accounts.AccNo || o.bTo == Accounts.AccNo);



            try
            {
                if (qr.Any())
                {
                    result.ErrCode = EnumErrCode.Success;
                    result.ErrMsg = "";
                    result.Data = qr.ToList();
                }
                else
                {
                    result.ErrCode = EnumErrCode.Empty;
                    result.ErrMsg = "Không có dữ liệu trong CSDL";
                    result.Data = null;
                }
            }
            catch (Exception ex) {
                result.ErrCode = EnumErrCode.Error;
                result.ErrMsg = ex.Message;
                result.Data = null;
            }
            return result;
        }
    }
}
