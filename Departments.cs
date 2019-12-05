using System;
using System.Collections;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doctor_sAppointmentBookingSystem.Models
{
   public class Departments
    {
        SqlConnection conn;
        string connString = "";
        public Departments()
        {
            conn = new SqlConnection("Server=SYEDEMO-PC;Database=DPBS;User Id=sa;Password=syedemon;");
        }


        public void AddDepartment(Department department)
        {
            conn.Open();
            string query = "INSERT INTO Departments (Deptname) VALUES('" + department.Deptname + "')";
            SqlCommand cmd = new SqlCommand(query, conn);
            int result = cmd.ExecuteNonQuery();
            conn.Close();
        }
      
        public void UpdateDepartment(Department department)
        {
            conn.Open();
            string query = "update Departments set Deptname='" + department.Deptname
                + "' where Deptid="+department.Deptid;
            SqlCommand cmd = new SqlCommand(query, conn);
            int result = cmd.ExecuteNonQuery();
            conn.Close();
        }
        public ArrayList GetDepartment(string Deptname)
        {
            ArrayList departments = new ArrayList();
            conn.Open();
            //string query = "SELECT * FROM Departments";
            string query = "SELECT * FROM Departments where Deptname='"+ Deptname + "'";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Department d = new Department()
            {

                    Deptid = reader.GetInt32(reader.GetOrdinal("Deptid")),
                    Deptname = reader.GetString(reader.GetOrdinal("Deptname")),

                };
                departments.Add(d);

            }
            conn.Close();
            return departments;
        }
        public ArrayList GetAllDepartments()
        {
            ArrayList departments = new ArrayList();
            conn.Open();
            string query = "SELECT * FROM Departments";
            SqlCommand cmd = new SqlCommand(query, conn);

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Department d = new Department()
                {
                    Deptid = reader.GetInt32(reader.GetOrdinal("Deptid")),
                    Deptname = reader.GetString(reader.GetOrdinal("Deptname")),

                };
                departments.Add(d);
                
            }
            
            conn.Close();
            return departments;
        }


    }
}
