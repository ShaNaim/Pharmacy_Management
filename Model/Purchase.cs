using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageIT.MedShop.Model
{
    class Purchase
    {
        public int ID { get; set; }
        public float Amount { get; set; }
        public float Price { get; set; }
        public Product Product { get; set; }
        public DateTime PurchaseDate { get; set; }

    }
}
