using ManageIT.MedShop.View.Employee;
using ManageIT.MedShop.View.Purchase;
using ManageIT.MedShop.View.Sells;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ManageIT.MedShop.View.Start
{
    public partial class AdminFrame : Form
    {
        public AdminFrame(string userName)
        {
            InitializeComponent();
            lblCopyRight.Text = Utility.FramesUtility.CopyRightText;
            lblUserName.Text = "Welcome : " + userName;
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

        private void LoadEmployAdd()
        {
            AddNewEmploy addNewEmploy = new AddNewEmploy();

            addNewEmploy.TopLevel = false;
            addNewEmploy.AutoScroll = true;
            addNewEmploy.FormBorderStyle = FormBorderStyle.None;
            addNewEmploy.Dock = DockStyle.Fill;

            this.pnlDisplay.Controls.Clear();
            this.pnlDisplay.Controls.Add(addNewEmploy);

            addNewEmploy.Show();
        }

        private void LoadEmployInfo()
        {
            EmployInfo employInfo = new EmployInfo();

            employInfo.TopLevel = false;
            employInfo.AutoScroll = true;
            employInfo.FormBorderStyle = FormBorderStyle.None;
            employInfo.Dock = DockStyle.Fill;

            this.pnlDisplay.Controls.Clear();
            this.pnlDisplay.Controls.Add(employInfo);

            employInfo.Show();
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

        private void LoadSellsMain()
        {
            SellsMain sellsMain = new SellsMain();

            sellsMain.TopLevel = false;
            sellsMain.AutoScroll = true;
            sellsMain.FormBorderStyle = FormBorderStyle.None;
            sellsMain.Dock = DockStyle.Fill;

            this.pnlDisplay.Controls.Clear();
            this.pnlDisplay.Controls.Add(sellsMain);

            sellsMain.Show();
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

        private void DailyPurchaseToolStripMenuItem_Click(object sender, EventArgs e) => LoadPurchaseMenu();

        private void NewParchesToolStripMenuItem_Click(object sender, EventArgs e) => LoadPurchaseNew();

        private void AddNewToolStripMenuItem_Click(object sender, EventArgs e) => LoadEmployAdd();

        private void EmployesToolStripMenuItem_Click(object sender, EventArgs e) => LoadEmployInfo();

        private void SettingToolStripMenuItem_Click(object sender, EventArgs e) => LoadSetting();

        private void SellsToolStripMenuItem1_Click(object sender, EventArgs e) => LoadSellsMain();
    }
}
