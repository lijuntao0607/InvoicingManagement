using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using CommonEntity;

namespace Utility
{
    public class DataFilterFactory
    {
        private static  DataFilterFactory _dataFilterFactory = new DataFilterFactory();
        public static DataFilterFactory NewInstance
        {
            get
            {
                return _dataFilterFactory;
            }
        }

        /// <summary>
        /// 根据查询条件生成查询语句
        /// </summary>
        /// <param name="filters"></param>
        /// <param name="a">实体名</param>
        /// <returns></returns>
        public string ProduceQueryString(List<DataFilter> filters,string a)
        {
            
            if (filters == null)
                return string.Empty;
            StringBuilder result = new StringBuilder();
            if (filters.Count > 0)
            {
                result.Append(" and ");
            }
            //type=string
            var stringList = from f in filters where f.Type.ToLower() == DataFilterType.stringType select f;
            foreach (var i in stringList)
            {
                result.Append(a + "." + i.Field + " like " + "'%" + i.Value + "%'" + " and ");
            }
            //type=boolean
            var booleanList = from f in filters where f.Type.ToLower() == DataFilterType.booleanType select f;
            foreach (var i in booleanList)
            {
                result.Append(a + "." + i.Field + "=" + i.Value + " and ");
            }
            //type=numeric
            var numericList = from f in filters where f.Type.ToLower() == DataFilterType.numericType group f by f.Field into g select g;
            foreach (var i in numericList)
            {
                result.Append("( ");
                string iiStr = string.Empty;
                foreach (var ii in i)
                {
                    iiStr += a + "." + ii.Field + GetComparison(ii.Comparison) + ii.Value + " and ";
                }
                result.Append(iiStr.Substring(0, iiStr.Length - 4));
                result.Append(" )");
                result.Append(" and ");
            }
            //type=date
            var dateList = from f in filters where f.Type == DataFilterType.dateType group f by f.Field into g select g;
            foreach (var i in dateList)
            {
                result.Append("( ");
                string iiStr = string.Empty;
                foreach (var ii in i)
                {
                    iiStr += a + "." + ii.Field + GetComparison(ii.Comparison) + " date('" + ii.Value + "', 'mm/dd/yyyy')" + " and ";
                }
                result.Append(iiStr.Substring(0, iiStr.Length - 4));
                result.Append(" )");
                result.Append(" and ");
            }
            //type=list  :["1","2"]
            var listList = from f in filters where f.Type == DataFilterType.listType select f;
            foreach (var i in listList)
            {
                result.Append(a + "." + i.Field + " in " + i.Value.Replace("[", "( ").Replace("]", " )").Replace("\"", "'") + " and ");
            }

            return result.ToString().Substring(0, result.Length - 4);
            
        }
        private string GetComparison(string comparison)
        {
            string res = string.Empty;
            switch (comparison)
            {
                case ComparisonType.lt:
                    res = "<";
                    break;
                case ComparisonType.gt:
                    res = ">";
                    break;
                case ComparisonType.eq:
                    res = "=";
                    break;
            }
            return res;
        }
    }
}
