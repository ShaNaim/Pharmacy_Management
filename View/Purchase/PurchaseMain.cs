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
        

        private void TxtName_KeyPress(object sender, KeyPressEventArgs e) => Utility.FrameUtility.FocusOn(txtAmount, e);
        

        private void TxtAmount_KeyPress(object sender, KeyPressEventArgs e) => Utility.FrameUtility.FocusOn(txtVender, e);
        

        private void TxtVender_KeyPress(object sender, KeyPressEventArgs e) => Utility.FrameUtility.FocusOn(txtPrice, e);
    }
}
