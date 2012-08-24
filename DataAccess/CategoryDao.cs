using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DomainModule;

namespace DataAccess
{
    public class CategoryDao<T> : TreeNodeDao<T> where T : Category
    {
        public IList<T> GetAll()
        {
            return GetList("from Category as c where c.IsDel=false");
        }
    }
}
