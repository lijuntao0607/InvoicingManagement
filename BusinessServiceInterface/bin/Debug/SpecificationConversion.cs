using System;
using System.Collections.Generic;
using System.Text;
using CommonEntity;

namespace DomainModule
{
    /// <summary>
    /// 规格转换
    /// </summary>
    public class SpecConversion:BaseEntity
    {
        public virtual Specification SpecOriginal { get; set; }
        public virtual Specification SpecTarget { get; set; }
        public virtual double Amount { get; set; }

    }
}
