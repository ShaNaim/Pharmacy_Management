using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Data.SqlClient;

namespace ManageIT.MedShop.Model
{
    class Products
    {
        static DataBase db = new DataBase();
        public void addProduct(Product product)
        {
            string query = "insert into ProductTable(ProductId,Name,VenderId,AmountLeft) "
                    + "values('" + product.ID + "','" + product.Name + "','" + product.VenderID + "','" + product.AmountLeft + "')";
            try
            {
                int row = DBConnection.ExecuteQuery(query);
            }
            catch (Exception)
            {

                throw;
            }
        }
        public void deleteProduct(Product product)
        {

        }
        public void updateProduct(Product product)
        {

        }
        public void getProduct(Product product)
        {

        }
        public void getAllProduct(Product product)
        { 

        }
        public ArrayList searchFor(string keyWord)
        {
            keyWord = "%" + keyWord + "%";
            ArrayList result = new ArrayList();
            string query = "SELECT * FROM ProductTable WHERE Name LIKE '"+keyWord+"';";
            try
            {
                SqlDataReader reader = DBConnection.getReader(query);

                while (reader.Read())
                {
                    Product product = new Product()
                    {

                        ID = reader.GetInt32(reader.GetOrdinal("ProductId")),
                        Name = reader.GetString(reader.GetOrdinal("Name")),
                        VenderID = reader.GetInt32(reader.GetOrdinal("VenderId")),
                        AmountLeft = reader.GetDouble(reader.GetOrdinal("AmountLeft"))
                    };
                    result.Add(product);
                }
            }
            catch (Exception ex)
            {
                throw;
            }
            if (result != null)
            {
                return result;
            }
            return null;
        }
    }
}
