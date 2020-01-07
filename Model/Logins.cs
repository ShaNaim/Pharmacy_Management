using ManageIT.MedShop.Utility;
using System;
using System.Data.SqlClient;

namespace ManageIT.MedShop.Model
{
    class Logins
    {
        public int authenticateUser(Login user)
        {
            Login authenticateUser = getUser(user);

            if (authenticateUser != null)
            {
                if (authenticateUser.UserId == user.UserId)
                {
                    if (authenticateUser.UserPassword == user.UserPassword)
                    {
                        return (int)CodeUtility.loginStatus.Accepted;
                    }
                }
            }
            return (int)CodeUtility.loginStatus.Declined;
        }
        public Login getUser(Login user)
        {
            Login loginUser = new Login();
            string query = "SELECT * FROM LoginTable WHERE UserId = '" + user.UserId + "'; ";
            try
            {
                SqlDataReader reader = DBConnection.getReader(query);

                while (reader.Read())
                {
                    loginUser = new Login()
                    {
                        UserId = reader.GetInt32(reader.GetOrdinal("UserId")),
                        UserPassword = reader.GetString(reader.GetOrdinal("Password")),
                        UserStatus = reader.GetInt32(reader.GetOrdinal("Status"))
                    };
                }
            }
            catch (Exception)
            {
                throw;
            }
            if (loginUser.UserId == user.UserId)
            {
                return loginUser;
            }
            return null;
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
