using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BusinessServiceInterface;
using DataAccess;
using DomainModule;

namespace BusinessService
{
    public class CategoryService : ICategoryService
    {
        public CategoryDao<Category> CategoryDao { get; set; }
        public CategoryService()
        {
            CategoryDao = new CategoryDao<Category>();
        }
        public void Add(DomainModule.Category c)
        {
            try
            {
                NHinbernateSessionFactory.OpenSession();
CategoryDao.Save(c);

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

CategoryDao.Delete(id);
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



        public IList<Category> GetAll()
        {
            try
            {
                NHinbernateSessionFactory.OpenSession();

                IList<Category> list= CategoryDao.GetAll();
                return list;
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


        public Category Get(string id)
        {
            try
            {
                NHinbernateSessionFactory.OpenSession();

                var o= CategoryDao.Get(id);
                return o;
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


        public void Update(Category c)
        {
            try
            {
                NHinbernateSessionFactory.OpenSession();
                CategoryDao.Update(c);

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
