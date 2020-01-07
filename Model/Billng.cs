using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageIT.MedShop.Model
{
    class Billng
    {
        public int ProductId { get; set; }
        public string productName { get; set; }
        public double unitPrice { get; set; }
        public double quantity { get; set; }
        public double Price { get { return unitPrice * quantity; } }
        public int invoiceId { get; set; }
    }
}
