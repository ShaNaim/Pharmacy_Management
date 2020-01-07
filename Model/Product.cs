namespace ManageIT.MedShop.Model
{
    class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public double AmountLeft { get; set; }
        public double UnitPrice { get; set; }
        public Vender vender { get; set; }

    }
}
