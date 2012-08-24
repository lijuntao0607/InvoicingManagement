using System;
using System.Collections.Generic;
using System.Text;

namespace CommonEntity
{
    public class ListItem:BaseEntity
    {
        public virtual BaseList List { get; set; }
    }
}
