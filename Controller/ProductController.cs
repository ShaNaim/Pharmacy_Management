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
        public static void addProduct(int id,string name,int venderId,double amountLeft)
        {
            Product product = new Product
            {
                ID = id,
                Name = name,
                AmountLeft = amountLeft,
                VenderID = venderId,
                vender = VenderController.getVender(venderId)
            };
            db.Products.addProduct(product);
        }
        public static ArrayList searchFor(string keyWord)
        {
            return db.Products.searchFor(keyWord);
        }
    }
}
