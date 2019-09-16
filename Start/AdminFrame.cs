﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ManageIT.MedShop.Purchase;

namespace ManageIT.MedShop.Start
{
    public partial class AdminFrame : Form
    {
        public AdminFrame()
        {
            InitializeComponent();
        }

        ///////////////////////////////// Custom Method /////////////////////////////////

       


        ///////////////////////////////// Action Events /////////////////////////////////

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

        private void DailyPurchaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PurchaseMain purchaseMain = new PurchaseMain();
            purchaseMain.TopLevel = false;
            purchaseMain.AutoScroll = true;
            purchaseMain.FormBorderStyle = FormBorderStyle.None;
            purchaseMain.Dock = DockStyle.Fill;

            this.pnlDisplay.Controls.Clear();
            this.pnlDisplay.Controls.Add(purchaseMain);

            purchaseMain.Show();
        }
    }
}
