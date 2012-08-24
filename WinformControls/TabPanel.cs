using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinformControls
{
    /// <summary>
    /// 未完成
    /// </summary>
    public partial class TabPanel : Panel
    {
        public event EventHandler PageClosed;
        public event EventHandler PageIndexChanged;
        public List<Panel> Panels { get; set; }

        public TabPanel()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }

    }

    class TabButton : Panel
    {
       
        private Label CloseLabel = new Label();
        public Label TitleLabel { get; set; }
        public TabButton(TabPanel tabPanel,String text)
        {

            CloseLabel.Text = "X";
            CloseLabel.Click += new EventHandler(CloseLabelClick);
            

            TitleLabel = new Label();
            TitleLabel.Text = text;

            this.Controls.Add(TitleLabel);
            this.Controls.Add(TitleLabel);

            this.Click += new EventHandler(TabButtonClick);

        }
        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }

        private void CloseLabelClick(object sender, EventArgs e)
        {

        }

        private void TabButtonClick(object sender, EventArgs e)
        {

        }
    }
}
