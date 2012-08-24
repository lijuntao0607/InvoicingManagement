using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BusinessServiceInterface;
using DataAccess;
using DomainModule;
using ViewModel;
using System.Collections;

namespace BusinessService
{
    public class WarehouseService:IWarehouseService
    {
        public ProductDao<ProductInfo> ProductDao { get; set; }
        public WarehouseService()
        {
            ProductDao = new ProductDao<ProductInfo>();
        }
        public IList<ProductView> GetListByUser(string userId)
        {
            IList<ProductView> result = new List<ProductView>();
            IList list = null;
            try
            {
                NHinbernateSessionFactory.OpenSession();

                //string queryString = " select new ProductView(p.ProductName,p.ProductNumber,p.Category.CategoryName,p.taxRate,)";
                string queryString = " select p.Id,s.Id,p.ProductName,p.ProductNumber," +
                    " c.CategoryName,p.TaxRate,s.Barcode,u.DicName,s.UnitPrice,s.SpecifiText,witem.Amount " +
                    " from WarehouseItem as witem left join witem.Specification as s left join s.Product as p left join p.Category as c left join s.Unit as u where p.IsDel=false and s.IsDel=false "+
                    " and witem.Warehouse.User.Id='"+userId+"'";

                list = ProductDao.GetObjectList(queryString);
                for (int i = 0; i < list.Count; i++)
                {
                    result.Add(new ProductView((object[])list[i]));
                }

                return result;
            }
            catch (NHibernate.HibernateException hex)
            {
                NHinbernateSessionFactory.Rollback();
                throw hex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                NHinbernateSessionFactory.Commit();
            }
        }
    }
}
