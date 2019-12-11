using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ManageIT.MedShop.Model;
using System.Collections;
using System.CodeDom;

namespace ManageIT.MedShop.Controller
{
    class VenderController
    {
        static DataBase db = new DataBase();
        public static Vender getVender(int venderId)
        {
            return db.Venders.getVender(venderId);
        }
        public static ArrayList getAllVenderNames()
        {
            return db.Venders.getAllVenderName();
        }
        public static Vender getVenderbyName(string name)
        {
            return db.Venders.getVenderbyName(name);
        }
        public static ArrayList getAllVender()
        {
            return db.Venders.getAllVender();
        }
    }
}
