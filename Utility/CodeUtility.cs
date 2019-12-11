using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageIT.MedShop.Utility
{
    public static class CodeUtility
    {
        public enum UserStatus
        {
            Admin = 1,
            Employee = 2,
            Helper = 0
        }
        public enum loginStatus
        {
            Accepted = 202,
            Declined = 404
        }
    }
}
