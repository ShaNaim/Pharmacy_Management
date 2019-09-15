using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManageIT.MedShop.Start
{
    public partial class EmployFrame : Form
    {
        public EmployFrame()
        {
            InitializeComponent();
        }





        private void BtnLogout_MouseEnter(object sender, EventArgs e)
        {
            Color clr = Color.Salmon;
            btnLogout.BackColor = clr;
        }

        private void BtnLogout_MouseLeave(object sender, EventArgs e)
        {
            Color clr = Color.Tomato;
            btnLogout.BackColor = clr;
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            this.Hide();
            loginForm.Show();
        }
    }
}
