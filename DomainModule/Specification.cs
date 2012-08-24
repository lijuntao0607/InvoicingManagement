using System;
using System.Collections.Generic;
using System.Text;
using CommonEntity;

namespace DomainModule
{
    public class Specification:BaseEntity
    {
        //商品名称*+商品编号*+商品规格*+条码*+品种+单位+含税进价*+税率*+属性（配/购）
        public virtual ProductInfo Product { get; set; }
        public virtual string Barcode { get; set; }
        public virtual Unit Unit { get; set; }
        public virtual double? UnitPrice { get; set; }
        public virtual string SpecifiText { get; set; }

    }
}
