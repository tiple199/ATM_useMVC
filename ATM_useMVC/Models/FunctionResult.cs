using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_useMVC.Models
{
    internal class FunctionResult<T>
    {
        public EnumErrCode ErrCode { get; set; }
        public string ErrMsg { get; set; }
        public T Data { get; set; }
    }
}
