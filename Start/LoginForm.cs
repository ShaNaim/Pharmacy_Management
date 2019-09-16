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

namespace ManageIT.MedShop.Start
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }


        ///////////////////////////////// Custom Method /////////////////////////////////
        
        private bool checkUser()
        {
            if(txtUserName.Text == "Admin" || txtUserName.Text == "Emp")
            {
                if(txtPassword.Text == "admin" || txtPassword.Text == "emp")
                {
                    return true;
                }
                else
                {
                    txtPassword.Text = "";
                    txtUserName.Text = "";
                    lblError.Visible = true ;
                    lblError.Text = "Incorrect Password";
                }
            }
            else
            {
                txtPassword.Text = "";
                txtUserName.Text = "";
                lblError.Visible = true;
                lblError.Text = "Incorrect Username";
            }
            return false;
        }
        private void UserLogin()
        {
            if (checkUser())
            {
                if (txtUserName.Text == "Admin")
                {
                    AdminFrame adminFrame = new AdminFrame();
                    this.Hide();
                    adminFrame.Show();
                }
                else
                {
                    EmployFrame employFrame = new EmployFrame();
                    this.Hide();
                    employFrame.Show();
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
            UserLogin();
        }

        private void TxtUserName_TextChanged(object sender, EventArgs e)
        {
            if(txtUserName.Text != "")
            {
                lblError.Visible = false;
            }
        }

        private void TxtUserName_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utility.FrameUtility.FocusOn(txtPassword, e);
        }

        private void TxtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Equals((Char)Keys.Enter))
            {
                
                UserLogin();
            }
            MessageBox.Show("OK");
        }
    }
}
