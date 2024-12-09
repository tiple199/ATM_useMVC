using ATM_useMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM_useMVC.Controller
{
    internal class Check_Cash_ctrl
    {
        DatabaseDataContext db = new DatabaseDataContext();
        public FunctionResult<Boolean> AddCash(int price,int cash)
        {
            FunctionResult<Boolean> result = new FunctionResult<Boolean>();
            try
            {
                int quantity_cash;
                if (price % cash == 0 && price >= cash)
                {
                    if(cash == 50000)
                    {
                        quantity_cash = Machine.n50000;
                    }
                    else if(cash == 100000)
                    {
                        quantity_cash = Machine.n100000;
                    }
                    else if(cash == 200000)
                    {
                        quantity_cash = Machine.n200000;
                    }
                    else
                    {
                        quantity_cash = Machine.n500000;
                    }
                    int RC = 500 - quantity_cash; // Số lượng tờ có thể thêm vào
                    int newcash = price / cash + quantity_cash; // Số lượng tờ 500 mới
                    int newBalance = price + Machine.totalPrice;
                    if (price / cash <= RC)
                    {
                        // Truy xuất máy ATM với ID tương ứng
                        var atmMachine = db.AtmMachines.FirstOrDefault(m => m.MachineID == Machine.MachineID);

                        // Kiểm tra xem máy ATM có tồn tại không
                        if (atmMachine != null)
                        {

                            // Cập nhật thông tin máy ATM
                            atmMachine.TotalCash = newBalance;
                            Machine.totalPrice = newBalance;
                            
                            if (cash == 50000)
                            {
                           
                                atmMachine.n50000 = newcash;
                                Machine.n50000 = (int)atmMachine.n50000;
                            }
                            else if (cash == 100000)
                            {
                                atmMachine.n100000 = newcash;
                                Machine.n100000 = (int)atmMachine.n100000;
                            }
                            else if (cash == 200000)
                            {
                                atmMachine.n200000 = newcash;
                                Machine.n200000 = (int)atmMachine.n200000;
                            }
                            else
                            {
                                atmMachine.n500000 = newcash;
                                Machine.n500000 = (int)atmMachine.n500000;
                            }
                            // Lưu thay đổi vào cơ sở dữ liệu
                            db.SubmitChanges();
                            

                            result.ErrCode = EnumErrCode.Success;
                            result.ErrMsg = "Thêm tiền thành công!";
                            result.Data = true;
                            

                            
                            
                        }
                        else
                        {
                            result.ErrCode = EnumErrCode.Error;
                            result.ErrMsg = "Không tìm thấy máy ATM với ID được cung cấp!";
                            result.Data = false;
                        }
                    }
                    else
                    {
                        result.ErrCode = EnumErrCode.Error;
                        result.ErrMsg = "Số tiền không được vượt quá 500 tờ tiền của mỗi loại";
                        result.Data = false;
                    }

                }
                else
                {
                    result.ErrCode = EnumErrCode.Error;
                    result.ErrMsg = "Số tiền thêm vào phải là bội số của số tiền cần thêm!";
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
