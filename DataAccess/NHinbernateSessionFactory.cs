using System;
using System.Collections.Generic;
using System.Text;
using NHibernate;
using NHibernate.Cfg;
using System.Threading;

namespace DataAccess
{
    public class NHinbernateSessionFactory
    {
        public static readonly string CurrentSessionKey = "NHibernate.Context.WebSessionContext.SessionFactoryMapKey";
        private  static ISessionFactory _sessionFactory = CreateSessionFactory();
        public static ISessionFactory SessionFactory
        {
            get
            {
                if (_sessionFactory == null)
                    _sessionFactory = CreateSessionFactory();
                return _sessionFactory;
            }
        }
        protected static ISessionFactory CreateSessionFactory()
        {
            return new Configuration()
                .Configure(AppDomain.CurrentDomain.BaseDirectory + "Nhibernate.cfg.xml")
                .BuildSessionFactory();
        }
        public static void SetSession(ISession session)
        {
            Thread.SetData(Thread.GetNamedDataSlot("session"), session);
        }

        public static ISession GetSession()
        {
            object obj = Thread.GetData(Thread.GetNamedDataSlot("session"));
            if (obj == null)
                throw new Exception("no session object!");

            return (ISession)obj;
        }
        public static ISession OpenSession()
        {
            var session = SessionFactory.OpenSession();
            SetSession(session);
            session.Transaction.Begin();
            return session;
        }
        /// <summary>
        /// 提交
        /// </summary>
        public static void Commit()
        {
            var session = GetSession();
            if (session.Transaction != null &&
                session.Transaction.IsActive)
            {
                try
                {
                    session.Transaction.Commit();
                }
                catch (HibernateException ex)
                {
                    //Utils.Log.Error(ex.Message);
                    session.Transaction.Rollback();
                    throw ex;
                }
                finally
                {
                    session.Close();
                }
            }

        }
        /// <summary>
        /// 事物回滚
        /// </summary>
        public static void Rollback()
        {
            var session = GetSession();
            if (session.Transaction != null &&
                session.Transaction.IsActive)
            {
                session.Transaction.Rollback();
            }
            session.Close();
        }
    }
}
