using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DomainModule;

namespace DataAccess
{
    public class WarehouseItemDao<T> :BaseDao<T> where T:WarehouseItem
    {
        public T GetBySpecId(string warehouseId,string specId)
        {
            return NHinbernateSessionFactory.GetSession().CreateQuery("from WarehouseItem as wi where wi.IsDel=false and wi.Specification.Id=? and wi.Warehouse.Id=?").SetString(0,specId).SetString(1,warehouseId).UniqueResult<T>();
        }
        public IList<T> GetList(string userId)
        {
            IList<T> list = null;
            string hql = "from WarehouseItem as witem where witem.IsDel=false and witem.Warehouse.User.Id=?";
            list = NHinbernateSessionFactory.GetSession().CreateQuery(hql).SetString(0,userId).List<T>();
            return list;
        }
    }
}
