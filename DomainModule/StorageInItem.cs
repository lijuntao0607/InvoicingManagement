using System;
using System.Collections.Generic;
using System.Text;
using CommonEntity;

namespace DomainModule
{
    public class StorageInItem:ListItem
    {
        //public ProductInfo  Product { get; set; }
        public virtual Specification Specification { get; set; }
        public virtual double Amount { get; set; }
        public virtual double UnitPrice { get; set; }
        public virtual double? TaxRate { get; set; }
    }
}
