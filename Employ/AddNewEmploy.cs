using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ManageIT.MedShop.Utility;

namespace ManageIT.MedShop.Employ
{
    public partial class AddNewEmploy : Form
    {
        private EmployInfo EmployInfo ;
        public AddNewEmploy()
        {
            InitializeComponent();
        }
        public AddNewEmploy(EmployInfo employInfo)
        {
            InitializeComponent();
            this.EmployInfo = employInfo ;
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
            if(txtID.Text != "" && txtPassword.Text != "" && txtName.Text != "" && txtContact.Text != "" && txtSalary.Text != "" )
            {
                return true;
            }
            return false;
        }

        ///////////////////////////////// Action Events /////////////////////////////////
        private void TxtID_KeyPress(object sender, KeyPressEventArgs e) => FrameUtility.FocusOn(txtPassword, e);

        private void TxtPassword_KeyPress(object sender, KeyPressEventArgs e) => FrameUtility.FocusOn(txtName, e);

        private void TxtName_KeyPress(object sender, KeyPressEventArgs e) => FrameUtility.FocusOn(txtContact, e);

        private void TxtContact_KeyPress(object sender, KeyPressEventArgs e) => FrameUtility.FocusOn(txtSalary, e);

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            string msgString = "ADD" + txtName.Text;
            if(CheckInsart())
            {
                MessageBox.Show(msgString, "Are You Sure", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            }
            else
            {
                MessageBox.Show("All Information Must Be filled", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
