using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Text;
using System.Windows.Forms;

namespace WinformControls
{
    public partial class ExtensionTabPage : TabPage
    {
        public ExtensionTabPage()
        {
            InitializeComponent();
        }

        public ExtensionTabPage(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
