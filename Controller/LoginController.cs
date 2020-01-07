using ManageIT.MedShop.Model;
using ManageIT.MedShop.Utility;

namespace ManageIT.MedShop.Controller
{
    class LoginController
    {
        private static DataBase db = new DataBase();
        public static void addUser(int id, string password, int status)
        {
            Login login = new Login
            {
                UserId = id,
                UserPassword = password,
                UserStatus = status
            };
            db.Logins.addUser(login);
        }
        public static Login authenticateUser(int id, string password)
        {
            Login user = new Login
            {
                UserId = id,
                UserPassword = password,
                UserStatus = (int)CodeUtility.UserStatus.Helper
            };

            if (db.Logins.authenticateUser(user) == (int)CodeUtility.loginStatus.Accepted)
            {
                return db.Logins.getUser(user);
            }
            return null;
        }
    }
}
