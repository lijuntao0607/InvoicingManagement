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
    public class StorageOutService : IStorageOutService
    {
        public StorageOutDao<StorageOut> StorageOutDao { get; set; }
        public StorageOutItemDao<StorageOutItem> StorageOutItemDao { get; set; }
        public WarehouseDao<Warehouse> WarehouseDao { get; set; }
        public WarehouseItemDao<WarehouseItem> WarehouseItemDao { get; set; }
        public StorageOutService()
        {
            StorageOutDao = new StorageOutDao<StorageOut>();
            StorageOutItemDao = new StorageOutItemDao<StorageOutItem>();
            WarehouseDao = new WarehouseDao<Warehouse>();
            WarehouseItemDao = new WarehouseItemDao<WarehouseItem>();
        }
        public DomainModule.StorageOut Get(string id)
        {
            try
            {
                NHinbernateSessionFactory.OpenSession();
                return StorageOutDao.Get(id);
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

        public void Add(DomainModule.StorageOut si)
        {
            try
            {
                NHinbernateSessionFactory.OpenSession();
                StorageOutDao.Save(si);
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

        public void Add(DomainModule.StorageOut si, IList<StorageOutItem> list)
        {
            try
            {
                NHinbernateSessionFactory.OpenSession();
                si.Warehouse = WarehouseDao.GetWarehouseByUser(si.User.Id);
                StorageOutDao.Save(si);
                for (int i = 0; i < list.Count; i++)
                {
                    list[i].List = si;
                    StorageOutItemDao.Save(list[i]);
                    WarehouseItem witem = WarehouseItemDao.GetBySpecId(si.Warehouse.Id, list[i].Specification.Id);
                    if (witem == null)
                    {
                        witem = new WarehouseItem();
                        witem.Warehouse = si.Warehouse;
                        witem.Specification = list[i].Specification;
                        witem.Amount = 0;
                    }
                    witem.Amount -= list[i].Amount;
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

        public void Update(DomainModule.StorageOut si)
        {
            try
            {
                NHinbernateSessionFactory.OpenSession();
                StorageOutDao.Update(si);
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

        public void Update(DomainModule.StorageOut si, IList<StorageOutItem> list)
        {
            throw new NotImplementedException();
        }

        public void Delete(string id)
        {
            throw new NotImplementedException();
        }

        //public ViewModel.StorageOutItemView GetItem(string id)
        //{
        //    throw new NotImplementedException();
        //}

        public void DeleteItem(string id)
        {
            throw new NotImplementedException();
        }

        public IList<DomainModule.StorageOut> GetList(List<CommonEntity.DataFilter> filters)
        {
            try
            {
                NHinbernateSessionFactory.OpenSession();

                return StorageOutDao.GetList(" from StorageOut as si where si.IsDel=false " + DataFilterFactory.NewInstance.ProduceQueryString(filters, "si"));
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

        public List<StorageOutView> GetView()
        {
            try
            {
                NHinbernateSessionFactory.OpenSession();
                List<StorageOutView> viewList = new List<StorageOutView>();
                IList list = StorageOutDao.GetObjectList("select l.Id,l.ListNumber,l.StorageOutTime,sum(item.UnitPrice*item.Amount),sum(item.Amount) from StorageOutItem as item left join item.List as l where l.IsDel=false  group by l.Id,l.ListNumber,l.StorageOutTime");
                for (int i = 0; i < list.Count; i++)
                {
                    viewList.Add(new StorageOutView((object[])list[i]));
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
                    " from StorageOutItem as sitem left join sitem.Specification as s left join s.Product as p left join s.Product.Category as c left join s.Unit as u where p.IsDel=false and s.IsDel=false and sitem.List.Id='"+id+"'";
                IList list = StorageOutDao.GetObjectList(hql);
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



        //StorageOutItem IStorageOutService.DeleteItem(string id)
        //{
        //    throw new NotImplementedException();
        //}


        public List<StorageOutView> GetView(string userId)
        {
            try
            {
                NHinbernateSessionFactory.OpenSession();
                List<StorageOutView> viewList = new List<StorageOutView>();
                IList list = StorageOutDao.GetObjectList("select l.Id,l.ListNumber,l.StorageOutTime,sum(item.UnitPrice*item.Amount),sum(item.Amount) from StorageOutItem as item left join item.List as l where l.IsDel=false and l.User.Id='" + userId + "'  group by l.Id,l.ListNumber,l.StorageOutTime");
                for (int i = 0; i < list.Count; i++)
                {
                    viewList.Add(new StorageOutView((object[])list[i]));
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

        public string GetStorageOutNumber()
        {
            try
            {
                NHinbernateSessionFactory.OpenSession();

                string dt = DateTime.Now.ToShortDateString();
                List<string> myList = new List<string>(dt.Split('/'));
                if (myList[0].Length == 1)
                    dt = myList[2] + "0" + myList[0] + myList[1];
                else

                    dt = myList[2] + myList[0] + myList[1];

                var obj = StorageOutDao.Unique("select si.ListNumber from StorageOut as si order by si.CreateTime desc");
                if (obj == null)
                {
                    return dt + "01";
                }
                string oldNumber = obj.ToString().Trim();
                

                 //dt = dt.Substring(7, 4) + dt.Substring(4, 2) + dt.Substring(1, 2);
                
                if ( (oldNumber == null) || (oldNumber==""))
                {
                    return dt + "01";
                }
                else
                {
                    if (oldNumber.Substring(0, 8) == dt)
                        if (Int32.Parse(oldNumber.Substring(8, oldNumber.Length - 8)) > 9)
                            return dt + (Int32.Parse(oldNumber.Substring(8, oldNumber.Length - 8)) + 1);
                        else
                            return dt + "0" + (Int32.Parse(oldNumber.Substring(8, oldNumber.Length - 8)) + 1);
                    else
                        return dt + "01";

                }

                //\\return oldNumber;
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
