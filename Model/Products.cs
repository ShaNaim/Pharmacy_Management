using System;
using System.Collections;
using System.Data.SqlClient;

namespace ManageIT.MedShop.Model
{
    class Products
    {
        static DataBase db = new DataBase();
        public void addProduct(Product product)
        {
            string query = "insert into ProductTable(Name,VenderId,AmountLeft,UnitPrice) "
                    + "values('" + product.Name + "','" + product.vender.ID + "','" + product.AmountLeft + "','" + product.UnitPrice + "')";
            DBConnection.ExecuteQuery(query);
        }
        public Product getProduct(int productId)
        {
            string query = "SELECT * FROM ProductTable WHERE ProductId = '" + productId + "'; ";
            try
            {
                SqlDataReader reader = DBConnection.getReader(query);

                while (reader.Read())
                {
                    Product product = new Product()
                    {

                        ID = reader.GetInt32(reader.GetOrdinal("ProductId")),
                        Name = reader.GetString(reader.GetOrdinal("Name")),
                        vender = db.Venders.getVender(reader.GetInt32(reader.GetOrdinal("VenderId"))),
                        AmountLeft = reader.GetDouble(reader.GetOrdinal("AmountLeft")),
                        UnitPrice = reader.GetDouble(reader.GetOrdinal("UnitPrice"))

                    };
                    if (product != null)
                    {
                        return product;
                    }
                    else
                    {
                        return null;
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
            return null;
        }
        public void deleteProduct(int productId)
        {
            string query = "DELETE FROM ProductTable where ProductId = '" + productId + "';";
            DBConnection.ExecuteQuery(query);
        }
        public void updateProduct(Product product)
        {
            string query = "UPDATE ProductTable SET Name = '" + product.Name + "', AmountLeft = '" + product.AmountLeft + "', VenderId = '" + product.vender.ID + "', UnitPrice = '" + product.UnitPrice + "' WHERE ProductId = '" + product.ID + "'; ";
            DBConnection.ExecuteQuery(query);
        }
        public Product getProductByName(string keyWord)
        {
            string query = "SELECT * FROM ProductTable WHERE Name = '" + keyWord + "';";
            try
            {
                SqlDataReader reader = DBConnection.getReader(query);

                while (reader.Read())
                {
                    Product product = new Product()
                    {

                        ID = reader.GetInt32(reader.GetOrdinal("ProductId")),
                        Name = reader.GetString(reader.GetOrdinal("Name")),
                        vender = db.Venders.getVender(reader.GetInt32(reader.GetOrdinal("VenderId"))),
                        AmountLeft = reader.GetDouble(reader.GetOrdinal("AmountLeft")),
                        UnitPrice = reader.GetDouble(reader.GetOrdinal("UnitPrice"))

                    };
                    if (product != null)
                    {
                        return product;
                    }
                    else
                    {
                        return null;
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
            return null;
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
                        UnitPrice = reader.GetDouble(reader.GetOrdinal("UnitPrice")),
                        vender = db.Venders.getVender(reader.GetInt32(reader.GetOrdinal("VenderId"))),
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
            string query = "SELECT * FROM ProductTable WHERE Name LIKE '" + keyWord + "';";
            try
            {
                SqlDataReader reader = DBConnection.getReader(query);

                while (reader.Read())
                {
                    Product product = new Product()
                    {

                        ID = reader.GetInt32(reader.GetOrdinal("ProductId")),
                        Name = reader.GetString(reader.GetOrdinal("Name")),
                        UnitPrice = reader.GetDouble(reader.GetOrdinal("UnitPrice")),
                        vender = db.Venders.getVender(reader.GetInt32(reader.GetOrdinal("VenderId"))),
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
