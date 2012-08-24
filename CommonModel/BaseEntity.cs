using System;
using System.Collections.Generic;
using System.Text;

namespace CommonEntity
{
    /// <summary>
    /// 
    /// 框架基础实体类
    /// 
    /// 作者：奥大帅
    /// </summary>
    public class BaseEntity
    {
        public BaseEntity()
        {
            Id = Guid.NewGuid().ToString();
            CreateTime = DateTime.Now;
            IsDel = false;
        }

        public virtual String Id { get; set; }
        /// <summary>
        /// 创建日期
        /// </summary>


        private DateTime? createTime;

        public virtual DateTime? CreateTime
        {
            get { return createTime; }
            set { createTime = value; }
        }

        /// <summary>
        /// 是否已删除的
        /// </summary>
        public virtual bool? IsDel { get; set; }
    }

    
}
