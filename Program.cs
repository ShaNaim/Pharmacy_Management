using ManageIT.MedShop.View.Sells;
using ManageIT.MedShop.View.Purchase;
using ManageIT.MedShop.View.Start;
using System;
using System.Windows.Forms;

namespace ManageIT.MedShop
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new BillingSystem());
        }
    }
}
