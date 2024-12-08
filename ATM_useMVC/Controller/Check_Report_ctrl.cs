using ATM_useMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM_useMVC.Controller
{
    internal class Check_Report_ctrl
    {
        DatabaseDataContext db = new DatabaseDataContext();
        public FunctionResult<List<Transaction>> report(string type)
        {
            FunctionResult<List<Transaction>> result = new FunctionResult<List<Transaction>>();
            if (type == "today")
            {
                var data_statement = db.Transactions
                                   .Where(t => t.Date == DateTime.Now.Date);
                if (data_statement.Any())
                {
                    result.ErrCode = EnumErrCode.Success;
                    result.ErrMsg = "Lấy dữ liệu thành công";
                    result.Data = data_statement.ToList();
                }
                else
                {
                    result.ErrCode = EnumErrCode.Error;
                    result.ErrMsg = "Không có dữ liệu trong database";
                    result.Data = null;
                }
            }
            else if(type == "yesterday")
            {
                var data_statement = db.Transactions
                                   .Where(t => t.Date == DateTime.Now.AddDays(-1).Date);
                if (data_statement.Any())
                {
                    result.ErrCode = EnumErrCode.Success;
                    result.ErrMsg = "Lấy dữ liệu thành công";
                    result.Data = data_statement.ToList();
                }
                else
                {
                    result.ErrCode = EnumErrCode.Error;
                    result.ErrMsg = "Không có dữ liệu trong database";
                    result.Data = null;
                }
            }

            else
            {
                var data_statement = db.Transactions;
                if (data_statement.Any())
                {
                    result.ErrCode = EnumErrCode.Success;
                    result.ErrMsg = "Lấy dữ liệu thành công";
                    result.Data = data_statement.ToList();
                }
                else
                {
                    result.ErrCode = EnumErrCode.Error;
                    result.ErrMsg = "Không có dữ liệu trong database";
                    result.Data = null;
                }
            }
            
            // Hiển thị dữ liệu lên DataGridView
            
            return result;
        }
    }
}
