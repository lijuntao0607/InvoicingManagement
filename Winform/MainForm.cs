using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using BusinessService;
using WinformControls;
using DomainModule;
using BackgroundControl;
using CommonEntity;
using ViewModel;
using System.Linq;
using Utility;

namespace Winform
{
    public partial class MainForm : BaseForm
    {
        //private ComboBox cbbSpecDataGridViewUnit = new ComboBox();

        
        System.Windows.Forms.TreeNode CurrentNode;
        public MainForm()
        {
            try
            {
                InitializeComponent();
                SystemControl.SystemInit();
                LoginForm loginForm = new LoginForm();
                if (loginForm.ShowDialog(this) == DialogResult.OK)
                {

                }
                else
                {
                    System.Environment.Exit(0);
                }
            }
            catch (Exception ex)
            {
                Toast.Show(ex.Message);
                System.Environment.Exit(0);
            }

        }

        private void addProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                TabControlManager.ShowPage(extensionTabControl1, AddProductPage);
            }
            catch (Exception ex)
            {
                Toast.Show(ex.Message);
            }
        }

        private void productListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                TabControlManager.ShowPage(extensionTabControl1, ProductListPage);
            }
            catch (Exception ex)
            {
                Toast.Show(ex.Message);
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                
            }
            catch (Exception ex)
            {
                Toast.Show(ex.Message);
            }


        }

        private void LoadProductSpecData(ProductInfo product)
        {
            try
            {

            }catch(Exception ex)
            {
                Toast.Show(ex.Message);
            }

        }


        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            try
            {
                if (e.Button == MouseButtons.Right)
                {
                    if (e.Node.Level == 0)
                    {
                        RenameMenuItem.Visible = false;
                        DeleteCategoryMenuItem.Visible = false;
                    }
                    else
                    {
                        RenameMenuItem.Visible = true;
                        DeleteCategoryMenuItem.Visible = true;
                    }
                    this.CategoryTreeContextMenuStrip.Show(treeView1 ,e.X,e.Y);
                    CurrentNode = e.Node;
                }
            }
            catch (Exception ex)
            {
                Toast.Show(ex.Message);
            }

        }

        private void RenameMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (CurrentNode != null)
                {
                    CurrentNode.BeginEdit();
                }
            }
            catch (Exception ex)
            {
                Toast.Show(ex.Message);
            }

            

        }

        private void AddCategoryMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Category category = new Category();
                category.CategoryName = "新类别";
                if (CurrentNode.Level != 0)
                {
                    category.Parent = (Category)CurrentNode.Tag;
                }
                else
                {
                    category.Parent = null;
                }
                SystemVariable.CategoryService.Add(category);
                System.Windows.Forms.TreeNode node=TreeViewManager.AddNode(category, CurrentNode,false);
                CurrentNode.Expand();
                node.BeginEdit();

            }
            catch (Exception ex)
            {
                Toast.Show(ex.Message);
            }
        }

        private void DeleteCategoryMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("确定删除吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Category category=(Category )CurrentNode .Tag;
                    SystemVariable.CategoryService.Delete(category);
                    
                }
            }
            catch (Exception ex)
            {
                Toast.Show(ex.Message);
            }
        }

        private void treeView1_AfterLabelEdit(object sender, NodeLabelEditEventArgs e)
        {
            try
            {
                if (e.Node.Level != 0&& !string.IsNullOrEmpty(e.Label))
                {
                    Category category = (Category)e.Node.Tag;
                    category.CategoryName = e.Label;
                    SystemVariable.CategoryService.Update(category);
                    e.Node.Text = category.CategoryName;
                }
            }
            catch (Exception ex)
            {
                Toast.Show(ex.Message);
            }
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void ProductListPage_Enter(object sender, EventArgs e)
        {
            try
            {
                TreeViewManager.TreeLoad(treeView1);
                IList<ProductView> list = SystemVariable.ProductService.GetProductViewList(null, null);
                DataGridViewManager.RebindListDataSource<ProductView>(productListDataGridView, list);

                tbBarcode.Focus();
            }
            catch (Exception ex)
            {
                Toast.Show(ex.Message);
            }
        }

        private void AddProductPage_Enter(object sender, EventArgs e)
        {
            try
            {
                List<SpecificationView> list = new List<SpecificationView>();
                DataGridViewManager.RebindListDataSource<SpecificationView>(ApSpecDataGridView, list);
                ApSpecDataGridView.Tag = list;
                if (AddProductPage.Tag == null)
                {
                    ProductInfo product = new ProductInfo();
                    AddProductPage.Tag = product;
                }
                //cbbSpecDataGridViewUnit.DataSource = SystemVariable.SystemDictionarySet[EnumDictionary.Unit];
                //cbbSpecDataGridViewUnit.ValueMember = "Id";
                //cbbSpecDataGridViewUnit.DisplayMember = "DicName";

                SLShowUnit.DataSource = SystemVariable.SystemDictionarySet[EnumDictionary.Unit];
                SLShowUnit.ValueMember = "Id";
                SLShowUnit.DisplayMember = "DicName";

                this.ApUnit.DataSource = SystemVariable.SystemDictionarySet[EnumDictionary.Unit];
                this.ApUnit.ValueMember = "Id";
                this.ApUnit.DisplayMember = "DicName";
                //SLUnit.DataSource = SystemVariable.SystemDictionarySet[EnumDictionary.Unit];
                //SLUnit.DisplayMember = "DicName";
                //SLUnit.ValueMember = "Id";
                //SLUnit.Items.AddRange(SystemVariable.SystemDictionarySet[EnumDictionary.Unit]);
                //SLUnit.Items.Add(SystemVariable.SystemDictionarySet[EnumDictionary.Unit][0].Id);                
            }
            catch (Exception ex)
            {
                Toast.Show(ex.Message);
            }
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            try
            {
                TabControlManager.ShowPage(extensionTabControl1, AddProductPage);
            }
            catch (Exception ex)
            {
                Toast.Show(ex.Message);
            }
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            try
            {
                if (productListDataGridView.SelectedRows.Count > 0)
                {
                    if (DialogResult.Yes == MessageBox.Show("你确定要删除吗?", "提示", MessageBoxButtons.YesNo))
                    {
                        string id = productListDataGridView.SelectedRows[0].Cells["PlId"].Value.ToString();
                        //productListDataGridView.Rows.Remove(productListDataGridView.SelectedRows[0]);
                        IList<ProductView> list =(IList<ProductView>) productListDataGridView.DataSource;

                        SystemVariable.ProductService.Delete(id);
                        list.RemoveAt(productListDataGridView.SelectedRows[0].Index);
                        DataGridViewManager.RebindListDataSource<ProductView>(productListDataGridView, list);

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

        private void btnDeleteSpec_Click(object sender, EventArgs e)
        {
            try
            {
                if (ApSpecDataGridView.SelectedRows.Count > 0||ApSpecDataGridView.SelectedCells.Count>0)
                {
                    if (DialogResult.Yes == MessageBox.Show("你确定要删除吗?", "提示", MessageBoxButtons.YesNo))
                    {
                        int rowIndex = ApSpecDataGridView.SelectedCells[0].RowIndex;
                        List<SpecificationView> list = (List<SpecificationView >)ApSpecDataGridView.Tag;
                        list.RemoveAt(rowIndex);
                        DataGridViewManager.RebindListDataSource<SpecificationView>(ApSpecDataGridView, list);
                        //SpecDataGridView.Rows.Remove(SpecDataGridView.SelectedRows[0]);

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


        private void LoadProductList(Category category,string productNumber,string barcode)
        {
            try
            {
                List<DataFilter> filters = new List<DataFilter>();

                productListDataGridView.DataSource = SystemVariable.ProductService.GetProductViewList(null, filters);

            }
            catch (Exception ex)
            {
                Toast.Show(ex.Message);
            }
        }

        private void tbCategory_Enter(object sender, EventArgs e)
        {
            try
            {
                ProductInfo newProduct = (ProductInfo)AddProductPage.Tag;
                //AddProductPage.Tag = newProduct;
                using (CategorySelectWindow cateSelectWin = new CategorySelectWindow())
                {
                    DialogResult result = cateSelectWin.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        newProduct.Category = cateSelectWin.Category;
                        ApCategory.Text = newProduct.Category.CategoryName;
                    }
                }

            }
            catch (Exception ex)
            {
                Toast.Show(ex.Message);
            }
        }

        private void ApCategory_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void btnAddSpec_Click(object sender, EventArgs e)
        {
            try
            {

                //IList<SpecificationView> list = (IList<SpecificationView>)SpecDataGridView.DataSource;
                List<SpecificationView> list = (List<SpecificationView>) this.ApSpecDataGridView .Tag;
                SpecificationView spec = new SpecificationView();
                spec.SpecifiText = ApSpeciText.Text;
                if (string.IsNullOrEmpty(ApUnitPrice.Text))
                {
                    spec.UnitPrice = 0;

                }
                else
                {
                    spec.UnitPrice = Convert.ToDouble(ApUnitPrice.Text);
                }
                

                spec.UnitId = ApUnit.SelectedValue.ToString();
                spec.Barcode = ApBarcode.Text;
                //spec.SpecifiText = "11";
                //spec.Barcode = "111";
                //spec.UnitId = "37163f05-48c2-4a1f-88c4-347e05e0fb25";
                list.Add(spec);
                DataGridViewManager.RebindListDataSource<SpecificationView>(ApSpecDataGridView, list);
                for (int i = 0; i < list.Count; i++)
                {
                    ApSpecDataGridView.Rows[i].Cells["SLShowUnit"].Value = list[i].UnitId;
                }
            }
            catch (Exception ex)
            {
                Toast.Show(ex.Message);
            }
        }

        

        private void SpecDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SystemDictionaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                DicSelectWindow dicSelectWindow = new DicSelectWindow();
                dicSelectWindow.ShowDialog();
            }
            catch (Exception ex)
            {
                Toast.Show(ex.Message);
            }
        }

        private string SaveProductValidate()
        {
            
            StringBuilder sb = new StringBuilder();

            if (string.IsNullOrEmpty(ApProductName.Text))
            {
                sb.Append("请输入产品名\n");
            }
            //if (string.IsNullOrEmpty(this.ApProductNumber.Text))
            //{
            //    sb.Append("请输入货号\n");
            //}
            if (string.IsNullOrEmpty(this.ApCategory.Text))
            {
                sb.Append("请产品类别\n");
            }
            if (string.IsNullOrEmpty(this.ApTaxRate.Text))
            {
                sb.Append("请输入产品税率\n");
            }
            List<SpecificationView> list = (List<SpecificationView>)this.ApSpecDataGridView.Tag;
            sb.Append(ValidateSpecList(list));
            if(sb.Length >0)
                sb=sb.Remove (sb.Length -1,1);
            return sb.ToString ();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string str = SaveProductValidate();
                if (str.Length > 0)
                {
                    Toast.Show(str);
                }
                else
                {
                    ProductInfo product = (ProductInfo)AddProductPage.Tag;
                    
                    if (product != null)
                    {
                        AssignAddProduct(product);
                        List<SpecificationView> list = (List<SpecificationView>)ApSpecDataGridView.DataSource;


                        SystemVariable.ProductService.Add(product);

                    }
                    AddProductPage.Tag = null;
                }
            }
            catch (Exception ex)
            {
                Toast.Show(ex.Message);
            }
        }
        private void addProductPageInit()
        {
            ApCategory.Text = string.Empty;
            ApProductName.Text = string.Empty;
            ApProductNumber.Text = string.Empty;
            ApTaxRate.Text = string.Empty;
            ApSpeciText.Text = string.Empty;
            ApUnitPrice.Text = string.Empty;
            ApBarcode.Text = string.Empty;

            DataGridViewManager.RebindListDataSource<SpecificationView>(ApSpecDataGridView, null);
            AddProductPage.Tag = new ProductInfo();
        }
        private void AssignAddProduct(ProductInfo product)
        {
            product.ProductName = ApProductName.Text;
            product.ProductNumber = ApProductNumber.Text; 
            product.TaxRate =Convert.ToDouble( ApTaxRate.Text);
            

        }
        private void AssignUpdateProduct(ProductInfo product)
        {
            product.ProductName = UpProductName.Text;
            product.ProductNumber = UpProductNumber.Text;
            product.TaxRate = Convert.ToDouble(UpTaxRate.Text);


        }
        private void btnSaveAndContinue_Click(object sender, EventArgs e)
        {
            try
            {
                string str = SaveProductValidate();
                if (str.Length > 0)
                {
                    Toast.Show(str);
                }
                else
                {
                    ProductInfo product = (ProductInfo)AddProductPage.Tag;
                    AssignAddProduct(product);

                    if (product != null)
                    {
                        List<SpecificationView> list = (List<SpecificationView>)ApSpecDataGridView.DataSource;

                        //SystemVariable.ProductService.Add(product,list);
                        SystemVariable.ProductService.Add(product, list);
                    }

                    addProductPageInit();
                    Toast.Show("操作成功");
                }


            }
            catch (Exception ex)
            {
                Toast.Show(ex.Message);
            }
        }

        private void SpecDataGridView_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
            }
            catch (Exception ex)
            {
                Toast.Show(ex.Message);
            }
        }

        private void SpecDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void PurchaseStorageInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                TabControlManager.ShowPage(extensionTabControl1,addStorageInPage);
            }
            catch (Exception ex)
            {
                Toast.Show(ex.Message);
            }
        }

        private void SpecDataGridView_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 2)
                {
                }
            }
            catch (Exception ex)
            {
                Toast.Show(ex.Message);
            }
        }

        private void SpecDataGridView_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

       
            }
            catch (Exception ex)
            {
                Toast.Show(ex.Message);
            }
        }



        private void SpecDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (ApSpecDataGridView.Columns["SLShowUnit"] == ApSpecDataGridView.Columns[e.ColumnIndex])
                {
                    List<SpecificationView> list = (List<SpecificationView>)this.ApSpecDataGridView.DataSource;
                    for (int i = 0; i < list.Count; i++)
                    {
                        if (ApSpecDataGridView.Rows[i].Cells["SLShowUnit"].Value != null)
                        {
                            list[i].UnitId = ApSpecDataGridView.Rows[i].Cells["SLShowUnit"].Value.ToString();
                        }
                        
                    }
                    //DataGridViewManager.RebindListDataSource<SpecificationView>(SpecDataGridView, list);
                }
            }
            catch (Exception ex)
            {
                Toast.Show(ex.Message);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="spec"></param>
        /// <param name="type"></param>
        private void AsiSearchProductPanelShowSpec(Specification spec)
        {
            if (spec == null)
            {
                return;
            }
            AsProductSpeciText.SelectedValue = spec.Id;
            AsProductUnit.Text = spec.Unit.DicName;
            AsProductBarcode.Text = spec.Barcode;
            AsProductUnitPrice.Text = spec.UnitPrice.ToString();
            if (string.IsNullOrEmpty(AsProductAmount.Text))
            {
                AsProductAmount.Text = "1";
            }
        }
        private void AsoSearchProductPanelShowSpec(Specification spec)
        {
            if (spec == null)
            {
                return;
            }
            this.AsoStorageOutSpeciText.SelectedValue = spec.Id;
            AsoStorageOutUnit.Text = spec.Unit.DicName;
            AsoStorageOutBarcode.Text = spec.Barcode;
            AsoStorageOutUnitPrice.Text = spec.UnitPrice.ToString();
            if (string.IsNullOrEmpty(AsoStorageOutAmount.Text))
            {
                AsoStorageOutAmount.Text = "1";
            }
        }
        //SearchProductPanelShowProduct
        private void AsoSearchProductPanelShowProduct(ProductInfo product)
        {
            if (product == null)
            {
                return;
            }
            this.AsoStorageOutProductName.Text = product.ProductName;
            AsoStorageOutProductNumber.Text = product.ProductNumber;
            if (product.SpecList.Count > 0)
            {
                AsoStorageOutSpeciText.DataSource = product.SpecList;
                AsoStorageOutSpeciText.DisplayMember = "SpecifiText";
                AsoStorageOutSpeciText.ValueMember = "Id";
                AsoSearchProductPanelShowSpec(product.SpecList[0]);
                AsoStorageOutSpeciText.Enabled = true;
            }
        }
        private void AsiSearchProductPanelShowProduct(ProductInfo product)
        {
            if (product == null)
            {
                return;
            }
            AsProductName.Text = product.ProductName;
            AsProductNumber.Text = product.ProductNumber;
            if (product.SpecList.Count > 0)
            {
                AsProductSpeciText.DataSource = product.SpecList;
                AsProductSpeciText.DisplayMember = "SpecifiText";
                AsProductSpeciText.ValueMember = "Id";
                AsiSearchProductPanelShowSpec(product.SpecList[0]);
                AsProductSpeciText.Enabled = true;
            }
        }
        private void AsoSearchProductPanelShowProduct(Specification spec)
        {
            if (spec == null)
            {
                return;
            }
            this.AsoStorageOutBarcode.Tag = spec;
            AsoStorageOutProductName.Text = spec.Product.ProductName;
            AsoStorageOutProductNumber.Text = spec.Product.ProductNumber;
            this.AsoStorageOutSpeciText.DataSource = spec.Product.SpecList;
            AsoStorageOutSpeciText.DisplayMember = "SpecifiText";
            AsoStorageOutSpeciText.ValueMember = "Id";
            AsoSearchProductPanelShowSpec(spec);
            AsoStorageOutSpeciText.Enabled = false;
        }
        private void AsiSearchProductPanelShowProduct(Specification  spec)
        {
            if (spec == null)
            {
                return;
            }
            AsProductBarcode.Tag = spec;
            AsProductName.Text = spec.Product .ProductName;
            AsProductNumber.Text = spec.Product.ProductNumber;
            AsProductSpeciText.DataSource = spec.Product.SpecList;
            AsProductSpeciText.DisplayMember = "SpecifiText";
            AsProductSpeciText.ValueMember = "Id";
            AsiSearchProductPanelShowSpec(spec);
            AsProductSpeciText.Enabled = false;
        }
        private void AsProductNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == '\r'&& !string.IsNullOrEmpty(AsProductNumber.Text ))
                {
                    //AsProductBarcode.Tag = null;
                    ProductInfo product=SystemVariable.ProductService.GetByProductNumber(AsProductNumber .Text);
                    AsProductName.Tag = product;
                    this.AsProductBarcode.Tag = product.SpecList[0];
                    if (product != null)
                    {
                        
                        AsiSearchProductPanelShowProduct(product);
                    }
                }
            }
            catch (Exception ex)
            {
                Toast.Show(ex.Message);
            }
        }
        /// <summary>
        /// 添加入库单页面载入事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addStorageInPage_Enter(object sender, EventArgs e)
        {
            try
            {
                AsNumber.Text = SystemVariable.StorageInService.GetStorageInNumber();
                if (AsStorageInItemDataGridView.Tag == null)
                {
                    IList<ProductView> list = new List<ProductView>();
                    AsStorageInItemDataGridView.Tag = list;
                    DataGridViewManager.RebindListDataSource<ProductView>(AsStorageInItemDataGridView, list);
                    
                }
                AsProductBarcode.Focus();
                
            }
            catch (Exception ex)
            {
                Toast.Show(ex.Message);
            }
        }

        private void AsProductBarcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == '\r' && !string.IsNullOrEmpty(this.AsProductBarcode  .Text))
                {
                    //AsProductName.Tag = null;
                    Specification spec = SystemVariable.ProductService.GetByBarcode(AsProductBarcode.Text);
                    AsProductBarcode.Tag = spec;
                    if (spec != null)
                    {
                        AsiSearchProductPanelShowProduct(spec);
                        IList<ProductView> list = (IList<ProductView>)AsStorageInItemDataGridView.DataSource;
                        // Specification spec = (Specification)AsProductBarcode.Tag;
                        int sameProductIndex = -1;
                        if (spec != null)
                        {
                            for (int i = 0; i < list.Count; i++)
                            {
                                if (list[i].SpecId == spec.Id)
                                {
                                    sameProductIndex = i;
                                    break;
                                }
                            }
                        }
                        if (sameProductIndex != -1)
                        {
                            list[sameProductIndex].Amount += Convert.ToInt32(AsProductAmount.Text);
                            DataGridViewManager.RebindListDataSource<ProductView>(AsStorageInItemDataGridView, list);
                        }
                        else
                        {
                            AddStorageInAddItem();
                        }
                        InitAddStorageInItem();
                        AsProductBarcode.Focus();

                    }
                   
                }
                else
                {
                    if (e.KeyChar == '\r')
                    {
                        List<ProductView> list = (List<ProductView>)AsStorageInItemDataGridView.DataSource; 
                        if (list.Count > 0)
                            SaveStorageIn_Click();
                    }
                }

            }
            catch (Exception ex)
            {
                Toast.Show(ex.Message);
            }
        }

        private void AsProductSpeciText_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                ProductInfo product = (ProductInfo)AsProductName.Tag;
                if (product != null)
                {
                    string id=AsProductSpeciText .SelectedValue .ToString ();
                    //Specification spec;
                    for (int i = 0; i < product.SpecList.Count ; i++)
                    {
                        if (product.SpecList[i].Id == id)
                        {
                            AsiSearchProductPanelShowSpec(product.SpecList[i]);
                            AsProductBarcode.Tag = product.SpecList[i];
                            break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Toast.Show(ex.Message);
            }
        }
        //private void AddStorageOutAddItem()
        //{
        //    Specification spec = (Specification)this.AsoStorageOutBarcode.Tag;

        //    if (spec != null)
        //    {
        //        IList<ProductView> list = (IList<ProductView>)AsoStorageOutItemDataGridView.Tag;
        //        ProductView product = new ProductView();
        //        product.Amount = Convert.ToDouble(AsoStorageOutAmount.Text);
        //        product.ProductId = spec.Product.Id;
        //        product.SpecId = spec.Id;
        //        product.Category = spec.Product.Category.CategoryName;
        //        product.ProductName = spec.Product.ProductName;
        //        product.ProductNumber = spec.Product.ProductNumber;
        //        product.Barcode = spec.Barcode;
        //        product.Category = spec.Product.Category.CategoryName;
        //        product.SpecifiText = spec.SpecifiText;
        //        product.TaxRate = spec.Product.TaxRate;
        //        product.Unit = spec.Unit.DicName;
        //        product.UnitPrice = Convert.ToDouble(AsoStorageOutUnitPrice.Text);
        //        list.Add(product);
        //        DataGridViewManager.RebindListDataSource<ProductView>(AsoStorageOutItemDataGridView, list);
        //    }
        //    else
        //    {
        //        Toast.Show("请选择产品");
        //    }
        //}
        private void  AddStorageInAddItem()
        {
            Specification spec = (Specification)AsProductBarcode.Tag;

            if (spec != null)
            {
                IList<ProductView> list = (IList < ProductView >) AsStorageInItemDataGridView.Tag;
                ProductView product = new ProductView();
                product.Amount = Convert.ToDouble(AsProductAmount.Text);
                product.ProductId =spec.Product .Id;
                product.SpecId = spec.Id;
                product.Category = spec.Product.Category.CategoryName;
                product.ProductName = spec.Product.ProductName;
                product.ProductNumber = spec.Product.ProductNumber;
                product.Barcode = spec.Barcode;
                product.Category = spec.Product.Category.CategoryName;
                product.SpecifiText = spec.SpecifiText;
                product.TaxRate = spec.Product.TaxRate;
                product.Unit = spec.Unit.DicName;
                product.UnitPrice = Convert.ToDouble(AsProductUnitPrice.Text);
                list.Add(product);
                DataGridViewManager.RebindListDataSource<ProductView>(AsStorageInItemDataGridView, list);
            }
            else
            {
                Toast.Show("请选择产品");
            }
        }

        private void InitAddStorageInItem()
        {
            AsProductAmount.Text = string.Empty;
            AsProductBarcode.Text = string.Empty;
            AsProductBarcode.Tag = null;
            AsProductName.Text = string.Empty;
            AsProductNumber.Text = string.Empty;
            AsProductNumber.Tag = null;
            AsProductSpeciText.Text = string.Empty;
            AsProductUnit.Text = string.Empty;
            AsProductUnitPrice.Text = string.Empty;
            AsProductSpeciText.DataSource = new List<Specification>();
        }

        private void btnAddStorageInItem_Click(object sender, EventArgs e)
        {
            try
            {
                TabControlManager.ShowPage(extensionTabControl1, AddProductPage);

               /* IList<ProductView> list = (IList<ProductView>)AsStorageInItemDataGridView.DataSource;
                Specification spec = (Specification)AsProductBarcode.Tag;
                int sameProductIndex = -1;
                if (spec != null)
                {
                    for (int i = 0; i < list.Count; i++)
                    {
                        if (list[i].SpecId == spec.Id)
                        {
                            sameProductIndex = i;
                            break;
                        }
                    }
                }
                if (sameProductIndex!=-1)
                {
                    list[sameProductIndex].Amount += Convert.ToInt32(AsProductAmount.Text);
                    DataGridViewManager.RebindListDataSource<ProductView>(AsStorageInItemDataGridView, list);
                }
                else
                {
                    AddStorageInAddItem();
                }
                InitAddStorageInItem();
                AsProductBarcode.Focus();*/
                //DataGridViewManager.RebindListDataSource<ProductView>(AsStorageInItemDataGridView, list);
                //IList<ProductView> list = (IList<ProductView>)AsStorageInItemDataGridView.Tag;
                
            }
            catch (Exception ex)
            {
                Toast.Show(ex.Message);
            }
        }

        private void btnDeleteStorageInItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (AsStorageInItemDataGridView.SelectedRows.Count > 0)
                {
                    IList<ProductView> list = (IList<ProductView>)AsStorageInItemDataGridView.Tag;
                    //string id = AsStorageInItemDataGridView.SelectedRows[0].Cells["Id"].Value.ToString();
                    //productListDataGridView.Rows.Remove(productListDataGridView.SelectedRows[0]);
                    if (list.Count ()>0) {
                        list.RemoveAt(AsStorageInItemDataGridView.SelectedRows[0].Index);
                        DataGridViewManager.RebindListDataSource<ProductView>(AsStorageInItemDataGridView, list);
                        AsProductBarcode.Focus();
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

        private void ribbonMenuButton1_Click(object sender, EventArgs e)
        {
            try
            {
                Specification spec = (Specification)AsProductBarcode.Tag;
                if (spec != null)
                {
                    IList<ProductView> list = (IList<ProductView>)AsStorageInItemDataGridView.Tag;
                    ProductView product = new ProductView();
                    product.Amount = Convert.ToDouble(AsProductAmount.Text);
                    product.ProductId = spec.Id;
                    product.ProductName = spec.Product.ProductName;
                    product.ProductNumber = spec.Product.ProductNumber;
                    product.Barcode = spec.Barcode;
                    product.Category = spec.Product.Category.CategoryName;
                    product.SpecifiText = spec.SpecifiText;
                    product.TaxRate = spec.Product.TaxRate;
                    product.Unit = spec.Unit.DicName;
                    product.UnitPrice = Convert.ToDouble(AsProductUnitPrice.Text);
                    list.Add(product);
                    DataGridViewManager.RebindListDataSource<ProductView>(AsStorageInItemDataGridView, list);
                }
                else
                {
                    Toast.Show("请选择产品");
                }
            }
            catch (Exception ex)
            {
                Toast.Show(ex.Message);
            }
        }

        private void updateStorageInPage_Enter(object sender, EventArgs e)
        {
            try
            {

                //List<ProductView> list = SystemVariable.StorageInService.GetItemView();
            }
            catch (Exception ex)
            {
                Toast.Show(ex.Message);
            }
        }

        private void UsSearchProductNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == '\r' && !string.IsNullOrEmpty(AsProductNumber.Text))
                {
                    //AsProductBarcode.Tag = null;
                    ProductInfo product = SystemVariable.ProductService.GetByProductNumber(UsSearchProductNumber.Text);
                    AsProductName.Tag = product;
                    if (product != null)
                    {

                        UsSearchProductPanelShowProduct(product);
                    }
                }
            }
            catch (Exception ex)
            {
                Toast.Show(ex.Message);
            }
        }
        private void UsSearchProductPanelShowSpec(Specification spec)
        {
            if (spec == null)
            {
                return;
            }
            this.UsSearchSpeciText .SelectedValue = spec.Id;
            UsSearchUnit.Text = spec.Unit.DicName;
            UsSearchBarcode.Text = spec.Barcode;
            UsSearchUnitPrice.Text = spec.UnitPrice.ToString();
            if (string.IsNullOrEmpty(UsSearchAmount.Text))
            {
                UsSearchAmount.Text = "1";
            }
        }
        private void UsSearchProductPanelShowProduct(ProductInfo product)
        {
            if (product == null)
            {
                return;
            }
            UsSearchProductName.Text = product.ProductName;
            UsSearchProductNumber.Text = product.ProductNumber;
            if (product.SpecList.Count > 0)
            {
                UsSearchSpeciText.DataSource = product.SpecList;
                UsSearchSpeciText.DisplayMember = "SpecifiText";
                UsSearchSpeciText.ValueMember = "Id";
                UsSearchProductPanelShowSpec(product.SpecList[0]);
                UsSearchSpeciText.Enabled = true;
            }
        }
        private void UsSearchProductPanelShowProduct(Specification spec)
        {
            if (spec == null)
            {
                return;
            }
            UsSearchBarcode.Tag = spec;
            UsSearchProductName.Text = spec.Product.ProductName;
            UsSearchProductNumber.Text = spec.Product.ProductNumber;
            UsSearchSpeciText.DataSource = spec.Product.SpecList;
            UsSearchSpeciText.DisplayMember = "SpecifiText";
            UsSearchSpeciText.ValueMember = "Id";
            UsSearchProductPanelShowSpec(spec);
            UsSearchSpeciText.Enabled = false;
        }

        private void UsSearchBarcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == '\r' && !string.IsNullOrEmpty(UsSearchBarcode.Text))
                {
                    //AsProductName.Tag = null;
                    Specification spec = SystemVariable.ProductService.GetByBarcode(AsProductBarcode.Text);
                    UsSearchBarcode.Tag = spec;
                    if (spec != null)
                    {
                        UsSearchProductPanelShowProduct(spec);
                    }
                }
            }
            catch (Exception ex)
            {
                Toast.Show(ex.Message);
            }
        }

        private void btnEditProduct_Click(object sender, EventArgs e)
        {
            try
            {
                if (productListDataGridView.SelectedRows.Count > 0)
                {
                    IList<ProductView> list =(IList<ProductView> ) productListDataGridView.DataSource;
                    updateProductPage.Tag = SystemVariable.ProductService.GetSpecification(list[productListDataGridView.SelectedRows[0].Index].SpecId );
                    TabControlManager.ShowPage(extensionTabControl1,updateProductPage );

                }
                else
                {
                    Toast.Show("请选择一个产品进行修改");
                }
            }
            catch (Exception ex)
            {
                Toast.Show(ex.Message);
            }
        }

        private void ribbonMenuButton6_Click(object sender, EventArgs e)
        {
            try
            {
                //var selectedNode = treeView1.SelectedNode;
                //if (selectedNode != null && selectedNode.Tag != null)
                //{
                //    Category c = (Category)selectedNode.Tag;
                //    IList<ProductView> list = SystemVariable.ProductService.GetProductViewList(c, null);
                //    DataGridViewManager.RebindListDataSource<ProductView>(productListDataGridView, list);
                //}
                if (!string.IsNullOrEmpty(this.tbBarcode.Text))
                {
                    //AsProductName.Tag = null;
                    Specification spec = SystemVariable.ProductService.GetByBarcode(tbBarcode.Text);
                    tbBarcode.Tag = spec;
                    if (spec != null)
                    {

                        IList<ProductView> list = (IList<ProductView>)productListDataGridView.DataSource;
                        list.Clear();
                        list.Add(new ProductView(spec));
                        DataGridViewManager.RebindListDataSource<ProductView>(productListDataGridView, list);
                        tbBarcode.Text = "";
                        tbBarcode.Focus();


                    }

                }
            }
            catch (Exception ex)
            {
                Toast.Show(ex.Message);
            }
        }

        private void UpCategory_Enter(object sender, EventArgs e)
        {
            try
            {
                Specification spec=(Specification)updateProductPage.Tag;
                ProductInfo newProduct = spec.Product ;

                using (CategorySelectWindow cateSelectWin = new CategorySelectWindow())
                {
                    DialogResult result = cateSelectWin.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        newProduct.Category = cateSelectWin.Category;
                        ApCategory.Text = newProduct.Category.CategoryName;
                    }
                }

            }
            catch (Exception ex)
            {
                Toast.Show(ex.Message);
            }
        }

        private void updateProductPage_Enter(object sender, EventArgs e)
        {
            try
            {
                if (updateProductPage.Tag == null)
                {
                    updateProductPage.Hide();
                }
                else
                {
                    UpSlShowUnit.DataSource = SystemVariable.SystemDictionarySet[EnumDictionary.Unit];
                    UpSlShowUnit.ValueMember = "Id";
                    UpSlShowUnit.DisplayMember = "DicName";

                    Specification spec = (Specification)updateProductPage.Tag;
                    UpProductName.Text = spec.Product.ProductName;
                    UpProductNumber.Text = spec.Product.ProductNumber;
                    UpCategory.Text = spec.Product.Category.CategoryName;
                    UpTaxRate.Text =NoExceptionConvert.ToString ( spec.Product.TaxRate.ToString ());

                    IList<SpecificationView > list=new List<SpecificationView >();
                    for (int i = 0; i < spec.Product .SpecList .Count ; i++)
                    {
                        list.Add(new SpecificationView(spec.Product.SpecList[i]));
                    }
                    DataGridViewManager.RebindListDataSource<SpecificationView>(UpSpecDataGridView, list);
                    for (int i = 0; i < list.Count; i++)
                    {
                        if (!string.IsNullOrEmpty(list[i].UnitId))
                        {
                            UpSpecDataGridView.Rows[i].Cells["UpSlShowUnit"].Value = list[i].UnitId;
                        }
                    }
                    IList<SpecificationView> dirtyList = new List<SpecificationView>();
                    UpSpecDataGridView.Tag = dirtyList;
                }
            }
            catch (Exception ex)
            {
                Toast.Show(ex.Message);
            }
        }
        private void updateProductPageInit()
        {
            UpProductName.Text = string.Empty;
            UpProductNumber.Text = string.Empty;
            UpCategory.Text = string.Empty;
            UpTaxRate.Text = string.Empty;
            updateProductPage.Tag = null;
            UpSpecDataGridView.Tag = null;
            DataGridViewManager.RebindListDataSource<SpecificationView>(UpSpecDataGridView, null);
        }
        private string ValidateSpecList(IList<SpecificationView> list)
        {
            if (list== null)
            {
                return string.Empty;
            }
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < list.Count; i++)
            {
                if (string.IsNullOrEmpty(list[i].UnitId))
                {
                    sb.Append("单位不能为空\n");
                }

                if (list[i].UnitPrice == null)
                {
                    sb.Append("单价不能为空\n");
                }

                if (string.IsNullOrEmpty(list[i].Barcode))
                {
                    sb.Append("条码不能为空\n");
                }
            }
            if (list.Count < 1)
            {
                sb.Append("产品至少需要一种规格\n");
            }
            return sb.ToString();
        }
        private void UpSave_Click(object sender, EventArgs e)
        {
            try
            {
                List<SpecificationView> list = (List<SpecificationView>)UpSpecDataGridView.DataSource;
                List<SpecificationView> dirtyList = (List<SpecificationView>)UpSpecDataGridView.Tag;
                StringBuilder str = new StringBuilder();
                if (string.IsNullOrEmpty(UpProductName.Text))
                {
                    str.Append("产品名不能为空");
                }
                if (string.IsNullOrEmpty(UpProductNumber.Text))
                {
                    str.Append("货号不能为空");
                }
                if (string.IsNullOrEmpty(UpCategory.Text))
                {
                    str.Append("类别不能为空");
                }
                if (string.IsNullOrEmpty(UpTaxRate.Text))
                {
                    str.Append("税率不能为空");
                }
                str.Append(ValidateSpecList(list));
                if (str.Length > 0)
                {
                    Toast.Show(str.ToString ());
                }
                else
                {
                    var s = (Specification)updateProductPage.Tag;
                    ProductInfo product = s.Product ;
                    AssignUpdateProduct(product);

                    if (product != null)
                    {
                        

                        //SystemVariable.ProductService.Add(product,list);
                        SystemVariable.ProductService.Update(product,dirtyList);
                        //for (int i = 0; i < dirtyList.Count; i++)
                        //{
                        //    var spec = SystemVariable.ProductService.Translate(dirtyList[i]);
                        //    spec.Product = product;
                        //    SystemVariable.ProductService.SaveOrUpdateSpecification(spec);
                        //}
                    }

                    updateProductPageInit();
                    updateProductPage.Tag = null;
                    Toast.Show(SystemConstant.OPERATION_SUCCEED);
                    extensionTabControl1.TabPages.Remove(updateProductPage);
                }
                
            }
            catch (Exception ex)
            {
                Toast.Show(ex.Message);
            }
        }

        private void UpAddSpec_Click(object sender, EventArgs e)
        {
            try
            {
                List<SpecificationView> list = (List<SpecificationView>)this.UpSpecDataGridView.DataSource;
                SpecificationView spec = new SpecificationView();
                list.Add(spec);
                DataGridViewManager.RebindListDataSource<SpecificationView>(UpSpecDataGridView, list);
                for (int i = 0; i < list.Count; i++)
                {
                    UpSpecDataGridView.Rows[i].Cells["UpSlShowUnit"].Value = list[i].UnitId;
                }
            }
            catch (Exception ex)
            {
                Toast.Show(ex.Message);
            }
        }

        private void UpSpecDataGridView_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                Toast.Show(ex.Message);
            }
        }

        private void UpDeleteSpec_Click(object sender, EventArgs e)
        {
            try
            {
                if (UpSpecDataGridView.SelectedRows.Count > 0||UpSpecDataGridView.SelectedCells.Count>0)
                {
                    if (DialogResult.Yes == MessageBox.Show("你确定要删除吗?", "提示", MessageBoxButtons.YesNo))
                    {
                        IList<SpecificationView> list = (IList<SpecificationView>)UpSpecDataGridView.DataSource;
                        IList<SpecificationView> dirtyList = (IList<SpecificationView>)UpSpecDataGridView.Tag;
                        var item = list[UpSpecDataGridView.SelectedCells[0].RowIndex];
                        item.IsDel = true;
                        if (!dirtyList.Contains(item))
                        {
                            dirtyList.Add(item);
                        }
                        list.Remove(item);
                        DataGridViewManager.RebindListDataSource<SpecificationView>(UpSpecDataGridView, list);
                        for (int i = 0; i < list.Count; i++)
                        {
                            UpSpecDataGridView.Rows[i].Cells["UpSlShowUnit"].Value = list[i].UnitId;
                        }
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

        private void UpSpecDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            List<SpecificationView> list = (List<SpecificationView>)this.UpSpecDataGridView.DataSource;
            if (UpSpecDataGridView.Columns["UpSlShowUnit"] == UpSpecDataGridView.Columns[e.ColumnIndex])
            {
                
                for (int i = 0; i < list.Count; i++)
                {
                    if (UpSpecDataGridView.Rows[i].Cells["UpSlShowUnit"].Value != null)
                    {
                        list[i].UnitId = UpSpecDataGridView.Rows[i].Cells["UpSlShowUnit"].Value.ToString();
                    }

                }
                //DataGridViewManager.RebindListDataSource<SpecificationView>(SpecDataGridView, list);
            }

            IList<SpecificationView> dirtyList = (IList<SpecificationView>)UpSpecDataGridView.Tag;
            if (!dirtyList.Contains(list[e.RowIndex]))
            {
                dirtyList.Add(list[e.RowIndex]);
            }

        }
        private void QueryStorageInList(DataGridView dataGridView,DateTime start, DateTime end)
        {

        }
        private void btnSearchStorageIn_Click(object sender, EventArgs e)
        {
            try
            {
                //Toast.Show("Transaction初始化错误");
                DateTime startDate = SilSearchStartTime.Value;
                DateTime endDate = SilSearchEndTime.Value;
                DataFilter df1 = new DataFilter() {
                    Field = "StorageInTime",
                    Value =startDate .ToString(),
                    Type = DataFilterType.dateType ,
                    Comparison = ComparisonType.gt

                };
                DataFilter df2 = new DataFilter()
                {
                    Field = "StorageInTime",
                    Value = endDate.ToString(),
                    Type = DataFilterType.dateType,
                    Comparison = ComparisonType.lt

                };

                IList<StorageIn> list1 = SystemVariable.StorageInService.GetList(new List<DataFilter>() {
                    df1,df2
                });


                List<StorageInView> list = SystemVariable.StorageInService.GetView(SystemVariable.LoginUser.Id);
                DataGridViewManager.RebindListDataSource<StorageInView>(StorageInListDataGridView, list);
            }
            catch (Exception ex)
            {
                Toast.Show(ex.Message);
            }
        }

        private void ribbonMenuButton7_Click(object sender, EventArgs e)
        {
            try
            {
                TabControlManager.ShowPage(extensionTabControl1,addStorageInPage);
            }
            catch (Exception ex)
            {
                Toast.Show(ex.Message);
            }
        }

        private void AsStorageInItemDataGridView_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (AsStorageInItemDataGridView.Columns[e.ColumnIndex].Name != "AsProductListAmount")
            {
                e.Cancel = true;
            }
        }

        private void AsStorageInItemDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            //try
            //{
            //    if (AsStorageInItemDataGridView.Columns[e.ColumnIndex].Name != "AsProductListAmount")
            //    {
            //        List<ProductView> list = (List<ProductView>)AsStorageInItemDataGridView.DataSource;
            //        var item = list[e.RowIndex];
                    
            //    }
            //}
            //catch (Exception ex)
            //{
            //    Toast.Show(ex.Message);
            //}
        }

        private void AsStorageInItemDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
           // Toast.Show("数据格式不正确");
        }

        private void AsStorageInItemDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private bool ValidateAddStorageIn()
        {
            StringBuilder sb = new StringBuilder();
            if (string.IsNullOrEmpty(this.AsNumber.Text))
            { 
                sb.Append("入库单号不能为空\n");
            }
            List<ProductView> list = (List<ProductView>)AsStorageInItemDataGridView.DataSource;
            if (list.Count() == 0)
            {
                sb.Append("至少需要一项入库产品\n");
            }
            if (sb.Length > 0)
            {
                Toast.Show(sb.ToString ());
                return false;
            }
            return true;
        }
        private void btnSaveStorageIn_Click(object sender, EventArgs e)
        {
            try
            {
                SaveStorageIn_Click();
            }
            catch (Exception ex)
            {
                Toast.Show(ex.Message);
            }
        }

        private void SaveStorageIn_Click()
        {
            try
            {
                if (ValidateAddStorageIn())
                {
                    StorageIn si = new StorageIn();
                    si.ListNumber = AsNumber.Text;
                    si.StorageInTime = AsStorageInTime.Value;
                    si.User = SystemVariable.LoginUser;
                    List<ProductView> list = (List<ProductView>)AsStorageInItemDataGridView.DataSource;
                    List<StorageInItem> itemList = new List<StorageInItem>();
                    for (int i = 0; i < list.Count; i++)
                    {
                        StorageInItem item = new StorageInItem();
                        item.Amount = list[i].Amount;
                        item.List = si;
                        item.Specification = new Specification() { Id = list[i].SpecId };
                        item.TaxRate = list[i].TaxRate;
                        item.UnitPrice = list[i].UnitPrice.Value;
                        itemList.Add(item);

                    }


                    SystemVariable.StorageInService.Add(si, itemList);
                    Toast.Show(SystemConstant.OPERATION_IN_STORAGE_SUCCEED);
                    AsNumber.Text = string.Empty;
                    DataGridViewManager.RebindListDataSource<ProductView>(AsStorageInItemDataGridView, null);
                    list.Clear();
                    InitAddStorageInItem();
                    //extensionTabControl1.TabPages.Remove(addStorageInPage);
                    //TabControlManager.ShowPage(extensionTabControl1, listStorageInPage );
                    AsNumber.Text = SystemVariable.StorageInService.GetStorageInNumber();
                    AsProductBarcode.Focus();


                }
            }
            catch (Exception ex)
            {
                Toast.Show(ex.Message);
            }
        }
        private void listStorageInPage_Enter(object sender, EventArgs e)
        {

        }

        private void PurchaseReporterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Toast.Show("Transaction不能提交两次,请检查是是否重复开启事物");
        }

        private void SalesReporterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Toast.Show("NHibernate Exception,请检查配置文件");
        }

        private void InvoicingReporterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TabControlManager.ShowPage(extensionTabControl1,invoicingReportPage);
        }

        private void InvoicingUpdateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Toast.Show("Transaction不能提交两次,请检查是是否重复开启事物");
        }

        private void InvoicingViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                TabControlManager.ShowPage(extensionTabControl1,inventoryPage );
            }
            catch (Exception ex)
            {
                Toast.Show(ex.Message);
            }
        }

        private void inventoryPage_Enter(object sender, EventArgs e)
        {
            try
            {
                IList<ProductView> list = SystemVariable.WarehouseService.GetListByUser(SystemVariable.LoginUser.Id);
                DataGridViewManager.RebindListDataSource<ProductView>(inventoryDataGridView, list);
            }
            catch (Exception ex)
            {
                Toast.Show(ex.Message);
            }
        }

        private void SalesStorageOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Toast.Show("Transaction不能提交两次,请检查是是否重复开启事物");
        }

        private void ribbonMenuButton5_Click(object sender, EventArgs e)
        {
            try
            {
                List<StorageInView> list = SystemVariable.StorageInService.GetView(SystemVariable.LoginUser.Id);
                DataGridViewManager.RebindListDataSource<StorageInView>(StorageInListDataGridView, list);
            }
            catch (Exception ex)
            {
                Toast.Show(ex.Message);
            }
        }

        private void ribbonMenuButton9_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.StorageInListDataGridView.SelectedRows.Count > 0 || StorageInListDataGridView.SelectedCells.Count > 0)
                {
                    int i = StorageInListDataGridView.SelectedCells[0].RowIndex;
                    IList<StorageInView> list = (IList<StorageInView>)StorageInListDataGridView.DataSource;
                    string id = list[i].Id;
                    textBox2.Text = list[i].ListNumber;
                    dateTimePicker2.Value = list[i].StorageInTime;
                    IList<ProductView> itemView = SystemVariable.StorageInService.GetItemView(id);
                    DataGridViewManager.RebindListDataSource<ProductView>(dataGridView2, itemView);
                    TabControlManager.ShowPage(extensionTabControl1, updateStorageInPage);
                }
                else
                {
                    Toast.Show("请选择要查看的行");
                }


                //TabControlManager.ShowPage(extensionTabControl1, updateStorageInPage);


                //IList<ProductView> list = new List<ProductView>();
                //AsStorageInItemDataGridView.Tag = list;
                //DataGridViewManager.RebindListDataSource<ProductView>(AsStorageInItemDataGridView, list);
            }
            catch (Exception ex)
            {
                Toast.Show(ex.Message);
            }
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }
        private void InitAddStorageOutItem()
        {
            AsoStorageOutAmount.Text = string.Empty;
            AsoStorageOutBarcode.Text = string.Empty;
            AsoStorageOutBarcode.Tag = null;
            AsoStorageOutProductName.Text = string.Empty;
            AsoStorageOutProductNumber.Text = string.Empty;
            AsoStorageOutProductNumber.Tag = null;
            AsoStorageOutSpeciText.Text = string.Empty;
            AsoStorageOutUnit.Text = string.Empty;
            AsoStorageOutUnitPrice.Text = string.Empty;
            AsoStorageOutSpeciText.DataSource = new List<Specification>();
        }
        private void AddStorageOutAddItem()
        {
            Specification spec = (Specification)AsoStorageOutBarcode.Tag;

            if (spec != null)
            {
                IList<ProductView> list = (IList<ProductView>)AsoStorageOutItemDataGridView.Tag;
                ProductView product = new ProductView();
                product.Amount = Convert.ToDouble(AsoStorageOutAmount.Text);
                product.ProductId = spec.Product.Id;
                product.SpecId = spec.Id;
                product.Category = spec.Product.Category.CategoryName;
                product.ProductName = spec.Product.ProductName;
                product.ProductNumber = spec.Product.ProductNumber;
                product.Barcode = spec.Barcode;
                product.Category = spec.Product.Category.CategoryName;
                product.SpecifiText = spec.SpecifiText;
                product.TaxRate = spec.Product.TaxRate;
                product.Unit = spec.Unit.DicName;
                product.UnitPrice = Convert.ToDouble(AsoStorageOutUnitPrice.Text);
                list.Add(product);
                DataGridViewManager.RebindListDataSource<ProductView>(AsoStorageOutItemDataGridView, list);
            }
            else
            {
                Toast.Show("请选择产品");
            }
        }
        private void btnAddStorageOutItem_Click(object sender, EventArgs e)
        {
            try
            {
                IList<ProductView> list = (IList<ProductView>)AsoStorageOutItemDataGridView.DataSource;
                Specification spec = (Specification)AsoStorageOutBarcode.Tag;
                int sameProductIndex = -1;
                //如果出库单明细允许存在两条相同的产品记录,那么请注释下面一段代码
                //if (spec != null)
                //{
                //    for (int i = 0; i < list.Count; i++)
                //    {
                //        if (list[i].SpecId == spec.Id)
                //        {
                //            sameProductIndex = i;
                //            break;
                //        }
                //    }
                //}
                // 一段代码结束
                if (sameProductIndex != -1)
                {
                    list[sameProductIndex].Amount += Convert.ToInt32(AsoStorageOutAmount.Text);
                    DataGridViewManager.RebindListDataSource<ProductView>(AsoStorageOutItemDataGridView, list);
                }
                else
                {
                    AddStorageOutAddItem();
                }
                InitAddStorageOutItem();
                //DataGridViewManager.RebindListDataSource<ProductView>(AsStorageInItemDataGridView, list);
                //IList<ProductView> list = (IList<ProductView>)AsStorageInItemDataGridView.Tag;

            }
            catch (Exception ex)
            {
                Toast.Show(ex.Message);
            }
        }

        private void AsoDeleteStorageOutItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (AsoStorageOutItemDataGridView.SelectedRows.Count > 0)
                {
                    IList<ProductView> list = (IList<ProductView>)AsoStorageOutItemDataGridView.Tag;
                    //string id = AsStorageInItemDataGridView.SelectedRows[0].Cells["Id"].Value.ToString();
                    //productListDataGridView.Rows.Remove(productListDataGridView.SelectedRows[0]);
                    list.RemoveAt(AsoStorageOutItemDataGridView.SelectedRows[0].Index);
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
        private void AsoSaveStorageOut2()
        {
            try
            {
                if (ValidateAddStorageOut())
                {
                    StorageOut so = new StorageOut();
                    so.ListNumber = this.AsoStorageOutNumber.Text;
                    so.StorageInTime = AsStorageInTime.Value;
                    so.User = SystemVariable.LoginUser;
                    List<ProductView> list = (List<ProductView>)AsoStorageOutItemDataGridView.DataSource;
                    List<StorageOutItem> itemList = new List<StorageOutItem>();
                    for (int i = 0; i < list.Count; i++)
                    {
                        StorageOutItem item = new StorageOutItem();
                        item.Amount = list[i].Amount;
                        item.List = so;
                        item.Specification = new Specification() { Id = list[i].SpecId };
                        item.TaxRate = list[i].TaxRate;
                        item.UnitPrice = list[i].UnitPrice.Value;
                        itemList.Add(item);
                    }
                    SystemVariable.StorageOutService.Add(so, itemList);
                    Toast.Show(SystemConstant.OPERATION_SUCCEED);
                    this.AsoStorageOutNumber.Text = string.Empty;
                    DataGridViewManager.RebindListDataSource<ProductView>(AsoStorageOutItemDataGridView, null);
                    list.Clear();
                    InitAddStorageOutItem();
                   // extensionTabControl1.TabPages.Remove(addStorageOutPage);
                    AsoStorageOutNumber.Text = SystemVariable.StorageOutService.GetStorageOutNumber();
                    AsoStorageOutBarcode.Focus();
                   

                }
            }
            catch (Exception ex)
            {
                Toast.Show(ex.Message);
            }
        }

        private void AsoSaveStorageOut_Click(object sender, EventArgs e)
        {
            try
            {
                AsoSaveStorageOut2();

                }
            
            catch (Exception ex)
            {
                Toast.Show(ex.Message);
            }
        }

        private void AsoStorageOutProductNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == '\r' && !string.IsNullOrEmpty(AsProductNumber.Text))
                {
                    //AsProductBarcode.Tag = null;
                    ProductInfo product = SystemVariable.ProductService.GetByProductNumber(this.AsoStorageOutProductNumber.Text);
                    AsoStorageOutProductNumber.Tag = product;
                    this.AsoStorageOutBarcode.Tag = product.SpecList[0];
                    if (product != null)
                    {

                        AsoSearchProductPanelShowProduct(product);
                    }
                }
            }
            catch (Exception ex)
            {
                Toast.Show(ex.Message);
            }
        }

        private void treeView1_BeforeLabelEdit(object sender, NodeLabelEditEventArgs e)
        {
            try
            {
                e.CancelEdit = TreeViewManager.IsRootNode(e.Node);
            }
            catch (Exception ex)
            {
                Toast.Show(ex.Message);
            }
        }

        private void addStorageOutPage_Enter(object sender, EventArgs e)
        {
            try
            {
                AsoStorageOutNumber.Text = SystemVariable.StorageOutService.GetStorageOutNumber();
                if (AsoStorageOutItemDataGridView.Tag == null)
                {
                    IList<ProductView> list = new List<ProductView>();
                    AsoStorageOutItemDataGridView.Tag = list;
                    DataGridViewManager.RebindListDataSource<ProductView>(AsoStorageOutItemDataGridView, list);
                }

                
                

            }
            catch (Exception ex)
            {
                Toast.Show(ex.Message);
            }
        }

        private void AsoStorageOutBarcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == '\r' && !string.IsNullOrEmpty(this.AsoStorageOutBarcode.Text))
                {
                    //AsProductName.Tag = null;
                    Specification spec = SystemVariable.ProductService.GetByBarcode(AsoStorageOutBarcode.Text);
                    AsoStorageOutBarcode.Tag = spec;
                    if (spec != null)
                    {
                        AsoSearchProductPanelShowProduct(spec);
                        addStorageOutItem();


                    }
                }
                else
                {
                    if (e.KeyChar == '\r')
                    {
                        List<ProductView> list = (List<ProductView>)AsoStorageOutItemDataGridView.DataSource; 
                        if (list.Count > 0)
                            AsoSaveStorageOut2();
                    }
                }

            

            }
            catch (Exception ex)
            {
                Toast.Show(ex.Message);
            }
        }
     


        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void AsProductBarcode_TextChanged(object sender, EventArgs e)
        {

        }

        private void extensionTabControl1_Selected(object sender, TabControlEventArgs e)
        {
            if (e.TabPage== addStorageInPage)
            {
                this.ActiveControl = this.addStorageInPage;
                this.ActiveControl = this.AsProductBarcode;
                this.AsProductBarcode.Focus();
            }
        }

        private void groupBox9_Enter(object sender, EventArgs e)
        {

        }

        private void extensionTabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AsProductUnit_TextChanged(object sender, EventArgs e)
        {

        }

        private void AsNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void saveStorageOutItem()
        {

        }
        private void addStorageOutItem()
        {
            try
            {
                IList<ProductView> list = (IList<ProductView>)AsoStorageOutItemDataGridView.DataSource;
                Specification spec = (Specification)AsoStorageOutBarcode.Tag;
                int sameProductIndex = -1;
                //如果出库单明细允许存在两条相同的产品记录,那么请注释下面一段代码
                //if (spec != null)
                //{
                //    for (int i = 0; i < list.Count; i++)
                //    {
                //        if (list[i].SpecId == spec.Id)
                //        {
                //            sameProductIndex = i;
                //            break;
                //        }
                //    }
                //}
                // 一段代码结束
                if (sameProductIndex != -1)
                {
                    list[sameProductIndex].Amount += Convert.ToInt32(AsoStorageOutAmount.Text);
                    DataGridViewManager.RebindListDataSource<ProductView>(AsoStorageOutItemDataGridView, list);
                }
                else
                {
                    AddStorageOutAddItem();
                }
                InitAddStorageOutItem();
                //DataGridViewManager.RebindListDataSource<ProductView>(AsStorageInItemDataGridView, list);
                //IList<ProductView> list = (IList<ProductView>)AsStorageInItemDataGridView.Tag;
            }
            catch (Exception ex)
            {
                Toast.Show(ex.Message);
            }
    }
        private bool ValidateAddStorageOut()
        {
            StringBuilder sb = new StringBuilder();
            if (string.IsNullOrEmpty(this.AsoStorageOutNumber.Text))
            {
                sb.Append("出库单号不能为空\n");
            }
            List<ProductView> list = (List<ProductView>)AsoStorageOutItemDataGridView.DataSource;
            if (list.Count() == 0)
            {
                sb.Append("至少需要一项出库产品\n");
            }
            if (sb.Length > 0)
            {
                Toast.Show(sb.ToString());
                return false;
            }
            return true;
        }

        private void tbBarcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r' && !string.IsNullOrEmpty(this.tbBarcode.Text))
            {
                //AsProductName.Tag = null;
                Specification spec = SystemVariable.ProductService.GetByBarcode(tbBarcode.Text);
                tbBarcode.Tag = spec;
                if (spec != null)
                {
                    
                    IList<ProductView> list = (IList<ProductView>)productListDataGridView.DataSource ;
                    list.Clear();
                    list.Add(new ProductView(spec));
                    DataGridViewManager.RebindListDataSource<ProductView>(productListDataGridView, list);
                    tbBarcode.Text = "";
                    tbBarcode.Focus();


                }

            }
            //else
            //{
            //    if (e.KeyChar == '\r')
            //    {
            //        List<ProductView> list = (List<ProductView>)AsStorageInItemDataGridView.DataSource;
            //        if (list.Count > 0)
            //            SaveStorageIn_Click();
            //    }
            //}
        }

        private void ribbonMenuButton3_Click(object sender, EventArgs e)
        {
            try
            {
                TabControlManager.ShowPage(extensionTabControl1, ProductListPage);
            }
            catch (Exception ex)
            {
                Toast.Show(ex.Message);
            }
        }

        private void ribbonMenuButton4_Click(object sender, EventArgs e)
        {
            
            
        }

        private void invoicingReportPage_Enter(object sender, EventArgs e)
        {


        }

        private void InvoicingReportQueryButton_Click(object sender, EventArgs e)
        {
            try
            {
                //DataSet.InvoicingDataTable dt = new DataSet.InvoicingDataTable();

                DataTable t = SystemVariable.WarehouseService.GetInvoicingReportDataTable(InvoicingReportStartTime.Value, InvoicingReportEndTime.Value);

                //foreach (DataRow r in t.Rows)
                //{
                //    var nr = dt.NewRow();
                //    nr["Category"] = r["Category"];
                //    nr["ProductName"] = r["ProductName"];
                //    nr["ProductNumber"] = r["ProductNumber"];
                //    nr["SpecifiText"] = r["SpecifiText"];
                //    nr["StorageInAmount"] = r["StorageInAmount"];
                //    nr["StorageInTotalPrice"] = r["StorageInTotalPrice"];
                //    nr["StorageOutAmount"] = r["StorageOutAmount"];
                //    nr["StorageOutTotalPrice"] = r["StorageOutTotalPrice"];
                //    nr["ProfileLossAmount"] = r["ProfileLossAmount"];
                //    nr["ProfileLossTotalPrice"] = r["ProfileLossTotalPrice"];
                //    nr["InventoryAmount"] = r["InventoryAmount"];
                //    nr["InventoryTotalPrice"] = r["InventoryTotalPrice"];
                //    dt.Rows.Add(nr);
                //}
                InvoicingReport1.SetDataSource(t);
                

                //InvoicingReport1.Refresh();
                crystalReportViewer1.RefreshReport();
                
            }
            catch (Exception ex)
            {
                Toast.Show(ex.Message);
            }
        }

        private void ribbonMenuButton3_Click_1(object sender, EventArgs e)
        {
            try
            {
                TabControlManager.ShowPage(extensionTabControl1, ProductListPage);
            }
            catch (Exception ex)
            {
                Toast.Show(ex.Message);
            }
        }




        
    }
}
