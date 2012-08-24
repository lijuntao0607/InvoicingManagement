using System;
using System.Collections.Generic;
using System.Text;
using CommonEntity;

namespace DomainModule
{
    /// <summary>
    /// 用户基础信息
    /// </summary>
    public class UserInfo:BaseEntity
    {
        public UserInfo()
        {
            
        }
        public virtual string LoginName { get; set; }
        public virtual string Password { get; set; }
        public virtual string UserName { get; set; }
        public virtual string AmwayCardId { get; set; }
        public virtual string Address { get; set; }
        public virtual string IdentityNumber { get; set; }
        public virtual string Phone { get; set; }
        public virtual DateTime? StartTime { get; set; }
        public virtual DateTime? EndTime { get; set; }
    }
}
