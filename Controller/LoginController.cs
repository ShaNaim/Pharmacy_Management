using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ManageIT.MedShop.Model;

namespace ManageIT.MedShop.Controller
{
    class LoginController
    {
        public static DataBase db = new DataBase();
        public static void addUser(int id,string password,int status)
        {
            Login login = new Login
            {
                UserId = id,
                UserPassword = password,
                UserStatus = status
            };
            db.Logins.addUser(login);
        }
    }
}
