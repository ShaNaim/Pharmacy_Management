using System;
using System.Data;
using System.Data.SqlClient;

namespace ManageIT.MedShop.Model
{
    public static class DBConnection
    {
        public static string connectionString = "Data Source = DESKTOP-3PAI8AC;Initial Catalog = ShohanPharmacy; Integrated Security = True";

        //for select query
        public static DataSet GetDataSet(string query, SqlConnection Connection)
        {
            SqlCommand command = new SqlCommand(query, Connection);
            SqlDataAdapter adp = new SqlDataAdapter(command);
            DataSet ds = new DataSet();
            adp.Fill(ds);

            return ds;
        }
        public static DataTable GetDataTable(string query)
        {
            SqlConnection Connection = new SqlConnection(DBConnection.connectionString);
            Connection.Open();
            DataSet ds = GetDataSet(query, Connection);
            if (ds.Tables.Count > 0)
                return ds.Tables[0];
            return null;
        }
        public static int ExecuteQuery(string query)
        {
            try
            {
                SqlConnection Connection = new SqlConnection(DBConnection.connectionString);
                Connection.Open();
                SqlCommand command = new SqlCommand(query, Connection);
                int result = command.ExecuteNonQuery();
                Connection.Close();
                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public static SqlDataReader getReader(string query)
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(query, con);
            con.Open();

            return command.ExecuteReader();
        }
    }
}
