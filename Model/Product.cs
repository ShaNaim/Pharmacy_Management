using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageIT.MedShop.Model
{
    class Product
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public float AmountLeft { get; set; }
        Vender Vender { get; set; }
    }
}
