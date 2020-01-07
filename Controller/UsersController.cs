using ManageIT.MedShop.Model;
using System;

namespace ManageIT.MedShop.Controller
{
    class UsersController
    {
        static DataBase db = new DataBase();
        public static void addUser(int ID, string Name, int Contact, float Salary, DateTime JoidDate)
        {
            User user = new User
            {
                Id = ID,
                Name = Name,
                Contact = Contact,
                Salary = Salary,
                JoidDate = JoidDate
            };
            db.Users.addUser(user);
        }
        /*
        public static ArrayList getAllUser()
        {
            return db.Users.getAllUser();

        }*/
        public static User getUser(int uid)
        {
            return db.Users.getUser(uid);
        }
    }
}
