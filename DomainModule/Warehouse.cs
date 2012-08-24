using System;
using System.Collections.Generic;
using System.Text;
using CommonEntity;

namespace DomainModule
{
    public class Warehouse:BaseEntity
    {
        public virtual string Name { get; set; }
        public virtual UserInfo  User { get; set; }

    }
}
