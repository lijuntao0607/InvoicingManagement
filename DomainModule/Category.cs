using System;
using System.Collections.Generic;
using System.Text;
using CommonEntity;

namespace DomainModule
{
    public class Category:TreeNode
    {

        public virtual string CategoryName { get; set; }
    }
}
