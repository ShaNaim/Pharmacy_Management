using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
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
            catch (Exception ex)
            {
                throw;
            }
            return null;
        }
        public void getAllVender()
        {

        }
            
    }
}
