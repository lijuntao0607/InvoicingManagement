using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BusinessServiceInterface;
using DataAccess;
using DomainModule;
using ViewModel;
using System.Collections;
using System.Data;

namespace BusinessService
{
    public class WarehouseService:IWarehouseService
    {
        public ProductDao<ProductInfo> ProductDao { get; set; }
        public WarehouseDao<Warehouse> WarehouseDao { get; set; }
        public WarehouseService()
        {
            ProductDao = new ProductDao<ProductInfo>();
            WarehouseDao = new WarehouseDao<Warehouse>();
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
        public DataTable GetInvoicingReportDataTable(DateTime start,DateTime end)
        {
            try
            {
                NHinbernateSessionFactory.OpenSession();
                string sql = "select c.categoryname as Category,p.productname as ProductName,p.productnumber as ProductNumber, " +
    "s.specifitext as SpecifiText,count(sii.id) as StorageInAmount,sum(sii.unitprice*sii.amount) as StorageInTotalPrice, " +
    "count(soi.id) as StorageOutAmount,sum(soi.unitprice*soi.amount) as StorageOutTotalPrice, " +
    "count(sii.id)-count(soi.id) as ProfileLossAmount,sum(sii.unitprice*sii.amount)-sum(soi.unitprice*soi.amount) as ProfileLossTotalPrice ," +
    "count(wi.id) as InventoryAmount,sum(s.unitprice*wi.amount) InventoryTotalPrice " +
    "from tb_specification as s " +
    "left join tb_productinfo as p on s.product=p.id " +
    "left join tb_category as c on c.id=p.category " +
    "left join tb_storageinitem as sii on sii.specification=s.id " +
    "left join tb_storageoutitem as soi on soi.specification=s.id " +
    "left join tb_warehouseitem as wi on wi.specification=s.id "+
    "left join tb_storagein as si on si.id=sii.list "+
    "left join tb_storageout as so on so.id=soi.list "+
    "where si.StorageInTime between date('" + start.ToString("yyyy-MM-dd") + "') and date('" + end.ToString("yyyy-MM-dd") + "') and si.isdel=0 and " +
    "so.StorageInTime between date('" + start.ToString("yyyy-MM-dd") + "') and date('" + end.ToString("yyyy-MM-dd") + "') and so.isdel=0 ";
                return WarehouseDao.ExecuteDataset(sql).Tables[0];
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
