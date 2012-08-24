using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using BusinessService;
using DomainModule;
using WinformControls;

namespace BackgroundControl
{
    public class TreeViewManager
    {
        /// <summary>
        /// 加载树
        /// </summary>
        public static void TreeLoad(TreeView treeView1)
        {
            
            System.Windows.Forms.TreeNode rootNode = treeView1.Nodes[0];
            rootNode.Nodes.Clear();
            foreach (var item in SystemVariable.CategoryList)
            {
                if (item.Parent == null)
                {
                    AddNode(item, rootNode, true);
                }
            }

        }
        /// <summary>
        /// 添加节点
        /// </summary>
        /// <param name="category">类别</param>
        /// <param name="parent">父节点</param>
        /// <param name="isIteration">是否循环迭代添加子节点</param>
        /// <returns></returns>
        public static TreeNode AddNode(Category category, TreeNode parent, bool isIteration)
        {
            TreeNode newNode = new TreeNode(category.CategoryName);
            newNode.Tag = category;
            parent.Nodes.Add(newNode);
            if (isIteration)
            {
                foreach (var item in SystemVariable.CategoryList)
                {
                    if (item.Parent == category)
                    {
                        AddNode(item, newNode, true);
                    }
                }
            }
            return newNode;
        }

        public static Boolean IsRootNode(TreeNode node)
        {

            if (node.Level == 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
    
        
}
