using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_useMVC.Models
{
    internal enum EnumErrCode
    {
        Error = -1,
        Empty = 0,
        Success = 1,
        Invalid_input = 2,
        Duplicate_account = 3,
        Account_not_found = 4,
    }
}
