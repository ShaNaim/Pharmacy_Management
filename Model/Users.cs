using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                int row =DBConnection.ExecuteQuery(query);
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
        public User getUser(User user)
        {
            User user1 = new User();
            return user1;
        }
    }
}
