using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageIT.MedShop.Model
{
    class Logins
    {
        public void authenticateUser(Login user)
        {

        }
        public void addUser(Login user)
        {
            string query = "insert into LoginTable(UserId,Password,Status) "
                    + "values('" + user.UserId + "','" + user.UserPassword + "','" + user.UserStatus + "')";
            try
            {
               int row = DBConnection.ExecuteQuery(query);
            }
            catch (Exception)
            {

                throw;
            }
        }
        public void deleteUser(Login user)
        {

        }
        public void updateUser(Login user)
        {

        }
    }
}
