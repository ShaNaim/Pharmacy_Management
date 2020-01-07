using ManageIT.MedShop.Controller;
using ManageIT.MedShop.Model;
using ManageIT.MedShop.Utility;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ManageIT.MedShop.View.Start
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();

            lblCopyRight.Text = Utility.FramesUtility.CopyRightText;
        }


        ///////////////////////////////// Custom Method /////////////////////////////////

        private void clear()
        {
            txtPassword.Text = "";
            txtUserID.Text = "";
            lblError.Visible = true;
        }
        private bool authenticateInput()
        {
            int userId = 0;
            string password = txtPassword.Text;
            try
            {
                userId = Int32.Parse(txtUserID.Text);
                if (password != "")
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("Incorrect Password", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Incorrect User ID", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }


        private void authenticateUser()
        {
            if (authenticateInput())
            {
                Login login = LoginController.authenticateUser(Int32.Parse(txtUserID.Text), txtPassword.Text);
                if (login != null)
                {
                    if (login.UserStatus == (int)CodeUtility.UserStatus.Admin)
                    {
                        AdminFrame adminFrame = new AdminFrame(UsersController.getUser(Int32.Parse(txtUserID.Text)).Name);
                        adminFrame.Show();
                        this.Hide();
                    }
                    else if (login.UserStatus == (int)CodeUtility.UserStatus.Employee)
                    {
                        EmployFrame employFrame = new EmployFrame(UsersController.getUser(Int32.Parse(txtUserID.Text)).Name);
                        employFrame.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Invalid User", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Invalid User", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
        ///////////////////////////////// Action Events /////////////////////////////////

        private void BtnLogin_MouseEnter(object sender, EventArgs e)
        {
            Color clr = Color.FromArgb(111, 199, 93);
            btnLogin.BackColor = clr;
        }

        private void BtnLogin_MouseLeave(object sender, EventArgs e)
        {
            Color clr = Color.FromArgb(48, 107, 36);
            btnLogin.BackColor = clr;
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            authenticateUser();
        }

        private void TxtUserName_TextChanged(object sender, EventArgs e)
        {
            if (txtUserID.Text != "")
            {
                lblError.Visible = false;
            }
        }

        private void TxtUserName_KeyPress(object sender, KeyPressEventArgs e) => Utility.FramesUtility.FocusOn(txtPassword, e);

        private void TxtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals((char)Keys.Enter))
            {
                authenticateUser();
            }
        }
    }
}
