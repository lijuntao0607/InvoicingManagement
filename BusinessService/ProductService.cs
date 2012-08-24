using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BusinessServiceInterface;
using DomainModule;
using DataAccess;
using ViewModel;
using Utility;
using System.Collections;

namespace BusinessService
{
    public class ProductService:IProductService
    {
        public ProductDao<ProductInfo> ProductDao { get; set; }
        public DictionaryDao<Unit> UnitDao { get; set; }
        public SpecificationDao<Specification> SpecificationDao { get; set; }
        public ProductService()
        {
            ProductDao = new ProductDao<ProductInfo>();
            UnitDao = new DictionaryDao<Unit>();
            SpecificationDao = new SpecificationDao<Specification>();
        }
        public void Add(DomainModule.ProductInfo product)
        {
            try
            {
                NHinbernateSessionFactory.OpenSession();
            
                ProductDao.Save(product);
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

        public void Update(DomainModule.ProductInfo product)
        {
            try
            {
                NHinbernateSessionFactory.OpenSession();

                ProductDao.Update(product);
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

        public void Delete(string id)
        {
            try
            {
                NHinbernateSessionFactory.OpenSession();

                ProductDao.Delete(ProductDao.Get(id));
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

        public IList<DomainModule.ProductInfo> GetList()
        {
            try
            {
                NHinbernateSessionFactory.OpenSession();

                
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                NHinbernateSessionFactory.Commit();
            }
            return null;

        }


        public IList<ViewModel.ProductView> GetProductViewList(Category category, List<CommonEntity.DataFilter> filters)
        {
            IList<ProductView> result = new List<ProductView>();
            IList list = null;
            try
            {
                NHinbernateSessionFactory.OpenSession();
                //string queryString = " select new ProductView(p.ProductName,p.ProductNumber,p.Category.CategoryName,p.taxRate,)";
                string queryString = " select p.Id,s.Id,p.ProductName,p.ProductNumber," +
                    " c.CategoryName,p.TaxRate,s.Barcode,u.DicName,s.UnitPrice,s.SpecifiText " +
                    " from Specification as s left join s.Product as p left join s.Product.Category as c left join s.Unit as u where p.IsDel=false and s.IsDel=false ";
                if (category != null)
                {
                    queryString += " and s.Product.Category.NodePath like '" + category.Id + "' and ";
                }

                DataFilterFactory.NewInstance.ProduceQueryString(filters, "s.Product");
                list = ProductDao.GetObjectList(queryString);
                for (int i = 0; i < list.Count ; i++)
                {
                    result.Add(new ProductView((object[])list[i]));
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                NHinbernateSessionFactory.Commit();
            }



            return result;
        }


        public void Add(ProductInfo product, IList<SpecificationView> list)
        {
            try
            {
                NHinbernateSessionFactory.OpenSession();
                //List<Specification> spList = new List<Specification>();
                for (int i = 0; i < list.Count; i++)
                {
                    ProductDao.SaveOrUpdate(product);

                    SpecificationView view = list[i];
                    Specification spec = Translate(view);
                    SpecificationDao.Save(spec);
                    spec.Product = product;

                    //spList.Add();
                }

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

        public Specification Translate(SpecificationView view)
        {
            Specification spec = new Specification();
            spec.Id = view.Id;
            spec.UnitPrice = view.UnitPrice;
            spec.SpecifiText = view.SpecifiText;
            spec.Barcode = view.Barcode;
            spec.Unit = UnitDao.Get(view.UnitId);
            spec.IsDel = view.IsDel;
            return spec;
        }

        public SpecificationView Translate(Specification spec)
        {
            SpecificationView view = new SpecificationView(spec);
            return view;
        }

        /// <summary>
        /// 根据条码查找规格
        /// </summary>
        /// <param name="barcode"></param>
        /// <returns></returns>
        public Specification GetByBarcode(string barcode)
        {
            try
            {
                NHinbernateSessionFactory.OpenSession();
                return (Specification)ProductDao.Unique("from Specification as s where s.Barcode=? and s.IsDel=false", new ArrayList() {barcode });

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
        /// <summary>
        /// 根据货号查找产品
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public ProductInfo GetByProductNumber(string number)
        {
            try
            {
                NHinbernateSessionFactory.OpenSession();
                return (ProductInfo)ProductDao.Unique("from ProductInfo as p where p.ProductNumber=? and p.IsDel=false", new ArrayList() { number });

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


        public ProductInfo Get(string id)
        {
            try
            {
                NHinbernateSessionFactory.OpenSession();
                return ProductDao.Get(id);

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


        public Specification GetSpecification(string id)
        {
            try
            {
                
                NHinbernateSessionFactory.OpenSession();
                var s=  this.SpecificationDao .Get(id);
                var a = s.Product;
                var b = s.Product.SpecList;
                var c = s.Product.Category;
                var d = s.Unit;
                return s;
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


        public void SaveOrUpdateSpecification(Specification spec)
        {
            try
            {
                NHinbernateSessionFactory.OpenSession();
                SpecificationDao.SaveOrUpdate(spec);

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


        public void Update(ProductInfo product, IList<SpecificationView> list)
        {            
            try
            {
                NHinbernateSessionFactory.OpenSession();
                ProductDao.Update(product);

                for (int i = 0; i < list.Count; i++)
                {
                    var spec = SystemVariable.ProductService.Translate(list[i]);
                    spec.Product = product;
                    SpecificationDao.SaveOrUpdate(spec);
                }
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
