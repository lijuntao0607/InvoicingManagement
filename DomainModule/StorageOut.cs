using System;
using System.Collections.Generic;
using System.Text;
using CommonEntity;

namespace DomainModule
{
    public class StorageOut : BaseList
    {
        public virtual UserInfo User { get; set; }
        public virtual DateTime? StorageInTime { get; set; }
        public virtual Warehouse Warehouse { get; set; }
    }
}
