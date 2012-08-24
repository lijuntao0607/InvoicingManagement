using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CommonEntity;

namespace DataAccess
{
    public class BaseListDao<T>:BaseDao<T> where T:BaseEntity
    {

    }
}
