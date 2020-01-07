using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ManageIT.MedShop.Model;
using System.Collections;

namespace ManageIT.MedShop.Controller
{
    class BillingController
    {
        private static DataBase db = new DataBase();
        public static Billng createInvoice()
        {
            Billng invoice = new Billng
            {
                ProductId = 12,
                productName = "alpha",
                unitPrice = 23,
                quantity = 3,
                invoiceId = 1
            };
            return invoice;
        }
    }
}
