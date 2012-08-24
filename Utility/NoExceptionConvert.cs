using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Utility
{
    public class NoExceptionConvert
    {
        public static string ToString(object value)
        {
            try
            {
                return Convert.ToString(value);
            }
            catch
            {
                return string.Empty;
            }
        }
        public static double ToDouble(object value)
        {
            try
            {
                return Convert.ToDouble(value);
            }
            catch 
            {
                return 0;
            }
        }
    }
}
