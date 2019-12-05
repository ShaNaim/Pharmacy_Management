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

namespace ManageIT.MedShop.View.Purchase
{
    public partial class PurchaseNew : Form
    {
        public PurchaseNew()
        {
            InitializeComponent();
        }
        ///////////////////////////////// Custom Method /////////////////////////////////

        ///////////////////////////////// Action Events /////////////////////////////////
        private void TxtID_KeyPress(object sender, KeyPressEventArgs e) => Utility.FramesUtility.FocusOn(txtName, e);
        private void TxtName_KeyPress(object sender, KeyPressEventArgs e) => Utility.FramesUtility.FocusOn(txtTottal, e);
        private void TxtPrice_KeyPress(object sender, KeyPressEventArgs e) => Utility.FramesUtility.FocusOn(txtVender, e);

        private void PurchaseNew_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'shohanPharmacyDataSet2.ProductTable' table. You can move, or remove it, as needed.
            this.productTableTableAdapter.Fill(this.shohanPharmacyDataSet2.ProductTable);

        }
    }
}
