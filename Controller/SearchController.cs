using ManageIT.MedShop.Model;
using System.Collections;

namespace ManageIT.MedShop.Controller
{
    class SearchController
    {
        static DataBase db = new DataBase();
        public static ArrayList searchForProduct(string keyWord)
        {
            return db.Products.searchFor(keyWord);
        }
    }
}
