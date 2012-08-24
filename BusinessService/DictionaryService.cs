using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BusinessServiceInterface;
using ViewModel;
using DomainModule;
using DataAccess;

namespace BusinessService
{
    public class DictionaryService:IDictionaryService
    {
        public DictionaryDao<SystemDictionary> DictionaryDao { get; set; }
        public DictionaryService()
        {
            DictionaryDao = new DictionaryDao<SystemDictionary>();
        }
        public IDictionary<string, IList<SystemDictionary>> GetAllDictionary()
        {
            NHinbernateSessionFactory.OpenSession();
            
            IDictionary<string, IList<SystemDictionary>> dic = new Dictionary<string, IList<SystemDictionary>>();
            string[] dicList = new string[] {
                "Unit"
            };
            for (int i = 0; i < dicList.Length; i++)
            {
                dic.Add(dicList[i],DictionaryDao.GetList("from "+dicList[i]+" as d where d.IsDel=false"));
            }
            NHinbernateSessionFactory.Commit();
            //IList<Unit> unitList = DictionaryDao.GetList("select ");
            return dic;
        }




        public void SaveRange(IList<SystemDictionary> list)
        {

            try
            {
                NHinbernateSessionFactory.OpenSession();
for (int i = 0; i < list.Count; i++)
            {
                //NHinbernateSessionFactory.GetSession().SaveOrUpdate(list[i]);
                DictionaryDao.SaveOrUpdate(list[i]);
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


        public void Delete(string id)
        {
            try
            {
                NHinbernateSessionFactory.OpenSession();

DictionaryDao.Delete(id);
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

        public void Delete(SystemDictionary dic)
        {
            try
            {
                NHinbernateSessionFactory.OpenSession();
DictionaryDao.Delete(dic);

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


        public void SaveRange(System.Collections.ArrayList list)
        {
            try
            {
                NHinbernateSessionFactory.OpenSession();
for (int i = 0; i < list.Count; i++)
            {
                //NHinbernateSessionFactory.GetSession().SaveOrUpdate(list[i]);
                DictionaryDao.SaveOrUpdate(list[i]);
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
        public void SaveRange(string entityName,System.Collections.ArrayList list)
        {
            try
            {
                NHinbernateSessionFactory.OpenSession();

for (int i = 0; i < list.Count; i++)
            {
                //NHinbernateSessionFactory.GetSession().SaveOrUpdate(list[i]);
                DictionaryDao.SaveOrUpdate(entityName,list[i]);
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


        public void Save(object obj)
        {
            try
            {
                NHinbernateSessionFactory.OpenSession();
DictionaryDao.Save(obj);

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
