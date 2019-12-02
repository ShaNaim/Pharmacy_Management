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
        public float Amount { get; set; }
        Vender Vender { get; set; }
        public float Price { get; set; }
        public int PaymentType { get; set; }
        public DateTime PurchaseDate { get; set; }
    }
}
