using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManageIT.MedShop.View.Purchase
{
    public partial class PurchaseMain : Form
    {
        public PurchaseMain()
        {
            InitializeComponent();
        }

        ///////////////////////////////// Custom Method /////////////////////////////////

        ///////////////////////////////// Action Events /////////////////////////////////
        //private void TxtID_KeyPress(object sender, KeyPressEventArgs e) => Utility.FrameUtility.FocusOn(txtName, e);
        

        private void TxtName_KeyPress(object sender, KeyPressEventArgs e) => Utility.FramesUtility.FocusOn(txtAmount, e);
        

        //private void TxtAmount_KeyPress(object sender, KeyPressEventArgs e) => Utility.FrameUtility.FocusOn(cbVender, e);
        

        private void TxtVender_KeyPress(object sender, KeyPressEventArgs e) => Utility.FramesUtility.FocusOn(txtPrice, e);

        private void PurchaseMain_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'shohanPharmacyDataSet1.ProductTable' table. You can move, or remove it, as needed.
            this.productTableTableAdapter.Fill(this.shohanPharmacyDataSet1.ProductTable);
            // TODO: This line of code loads data into the 'shohanPharmacyDataSet.VenderTable' table. You can move, or remove it, as needed.
            this.venderTableTableAdapter.Fill(this.shohanPharmacyDataSet.VenderTable);

        }
    }
}
