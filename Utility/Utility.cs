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
        public static void FocusOn(TextBox focusBox , KeyPressEventArgs key)
        {
            if(key.KeyChar.Equals((Char)Keys.Enter))
            {
                focusBox.Focus();
            }
        }
    }
}
