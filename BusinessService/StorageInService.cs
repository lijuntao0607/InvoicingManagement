using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BusinessServiceInterface;
using DataAccess;
using DomainModule;
using Utility;
using ViewModel;
using System.Collections;

namespace BusinessService
{
    public class StorageInService : IStorageInService
    {
        public StorageInDao<StorageIn> StorageInDao { get; set; }
        public StorageInItemDao<StorageInItem> StorageInItemDao { get; set; }
        public WarehouseDao<Warehouse> WarehouseDao { get; set; }
        public WarehouseItemDao<WarehouseItem> WarehouseItemDao { get; set; }
        public StorageInService()
        {
            StorageInDao = new StorageInDao<StorageIn>();
            StorageInItemDao = new StorageInItemDao<StorageInItem>();
            WarehouseDao = new WarehouseDao<Warehouse>();
            WarehouseItemDao = new WarehouseItemDao<WarehouseItem>();
        }
        public DomainModule.StorageIn Get(string id)
        {
            try
            {
                NHinbernateSessionFactory.OpenSession();
                return StorageInDao.Get(id) ;
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

        public void Add(DomainModule.StorageIn si)
        {
            try
            {
                NHinbernateSessionFactory.OpenSession();
                StorageInDao.Save(si);
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

        public void Add(DomainModule.StorageIn si, IList<StorageInItem> list)
        {
            try
            {
                NHinbernateSessionFactory.OpenSession();
                si.Warehouse = WarehouseDao.GetWarehouseByUser(si.User.Id);
                StorageInDao.Save(si);
                for (int i = 0; i < list.Count; i++)
                {
                    list[i].List = si;
                    StorageInItemDao.Save(list[i]);
                    WarehouseItem witem = WarehouseItemDao.GetBySpecId(si.Warehouse.Id, list[i].Specification.Id);
                    if (witem == null)
                    {
                        witem = new WarehouseItem();
                        witem.Warehouse = si.Warehouse;
                        witem.Specification = list[i].Specification;
                        witem.Amount = 0;
                    }
                    witem.Amount += list[i].Amount;
                    WarehouseItemDao.SaveOrUpdate(witem);
                }
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

        public void Update(DomainModule.StorageIn si)
        {
            try
            {
                NHinbernateSessionFactory.OpenSession();
                StorageInDao.Update(si);
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

        public void Update(DomainModule.StorageIn si, IList<StorageInItem> list)
        {
            throw new NotImplementedException();
        }

        public void Delete(string id)
        {
            throw new NotImplementedException();
        }

        //public ViewModel.StorageInItemView GetItem(string id)
        //{
        //    throw new NotImplementedException();
        //}

        public void DeleteItem(string id)
        {
            throw new NotImplementedException();
        }

        public IList<DomainModule.StorageIn> GetList(List<CommonEntity.DataFilter> filters)
        {
            try
            {
                NHinbernateSessionFactory.OpenSession();

                return StorageInDao.GetList(" from StorageIn as si where si.IsDel=false "+DataFilterFactory.NewInstance.ProduceQueryString(filters,"si"));
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

        public List<StorageInView> GetView()
        {
            try
            {
                NHinbernateSessionFactory.OpenSession();
                List<StorageInView> viewList = new List<StorageInView>();
                IList list = StorageInDao.GetObjectList("select l.Id,l.ListNumber,l.StorageInTime,sum(item.UnitPrice*item.Amount),sum(item.Amount) from StorageInItem as item left join item.List as l where l.IsDel=false  group by l.Id,l.ListNumber,l.StorageInTime");
                for (int i = 0; i < list.Count; i++)
                {
                    viewList.Add(new StorageInView((object[])list[i]));
                }
                return viewList;
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
        public List<ProductView> GetItemView(string id)
        {
            try
            {
                NHinbernateSessionFactory.OpenSession();
                List<ProductView> viewList = new List<ProductView>();
                string hql = " select p.Id,s.Id,p.ProductName,p.ProductNumber," +
                    " c.CategoryName,sitem.TaxRate,s.Barcode,u.DicName,sitem.UnitPrice,s.SpecifiText,sitem.Amount " +
                    " from StorageInItem as sitem left join sitem.Specification as s left join s.Product as p left join s.Product.Category as c left join s.Unit as u where p.IsDel=false and s.IsDel=false and sitem.List.Id='"+id+"'";
                IList list = StorageInDao.GetObjectList(hql);
                for (int i = 0; i < list.Count; i++)
                {
                    viewList.Add(new ProductView((object[])list[i]));
                }
                return viewList;
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



        //StorageInItem IStorageInService.DeleteItem(string id)
        //{
        //    throw new NotImplementedException();
        //}


        public List<StorageInView> GetView(string userId)
        {
            try
            {
                NHinbernateSessionFactory.OpenSession();
                List<StorageInView> viewList = new List<StorageInView>();
                IList list = StorageInDao.GetObjectList("select l.Id,l.ListNumber,l.StorageInTime,sum(item.UnitPrice*item.Amount),sum(item.Amount) from StorageInItem as item left join item.List as l where l.IsDel=false and l.User.Id='"+userId+"'  group by l.Id,l.ListNumber,l.StorageInTime");
                for (int i = 0; i < list.Count; i++)
                {
                    viewList.Add(new StorageInView((object[])list[i]));
                }
                return viewList;
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
