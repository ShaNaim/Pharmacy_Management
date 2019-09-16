using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManageIT.MedShop.Utility
{
    public static class FrameUtility
    {
        public static void FocusOn(TextBox focusBox , EventArgs key)
        {
            if(key.Equals((Char)Keys.Enter))
            {
                focusBox.Focus();
            }
        }


    }
}
