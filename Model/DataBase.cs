using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageIT.MedShop.Model
{
    class DataBase
    {
        public Users users { get; set; }
        public Employees employees { get; set; }
        public Products products { get; set; }
        public Venders venders { get; set; }
        public Sells sells { get; set; }
        public DataBase()
        {
            users = new Users();
            employees = new Employees();
            products = new Products();
            venders = new Venders();
            sells = new Sells();
        }
    }
}
