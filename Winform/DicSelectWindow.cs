using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using ViewModel;
using BusinessService;
using WinformControls;
using DomainModule;
using BackgroundControl;

namespace Winform
{
    public partial class DicSelectWindow : BaseForm
    {

        ArrayList DirtyRows = new ArrayList();
        public DicSelectWindow()
        {
            



            InitializeComponent();
            cbbDicCategory.DataSource =SystemVariable.DictionaryCateList ;
            cbbDicCategory.DisplayMember = "Name";
            cbbDicCategory.ValueMember = "Value";

        }

        private void cbbDicCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DirtyRows.Clear();
                DataGridViewManager.RebindListDataSource<SystemDictionary>(dicDataGridView, SystemVariable.SystemDictionarySet[((ComboxItem)cbbDicCategory.SelectedItem).Value]);
                
            }
            catch (Exception ex)
            {
                Toast.Show(ex.Message);
            }
        }


        private void btnAddDic_Click(object sender, EventArgs e)
        {
            try
            {


                string str=cbbDicCategory.SelectedValue.ToString();
                IList<SystemDictionary> list = SystemVariable.SystemDictionarySet[str];
                
                switch (str)
                {
                    case EnumDictionary.Unit :
                        Unit newDic;
                        newDic = new Unit();
                        newDic.DicNumber = "0001";
                        newDic.DicName = "新类别";
                        

                        DirtyRows.Add(newDic);
                        list.Add(newDic);
                        break;
                }
                DataGridViewManager.RebindListDataSource<SystemDictionary>(dicDataGridView, list);

            }
            catch (Exception ex)
            {
                Toast.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dicDataGridView.SelectedRows.Count > 0)
                {
                    if (DialogResult.Yes== MessageBox.Show("你确定要删除吗?", "提示", MessageBoxButtons.YesNo))
                    {
                        int index = dicDataGridView.SelectedRows[0].Index;
                        var list = (IList<SystemDictionary>)dicDataGridView.DataSource;
                        dicDataGridView.DataSource = new List<SystemDictionary>();
                        list[index].IsDel = true;
                        DirtyRows.Add(list[index]);
                       
                        //SystemVariable.DictionaryService.Delete(list[index]);
                        list.RemoveAt(index);

                        DataGridViewManager.RebindListDataSource<SystemDictionary>(dicDataGridView, list);
                    }
                }
                else
                {
                    Toast.Show("请选择要删除的行");
                }
            }
            catch (Exception ex)
            {
                Toast.Show(ex.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string str = cbbDicCategory.SelectedValue.ToString();
                switch (str)
                {
                    case EnumDictionary.Unit:
                        SystemVariable.DictionaryService.SaveRange(DirtyRows);
                        break;
                }

                //Unit u = new Unit();
                //u.DicName = "afafafaf";
                //SystemVariable.DictionaryService.Save(u);
                
                DirtyRows.Clear();
                Toast.Show("操作成功");
            }
            catch (Exception ex)
            {
                Toast.Show(ex.Message);
            }
        }

        private void dicDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            string str = cbbDicCategory.SelectedValue.ToString();
            //var list = SystemVariable.SystemDictionarySet[str];
            var list = (IList<SystemDictionary>)dicDataGridView.DataSource;
            


            if (!DirtyRows.Contains(list[e.RowIndex]))
            {
                DirtyRows.Add(list[e.RowIndex]);
            }

            //DataGridViewManager.RebindListDataSource<SystemDictionary>(dicDataGridView, list);
        }

        private void dicDataGridView_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            //var list = (IList<SystemDictionary>)dicDataGridView.DataSource;
            //if(!DirtyRows .Contains(list[e.RowIndex]))
            //{
            //    DirtyRows.Add(list[e.RowIndex]);
            //}
            
        }

        private void DicSelectWindow_Load(object sender, EventArgs e)
        {
            //加载系统字典
            SystemVariable.SystemDictionarySet = SystemVariable.DictionaryService.GetAllDictionary(); 
        }
    }
}
