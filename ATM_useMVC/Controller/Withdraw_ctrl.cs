using ATM_useMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM_useMVC.Controller
{
    
    internal class Withdraw_ctrl
    {
        DatabaseDataContext db = new DatabaseDataContext();
        public FunctionResult<Boolean> f_withdraw(string txtAmount) { 
            FunctionResult<Boolean> result = new FunctionResult<Boolean>();

            if (txtAmount == "" || txtAmount == "0000.00")
            {
                result.ErrCode = EnumErrCode.Error;
                result.ErrMsg = "Bạn cần nhập số tiền trước khi rút!";
                result.Data = false;
            }
            else
            {
                try
                {
                    int Amount = Convert.ToInt32(txtAmount);
                    if (Amount <= Accounts.balance && Amount <= Machine.totalPrice && Amount % 50000 == 0 && Amount >= 100000)
                    {
                        int[] value_cash = { 500000, 200000, 100000, 50000 };
                        int[] count = { 0, 0, 0, 0 };
                        int[] machine_cash = { Machine.n500000, Machine.n200000, Machine.n100000, Machine.n50000 };
                        int remaining = Amount;
                        for (int i = 0; i < value_cash.Length; i++)
                        {
                            if (Amount < value_cash[i])
                            {
                                continue;
                            }
                            else
                            {
                                count[i] = Math.Min(remaining / value_cash[i], machine_cash[i]);
                                remaining -= count[i] * value_cash[i];
                            }

                        }
                        if (remaining == 0)
                        {
                            // Xử lý cập nhật tiền trong ATM

                            var atmMachine = db.AtmMachines.FirstOrDefault(x => x.MachineID == Machine.MachineID);
                            atmMachine.n500000 -= count[0];
                            atmMachine.n200000 -= count[1];
                            atmMachine.n100000 -= count[2];
                            atmMachine.n50000 -= count[3];
                            atmMachine.TotalCash -= Amount;


                            Machine.n500000 = Convert.ToInt32(atmMachine.n500000);
                            Machine.n200000 = Convert.ToInt32(atmMachine.n200000);
                            Machine.n100000 = Convert.ToInt32(atmMachine.n100000);
                            Machine.n50000 = Convert.ToInt32(atmMachine.n50000);
                            Machine.totalPrice = Convert.ToInt32(atmMachine.TotalCash);

                            // Xử lý chèn vào Transaction
                            Transaction tran = new Transaction();
                            tran.aFrom = Accounts.AccNo;
                            tran.Amount = Amount;
                            tran.Type = "WITHDRAW";
                            tran.bTo = String.Empty;
                            tran.Date = DateTime.Now.Date;
                            tran.Time = DateTime.Now.TimeOfDay;
                            tran.MachineID = Machine.MachineID;

                            db.Transactions.InsertOnSubmit(tran);
                            // Xử lý cập nhật tiền

                            var balance = db.Accounts.FirstOrDefault(o => o.AccNo == Accounts.AccNo);
                            if (balance != null)
                            {
                                balance.Balance -= Amount;
                                Accounts.balance = Convert.ToInt32(balance.Balance);
                                db.SubmitChanges();
                                result.ErrCode = EnumErrCode.Success;
                                result.ErrMsg = $"Rút tiền thành công!\nSố tiền: {Amount}\n500000: {count[0]} tờ\n200000: {count[1]} tờ\n100000: {count[2]} tờ\n50000: {count[3]} tờ";
                                result.Data = true;
                            }
                        }
                        else
                        {
                            result.ErrCode = EnumErrCode.Error;
                            result.ErrMsg = "Máy không có đủ mệnh giá phù hợp!";
                            result.Data = false;
                        }
                    }
                    else
                    {
                        result.ErrCode = EnumErrCode.Error;
                        result.ErrMsg = "Giá trị nhập không đúng hoặc máy ATM không đủ tiền";
                        result.Data = false;
                    }
                }
                catch (Exception ex) {
                    result.ErrCode = EnumErrCode.Error;
                    result.ErrMsg = ex.Message;
                    result.Data = false;
                }
            }
            return result;
        }
    }
}
