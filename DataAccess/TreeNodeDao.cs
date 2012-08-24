using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CommonEntity;

namespace DataAccess
{
    public class TreeNodeDao<T>:BaseDao<T> where T:TreeNode
    {
        public override T Save(T o)
        {
            if (o.Parent != null)
            {
                o.NodePath = o.Parent.NodePath + ","+o.Parent.Id;
            }
            return base.Save(o);
        }
    }
}
