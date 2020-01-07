using System;

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
