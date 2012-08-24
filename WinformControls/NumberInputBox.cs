using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Text;
using System.Windows.Forms;

namespace WinformControls
{
    public partial class NumberInputBox : TextBox
    {
        public NumberInputBox()
        {
            InitializeComponent();
            this.KeyPress += new KeyPressEventHandler (textBox_KeyPress);
        }

        public NumberInputBox(IContainer container):this()
        {
            
            container.Add(this);

            
        }

        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //判断按键是不是要输入的类型。
            if (((int)e.KeyChar < 48 || (int)e.KeyChar > 57) && (int)e.KeyChar != 8 && (int)e.KeyChar != 46)
                e.Handled = true;

            //小数点的处理。
            if ((int)e.KeyChar == 46)                           //小数点
            {
                if (this.Text.Length <= 0)
                    e.Handled = true;   //小数点不能在第一位
                else
                {
                    float f;
                    float oldf;
                    bool b1 = false, b2 = false;
                    b1 = float.TryParse(this.Text, out oldf);
                    b2 = float.TryParse(this.Text + e.KeyChar.ToString(), out f);
                    if (b2 == false)
                    {
                        if (b1 == true)
                            e.Handled = true;
                        else
                            e.Handled = false;
                    }
                }
            }
        }
    }
}
