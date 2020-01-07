using ManageIT.MedShop.Model;
using System.Collections;

namespace ManageIT.MedShop.Controller
{
    class ProductController
    {
        static DataBase db = new DataBase();
        public static void addProduct(int id, string name, string venderName, double amountLeft,double price)
        {
            Product product = new Product
            {
                ID = id,
                Name = name,
                AmountLeft = amountLeft,
                UnitPrice = price,
                vender = VenderController.getVender(VenderController.getVenderbyName(venderName).ID)
            };
            db.Products.addProduct(product);
        }

        public static ArrayList getAllProduct()
        {
            return db.Products.getAllProduct();
        }

        public static void deleteProduct(int productId)
        {
            db.Products.deleteProduct(productId);
        }

        public static void updateProduct(int id, string name, double amountLeft,double price)
        {
            Product product = new Product
            {
                ID = id,
                Name = name,
                AmountLeft = amountLeft,
                UnitPrice = price,
                vender = getProduct(id).vender
            };
            db.Products.updateProduct(product);
        }

        public static Product getProduct(int id)
        {
            return db.Products.getProduct(id);
        }
        public static Product getProductByName(string name)
        {
            return db.Products.getProductByName(name);
        }
    }
}
