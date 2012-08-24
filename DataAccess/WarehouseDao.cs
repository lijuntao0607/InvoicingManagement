using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DomainModule;

namespace DataAccess
{
    public class WarehouseDao<T> :BaseDao<T> where T:Warehouse
    {
        public virtual Warehouse GetWarehouseByUser(string userId)
        {
            return NHinbernateSessionFactory.GetSession().CreateQuery("from Warehouse as w where w.IsDel=false and w.User.Id=?").SetString(0, userId).UniqueResult<T>();
        }
    }
}
