using System;
using System.Collections.Generic;
using System.Text;
using CommonEntity;
using CommonEntity.Attribute;

namespace DomainModule
{
    public class ProductInfo:BaseEntity
    {
        //商品名称*+商品编号*+商品规格*+条码*+品种+单位+含税进价*+税率*+属性（配/购）
        public virtual string ProductName { get; set; }
        public virtual string ProductNumber { get; set; }

        public virtual Category Category { get; set; }
        //public virtual List<Specification> SpecList { get; set; }
        private IList<Specification> specList = new List<Specification>();
        public virtual IList<Specification> SpecList
        {
            get
            {
                return specList;
            }
            set
            {
                specList = value;
            }
        }
        public virtual double? TaxRate { get; set; }

    }
}
