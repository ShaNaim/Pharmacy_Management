using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ManageIT.MedShop.Model;

namespace ManageIT.MedShop.Controller
{
    class VenderController
    {
        static DataBase db = new DataBase();
        public static Vender getVender(int venderId)
        {
            return db.Venders.getVender(venderId);
        }
    }
}
