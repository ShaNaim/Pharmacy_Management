using ManageIT.MedShop.Controller;
using ManageIT.MedShop.Utility;
using System;
using System.Windows.Forms;


namespace ManageIT.MedShop.View.Employee
{
    public partial class AddNewEmploy : Form
    {
        private EmployInfo EmployInfo;
        public AddNewEmploy()
        {
            InitializeComponent();
        }
        public AddNewEmploy(EmployInfo employInfo)
        {
            InitializeComponent();
            this.EmployInfo = employInfo;
            txtID.Text = EmployInfo.txtID.Text;
            txtPassword.Text = EmployInfo.txtPassword.Text;
            txtContact.Text = EmployInfo.txtContact.Text;
            txtSalary.Text = EmployInfo.txtSalary.Text;
            dtpJoinDate.Value = EmployInfo.dtpJoinDate.Value;
            btnAdd.Text = "Update";
        }

        ///////////////////////////////// Custom Method /////////////////////////////////
        private bool CheckInsart()
        {
            if (txtID.Text != "" && txtPassword.Text != "" && txtName.Text != "" && txtContact.Text != "" && txtSalary.Text != "" && cbStatus.Text != "")
            {
                return true;
            }
            return false;
        }

        ///////////////////////////////// Action Events /////////////////////////////////
        private void TxtID_KeyPress(object sender, KeyPressEventArgs e) => FramesUtility.FocusOn(txtPassword, e);

        private void TxtPassword_KeyPress(object sender, KeyPressEventArgs e) => FramesUtility.FocusOn(txtName, e);

        private void TxtName_KeyPress(object sender, KeyPressEventArgs e) => FramesUtility.FocusOn(txtContact, e);

        private void TxtContact_KeyPress(object sender, KeyPressEventArgs e) => FramesUtility.FocusOn(txtSalary, e);

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            string msgString = "ADD" + txtName.Text + " ?";
            if (CheckInsart())
            {
                DialogResult dr = MessageBox.Show(msgString, "Are You Sure ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == System.Windows.Forms.DialogResult.Yes)
                {
                    UsersController.addUser(Int32.Parse(txtID.Text), txtName.Text, Int32.Parse(txtContact.Text), float.Parse(txtSalary.Text), dtpJoinDate.Value);
                    int status = 2;
                    if (cbStatus.SelectedIndex == 0)
                    {
                        status = 1;
                    }
                    LoginController.addUser(Int32.Parse(txtID.Text), txtPassword.Text, status);
                    MessageBox.Show(txtID.Text + "ADDED", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("All Information Must Be filled", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtContact_TextChanged(object sender, EventArgs e)
        {
            txtID.Text = txtContact.Text;
        }
    }
}
