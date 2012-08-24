using System;
using System.Collections.Generic;
using System.Text;
using BusinessServiceInterface;
using DomainModule;
using DataAccess;
using NHibernate;
using System.Collections;

namespace BusinessService
{
    public class UserService:IUserService
    {
        public UserDao<UserInfo>  UserDao { get; set; }
        public WarehouseDao<Warehouse> WarehouseDao { get; set; }
        public UserService()
        {
            UserDao = new UserDao<UserInfo>();
            WarehouseDao = new WarehouseDao<Warehouse>();
        }
        /// <summary>
        /// 未完成
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        public bool HaveSameUserName(string username)
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

            return false;
        }

        public UserInfo Login(string loginName,string password)
        {
            try
            {
                NHinbernateSessionFactory.OpenSession();

                IList param = new ArrayList();
                param.Add(loginName);
                param.Add(password);
                string hql = "from UserInfo as u where u.LoginName=? and u.Password=? and u.IsDel=false";
                IList<UserInfo> list= UserDao.GetList(hql, param);
                NHinbernateSessionFactory.Commit();
                if (list == null || list.Count == 0)
                {
                    return null;
                }
                else
                {
                    return list[0];
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

        public void Logout(UserInfo user)
        {
            throw new NotImplementedException();
        }


        public bool RegisterUser(UserInfo user)
        {
            bool result=false;
            try
            {
                NHinbernateSessionFactory.OpenSession();

                if (UserDao.HaveSameLoginName(user.LoginName))
                {
                    result= false;
                }
                Warehouse w = new Warehouse();

                UserInfo u = UserDao.Save(user);
                if (u == null)
                {
                    result = false;
                }
                else
                {
                    result = true;
                    
                    w.User = u;
                    w.Name = "默认仓";
                    WarehouseDao.Save(w);
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

    }
}
