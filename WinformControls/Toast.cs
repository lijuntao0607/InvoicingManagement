using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace WinformControls
{
    public class Toast
    {
        public static void Show(string msg)
        {
            MessageBox.Show(msg);
        }
    }
}
