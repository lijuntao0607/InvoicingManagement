using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BackgroundControl
{
    public class TabControlManager
    {
        /// <summary>
        /// 显示指定的page，并使之成为当前page
        /// </summary>
        /// <param name="container"></param>
        /// <param name="page"></param>
        public static void ShowPage(TabControl container,TabPage page)
        {
            if (!container.Contains(page))
            {
                container.TabPages.Add(page);
            }
            page.Show();
            container.SelectTab(page);
        }
    }
}
