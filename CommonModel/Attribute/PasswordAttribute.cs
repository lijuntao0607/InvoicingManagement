using System;
using System.Collections.Generic;
using System.Text;

namespace CommonEntity.Attribute
{
    [AttributeUsage(AttributeTargets.Field, Inherited = true)]
    public class PasswordAttribute:System.Attribute
    {
        public PasswordAttribute()
        {
        }
    }
}
