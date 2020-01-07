namespace ManageIT.MedShop.Model
{
    class Sell
    {
        public string ID { get; set; }
        public float Amounteft { get; set; }
        public float Sold { get; set; }
        public Product product { get; set; }
        public Quater Quater { get; set; }
    }
}
