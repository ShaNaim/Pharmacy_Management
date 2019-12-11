using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ManageIT.MedShop.Model;
using System.Collections;

namespace ManageIT.MedShop.Controller
{
    class ProductController
    {
        static DataBase db = new DataBase();
        public static void addProduct(int id,string name,string venderName, double amountLeft)
        {
            Product product = new Product
            {
                ID = id,
                Name = name,
                AmountLeft = amountLeft,
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
        public static void updateProduct(int id, string name, string venderName, double amountLeft)
        {
            Product product = new Product
            {
                ID = id,
                Name = name,
                AmountLeft = amountLeft,
                vender = VenderController.getVender(VenderController.getVenderbyName(venderName).ID)
            };
            db.Products.updateProduct(product);
        }
    }
}
