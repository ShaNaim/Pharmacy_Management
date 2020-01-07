using System;
using System.Collections;
using System.Data.SqlClient;

namespace ManageIT.MedShop.Model
{
    class Users
    {
        public void addUser(User user)
        {
            string query = "insert into Users(UserId,Name,Contact,Salary,JoinDate) "
                    + "values('" + user.Id + "','" + user.Name + "','" + user.Contact + "','" + user.Salary + "','" + user.JoidDate + "')";
            try
            {
                int row = DBConnection.ExecuteQuery(query);
            }
            catch (Exception)
            {

                throw;
            }
        }
        public void deleteUser(User employee)
        {

        }
        public void updateUser(User employee)
        {

        }
        public ArrayList getAllUser()
        {
            ArrayList a = new ArrayList();
            return a;
        }
        public User getUser(int userId)
        {
            string query = "SELECT * FROM Users WHERE UserId = '" + userId + "'; ";
            try
            {
                SqlDataReader reader = DBConnection.getReader(query);

                while (reader.Read())
                {
                    User user = new User()
                    {

                        Id = reader.GetInt32(reader.GetOrdinal("UserId")),
                        Name = reader.GetString(reader.GetOrdinal("Name")),
                        Contact = reader.GetInt32(reader.GetOrdinal("Contact")),
                        Salary = (float)reader.GetDouble(reader.GetOrdinal("Salary")),
                        JoidDate = reader.GetDateTime(reader.GetOrdinal("JoinDate"))

                    };
                    if (user != null)
                    {
                        return user;
                    }
                    else
                    {
                        return null;
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
            return null;
        }
    }
}
