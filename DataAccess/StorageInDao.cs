using System;
using System.Collections.Generic;
using System.Text;
using DomainModule;

namespace DataAccess
{
    public class StorageInDao<T>:BaseDao<T> where T:StorageIn
    {
    }
}
