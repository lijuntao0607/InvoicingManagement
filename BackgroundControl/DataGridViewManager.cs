using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.ComponentModel;

namespace BackgroundControl
{
    public class DataGridViewManager
    {
        
        /// <summary>
        /// 重新绑定DataGridView的List数据源
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="gridView"></param>
        /// <param name="list"></param>
        public static void RebindListDataSource<T>(DataGridView gridView, IList<T> list )
        {
            //gridView.DataSource = new BindingList<T>();
            gridView.DataSource = new List<T>();
            if (list!=null&&list.Count > 0)
            {
                //BindingList<T> bindingList = new BindingList<T>(list);
                //gridView.DataSource = bindingList;
                gridView.DataSource = list;
            }
            
        }
    }
}
