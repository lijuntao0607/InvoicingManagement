using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace WinformControls
{
    /// <summary>
    /// 扩展的选项卡控件
    /// 
    /// 实现了可关闭的选项标签
    /// 
    /// 作者：奥大帅
    /// 
    /// 版本 0.1
    /// </summary>
    public partial class ExtensionTabControl : TabControl
    {
        public ExtensionTabControl()
        {
            InitializeComponent();
            
        }
        
        public ExtensionTabControl(IContainer container)
        {


            container.Add(this);

            InitializeComponent();

            this.MouseDown += new MouseEventHandler(tabControl_MouseDown);
            this.DrawItem += new DrawItemEventHandler(tabControl_DrawItem);

            
            
        }
        private void tabControl_DrawItem(object sender, DrawItemEventArgs e)
        {
            try
            {
                Rectangle myTabRect = this.GetTabRect(e.Index);
                int CLOSE_SIZE = 10;
                //先添加TabPage属性 

                Color color;
                if (this.SelectedIndex == e.Index)
                {
                    color = Color.Black;
                    using (Brush b = new SolidBrush(Color.Gold ))
                    {
                        e.Graphics.FillRectangle(b, myTabRect);
                    }
                    
                }else
                {
                    color = Color.Silver;
                    //using (Brush b = new SolidBrush(Color.FromArgb(186, 209, 240)))
                    //{
                    //    e.Graphics.FillRectangle(b, myTabRect);
                    //}
                }
                //color = Color.FromArgb(186,209,240);
                //color =Color.FromArgb(152,187,213);
                e.Graphics.DrawString(this.TabPages[e.Index].Text
, this.Font, SystemBrushes.Highlight, myTabRect.X + 2, myTabRect.Y + 2);
                //再画一个矩形框
                using (Pen p = new Pen(color))//自动释放资源
                {
                    myTabRect.Offset(myTabRect.Width - (CLOSE_SIZE + 3), 2);
                    myTabRect.Width = CLOSE_SIZE;
                    myTabRect.Height = CLOSE_SIZE;
                    e.Graphics.DrawRectangle(p, myTabRect);
                }

                //画关闭符号
                using (Pen objpen = new Pen(color))
                {
                    //"/"线
                    Point p1 = new Point(myTabRect.X + 3, myTabRect.Y + 3);
                    Point p2 = new Point(myTabRect.X + myTabRect.Width - 3, myTabRect.Y + myTabRect.Height - 3);
                    e.Graphics.DrawLine(objpen, p1, p2);

                    //"/"线
                    Point p3 = new Point(myTabRect.X + 3, myTabRect.Y + myTabRect.Height - 3);
                    Point p4 = new Point(myTabRect.X + myTabRect.Width - 3, myTabRect.Y + 3);
                    e.Graphics.DrawLine(objpen, p3, p4);
                }

                e.Graphics.Dispose();
            }
            catch (Exception)
            {
            }
        }

        private void tabControl_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left )
            {
                int x = e.X, y = e.Y;

                int CLOSE_SIZE = 10;

                //计算关闭区域 
                Rectangle myTabRect = this.GetTabRect(this.SelectedIndex);

                myTabRect.Offset(myTabRect.Width - (CLOSE_SIZE + 3), 2);
                myTabRect.Width = CLOSE_SIZE;
                myTabRect.Height = CLOSE_SIZE;

                //如果鼠标在区域内就关闭选项卡 
                bool isClose = x > myTabRect.X && x < myTabRect.Right
                 && y > myTabRect.Y && y < myTabRect.Bottom;

                if (isClose == true)
                {
                    this.TabPages.Remove(this.SelectedTab);
                }
            }
        }
    }
}
