using System;
using System.Collections.Generic;
using System.Text;
using DomainModule;
using CommonEntity;
using ViewModel;

namespace DataAccess
{
    public class ProductDao<T>:BaseDao<T> where T:ProductInfo
    {
        /// <summary>
        /// 获取产品试图列表
        /// </summary>
        /// <param name="hql"></param>
        /// <returns></returns>
        public IList<ProductView> GetProductViewList(string hql)
        {
            return NHinbernateSessionFactory.GetSession().CreateQuery(hql).List<ProductView>();
        }
    }
}
