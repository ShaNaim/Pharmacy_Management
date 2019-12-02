using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ManageIT.MedShop.View.Utility;

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
        private void TxtID_KeyPress(object sender, KeyPressEventArgs e) => Utility.FrameUtility.FocusOn(txtName, e);
        private void TxtName_KeyPress(object sender, KeyPressEventArgs e) => Utility.FrameUtility.FocusOn(txtPrice, e);
        private void TxtPrice_KeyPress(object sender, KeyPressEventArgs e) => Utility.FrameUtility.FocusOn(txtVender, e);
    }
}
