using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageIT.MedShop.Model
{
    class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public double AmountLeft { get; set; }
        public int VenderID { get; set; }
        public Vender vender { get; set; }
    }
}
