using System;
using System.Collections.Generic;
using System.Text;

namespace CommonEntity
{
    public class BaseList:BaseEntity
    {
        private IList<ListItem> listItem = new List<ListItem>();
        public virtual IList<ListItem> ListItem
        {
            get
            {
                return listItem;
            }
            set
            {
                listItem = value;
            }
        }
        /// <summary>
        /// 清单号
        /// </summary>
        public virtual string ListNumber { get; set; }
    }
}
