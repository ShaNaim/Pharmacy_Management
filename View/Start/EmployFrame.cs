using ManageIT.MedShop.View.Employee;
using ManageIT.MedShop.View.Purchase;
using ManageIT.MedShop.View.Sells;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ManageIT.MedShop.View.Start
{
    public partial class EmployFrame : Form
    {
        public EmployFrame(string userName)
        {
            InitializeComponent();
            lblCopyRight.Text = Utility.FramesUtility.CopyRightText;
            lblUserName.Text = "Welcome : " + userName;
            loadBilling();
        }

        ///////////////////////////////// Custom Method /////////////////////////////////
        private void LoadPurchaseMenu()
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
        private void LoadPurchaseNew()
        {
            PurchaseNew purchaseNew = new PurchaseNew();

            purchaseNew.TopLevel = false;
            purchaseNew.AutoScroll = true;
            purchaseNew.FormBorderStyle = FormBorderStyle.None;
            purchaseNew.Dock = DockStyle.Fill;

            this.pnlDisplay.Controls.Clear();
            this.pnlDisplay.Controls.Add(purchaseNew);

            purchaseNew.Show();
        }
        private void loadBilling()
        {
            BillingSystem billingMain = new BillingSystem();

            billingMain.TopLevel = false;
            billingMain.AutoScroll = true;
            billingMain.FormBorderStyle = FormBorderStyle.None;
            billingMain.Dock = DockStyle.Fill;

            this.pnlDisplay.Controls.Clear();
            this.pnlDisplay.Controls.Add(billingMain);

            billingMain.Show();
        }

        private void LoadSetting()
        {
            Setting setting = new Setting();

            setting.TopLevel = false;
            setting.AutoScroll = true;
            setting.FormBorderStyle = FormBorderStyle.None;
            setting.Dock = DockStyle.Fill;

            this.pnlDisplay.Controls.Clear();
            this.pnlDisplay.Controls.Add(setting);

            setting.Show();
        }

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

        private void BtnLogout_Click_1(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            this.Hide();
            loginForm.Show();
        }

        private void DailyPurchaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadPurchaseMenu();
        }

        private void NewPurchaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadPurchaseNew();
        }

        private void SettingToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            LoadSetting();
        }
    }
}
