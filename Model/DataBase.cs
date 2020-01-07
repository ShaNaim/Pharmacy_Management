namespace ManageIT.MedShop.Model
{
    class DataBase
    {
        public Logins Logins { get; set; }
        public Users Users { get; set; }
        public Products Products { get; set; }
        public Venders Venders { get; set; }
        public Sells Sells { get; set; }
        public Quaters Quaters { get; set; }
        public Purchases Purchases { get; set; }
        public DataBase()
        {
            Logins = new Logins();
            Users = new Users();
            Products = new Products();
            Venders = new Venders();
            Sells = new Sells();
            Quaters = new Quaters();
            Purchases = new Purchases();
        }
    }
}
