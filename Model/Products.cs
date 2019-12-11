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
            string query = "insert into ProductTable(Name,VenderId,AmountLeft) "
                    + "values('" + product.Name + "','" + product.vender.ID + "','" + product.AmountLeft + "')";
            DBConnection.ExecuteQuery(query);
        }
        public void getLatestProductId()
        {

        }
        public void deleteProduct(int productId)
        {
            string query = "DELETE FROM ProductTable where ProductId = '"+productId+"';";
            DBConnection.ExecuteQuery(query);
        }
        public void updateProduct(Product product)
        {
            string query = "UPDATE ProductTable SET Name = '"+product.Name+"', AmountLeft = "+product.AmountLeft+", VenderId = "+product.vender.ID+" WHERE ProductId = "+product.ID+"; ";
            DBConnection.ExecuteQuery(query);
        }
        public void getProduct(Product product)
        {

        }
        public ArrayList getAllProduct()
        {
            ArrayList result = new ArrayList();
            string query = "SELECT * FROM ProductTable ;";
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
            catch (Exception)
            {
                throw;
            }
            if (result != null)
            {
                return result;
            }
            return null;
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
            catch (Exception)
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
