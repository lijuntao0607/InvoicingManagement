using System;
using System.Collections.Generic;
using System.Text;
using CommonEntity;

namespace DomainModule
{
    public class SystemDictionary:BaseEntity
    {
        public virtual string DicNumber { get; set; }
        public virtual string DicName { get; set; }
        public virtual string MnemonicCode { get; set; }

    }
}
