namespace Winform
{
    partial class CategorySelectWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("产品类别");
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.CategoryTreeContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.AddCategoryMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RenameMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteCategoryMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CategoryTreeContextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.LabelEdit = true;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "RootNode";
            treeNode1.Text = "产品类别";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1});
            this.treeView1.Size = new System.Drawing.Size(310, 266);
            this.treeView1.TabIndex = 1;
            this.treeView1.BeforeLabelEdit += new System.Windows.Forms.NodeLabelEditEventHandler(this.treeView1_BeforeLabelEdit);
            this.treeView1.AfterLabelEdit += new System.Windows.Forms.NodeLabelEditEventHandler(this.treeView1_AfterLabelEdit);
            this.treeView1.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseClick);
            this.treeView1.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseDoubleClick);
            this.treeView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.treeView1_MouseClick);
            // 
            // CategoryTreeContextMenuStrip
            // 
            this.CategoryTreeContextMenuStrip.BackColor = System.Drawing.SystemColors.MenuBar;
            this.CategoryTreeContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddCategoryMenuItem,
            this.RenameMenuItem,
            this.DeleteCategoryMenuItem});
            this.CategoryTreeContextMenuStrip.Name = "CategoryTreeContextMenuStrip";
            this.CategoryTreeContextMenuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.CategoryTreeContextMenuStrip.Size = new System.Drawing.Size(153, 92);
            // 
            // AddCategoryMenuItem
            // 
            this.AddCategoryMenuItem.Name = "AddCategoryMenuItem";
            this.AddCategoryMenuItem.Size = new System.Drawing.Size(152, 22);
            this.AddCategoryMenuItem.Text = "添加类别";
            this.AddCategoryMenuItem.Click += new System.EventHandler(this.AddCategoryMenuItem_Click);
            // 
            // RenameMenuItem
            // 
            this.RenameMenuItem.Name = "RenameMenuItem";
            this.RenameMenuItem.Size = new System.Drawing.Size(152, 22);
            this.RenameMenuItem.Text = "重命名";
            this.RenameMenuItem.Click += new System.EventHandler(this.RenameMenuItem_Click);
            // 
            // DeleteCategoryMenuItem
            // 
            this.DeleteCategoryMenuItem.Name = "DeleteCategoryMenuItem";
            this.DeleteCategoryMenuItem.Size = new System.Drawing.Size(152, 22);
            this.DeleteCategoryMenuItem.Text = "删除类别";
            this.DeleteCategoryMenuItem.Click += new System.EventHandler(this.DeleteCategoryMenuItem_Click);
            // 
            // CategorySelectWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 266);
            this.Controls.Add(this.treeView1);
            this.Name = "CategorySelectWindow";
            this.Text = "CategorySelectWindow";
            this.Load += new System.EventHandler(this.CategorySelectWindow_Load);
            this.CategoryTreeContextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ContextMenuStrip CategoryTreeContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem AddCategoryMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RenameMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeleteCategoryMenuItem;
    }
}