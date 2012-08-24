using System;
using System.Collections.Generic;
using System.Text;

namespace CommonEntity
{
    public class TreeNode:BaseEntity
    {
        public virtual TreeNode Parent { get; set; }
        public virtual string NodePath { get; set; }
    }
}
