using ATM_useMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM_useMVC.Controller
{
    internal class Check_ATM
    {
        DatabaseDataContext db = new DatabaseDataContext();
        public FunctionResult<Boolean> CheckATM(string txtMachine_id)
        {
            FunctionResult<Boolean> result = new FunctionResult<Boolean>();
            var checkmachine = db.AtmMachines.FirstOrDefault(machine => machine.MachineID == txtMachine_id);

            if (checkmachine != null)
            {
                Machine.n500000 = Convert.ToInt32(checkmachine.n500000);
                Machine.n200000 = Convert.ToInt32(checkmachine.n200000);
                Machine.n100000 = Convert.ToInt32(checkmachine.n100000);
                Machine.n50000 = Convert.ToInt32(checkmachine.n50000);
                Machine.totalPrice = Convert.ToInt32(checkmachine.TotalCash);
                Machine.MachineID = txtMachine_id;

                result.ErrCode = EnumErrCode.Success;
                result.ErrMsg = "Xác nhận thành công";
                result.Data = true;
            }
            else
            {
                result.ErrCode = EnumErrCode.Error;
                result.ErrMsg = "Không tồn tại mã cây ATM này";
                result.Data = false;
            }
            return result;
        }

    }
}
