using System;
using System.Collections.Generic;
using System.Text;
using CommonEntity;
using System.Collections;
using NHibernate;
using System.Data;

namespace DataAccess
{
    public class BaseDao<T> where T:BaseEntity
    {
        /// <summary>
        /// 添加一条记录
        /// </summary>
        /// <param name="o"></param>
        /// <returns></returns>
        public virtual T Save(T o)
        {
            o.Id= NHinbernateSessionFactory.GetSession().Save(o).ToString ();
            return o;
        }
        public virtual object Save(object o)
        {
             NHinbernateSessionFactory.GetSession().Save(o).ToString();
            return o;
        }
        public virtual object Unique(string hql)
        {
            return Unique(hql, null);
        }

        public virtual object Unique(string hql,IList param)
        {
            IQuery query=NHinbernateSessionFactory .GetSession().CreateQuery(hql);
            if (param != null && param.Count > 0)
            {
                for (int i = 0; i < param.Count; i++)
			    {
			        query.SetParameter(i,param[i]);
			    }
            }
            return query.SetMaxResults(1).UniqueResult();
        }
        /// <summary>
        /// 逻辑删除一条记录
        /// </summary>
        /// <param name="o"></param>
        /// <returns></returns>
        public virtual bool Delete(T o)
        {
            //NHinbernateSessionFactory.GetSession().Delete(o);
            o.IsDel = true;
            NHinbernateSessionFactory.GetSession().Update(o);
            return true;
        }

        /// <summary>
        /// 逻辑删除一条记录
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public virtual bool Delete(string id)
        {
            return Delete(Get(id));
        }

        /// <summary>
        /// 根据主键获取实体
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public virtual T Get(String id)
        {
            return NHinbernateSessionFactory.GetSession().Get<T>(id);
        }
        public virtual T Get(String id,Type t)
        {
            return (T)NHinbernateSessionFactory.GetSession().Get(id,t);
        }
        /// <summary>
        /// 更新实体
        /// </summary>
        /// <param name="o"></param>
        public virtual void Update(T o)
        {
            NHinbernateSessionFactory.GetSession().Update(o);
        }
        public virtual void SaveOrUpdate(T o)
        {
            NHinbernateSessionFactory.GetSession().SaveOrUpdate(o);
        }
        public virtual void SaveOrUpdate(object o)
        {
            NHinbernateSessionFactory.GetSession().SaveOrUpdate(o);
        }
        public virtual void SaveOrUpdate(string entityName,object o)
        {
            NHinbernateSessionFactory.GetSession().SaveOrUpdate(entityName,o);
        }
        /// <summary>
        /// 物理删除一条记录
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public virtual bool PhysicsDelete(string id)
        {
            return PhysicsDelete(Get(id));
        }
        /// <summary>
        /// 物理删除一条记录
        /// </summary>
        /// <param name="o"></param>
        /// <returns></returns>
        public virtual bool PhysicsDelete(T o)
        {
            NHinbernateSessionFactory.GetSession().Delete(o);
            return true;
        }
        public virtual IList<T> GetList(string hql)
        {
            return GetList(hql, null);
        }

        public virtual IList GetObjectList(string hql)
        {
            return NHinbernateSessionFactory.GetSession().CreateQuery(hql).List();
        }
        public virtual IList<T> GetList(string hql, IList param)
        {
            IQuery query =NHinbernateSessionFactory.GetSession().CreateQuery(hql);
            if (param != null)
            {
                for (int i = 0; i < param.Count; i++)
                {
                    query.SetParameter(i, param[i]);
                }
            }

            return query.List<T>();
        }

        public virtual IList<T> GetList(string hql, IList param, int start, int limit)
        {
            IQuery query = NHinbernateSessionFactory.GetSession().CreateQuery(hql);
            for (int i = 0; i < param.Count; i++)
            {
                query.SetParameter(i, param[i]);
            }
            
            return query.SetFirstResult(start).SetMaxResults(limit).List<T>();
        }
        public object ExecuteScale(string s)
        {
            return ExecuteScale(s, CommandType.Text, null);
        }
        public object ExecuteScale(string s, CommandType type, ArrayList param)
        {
            IDbCommand cmd = NHinbernateSessionFactory.GetSession() .Connection.CreateCommand();
            NHinbernateSessionFactory.GetSession().Transaction.Enlist(cmd);
            cmd.CommandText = s;
            cmd.CommandType = type;
            if (param != null)
            {
                foreach (IDataParameter p in param)
                {
                    cmd.Parameters.Add(p);
                }
            }
            return cmd.ExecuteScalar();
        }

        public IDataReader Execute(string s,ArrayList param)
        {
            return Execute(s, CommandType.Text, param);
        }
        public IDataReader Execute(string s)
        {
            return Execute(s, CommandType.Text, null);
        }
        public IDataReader Execute(string s, CommandType type, ArrayList param)
        {
            IDbCommand cmd = NHinbernateSessionFactory.GetSession().Connection.CreateCommand();
            NHinbernateSessionFactory.GetSession().Transaction.Enlist(cmd);
            cmd.CommandText = s;
            cmd.CommandType = type;
            if (param != null)
            {
                foreach (IDataParameter p in param)
                {
                    cmd.Parameters.Add(p);
                }
            }
            return cmd.ExecuteReader();

        }

        public int ExecuteNonQuery(string s)
        {
            return ExecuteNonQuery(s, CommandType.Text, null);
        }
        public int ExecuteNonQuery(string s, CommandType type, ArrayList param)
        {
            IDbCommand cmd = NHinbernateSessionFactory.GetSession().Connection.CreateCommand();
            NHinbernateSessionFactory.GetSession().Transaction.Enlist(cmd);
            cmd.CommandText = s;
            cmd.CommandType = type;

            if (param != null)
            {
                foreach (IDataParameter p in param)
                {
                    cmd.Parameters.Add(p);
                }
            }
            return cmd.ExecuteNonQuery();
        }
        /// <summary>

        /// 填充DataSet

        /// </summary>

        /// <param name="sql"></param>

        /// <returns></returns>

        public DataSet ExecuteDataset(string sql)
        {

            ISession session = null;

            DataSet ds = new DataSet();

            try
            {

                session = NHinbernateSessionFactory.GetSession();

                IDbCommand command = session.Connection.CreateCommand();

                command.CommandText = sql;



                IDataReader reader = command.ExecuteReader();

                DataTable result = new DataTable();

                //result.Load(reader);//此方法亦可

                DataTable schemaTable = reader.GetSchemaTable();

                for (int i = 0; i < schemaTable.Rows.Count; i++)
                {

                    string columnName = schemaTable.Rows[i][0].ToString();

                    result.Columns.Add(columnName);

                }

                while (reader.Read())
                {

                    int fieldCount = reader.FieldCount;

                    object[] values = new Object[fieldCount];

                    for (int i = 0; i < fieldCount; i++)
                    {

                        values[i] = reader.GetValue(i);

                    }

                    result.Rows.Add(values);

                }

                ds.Tables.Add(result);

            }

            catch (Exception ex)
            {

                throw ex;

            }

            finally
            {

                if (session != null)
                {

                    session.Close();

                }

            }

            return ds;

        }

    }
}
