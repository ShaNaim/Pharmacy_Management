using System;
using System.Windows.Forms;

namespace ManageIT.MedShop.Utility
{
    public static class FramesUtility
    {
        public static string CopyRightText = "    ManageIT";
        public static void FocusOn(TextBox focusBox, KeyPressEventArgs key)
        {
            if (key.KeyChar.Equals((Char)Keys.Enter))
            {
                focusBox.Focus();
            }
        }

        /* try
             {
                 string query = "select * from Employee where EmpId='" + txtSearch.text + "'";
         DataTable dt = DBConnection.GetDataTable(query);
         dgvEmpInfo.DataSource = dt;
                 dgvEmpInfo.Refresh();

                 if (dt.Rows.Count == 1)
                 {
                     txtId.Text = dt.Rows[0]["EmpId"].ToString();
         txtName.Text = dt.Rows[0]["EmpName"].ToString();
         txtContact.Text = dt.Rows[0]["EmpContact"].ToString();
         txtDasignation.Text = dt.Rows[0]["Designation"].ToString();
         txtSalary.Text = dt.Rows[0]["Salary"].ToString();
         txtJDate.Text = dt.Rows[0]["JoiningDate"].ToString();
         txtPassword.Text = dt.Rows[0]["Password"].ToString();
         txtStatus.Text = dt.Rows[0]["Status"].ToString();

     }

                 else
                 {
                     MessageBox.Show("Invalid Employee ID", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                 }
             }
             catch (Exception ex)
             {
                 MessageBox.Show(ex.Message);
             }*/
        /*private void dgvEmpInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string id = dgvEmpInfo.Rows[e.RowIndex].Cells[0].Value.ToString();
                try
                {
                    string query = "select * from Employee where EmpId=" + id;
                    DataTable dt = DBConnection.GetDataTable(query);

                    if (dt.Rows.Count == 1)
                    {
                        txtId.Text = dt.Rows[0]["EmpId"].ToString();
                        txtName.Text = dt.Rows[0]["EmpName"].ToString();
                        txtContact.Text = dt.Rows[0]["EmpContact"].ToString();
                        txtDasignation.Text = dt.Rows[0]["Designation"].ToString();
                        txtSalary.Text = dt.Rows[0]["Salary"].ToString();
                        txtJDate.Text = dt.Rows[0]["JoiningDate"].ToString();
                        txtPassword.Text = dt.Rows[0]["Password"].ToString();
                        txtStatus.Text = dt.Rows[0]["Status"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("Invalid Id", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            btnAdd.Visible = btnUpdate.Visible = btnDelete.Visible = true;
            btnSave.Visible = false;
        }*/
    }
}
