using System;
using System.Collections.Generic;
using System.Text;
using CommonEntity;

namespace DomainModule
{
    public class WarehouseItem:BaseEntity
    {
        public virtual Warehouse Warehouse { get; set; }
        public virtual Specification Specification { get; set; }
        public virtual double Amount { get; set; }
        
    }
}
