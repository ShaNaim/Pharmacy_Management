using System;
using System.Collections;
using System.Data.SqlClient;

namespace ManageIT.MedShop.Model
{
    class Venders
    {
        public void addVender(Vender vender)
        {
            string query = "insert into VenderTable(VenderId,Name,Contact,Company) "
                    + "values('" + vender.ID + "','" + vender.Name + "','" + vender.Contact + "','" + vender.Company + "')";
            try
            {
                int row = DBConnection.ExecuteQuery(query);
            }
            catch (Exception)
            {

                throw;
            }
        }
        public void deleteVender()
        {

        }
        public void updateVender()
        {

        }
        public Vender getVender(int venderId)
        {
            string query = "SELECT * FROM VenderTable WHERE VenderId = '" + venderId + "'; ";
            try
            {
                SqlDataReader reader = DBConnection.getReader(query);

                while (reader.Read())
                {
                    Vender vender = new Vender()
                    {

                        ID = reader.GetInt32(reader.GetOrdinal("VenderId")),
                        Name = reader.GetString(reader.GetOrdinal("Name")),
                        Contact = reader.GetString(reader.GetOrdinal("Contact")),
                        Company = reader.GetString(reader.GetOrdinal("Company"))

                    };
                    if (vender != null)
                    {
                        return vender;
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
        public Vender getVenderbyName(string name)
        {
            string query = "SELECT * FROM VenderTable WHERE Name = '" + name + "'; ";
            try
            {
                SqlDataReader reader = DBConnection.getReader(query);

                while (reader.Read())
                {
                    Vender vender = new Vender()
                    {

                        ID = reader.GetInt32(reader.GetOrdinal("VenderId")),
                        Name = reader.GetString(reader.GetOrdinal("Name")),
                        Contact = reader.GetString(reader.GetOrdinal("Contact")),
                        Company = reader.GetString(reader.GetOrdinal("Company"))

                    };
                    if (vender != null)
                    {
                        return vender;
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
        public ArrayList getAllVender()
        {
            ArrayList result = new ArrayList();
            string query = "SELECT * FROM VenderTable ;";
            try
            {
                SqlDataReader reader = DBConnection.getReader(query);
                while (reader.Read())
                {
                    Vender vender = new Vender()
                    {

                        ID = reader.GetInt32(reader.GetOrdinal("VenderId")),
                        Name = reader.GetString(reader.GetOrdinal("Name")),
                        Contact = reader.GetString(reader.GetOrdinal("Contact")),
                        Company = reader.GetString(reader.GetOrdinal("Company"))

                    };
                    result.Add(vender);
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
        public ArrayList getAllVenderName()
        {
            ArrayList result = new ArrayList();
            string query = "SELECT Name FROM VenderTable ;";
            try
            {
                SqlDataReader reader = DBConnection.getReader(query);

                while (reader.Read())
                {
                    result.Add(reader.GetString(reader.GetOrdinal("Name")));
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
