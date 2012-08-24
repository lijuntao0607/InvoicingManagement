using System;
using System.Collections.Generic;
using System.Text;
using DomainModule;

namespace DataAccess
{
    public class UserDao<T>:BaseDao<T> where T:UserInfo
    {
        /// <summary>
        /// 判断是否存在相同用户名
        /// </summary>
        /// <param name="loginName"></param>
        /// <returns></returns>
        public bool HaveSameLoginName(string loginName)
        {
            var session = NHinbernateSessionFactory.GetSession();
            var result=session.CreateQuery("select 1 from UserInfo as u where u.LoginName=?").SetString(0, loginName).UniqueResult();
            if (result == null)
            {
                return false;
            }
            return true ;
        }
    }
}
