using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WinformControls;
using DomainModule;
using BackgroundControl;
using BusinessService;

namespace Winform
{
    public partial class CategorySelectWindow : BaseForm
    {
        TreeNode CurrentNode;

        /// <summary>
        /// 选中的类别
        /// </summary>
        public Category Category { get; set; }

        public CategorySelectWindow()
        {
            InitializeComponent();
        }
        
        private void CategorySelectWindow_Load(object sender, EventArgs e)
        {
            try
            {
                TreeViewManager.TreeLoad(treeView1);
            }
            catch (Exception ex)
            {
                Toast.Show(ex.Message);
            }
        }

        private void treeView1_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            try
            {
                if (e.Node.Level != 0)
                {

                    Category = (Category)e.Node.Tag;
                    this.DialogResult = DialogResult.OK;
                    this.Hide();

                }
            }
            catch (Exception ex)
            {
                Toast.Show(ex.Message);
            }
        }

        private void treeView1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (e.Node.Level == 0)
                {
                    RenameMenuItem.Visible = false;
                    DeleteCategoryMenuItem.Visible = false;
                }
                else
                {
                    RenameMenuItem.Visible = true;
                    DeleteCategoryMenuItem.Visible = true;
                }
                this.CategoryTreeContextMenuStrip.Show(treeView1, e.X, e.Y);
                CurrentNode = e.Node;
            }
        }

        private void treeView1_AfterLabelEdit(object sender, NodeLabelEditEventArgs e)
        {
            try
            {
                if (e.Node.Level != 0 && !string.IsNullOrEmpty(e.Label))
                {
                    Category category = (Category)e.Node.Tag;
                    category.CategoryName = e.Label;
                    SystemVariable.CategoryService.Update(category);
                    e.Node.Text = category.CategoryName;
                }

            }
            catch (Exception ex)
            {
                Toast.Show(ex.Message);
            }
        }

        private void AddCategoryMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Category category = new Category();
                category.CategoryName = "新类别";
                if (CurrentNode.Level != 0)
                {
                    category.Parent = (Category)CurrentNode.Tag;
                }
                else
                {
                    category.Parent = null;
                }
                SystemVariable.CategoryService.Add(category);
                System.Windows.Forms.TreeNode node = TreeViewManager.AddNode(category, CurrentNode, false);
                CurrentNode.Expand();
                node.BeginEdit();

            }
            catch (Exception ex)
            {
                Toast.Show(ex.Message);
            }
        }

        private void RenameMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (CurrentNode != null)
                {
                    CurrentNode.BeginEdit();
                }
            }
            catch (Exception ex)
            {
                Toast.Show(ex.Message);
            }
        }

        private void DeleteCategoryMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("确定删除吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Category category = (Category)CurrentNode.Tag;
                    SystemVariable.CategoryService.Delete(category);
                    //SystemVariable.CategoryList.Remove(category);
                }
            }
            catch (Exception ex)
            {
                Toast.Show(ex.Message);
            }
        }

        private void treeView1_BeforeLabelEdit(object sender, NodeLabelEditEventArgs e)
        {
            try
            {
                e.CancelEdit = TreeViewManager.IsRootNode(e.Node);
            }
            catch (Exception ex)
            {
                Toast.Show(ex.Message);
            }
        }
    }
}
