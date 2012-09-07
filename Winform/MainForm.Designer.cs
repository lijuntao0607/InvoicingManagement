﻿using System.Windows.Forms;
namespace Winform
{
    partial class MainForm 
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("产品类别");
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.SystemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExportMyDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.InportMyDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SystemDictionaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PurchaseManagerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PurchaseStorageInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SalesManagerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SalesStorageOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.invoicingToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.InvoicingViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.InvoicingUpdateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PurchaseReporterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SalesReporterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.InvoicingReporterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.CategoryTreeContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.AddCategoryMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RenameMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteCategoryMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel8 = new System.Windows.Forms.Panel();
            this.extensionTabControl1 = new WinformControls.ExtensionTabControl(this.components);
            this.updateProductPage = new System.Windows.Forms.TabPage();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.formLabel9 = new WinformControls.FormLabel();
            this.formLabel8 = new WinformControls.FormLabel();
            this.formLabel7 = new WinformControls.FormLabel();
            this.UpProductName = new System.Windows.Forms.TextBox();
            this.UpProductNumber = new System.Windows.Forms.TextBox();
            this.UpCategory = new System.Windows.Forms.TextBox();
            this.formLabel6 = new WinformControls.FormLabel();
            this.label11 = new System.Windows.Forms.Label();
            this.UpTaxRate = new WinformControls.NumberInputBox(this.components);
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.UpDeleteSpec = new RibbonStyle.RibbonMenuButton();
            this.UpAddSpec = new RibbonStyle.RibbonMenuButton();
            this.UpSave = new RibbonStyle.RibbonMenuButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewComboBoxColumn1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UpSpecDataGridView = new System.Windows.Forms.DataGridView();
            this.UpSlCreateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UpSlIsDel = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.UpSlUnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UpSlBarcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UpSlUnitId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UpSlShowUnit = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.UpSlSpecifiText = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UpSlId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updateStorageInPage = new System.Windows.Forms.TabPage();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.formLabel13 = new WinformControls.FormLabel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.formLabel12 = new WinformControls.FormLabel();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.ribbonMenuButton2 = new RibbonStyle.RibbonMenuButton();
            this.ribbonMenuButton1 = new RibbonStyle.RibbonMenuButton();
            this.formLabel25 = new WinformControls.FormLabel();
            this.UsSearchProductNumber = new System.Windows.Forms.TextBox();
            this.formLabel24 = new WinformControls.FormLabel();
            this.UsSearchBarcode = new System.Windows.Forms.TextBox();
            this.formLabel23 = new WinformControls.FormLabel();
            this.UsSearchProductName = new System.Windows.Forms.TextBox();
            this.formLabel20 = new WinformControls.FormLabel();
            this.UsSearchUnitPrice = new WinformControls.NumberInputBox(this.components);
            this.formLabel26 = new WinformControls.FormLabel();
            this.UsSearchAmount = new WinformControls.NumberInputBox(this.components);
            this.formLabel22 = new WinformControls.FormLabel();
            this.formLabel21 = new WinformControls.FormLabel();
            this.UsSearchUnit = new WinformControls.NumberInputBox(this.components);
            this.UsSearchSpeciText = new System.Windows.Forms.ComboBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn32 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn31 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inventoryPage = new System.Windows.Forms.TabPage();
            this.groupBox15 = new System.Windows.Forms.GroupBox();
            this.inventoryDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn29 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn28 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn27 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn30 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn26 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn25 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn24 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addStorageOutPage = new System.Windows.Forms.TabPage();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.AsoStorageOutBarcode = new System.Windows.Forms.TextBox();
            this.formLabel36 = new WinformControls.FormLabel();
            this.formLabel30 = new WinformControls.FormLabel();
            this.AsoDeleteStorageOutItem = new RibbonStyle.RibbonMenuButton();
            this.AsoStorageOutNumber = new System.Windows.Forms.TextBox();
            this.AsoAddStorageOutItem = new RibbonStyle.RibbonMenuButton();
            this.AsoStorageOutAmount = new WinformControls.NumberInputBox(this.components);
            this.formLabel31 = new WinformControls.FormLabel();
            this.AsoStorageOutProductNumber = new System.Windows.Forms.TextBox();
            this.formLabel37 = new WinformControls.FormLabel();
            this.formLabel33 = new WinformControls.FormLabel();
            this.formLabel29 = new WinformControls.FormLabel();
            this.AsoStorageOutProductName = new System.Windows.Forms.TextBox();
            this.formLabel35 = new WinformControls.FormLabel();
            this.AsoStorageOutUnit = new WinformControls.NumberInputBox(this.components);
            this.AsoStorageOutTime = new System.Windows.Forms.DateTimePicker();
            this.label15 = new System.Windows.Forms.Label();
            this.formLabel34 = new WinformControls.FormLabel();
            this.AsoSaveStorageOut = new RibbonStyle.RibbonMenuButton();
            this.AsoStorageOutSpeciText = new System.Windows.Forms.ComboBox();
            this.AsoStorageOutUnitPrice = new WinformControls.NumberInputBox(this.components);
            this.formLabel32 = new WinformControls.FormLabel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.AsoStorageOutItemDataGridView = new System.Windows.Forms.DataGridView();
            this.AsoProductListCreateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AsoProductListIsDel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AsoProductListUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AsoProductListSpecifiText = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AsoProductListTaxRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AsoProductListCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AsoProductListUnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AsoProductListBarcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AsoProductListProductNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AsoProductListAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AsoProductListProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AsoProductListSpecId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AsoProductListId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listStorageOutPage = new System.Windows.Forms.TabPage();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.formLabel28 = new WinformControls.FormLabel();
            this.SolSearchStartTime = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.SolSearchEndTime = new System.Windows.Forms.DateTimePicker();
            this.ribbonMenuButton5 = new RibbonStyle.RibbonMenuButton();
            this.StorageOutList = new System.Windows.Forms.DataGridView();
            this.CreateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsDel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addStorageInPage = new System.Windows.Forms.TabPage();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.btnAddStorageInItem = new RibbonStyle.RibbonMenuButton();
            this.btnDeleteStorageInItem = new RibbonStyle.RibbonMenuButton();
            this.formLabel19 = new WinformControls.FormLabel();
            this.AsProductBarcode = new System.Windows.Forms.TextBox();
            this.AsProductNumber = new System.Windows.Forms.TextBox();
            this.formLabel27 = new WinformControls.FormLabel();
            this.formLabel10 = new WinformControls.FormLabel();
            this.formLabel14 = new WinformControls.FormLabel();
            this.AsNumber = new System.Windows.Forms.TextBox();
            this.AsProductAmount = new WinformControls.NumberInputBox(this.components);
            this.formLabel11 = new WinformControls.FormLabel();
            this.formLabel17 = new WinformControls.FormLabel();
            this.AsStorageInTime = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.btnSaveStorageIn = new RibbonStyle.RibbonMenuButton();
            this.formLabel16 = new WinformControls.FormLabel();
            this.AsProductName = new System.Windows.Forms.TextBox();
            this.formLabel18 = new WinformControls.FormLabel();
            this.AsProductSpeciText = new System.Windows.Forms.ComboBox();
            this.AsProductUnit = new WinformControls.NumberInputBox(this.components);
            this.AsProductUnitPrice = new WinformControls.NumberInputBox(this.components);
            this.formLabel15 = new WinformControls.FormLabel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.AsStorageInItemDataGridView = new System.Windows.Forms.DataGridView();
            this.AsProductListCreateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AsProductListIsDel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AsProductListUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AsProductListSpeciText = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AsProductListTaxRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AsProductListCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AsProductListUnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AsProductListBarcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AdProductListNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AsProductListAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AsProductListName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AsProductListSpecId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AsProductListId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listStorageInPage = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.formLabel5 = new WinformControls.FormLabel();
            this.SilSearchStartTime = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.SilSearchEndTime = new System.Windows.Forms.DateTimePicker();
            this.btnSearchStorageIn = new RibbonStyle.RibbonMenuButton();
            this.ribbonMenuButton7 = new RibbonStyle.RibbonMenuButton();
            this.ribbonMenuButton9 = new RibbonStyle.RibbonMenuButton();
            this.StorageInListDataGridView = new System.Windows.Forms.DataGridView();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StlStorageInTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StlStorageInTotalAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StlStorageInTotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StlStorageListNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StlId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddProductPage = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.formLabel1 = new WinformControls.FormLabel();
            this.formLabel2 = new WinformControls.FormLabel();
            this.formLabel3 = new WinformControls.FormLabel();
            this.ApProductName = new System.Windows.Forms.TextBox();
            this.ApProductNumber = new System.Windows.Forms.TextBox();
            this.ApCategory = new System.Windows.Forms.TextBox();
            this.formLabel4 = new WinformControls.FormLabel();
            this.ApTaxRate = new WinformControls.NumberInputBox(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnDeleteSpec = new RibbonStyle.RibbonMenuButton();
            this.btnAddSpec = new RibbonStyle.RibbonMenuButton();
            this.btnSaveAndContinue = new RibbonStyle.RibbonMenuButton();
            this.btnSaveClose = new RibbonStyle.RibbonMenuButton();
            this.formLabel38 = new WinformControls.FormLabel();
            this.formLabel39 = new WinformControls.FormLabel();
            this.formLabel40 = new WinformControls.FormLabel();
            this.formLabel41 = new WinformControls.FormLabel();
            this.ApUnitPrice = new WinformControls.NumberInputBox(this.components);
            this.ApSpeciText = new System.Windows.Forms.TextBox();
            this.ApBarcode = new System.Windows.Forms.TextBox();
            this.ApUnit = new System.Windows.Forms.ComboBox();
            this.ApSpecDataGridView = new System.Windows.Forms.DataGridView();
            this.SLCreateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SLIsDel = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.SLUnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SLBarcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SLUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SLShowUnit = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.SLSpecifiText = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SLId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductListPage = new System.Windows.Forms.TabPage();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblProductNumber = new WinformControls.FormLabel();
            this.tbProduct = new System.Windows.Forms.TextBox();
            this.lblBarcode = new WinformControls.FormLabel();
            this.tbBarcode = new System.Windows.Forms.TextBox();
            this.btnEditProduct = new RibbonStyle.RibbonMenuButton();
            this.btnAddProduct = new RibbonStyle.RibbonMenuButton();
            this.ribbonMenuButton6 = new RibbonStyle.RibbonMenuButton();
            this.btnDeleteProduct = new RibbonStyle.RibbonMenuButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.productListDataGridView = new System.Windows.Forms.DataGridView();
            this.PlBarcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlProductAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlTaxRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlSpecText = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlUnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlProductNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlSpecId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel9 = new System.Windows.Forms.Panel();
            this.ribbonMenuButton3 = new RibbonStyle.RibbonMenuButton();
            this.menuStrip1.SuspendLayout();
            this.CategoryTreeContextMenuStrip.SuspendLayout();
            this.panel8.SuspendLayout();
            this.extensionTabControl1.SuspendLayout();
            this.updateProductPage.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpSpecDataGridView)).BeginInit();
            this.updateStorageInPage.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.panel6.SuspendLayout();
            this.groupBox11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.inventoryPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryDataGridView)).BeginInit();
            this.addStorageOutPage.SuspendLayout();
            this.groupBox13.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AsoStorageOutItemDataGridView)).BeginInit();
            this.listStorageOutPage.SuspendLayout();
            this.groupBox12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StorageOutList)).BeginInit();
            this.addStorageInPage.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AsStorageInItemDataGridView)).BeginInit();
            this.listStorageInPage.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StorageInListDataGridView)).BeginInit();
            this.AddProductPage.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ApSpecDataGridView)).BeginInit();
            this.ProductListPage.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productListDataGridView)).BeginInit();
            this.panel9.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SystemToolStripMenuItem,
            this.productInfoToolStripMenuItem,
            this.PurchaseManagerToolStripMenuItem,
            this.SalesManagerToolStripMenuItem,
            this.invoicingToolStripMenuItem1,
            this.ReportToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(890, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // SystemToolStripMenuItem
            // 
            this.SystemToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ExportMyDataToolStripMenuItem,
            this.InportMyDataToolStripMenuItem,
            this.ExitToolStripMenuItem});
            this.SystemToolStripMenuItem.Name = "SystemToolStripMenuItem";
            this.SystemToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.SystemToolStripMenuItem.Text = "系统";
            // 
            // ExportMyDataToolStripMenuItem
            // 
            this.ExportMyDataToolStripMenuItem.Name = "ExportMyDataToolStripMenuItem";
            this.ExportMyDataToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.ExportMyDataToolStripMenuItem.Text = "导出我的数据";
            this.ExportMyDataToolStripMenuItem.Visible = false;
            // 
            // InportMyDataToolStripMenuItem
            // 
            this.InportMyDataToolStripMenuItem.Name = "InportMyDataToolStripMenuItem";
            this.InportMyDataToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.InportMyDataToolStripMenuItem.Text = "导入我的数据";
            this.InportMyDataToolStripMenuItem.Visible = false;
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.ExitToolStripMenuItem.Text = "退出";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // productInfoToolStripMenuItem
            // 
            this.productInfoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productListToolStripMenuItem,
            this.addProductToolStripMenuItem,
            this.SystemDictionaryToolStripMenuItem});
            this.productInfoToolStripMenuItem.Name = "productInfoToolStripMenuItem";
            this.productInfoToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.productInfoToolStripMenuItem.Text = "产品";
            // 
            // productListToolStripMenuItem
            // 
            this.productListToolStripMenuItem.Name = "productListToolStripMenuItem";
            this.productListToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.productListToolStripMenuItem.Text = "产品列表";
            this.productListToolStripMenuItem.Click += new System.EventHandler(this.productListToolStripMenuItem_Click);
            // 
            // addProductToolStripMenuItem
            // 
            this.addProductToolStripMenuItem.Name = "addProductToolStripMenuItem";
            this.addProductToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.addProductToolStripMenuItem.Text = "添加产品";
            this.addProductToolStripMenuItem.Click += new System.EventHandler(this.addProductToolStripMenuItem_Click);
            // 
            // SystemDictionaryToolStripMenuItem
            // 
            this.SystemDictionaryToolStripMenuItem.Name = "SystemDictionaryToolStripMenuItem";
            this.SystemDictionaryToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.SystemDictionaryToolStripMenuItem.Text = "系统字典";
            this.SystemDictionaryToolStripMenuItem.Click += new System.EventHandler(this.SystemDictionaryToolStripMenuItem_Click);
            // 
            // PurchaseManagerToolStripMenuItem
            // 
            this.PurchaseManagerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PurchaseStorageInToolStripMenuItem});
            this.PurchaseManagerToolStripMenuItem.Name = "PurchaseManagerToolStripMenuItem";
            this.PurchaseManagerToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.PurchaseManagerToolStripMenuItem.Text = "采购管理";
            // 
            // PurchaseStorageInToolStripMenuItem
            // 
            this.PurchaseStorageInToolStripMenuItem.Name = "PurchaseStorageInToolStripMenuItem";
            this.PurchaseStorageInToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.PurchaseStorageInToolStripMenuItem.Text = "采购进货";
            this.PurchaseStorageInToolStripMenuItem.Click += new System.EventHandler(this.PurchaseStorageInToolStripMenuItem_Click);
            // 
            // SalesManagerToolStripMenuItem
            // 
            this.SalesManagerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SalesStorageOutToolStripMenuItem});
            this.SalesManagerToolStripMenuItem.Name = "SalesManagerToolStripMenuItem";
            this.SalesManagerToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.SalesManagerToolStripMenuItem.Text = "销售管理";
            // 
            // SalesStorageOutToolStripMenuItem
            // 
            this.SalesStorageOutToolStripMenuItem.Name = "SalesStorageOutToolStripMenuItem";
            this.SalesStorageOutToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.SalesStorageOutToolStripMenuItem.Text = "销售出库";
            this.SalesStorageOutToolStripMenuItem.Click += new System.EventHandler(this.SalesStorageOutToolStripMenuItem_Click);
            // 
            // invoicingToolStripMenuItem1
            // 
            this.invoicingToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.InvoicingViewToolStripMenuItem,
            this.InvoicingUpdateToolStripMenuItem});
            this.invoicingToolStripMenuItem1.Name = "invoicingToolStripMenuItem1";
            this.invoicingToolStripMenuItem1.Size = new System.Drawing.Size(41, 20);
            this.invoicingToolStripMenuItem1.Text = "库存";
            // 
            // InvoicingViewToolStripMenuItem
            // 
            this.InvoicingViewToolStripMenuItem.Name = "InvoicingViewToolStripMenuItem";
            this.InvoicingViewToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.InvoicingViewToolStripMenuItem.Text = "库存查看";
            this.InvoicingViewToolStripMenuItem.Click += new System.EventHandler(this.InvoicingViewToolStripMenuItem_Click);
            // 
            // InvoicingUpdateToolStripMenuItem
            // 
            this.InvoicingUpdateToolStripMenuItem.Name = "InvoicingUpdateToolStripMenuItem";
            this.InvoicingUpdateToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.InvoicingUpdateToolStripMenuItem.Text = "盘点库存";
            this.InvoicingUpdateToolStripMenuItem.Visible = false;
            this.InvoicingUpdateToolStripMenuItem.Click += new System.EventHandler(this.InvoicingUpdateToolStripMenuItem_Click);
            // 
            // ReportToolStripMenuItem
            // 
            this.ReportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PurchaseReporterToolStripMenuItem,
            this.SalesReporterToolStripMenuItem,
            this.InvoicingReporterToolStripMenuItem});
            this.ReportToolStripMenuItem.Name = "ReportToolStripMenuItem";
            this.ReportToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.ReportToolStripMenuItem.Text = "报表";
            this.ReportToolStripMenuItem.Visible = false;
            // 
            // PurchaseReporterToolStripMenuItem
            // 
            this.PurchaseReporterToolStripMenuItem.Name = "PurchaseReporterToolStripMenuItem";
            this.PurchaseReporterToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.PurchaseReporterToolStripMenuItem.Text = "采购统计报表";
            this.PurchaseReporterToolStripMenuItem.Visible = false;
            this.PurchaseReporterToolStripMenuItem.Click += new System.EventHandler(this.PurchaseReporterToolStripMenuItem_Click);
            // 
            // SalesReporterToolStripMenuItem
            // 
            this.SalesReporterToolStripMenuItem.Name = "SalesReporterToolStripMenuItem";
            this.SalesReporterToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.SalesReporterToolStripMenuItem.Text = "销售统计报表";
            this.SalesReporterToolStripMenuItem.Visible = false;
            this.SalesReporterToolStripMenuItem.Click += new System.EventHandler(this.SalesReporterToolStripMenuItem_Click);
            // 
            // InvoicingReporterToolStripMenuItem
            // 
            this.InvoicingReporterToolStripMenuItem.Name = "InvoicingReporterToolStripMenuItem";
            this.InvoicingReporterToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.InvoicingReporterToolStripMenuItem.Text = "进销存统计报表";
            this.InvoicingReporterToolStripMenuItem.Visible = false;
            this.InvoicingReporterToolStripMenuItem.Click += new System.EventHandler(this.InvoicingReporterToolStripMenuItem_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // CategoryTreeContextMenuStrip
            // 
            this.CategoryTreeContextMenuStrip.BackColor = System.Drawing.SystemColors.MenuBar;
            this.CategoryTreeContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddCategoryMenuItem,
            this.RenameMenuItem,
            this.DeleteCategoryMenuItem});
            this.CategoryTreeContextMenuStrip.Name = "CategoryTreeContextMenuStrip";
            this.CategoryTreeContextMenuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.CategoryTreeContextMenuStrip.Size = new System.Drawing.Size(123, 70);
            // 
            // AddCategoryMenuItem
            // 
            this.AddCategoryMenuItem.Name = "AddCategoryMenuItem";
            this.AddCategoryMenuItem.Size = new System.Drawing.Size(122, 22);
            this.AddCategoryMenuItem.Text = "添加类别";
            this.AddCategoryMenuItem.Click += new System.EventHandler(this.AddCategoryMenuItem_Click);
            // 
            // RenameMenuItem
            // 
            this.RenameMenuItem.Name = "RenameMenuItem";
            this.RenameMenuItem.Size = new System.Drawing.Size(122, 22);
            this.RenameMenuItem.Text = "重命名";
            this.RenameMenuItem.Click += new System.EventHandler(this.RenameMenuItem_Click);
            // 
            // DeleteCategoryMenuItem
            // 
            this.DeleteCategoryMenuItem.Name = "DeleteCategoryMenuItem";
            this.DeleteCategoryMenuItem.Size = new System.Drawing.Size(122, 22);
            this.DeleteCategoryMenuItem.Text = "删除类别";
            this.DeleteCategoryMenuItem.Click += new System.EventHandler(this.DeleteCategoryMenuItem_Click);
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.ribbonMenuButton3);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel8.Location = new System.Drawing.Point(0, 24);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(143, 417);
            this.panel8.TabIndex = 5;
            // 
            // extensionTabControl1
            // 
            this.extensionTabControl1.Controls.Add(this.ProductListPage);
            this.extensionTabControl1.Controls.Add(this.AddProductPage);
            this.extensionTabControl1.Controls.Add(this.listStorageInPage);
            this.extensionTabControl1.Controls.Add(this.addStorageInPage);
            this.extensionTabControl1.Controls.Add(this.listStorageOutPage);
            this.extensionTabControl1.Controls.Add(this.addStorageOutPage);
            this.extensionTabControl1.Controls.Add(this.inventoryPage);
            this.extensionTabControl1.Controls.Add(this.updateStorageInPage);
            this.extensionTabControl1.Controls.Add(this.updateProductPage);
            this.extensionTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.extensionTabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.extensionTabControl1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.extensionTabControl1.HotTrack = true;
            this.extensionTabControl1.Location = new System.Drawing.Point(0, 0);
            this.extensionTabControl1.Name = "extensionTabControl1";
            this.extensionTabControl1.SelectedIndex = 0;
            this.extensionTabControl1.Size = new System.Drawing.Size(747, 417);
            this.extensionTabControl1.TabIndex = 1;
            this.extensionTabControl1.SelectedIndexChanged += new System.EventHandler(this.extensionTabControl1_SelectedIndexChanged);
            this.extensionTabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this.extensionTabControl1_Selected);
            // 
            // updateProductPage
            // 
            this.updateProductPage.Controls.Add(this.groupBox7);
            this.updateProductPage.Controls.Add(this.groupBox6);
            this.updateProductPage.Location = new System.Drawing.Point(4, 24);
            this.updateProductPage.Name = "updateProductPage";
            this.updateProductPage.Padding = new System.Windows.Forms.Padding(3);
            this.updateProductPage.Size = new System.Drawing.Size(882, 389);
            this.updateProductPage.TabIndex = 2;
            this.updateProductPage.Text = "修改产品信息  ";
            this.updateProductPage.UseVisualStyleBackColor = true;
            this.updateProductPage.Enter += new System.EventHandler(this.updateProductPage_Enter);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label7);
            this.groupBox6.Controls.Add(this.label8);
            this.groupBox6.Controls.Add(this.label9);
            this.groupBox6.Controls.Add(this.label10);
            this.groupBox6.Controls.Add(this.UpTaxRate);
            this.groupBox6.Controls.Add(this.label11);
            this.groupBox6.Controls.Add(this.formLabel6);
            this.groupBox6.Controls.Add(this.UpCategory);
            this.groupBox6.Controls.Add(this.UpProductNumber);
            this.groupBox6.Controls.Add(this.UpProductName);
            this.groupBox6.Controls.Add(this.formLabel7);
            this.groupBox6.Controls.Add(this.formLabel8);
            this.groupBox6.Controls.Add(this.formLabel9);
            this.groupBox6.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox6.Location = new System.Drawing.Point(3, 3);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(876, 101);
            this.groupBox6.TabIndex = 1;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "产品基本信息";
            // 
            // formLabel9
            // 
            this.formLabel9.AutoSize = true;
            this.formLabel9.Location = new System.Drawing.Point(22, 30);
            this.formLabel9.Name = "formLabel9";
            this.formLabel9.Size = new System.Drawing.Size(49, 14);
            this.formLabel9.TabIndex = 0;
            this.formLabel9.Text = "产品名";
            // 
            // formLabel8
            // 
            this.formLabel8.AutoSize = true;
            this.formLabel8.Location = new System.Drawing.Point(22, 57);
            this.formLabel8.Name = "formLabel8";
            this.formLabel8.Size = new System.Drawing.Size(49, 14);
            this.formLabel8.TabIndex = 1;
            this.formLabel8.Text = "货  号";
            // 
            // formLabel7
            // 
            this.formLabel7.AutoSize = true;
            this.formLabel7.Location = new System.Drawing.Point(297, 30);
            this.formLabel7.Name = "formLabel7";
            this.formLabel7.Size = new System.Drawing.Size(49, 14);
            this.formLabel7.TabIndex = 2;
            this.formLabel7.Text = "类  别";
            // 
            // UpProductName
            // 
            this.UpProductName.Location = new System.Drawing.Point(87, 27);
            this.UpProductName.Name = "UpProductName";
            this.UpProductName.Size = new System.Drawing.Size(100, 23);
            this.UpProductName.TabIndex = 3;
            // 
            // UpProductNumber
            // 
            this.UpProductNumber.Location = new System.Drawing.Point(87, 54);
            this.UpProductNumber.Name = "UpProductNumber";
            this.UpProductNumber.Size = new System.Drawing.Size(100, 23);
            this.UpProductNumber.TabIndex = 4;
            // 
            // UpCategory
            // 
            this.UpCategory.BackColor = System.Drawing.SystemColors.Window;
            this.UpCategory.Location = new System.Drawing.Point(362, 27);
            this.UpCategory.Name = "UpCategory";
            this.UpCategory.ReadOnly = true;
            this.UpCategory.Size = new System.Drawing.Size(100, 23);
            this.UpCategory.TabIndex = 5;
            this.UpCategory.Enter += new System.EventHandler(this.UpCategory_Enter);
            // 
            // formLabel6
            // 
            this.formLabel6.AutoSize = true;
            this.formLabel6.Location = new System.Drawing.Point(297, 57);
            this.formLabel6.Name = "formLabel6";
            this.formLabel6.Size = new System.Drawing.Size(49, 14);
            this.formLabel6.TabIndex = 6;
            this.formLabel6.Text = "税  率";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.Location = new System.Drawing.Point(485, 57);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(119, 12);
            this.label11.TabIndex = 8;
            this.label11.Text = "( 如6%的税率输入6 )";
            // 
            // UpTaxRate
            // 
            this.UpTaxRate.Location = new System.Drawing.Point(362, 54);
            this.UpTaxRate.Name = "UpTaxRate";
            this.UpTaxRate.Size = new System.Drawing.Size(100, 23);
            this.UpTaxRate.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.ForeColor = System.Drawing.Color.DarkRed;
            this.label10.Location = new System.Drawing.Point(193, 30);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(11, 12);
            this.label10.TabIndex = 10;
            this.label10.Text = "*";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.ForeColor = System.Drawing.Color.DarkRed;
            this.label9.Location = new System.Drawing.Point(193, 59);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(11, 12);
            this.label9.TabIndex = 12;
            this.label9.Text = "*";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.ForeColor = System.Drawing.Color.DarkRed;
            this.label8.Location = new System.Drawing.Point(477, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(11, 12);
            this.label8.TabIndex = 13;
            this.label8.Text = "*";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.ForeColor = System.Drawing.Color.DarkRed;
            this.label7.Location = new System.Drawing.Point(477, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(11, 12);
            this.label7.TabIndex = 14;
            this.label7.Text = "*";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.UpSpecDataGridView);
            this.groupBox7.Controls.Add(this.dataGridView1);
            this.groupBox7.Controls.Add(this.panel4);
            this.groupBox7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox7.Location = new System.Drawing.Point(3, 104);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(876, 282);
            this.groupBox7.TabIndex = 3;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "产品规格";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.UpSave);
            this.panel4.Controls.Add(this.UpAddSpec);
            this.panel4.Controls.Add(this.UpDeleteSpec);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(3, 19);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(870, 62);
            this.panel4.TabIndex = 2;
            // 
            // UpDeleteSpec
            // 
            this.UpDeleteSpec.Arrow = RibbonStyle.RibbonMenuButton.e_arrow.None;
            this.UpDeleteSpec.BackColor = System.Drawing.Color.Transparent;
            this.UpDeleteSpec.ColorBase = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(209)))), ((int)(((byte)(240)))));
            this.UpDeleteSpec.ColorBaseStroke = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(187)))), ((int)(((byte)(213)))));
            this.UpDeleteSpec.ColorOn = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(78)))));
            this.UpDeleteSpec.ColorOnStroke = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(177)))), ((int)(((byte)(118)))));
            this.UpDeleteSpec.ColorPress = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.UpDeleteSpec.ColorPressStroke = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.UpDeleteSpec.FadingSpeed = 20;
            this.UpDeleteSpec.FlatAppearance.BorderSize = 0;
            this.UpDeleteSpec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpDeleteSpec.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpDeleteSpec.ForeColor = System.Drawing.Color.DarkBlue;
            this.UpDeleteSpec.GroupPos = RibbonStyle.RibbonMenuButton.e_groupPos.None;
            this.UpDeleteSpec.Image = global::Winform.Properties.Resources.gtk_remove;
            this.UpDeleteSpec.ImageLocation = RibbonStyle.RibbonMenuButton.e_imagelocation.Left;
            this.UpDeleteSpec.ImageOffset = 0;
            this.UpDeleteSpec.IsPressed = false;
            this.UpDeleteSpec.KeepPress = false;
            this.UpDeleteSpec.Location = new System.Drawing.Point(103, 17);
            this.UpDeleteSpec.MaxImageSize = new System.Drawing.Point(0, 0);
            this.UpDeleteSpec.MenuPos = new System.Drawing.Point(0, 0);
            this.UpDeleteSpec.Name = "UpDeleteSpec";
            this.UpDeleteSpec.Radius = 10;
            this.UpDeleteSpec.ShowBase = RibbonStyle.RibbonMenuButton.e_showbase.Yes;
            this.UpDeleteSpec.Size = new System.Drawing.Size(76, 29);
            this.UpDeleteSpec.SplitButton = RibbonStyle.RibbonMenuButton.e_splitbutton.No;
            this.UpDeleteSpec.SplitDistance = 0;
            this.UpDeleteSpec.TabIndex = 8;
            this.UpDeleteSpec.Text = "删除";
            this.UpDeleteSpec.Title = "";
            this.UpDeleteSpec.UseVisualStyleBackColor = true;
            this.UpDeleteSpec.Click += new System.EventHandler(this.UpDeleteSpec_Click);
            // 
            // UpAddSpec
            // 
            this.UpAddSpec.Arrow = RibbonStyle.RibbonMenuButton.e_arrow.None;
            this.UpAddSpec.BackColor = System.Drawing.Color.Transparent;
            this.UpAddSpec.ColorBase = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(209)))), ((int)(((byte)(240)))));
            this.UpAddSpec.ColorBaseStroke = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(187)))), ((int)(((byte)(213)))));
            this.UpAddSpec.ColorOn = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(78)))));
            this.UpAddSpec.ColorOnStroke = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(177)))), ((int)(((byte)(118)))));
            this.UpAddSpec.ColorPress = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.UpAddSpec.ColorPressStroke = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.UpAddSpec.FadingSpeed = 20;
            this.UpAddSpec.FlatAppearance.BorderSize = 0;
            this.UpAddSpec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpAddSpec.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpAddSpec.ForeColor = System.Drawing.Color.DarkBlue;
            this.UpAddSpec.GroupPos = RibbonStyle.RibbonMenuButton.e_groupPos.None;
            this.UpAddSpec.Image = global::Winform.Properties.Resources.add;
            this.UpAddSpec.ImageLocation = RibbonStyle.RibbonMenuButton.e_imagelocation.Left;
            this.UpAddSpec.ImageOffset = 0;
            this.UpAddSpec.IsPressed = false;
            this.UpAddSpec.KeepPress = false;
            this.UpAddSpec.Location = new System.Drawing.Point(17, 17);
            this.UpAddSpec.MaxImageSize = new System.Drawing.Point(0, 0);
            this.UpAddSpec.MenuPos = new System.Drawing.Point(0, 0);
            this.UpAddSpec.Name = "UpAddSpec";
            this.UpAddSpec.Radius = 10;
            this.UpAddSpec.ShowBase = RibbonStyle.RibbonMenuButton.e_showbase.Yes;
            this.UpAddSpec.Size = new System.Drawing.Size(76, 29);
            this.UpAddSpec.SplitButton = RibbonStyle.RibbonMenuButton.e_splitbutton.No;
            this.UpAddSpec.SplitDistance = 0;
            this.UpAddSpec.TabIndex = 7;
            this.UpAddSpec.Text = "添加";
            this.UpAddSpec.Title = "";
            this.UpAddSpec.UseVisualStyleBackColor = true;
            this.UpAddSpec.Click += new System.EventHandler(this.UpAddSpec_Click);
            // 
            // UpSave
            // 
            this.UpSave.Arrow = RibbonStyle.RibbonMenuButton.e_arrow.None;
            this.UpSave.BackColor = System.Drawing.Color.Transparent;
            this.UpSave.ColorBase = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(209)))), ((int)(((byte)(240)))));
            this.UpSave.ColorBaseStroke = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(187)))), ((int)(((byte)(213)))));
            this.UpSave.ColorOn = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(78)))));
            this.UpSave.ColorOnStroke = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(177)))), ((int)(((byte)(118)))));
            this.UpSave.ColorPress = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.UpSave.ColorPressStroke = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.UpSave.FadingSpeed = 20;
            this.UpSave.FlatAppearance.BorderSize = 0;
            this.UpSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpSave.ForeColor = System.Drawing.Color.DarkBlue;
            this.UpSave.GroupPos = RibbonStyle.RibbonMenuButton.e_groupPos.None;
            this.UpSave.Image = global::Winform.Properties.Resources.document_open;
            this.UpSave.ImageLocation = RibbonStyle.RibbonMenuButton.e_imagelocation.Left;
            this.UpSave.ImageOffset = 0;
            this.UpSave.IsPressed = false;
            this.UpSave.KeepPress = false;
            this.UpSave.Location = new System.Drawing.Point(599, 17);
            this.UpSave.MaxImageSize = new System.Drawing.Point(0, 0);
            this.UpSave.MenuPos = new System.Drawing.Point(0, 0);
            this.UpSave.Name = "UpSave";
            this.UpSave.Radius = 10;
            this.UpSave.ShowBase = RibbonStyle.RibbonMenuButton.e_showbase.Yes;
            this.UpSave.Size = new System.Drawing.Size(101, 29);
            this.UpSave.SplitButton = RibbonStyle.RibbonMenuButton.e_splitbutton.No;
            this.UpSave.SplitDistance = 0;
            this.UpSave.TabIndex = 10;
            this.UpSave.Text = "  保存";
            this.UpSave.Title = "";
            this.UpSave.UseVisualStyleBackColor = true;
            this.UpSave.Click += new System.EventHandler(this.UpSave_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewComboBoxColumn1,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewTextBoxColumn6});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 81);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(870, 198);
            this.dataGridView1.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "CreateTime";
            this.dataGridViewTextBoxColumn6.HeaderText = "CreateTime";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Visible = false;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "IsDel";
            this.dataGridViewCheckBoxColumn1.HeaderText = "IsDel";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "UnitPrice";
            this.dataGridViewTextBoxColumn5.HeaderText = "单价(含税)";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Barcode";
            this.dataGridViewTextBoxColumn4.HeaderText = "条形码";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "UnitId";
            this.dataGridViewTextBoxColumn3.HeaderText = "计量单位";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Visible = false;
            // 
            // dataGridViewComboBoxColumn1
            // 
            this.dataGridViewComboBoxColumn1.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.dataGridViewComboBoxColumn1.HeaderText = "计量单位";
            this.dataGridViewComboBoxColumn1.Name = "dataGridViewComboBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "SpecifiText";
            this.dataGridViewTextBoxColumn2.HeaderText = "产品规格";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // UpSpecDataGridView
            // 
            this.UpSpecDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.UpSpecDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UpSpecDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UpSlId,
            this.UpSlSpecifiText,
            this.UpSlShowUnit,
            this.UpSlUnitId,
            this.UpSlBarcode,
            this.UpSlUnitPrice,
            this.UpSlIsDel,
            this.UpSlCreateTime});
            this.UpSpecDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UpSpecDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.UpSpecDataGridView.Location = new System.Drawing.Point(3, 81);
            this.UpSpecDataGridView.Name = "UpSpecDataGridView";
            this.UpSpecDataGridView.RowTemplate.Height = 23;
            this.UpSpecDataGridView.Size = new System.Drawing.Size(870, 198);
            this.UpSpecDataGridView.TabIndex = 4;
            this.UpSpecDataGridView.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.UpSpecDataGridView_CellBeginEdit);
            this.UpSpecDataGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.UpSpecDataGridView_CellEndEdit);
            // 
            // UpSlCreateTime
            // 
            this.UpSlCreateTime.DataPropertyName = "CreateTime";
            this.UpSlCreateTime.HeaderText = "CreateTime";
            this.UpSlCreateTime.Name = "UpSlCreateTime";
            this.UpSlCreateTime.Visible = false;
            // 
            // UpSlIsDel
            // 
            this.UpSlIsDel.DataPropertyName = "IsDel";
            this.UpSlIsDel.HeaderText = "IsDel";
            this.UpSlIsDel.Name = "UpSlIsDel";
            this.UpSlIsDel.Visible = false;
            // 
            // UpSlUnitPrice
            // 
            this.UpSlUnitPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.UpSlUnitPrice.DataPropertyName = "UnitPrice";
            this.UpSlUnitPrice.HeaderText = "单价(含税)";
            this.UpSlUnitPrice.Name = "UpSlUnitPrice";
            this.UpSlUnitPrice.Width = 102;
            // 
            // UpSlBarcode
            // 
            this.UpSlBarcode.DataPropertyName = "Barcode";
            this.UpSlBarcode.HeaderText = "条形码";
            this.UpSlBarcode.Name = "UpSlBarcode";
            // 
            // UpSlUnitId
            // 
            this.UpSlUnitId.DataPropertyName = "UnitId";
            this.UpSlUnitId.HeaderText = "计量单位";
            this.UpSlUnitId.Name = "UpSlUnitId";
            this.UpSlUnitId.Visible = false;
            // 
            // UpSlShowUnit
            // 
            this.UpSlShowUnit.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.UpSlShowUnit.HeaderText = "计量单位";
            this.UpSlShowUnit.Name = "UpSlShowUnit";
            // 
            // UpSlSpecifiText
            // 
            this.UpSlSpecifiText.DataPropertyName = "SpecifiText";
            this.UpSlSpecifiText.HeaderText = "产品规格";
            this.UpSlSpecifiText.Name = "UpSlSpecifiText";
            // 
            // UpSlId
            // 
            this.UpSlId.DataPropertyName = "Id";
            this.UpSlId.HeaderText = "Id";
            this.UpSlId.Name = "UpSlId";
            this.UpSlId.Visible = false;
            // 
            // updateStorageInPage
            // 
            this.updateStorageInPage.Controls.Add(this.panel6);
            this.updateStorageInPage.Controls.Add(this.groupBox10);
            this.updateStorageInPage.Location = new System.Drawing.Point(4, 24);
            this.updateStorageInPage.Name = "updateStorageInPage";
            this.updateStorageInPage.Padding = new System.Windows.Forms.Padding(3);
            this.updateStorageInPage.Size = new System.Drawing.Size(882, 389);
            this.updateStorageInPage.TabIndex = 3;
            this.updateStorageInPage.Text = "修改采购入库单  ";
            this.updateStorageInPage.UseVisualStyleBackColor = true;
            this.updateStorageInPage.Enter += new System.EventHandler(this.updateStorageInPage_Enter);
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.label13);
            this.groupBox10.Controls.Add(this.dateTimePicker2);
            this.groupBox10.Controls.Add(this.formLabel12);
            this.groupBox10.Controls.Add(this.textBox2);
            this.groupBox10.Controls.Add(this.formLabel13);
            this.groupBox10.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox10.Location = new System.Drawing.Point(3, 3);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(876, 84);
            this.groupBox10.TabIndex = 1;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "入库单信息";
            // 
            // formLabel13
            // 
            this.formLabel13.AutoSize = true;
            this.formLabel13.Location = new System.Drawing.Point(40, 33);
            this.formLabel13.Name = "formLabel13";
            this.formLabel13.Size = new System.Drawing.Size(63, 14);
            this.formLabel13.TabIndex = 0;
            this.formLabel13.Text = "入库单号";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBox2.Location = new System.Drawing.Point(109, 30);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(124, 23);
            this.textBox2.TabIndex = 1;
            // 
            // formLabel12
            // 
            this.formLabel12.AutoSize = true;
            this.formLabel12.Location = new System.Drawing.Point(401, 33);
            this.formLabel12.Name = "formLabel12";
            this.formLabel12.Size = new System.Drawing.Size(63, 14);
            this.formLabel12.TabIndex = 2;
            this.formLabel12.Text = "入库日期";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Enabled = false;
            this.dateTimePicker2.Location = new System.Drawing.Point(470, 27);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(124, 23);
            this.dateTimePicker2.TabIndex = 3;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label13.ForeColor = System.Drawing.Color.DarkRed;
            this.label13.Location = new System.Drawing.Point(249, 35);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(11, 12);
            this.label13.TabIndex = 12;
            this.label13.Text = "*";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.dataGridView2);
            this.panel6.Controls.Add(this.groupBox11);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(3, 87);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(876, 299);
            this.panel6.TabIndex = 2;
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.UsSearchSpeciText);
            this.groupBox11.Controls.Add(this.UsSearchUnit);
            this.groupBox11.Controls.Add(this.formLabel21);
            this.groupBox11.Controls.Add(this.formLabel22);
            this.groupBox11.Controls.Add(this.UsSearchAmount);
            this.groupBox11.Controls.Add(this.formLabel26);
            this.groupBox11.Controls.Add(this.UsSearchUnitPrice);
            this.groupBox11.Controls.Add(this.formLabel20);
            this.groupBox11.Controls.Add(this.UsSearchProductName);
            this.groupBox11.Controls.Add(this.formLabel23);
            this.groupBox11.Controls.Add(this.UsSearchBarcode);
            this.groupBox11.Controls.Add(this.formLabel24);
            this.groupBox11.Controls.Add(this.UsSearchProductNumber);
            this.groupBox11.Controls.Add(this.formLabel25);
            this.groupBox11.Controls.Add(this.ribbonMenuButton1);
            this.groupBox11.Controls.Add(this.ribbonMenuButton2);
            this.groupBox11.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox11.Location = new System.Drawing.Point(0, 0);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(876, 167);
            this.groupBox11.TabIndex = 2;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "添加产品";
            this.groupBox11.Visible = false;
            // 
            // ribbonMenuButton2
            // 
            this.ribbonMenuButton2.Arrow = RibbonStyle.RibbonMenuButton.e_arrow.None;
            this.ribbonMenuButton2.BackColor = System.Drawing.Color.Transparent;
            this.ribbonMenuButton2.ColorBase = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(209)))), ((int)(((byte)(240)))));
            this.ribbonMenuButton2.ColorBaseStroke = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(187)))), ((int)(((byte)(213)))));
            this.ribbonMenuButton2.ColorOn = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(78)))));
            this.ribbonMenuButton2.ColorOnStroke = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(177)))), ((int)(((byte)(118)))));
            this.ribbonMenuButton2.ColorPress = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ribbonMenuButton2.ColorPressStroke = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ribbonMenuButton2.FadingSpeed = 20;
            this.ribbonMenuButton2.FlatAppearance.BorderSize = 0;
            this.ribbonMenuButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ribbonMenuButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ribbonMenuButton2.ForeColor = System.Drawing.Color.DarkBlue;
            this.ribbonMenuButton2.GroupPos = RibbonStyle.RibbonMenuButton.e_groupPos.None;
            this.ribbonMenuButton2.Image = global::Winform.Properties.Resources.gtk_remove;
            this.ribbonMenuButton2.ImageLocation = RibbonStyle.RibbonMenuButton.e_imagelocation.Left;
            this.ribbonMenuButton2.ImageOffset = 0;
            this.ribbonMenuButton2.IsPressed = false;
            this.ribbonMenuButton2.KeepPress = false;
            this.ribbonMenuButton2.Location = new System.Drawing.Point(366, 125);
            this.ribbonMenuButton2.MaxImageSize = new System.Drawing.Point(0, 0);
            this.ribbonMenuButton2.MenuPos = new System.Drawing.Point(0, 0);
            this.ribbonMenuButton2.Name = "ribbonMenuButton2";
            this.ribbonMenuButton2.Radius = 10;
            this.ribbonMenuButton2.ShowBase = RibbonStyle.RibbonMenuButton.e_showbase.Yes;
            this.ribbonMenuButton2.Size = new System.Drawing.Size(76, 29);
            this.ribbonMenuButton2.SplitButton = RibbonStyle.RibbonMenuButton.e_splitbutton.No;
            this.ribbonMenuButton2.SplitDistance = 0;
            this.ribbonMenuButton2.TabIndex = 10;
            this.ribbonMenuButton2.Text = "删除";
            this.ribbonMenuButton2.Title = "";
            this.ribbonMenuButton2.UseVisualStyleBackColor = true;
            this.ribbonMenuButton2.Visible = false;
            // 
            // ribbonMenuButton1
            // 
            this.ribbonMenuButton1.Arrow = RibbonStyle.RibbonMenuButton.e_arrow.None;
            this.ribbonMenuButton1.BackColor = System.Drawing.Color.Transparent;
            this.ribbonMenuButton1.ColorBase = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(209)))), ((int)(((byte)(240)))));
            this.ribbonMenuButton1.ColorBaseStroke = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(187)))), ((int)(((byte)(213)))));
            this.ribbonMenuButton1.ColorOn = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(78)))));
            this.ribbonMenuButton1.ColorOnStroke = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(177)))), ((int)(((byte)(118)))));
            this.ribbonMenuButton1.ColorPress = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ribbonMenuButton1.ColorPressStroke = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ribbonMenuButton1.FadingSpeed = 20;
            this.ribbonMenuButton1.FlatAppearance.BorderSize = 0;
            this.ribbonMenuButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ribbonMenuButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ribbonMenuButton1.ForeColor = System.Drawing.Color.DarkBlue;
            this.ribbonMenuButton1.GroupPos = RibbonStyle.RibbonMenuButton.e_groupPos.None;
            this.ribbonMenuButton1.Image = global::Winform.Properties.Resources.add;
            this.ribbonMenuButton1.ImageLocation = RibbonStyle.RibbonMenuButton.e_imagelocation.Left;
            this.ribbonMenuButton1.ImageOffset = 0;
            this.ribbonMenuButton1.IsPressed = false;
            this.ribbonMenuButton1.KeepPress = false;
            this.ribbonMenuButton1.Location = new System.Drawing.Point(271, 125);
            this.ribbonMenuButton1.MaxImageSize = new System.Drawing.Point(0, 0);
            this.ribbonMenuButton1.MenuPos = new System.Drawing.Point(0, 0);
            this.ribbonMenuButton1.Name = "ribbonMenuButton1";
            this.ribbonMenuButton1.Radius = 10;
            this.ribbonMenuButton1.ShowBase = RibbonStyle.RibbonMenuButton.e_showbase.Yes;
            this.ribbonMenuButton1.Size = new System.Drawing.Size(76, 29);
            this.ribbonMenuButton1.SplitButton = RibbonStyle.RibbonMenuButton.e_splitbutton.No;
            this.ribbonMenuButton1.SplitDistance = 0;
            this.ribbonMenuButton1.TabIndex = 9;
            this.ribbonMenuButton1.Text = "添加";
            this.ribbonMenuButton1.Title = "";
            this.ribbonMenuButton1.UseVisualStyleBackColor = true;
            this.ribbonMenuButton1.Visible = false;
            this.ribbonMenuButton1.Click += new System.EventHandler(this.ribbonMenuButton1_Click);
            // 
            // formLabel25
            // 
            this.formLabel25.AutoSize = true;
            this.formLabel25.Location = new System.Drawing.Point(40, 25);
            this.formLabel25.Name = "formLabel25";
            this.formLabel25.Size = new System.Drawing.Size(35, 14);
            this.formLabel25.TabIndex = 11;
            this.formLabel25.Text = "货号";
            // 
            // UsSearchProductNumber
            // 
            this.UsSearchProductNumber.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.UsSearchProductNumber.Location = new System.Drawing.Point(109, 22);
            this.UsSearchProductNumber.Name = "UsSearchProductNumber";
            this.UsSearchProductNumber.ReadOnly = true;
            this.UsSearchProductNumber.Size = new System.Drawing.Size(124, 23);
            this.UsSearchProductNumber.TabIndex = 12;
            this.UsSearchProductNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.UsSearchProductNumber_KeyPress);
            // 
            // formLabel24
            // 
            this.formLabel24.AutoSize = true;
            this.formLabel24.Location = new System.Drawing.Point(267, 25);
            this.formLabel24.Name = "formLabel24";
            this.formLabel24.Size = new System.Drawing.Size(35, 14);
            this.formLabel24.TabIndex = 14;
            this.formLabel24.Text = "条码";
            // 
            // UsSearchBarcode
            // 
            this.UsSearchBarcode.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.UsSearchBarcode.Location = new System.Drawing.Point(330, 22);
            this.UsSearchBarcode.Name = "UsSearchBarcode";
            this.UsSearchBarcode.ReadOnly = true;
            this.UsSearchBarcode.Size = new System.Drawing.Size(124, 23);
            this.UsSearchBarcode.TabIndex = 15;
            this.UsSearchBarcode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.UsSearchBarcode_KeyPress);
            // 
            // formLabel23
            // 
            this.formLabel23.AutoSize = true;
            this.formLabel23.Location = new System.Drawing.Point(43, 58);
            this.formLabel23.Name = "formLabel23";
            this.formLabel23.Size = new System.Drawing.Size(49, 14);
            this.formLabel23.TabIndex = 16;
            this.formLabel23.Text = "产品名";
            // 
            // UsSearchProductName
            // 
            this.UsSearchProductName.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.UsSearchProductName.Location = new System.Drawing.Point(109, 55);
            this.UsSearchProductName.Name = "UsSearchProductName";
            this.UsSearchProductName.ReadOnly = true;
            this.UsSearchProductName.Size = new System.Drawing.Size(124, 23);
            this.UsSearchProductName.TabIndex = 17;
            // 
            // formLabel20
            // 
            this.formLabel20.AutoSize = true;
            this.formLabel20.Location = new System.Drawing.Point(47, 90);
            this.formLabel20.Name = "formLabel20";
            this.formLabel20.Size = new System.Drawing.Size(49, 14);
            this.formLabel20.TabIndex = 24;
            this.formLabel20.Text = "进货价";
            // 
            // UsSearchUnitPrice
            // 
            this.UsSearchUnitPrice.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.UsSearchUnitPrice.Location = new System.Drawing.Point(109, 87);
            this.UsSearchUnitPrice.Name = "UsSearchUnitPrice";
            this.UsSearchUnitPrice.ReadOnly = true;
            this.UsSearchUnitPrice.Size = new System.Drawing.Size(124, 23);
            this.UsSearchUnitPrice.TabIndex = 25;
            // 
            // formLabel26
            // 
            this.formLabel26.AutoSize = true;
            this.formLabel26.Location = new System.Drawing.Point(268, 90);
            this.formLabel26.Name = "formLabel26";
            this.formLabel26.Size = new System.Drawing.Size(35, 14);
            this.formLabel26.TabIndex = 26;
            this.formLabel26.Text = "数量";
            // 
            // UsSearchAmount
            // 
            this.UsSearchAmount.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.UsSearchAmount.Location = new System.Drawing.Point(330, 87);
            this.UsSearchAmount.Name = "UsSearchAmount";
            this.UsSearchAmount.ReadOnly = true;
            this.UsSearchAmount.Size = new System.Drawing.Size(124, 23);
            this.UsSearchAmount.TabIndex = 27;
            // 
            // formLabel22
            // 
            this.formLabel22.AutoSize = true;
            this.formLabel22.Location = new System.Drawing.Point(268, 58);
            this.formLabel22.Name = "formLabel22";
            this.formLabel22.Size = new System.Drawing.Size(35, 14);
            this.formLabel22.TabIndex = 29;
            this.formLabel22.Text = "规格";
            // 
            // formLabel21
            // 
            this.formLabel21.AutoSize = true;
            this.formLabel21.Location = new System.Drawing.Point(487, 58);
            this.formLabel21.Name = "formLabel21";
            this.formLabel21.Size = new System.Drawing.Size(35, 14);
            this.formLabel21.TabIndex = 30;
            this.formLabel21.Text = "单位";
            // 
            // UsSearchUnit
            // 
            this.UsSearchUnit.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.UsSearchUnit.Location = new System.Drawing.Point(546, 52);
            this.UsSearchUnit.Name = "UsSearchUnit";
            this.UsSearchUnit.ReadOnly = true;
            this.UsSearchUnit.Size = new System.Drawing.Size(124, 23);
            this.UsSearchUnit.TabIndex = 31;
            // 
            // UsSearchSpeciText
            // 
            this.UsSearchSpeciText.FormattingEnabled = true;
            this.UsSearchSpeciText.Location = new System.Drawing.Point(330, 52);
            this.UsSearchSpeciText.Name = "UsSearchSpeciText";
            this.UsSearchSpeciText.Size = new System.Drawing.Size(124, 22);
            this.UsSearchSpeciText.TabIndex = 32;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewTextBoxColumn31,
            this.dataGridViewTextBoxColumn32});
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dataGridView2.Location = new System.Drawing.Point(0, 167);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 23;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(876, 132);
            this.dataGridView2.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn32
            // 
            this.dataGridViewTextBoxColumn32.HeaderText = "CreateTime";
            this.dataGridViewTextBoxColumn32.Name = "dataGridViewTextBoxColumn32";
            this.dataGridViewTextBoxColumn32.Visible = false;
            // 
            // dataGridViewTextBoxColumn31
            // 
            this.dataGridViewTextBoxColumn31.HeaderText = "IsDel";
            this.dataGridViewTextBoxColumn31.Name = "dataGridViewTextBoxColumn31";
            this.dataGridViewTextBoxColumn31.Visible = false;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "Unit";
            this.dataGridViewTextBoxColumn17.HeaderText = "计量单位";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "SpecifiText";
            this.dataGridViewTextBoxColumn16.HeaderText = "规格";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "TaxRate";
            this.dataGridViewTextBoxColumn15.HeaderText = "税率";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "Category";
            this.dataGridViewTextBoxColumn14.HeaderText = "类别";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "UnitPrice";
            this.dataGridViewTextBoxColumn13.HeaderText = "进货价(含税)";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Barcode";
            this.dataGridViewTextBoxColumn12.HeaderText = "条码";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "ProductNumber";
            this.dataGridViewTextBoxColumn11.HeaderText = "货号";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Amount";
            this.dataGridViewTextBoxColumn10.HeaderText = "数量";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "ProductName";
            this.dataGridViewTextBoxColumn9.HeaderText = "名称";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "SpecId";
            this.dataGridViewTextBoxColumn8.HeaderText = "SpecId";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Visible = false;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "ProductId";
            this.dataGridViewTextBoxColumn7.HeaderText = "Id";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Visible = false;
            // 
            // inventoryPage
            // 
            this.inventoryPage.Controls.Add(this.inventoryDataGridView);
            this.inventoryPage.Controls.Add(this.groupBox15);
            this.inventoryPage.Location = new System.Drawing.Point(4, 24);
            this.inventoryPage.Name = "inventoryPage";
            this.inventoryPage.Padding = new System.Windows.Forms.Padding(3);
            this.inventoryPage.Size = new System.Drawing.Size(882, 389);
            this.inventoryPage.TabIndex = 7;
            this.inventoryPage.Text = "库存清单  ";
            this.inventoryPage.UseVisualStyleBackColor = true;
            this.inventoryPage.Enter += new System.EventHandler(this.inventoryPage_Enter);
            // 
            // groupBox15
            // 
            this.groupBox15.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox15.Location = new System.Drawing.Point(3, 3);
            this.groupBox15.Name = "groupBox15";
            this.groupBox15.Size = new System.Drawing.Size(876, 100);
            this.groupBox15.TabIndex = 0;
            this.groupBox15.TabStop = false;
            this.groupBox15.Text = "查询";
            // 
            // inventoryDataGridView
            // 
            this.inventoryDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.inventoryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.inventoryDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn22,
            this.dataGridViewTextBoxColumn23,
            this.dataGridViewTextBoxColumn24,
            this.Column5,
            this.dataGridViewTextBoxColumn25,
            this.dataGridViewTextBoxColumn26,
            this.dataGridViewTextBoxColumn30,
            this.Column4,
            this.dataGridViewTextBoxColumn27,
            this.dataGridViewTextBoxColumn28,
            this.dataGridViewTextBoxColumn29});
            this.inventoryDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inventoryDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.inventoryDataGridView.Location = new System.Drawing.Point(3, 103);
            this.inventoryDataGridView.MultiSelect = false;
            this.inventoryDataGridView.Name = "inventoryDataGridView";
            this.inventoryDataGridView.RowTemplate.Height = 23;
            this.inventoryDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.inventoryDataGridView.Size = new System.Drawing.Size(876, 283);
            this.inventoryDataGridView.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn29
            // 
            this.dataGridViewTextBoxColumn29.DataPropertyName = "Unit";
            this.dataGridViewTextBoxColumn29.HeaderText = "计量单位";
            this.dataGridViewTextBoxColumn29.Name = "dataGridViewTextBoxColumn29";
            // 
            // dataGridViewTextBoxColumn28
            // 
            this.dataGridViewTextBoxColumn28.DataPropertyName = "TaxRate";
            this.dataGridViewTextBoxColumn28.HeaderText = "税率(%)";
            this.dataGridViewTextBoxColumn28.Name = "dataGridViewTextBoxColumn28";
            // 
            // dataGridViewTextBoxColumn27
            // 
            this.dataGridViewTextBoxColumn27.DataPropertyName = "Category";
            this.dataGridViewTextBoxColumn27.HeaderText = "类别";
            this.dataGridViewTextBoxColumn27.Name = "dataGridViewTextBoxColumn27";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Barcode";
            this.Column4.HeaderText = "条形码";
            this.Column4.Name = "Column4";
            // 
            // dataGridViewTextBoxColumn30
            // 
            this.dataGridViewTextBoxColumn30.DataPropertyName = "Amount";
            this.dataGridViewTextBoxColumn30.HeaderText = "当前库存";
            this.dataGridViewTextBoxColumn30.Name = "dataGridViewTextBoxColumn30";
            // 
            // dataGridViewTextBoxColumn26
            // 
            this.dataGridViewTextBoxColumn26.DataPropertyName = "UnitPrice";
            this.dataGridViewTextBoxColumn26.HeaderText = "单价";
            this.dataGridViewTextBoxColumn26.Name = "dataGridViewTextBoxColumn26";
            // 
            // dataGridViewTextBoxColumn25
            // 
            this.dataGridViewTextBoxColumn25.DataPropertyName = "ProductNumber";
            this.dataGridViewTextBoxColumn25.HeaderText = "货号";
            this.dataGridViewTextBoxColumn25.Name = "dataGridViewTextBoxColumn25";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "SpecifiText";
            this.Column5.HeaderText = "产品规格";
            this.Column5.Name = "Column5";
            // 
            // dataGridViewTextBoxColumn24
            // 
            this.dataGridViewTextBoxColumn24.DataPropertyName = "ProductName";
            this.dataGridViewTextBoxColumn24.HeaderText = "产品名";
            this.dataGridViewTextBoxColumn24.Name = "dataGridViewTextBoxColumn24";
            // 
            // dataGridViewTextBoxColumn23
            // 
            this.dataGridViewTextBoxColumn23.DataPropertyName = "SpecId";
            this.dataGridViewTextBoxColumn23.HeaderText = "SpecId";
            this.dataGridViewTextBoxColumn23.Name = "dataGridViewTextBoxColumn23";
            this.dataGridViewTextBoxColumn23.Visible = false;
            // 
            // dataGridViewTextBoxColumn22
            // 
            this.dataGridViewTextBoxColumn22.DataPropertyName = "ProductId";
            this.dataGridViewTextBoxColumn22.HeaderText = "Id";
            this.dataGridViewTextBoxColumn22.Name = "dataGridViewTextBoxColumn22";
            this.dataGridViewTextBoxColumn22.Visible = false;
            // 
            // addStorageOutPage
            // 
            this.addStorageOutPage.Controls.Add(this.panel7);
            this.addStorageOutPage.Controls.Add(this.groupBox13);
            this.addStorageOutPage.Location = new System.Drawing.Point(4, 24);
            this.addStorageOutPage.Name = "addStorageOutPage";
            this.addStorageOutPage.Padding = new System.Windows.Forms.Padding(3);
            this.addStorageOutPage.Size = new System.Drawing.Size(882, 389);
            this.addStorageOutPage.TabIndex = 6;
            this.addStorageOutPage.Text = "添加销售出库  ";
            this.addStorageOutPage.UseVisualStyleBackColor = true;
            this.addStorageOutPage.Enter += new System.EventHandler(this.addStorageOutPage_Enter);
            // 
            // groupBox13
            // 
            this.groupBox13.Controls.Add(this.formLabel32);
            this.groupBox13.Controls.Add(this.AsoStorageOutUnitPrice);
            this.groupBox13.Controls.Add(this.AsoStorageOutSpeciText);
            this.groupBox13.Controls.Add(this.AsoSaveStorageOut);
            this.groupBox13.Controls.Add(this.formLabel34);
            this.groupBox13.Controls.Add(this.label15);
            this.groupBox13.Controls.Add(this.AsoStorageOutTime);
            this.groupBox13.Controls.Add(this.AsoStorageOutUnit);
            this.groupBox13.Controls.Add(this.formLabel35);
            this.groupBox13.Controls.Add(this.AsoStorageOutProductName);
            this.groupBox13.Controls.Add(this.formLabel29);
            this.groupBox13.Controls.Add(this.formLabel33);
            this.groupBox13.Controls.Add(this.formLabel37);
            this.groupBox13.Controls.Add(this.AsoStorageOutProductNumber);
            this.groupBox13.Controls.Add(this.formLabel31);
            this.groupBox13.Controls.Add(this.AsoStorageOutAmount);
            this.groupBox13.Controls.Add(this.AsoAddStorageOutItem);
            this.groupBox13.Controls.Add(this.AsoStorageOutNumber);
            this.groupBox13.Controls.Add(this.AsoDeleteStorageOutItem);
            this.groupBox13.Controls.Add(this.formLabel30);
            this.groupBox13.Controls.Add(this.formLabel36);
            this.groupBox13.Controls.Add(this.AsoStorageOutBarcode);
            this.groupBox13.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox13.Location = new System.Drawing.Point(3, 3);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Size = new System.Drawing.Size(876, 116);
            this.groupBox13.TabIndex = 1;
            this.groupBox13.TabStop = false;
            this.groupBox13.Text = "出库单信息";
            // 
            // AsoStorageOutBarcode
            // 
            this.AsoStorageOutBarcode.Location = new System.Drawing.Point(109, 54);
            this.AsoStorageOutBarcode.Name = "AsoStorageOutBarcode";
            this.AsoStorageOutBarcode.Size = new System.Drawing.Size(124, 23);
            this.AsoStorageOutBarcode.TabIndex = 15;
            this.AsoStorageOutBarcode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AsoStorageOutBarcode_KeyPress);
            // 
            // formLabel36
            // 
            this.formLabel36.AutoSize = true;
            this.formLabel36.Location = new System.Drawing.Point(40, 63);
            this.formLabel36.Name = "formLabel36";
            this.formLabel36.Size = new System.Drawing.Size(35, 14);
            this.formLabel36.TabIndex = 14;
            this.formLabel36.Text = "条码";
            // 
            // formLabel30
            // 
            this.formLabel30.AutoSize = true;
            this.formLabel30.Location = new System.Drawing.Point(40, 33);
            this.formLabel30.Name = "formLabel30";
            this.formLabel30.Size = new System.Drawing.Size(63, 14);
            this.formLabel30.TabIndex = 0;
            this.formLabel30.Text = "出库单号";
            // 
            // AsoDeleteStorageOutItem
            // 
            this.AsoDeleteStorageOutItem.Arrow = RibbonStyle.RibbonMenuButton.e_arrow.None;
            this.AsoDeleteStorageOutItem.BackColor = System.Drawing.Color.Transparent;
            this.AsoDeleteStorageOutItem.ColorBase = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(209)))), ((int)(((byte)(240)))));
            this.AsoDeleteStorageOutItem.ColorBaseStroke = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(187)))), ((int)(((byte)(213)))));
            this.AsoDeleteStorageOutItem.ColorOn = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(78)))));
            this.AsoDeleteStorageOutItem.ColorOnStroke = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(177)))), ((int)(((byte)(118)))));
            this.AsoDeleteStorageOutItem.ColorPress = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.AsoDeleteStorageOutItem.ColorPressStroke = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.AsoDeleteStorageOutItem.FadingSpeed = 20;
            this.AsoDeleteStorageOutItem.FlatAppearance.BorderSize = 0;
            this.AsoDeleteStorageOutItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AsoDeleteStorageOutItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AsoDeleteStorageOutItem.ForeColor = System.Drawing.Color.DarkBlue;
            this.AsoDeleteStorageOutItem.GroupPos = RibbonStyle.RibbonMenuButton.e_groupPos.None;
            this.AsoDeleteStorageOutItem.Image = global::Winform.Properties.Resources.gtk_remove;
            this.AsoDeleteStorageOutItem.ImageLocation = RibbonStyle.RibbonMenuButton.e_imagelocation.Left;
            this.AsoDeleteStorageOutItem.ImageOffset = 0;
            this.AsoDeleteStorageOutItem.IsPressed = false;
            this.AsoDeleteStorageOutItem.KeepPress = false;
            this.AsoDeleteStorageOutItem.Location = new System.Drawing.Point(157, 84);
            this.AsoDeleteStorageOutItem.MaxImageSize = new System.Drawing.Point(0, 0);
            this.AsoDeleteStorageOutItem.MenuPos = new System.Drawing.Point(0, 0);
            this.AsoDeleteStorageOutItem.Name = "AsoDeleteStorageOutItem";
            this.AsoDeleteStorageOutItem.Radius = 10;
            this.AsoDeleteStorageOutItem.ShowBase = RibbonStyle.RibbonMenuButton.e_showbase.Yes;
            this.AsoDeleteStorageOutItem.Size = new System.Drawing.Size(76, 29);
            this.AsoDeleteStorageOutItem.SplitButton = RibbonStyle.RibbonMenuButton.e_splitbutton.No;
            this.AsoDeleteStorageOutItem.SplitDistance = 0;
            this.AsoDeleteStorageOutItem.TabIndex = 10;
            this.AsoDeleteStorageOutItem.Text = "删除";
            this.AsoDeleteStorageOutItem.Title = "";
            this.AsoDeleteStorageOutItem.UseVisualStyleBackColor = true;
            this.AsoDeleteStorageOutItem.Click += new System.EventHandler(this.AsoDeleteStorageOutItem_Click);
            // 
            // AsoStorageOutNumber
            // 
            this.AsoStorageOutNumber.Enabled = false;
            this.AsoStorageOutNumber.Location = new System.Drawing.Point(109, 30);
            this.AsoStorageOutNumber.Name = "AsoStorageOutNumber";
            this.AsoStorageOutNumber.Size = new System.Drawing.Size(124, 23);
            this.AsoStorageOutNumber.TabIndex = 1;
            // 
            // AsoAddStorageOutItem
            // 
            this.AsoAddStorageOutItem.Arrow = RibbonStyle.RibbonMenuButton.e_arrow.None;
            this.AsoAddStorageOutItem.BackColor = System.Drawing.Color.Transparent;
            this.AsoAddStorageOutItem.ColorBase = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(209)))), ((int)(((byte)(240)))));
            this.AsoAddStorageOutItem.ColorBaseStroke = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(187)))), ((int)(((byte)(213)))));
            this.AsoAddStorageOutItem.ColorOn = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(78)))));
            this.AsoAddStorageOutItem.ColorOnStroke = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(177)))), ((int)(((byte)(118)))));
            this.AsoAddStorageOutItem.ColorPress = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.AsoAddStorageOutItem.ColorPressStroke = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.AsoAddStorageOutItem.FadingSpeed = 20;
            this.AsoAddStorageOutItem.FlatAppearance.BorderSize = 0;
            this.AsoAddStorageOutItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AsoAddStorageOutItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AsoAddStorageOutItem.ForeColor = System.Drawing.Color.DarkBlue;
            this.AsoAddStorageOutItem.GroupPos = RibbonStyle.RibbonMenuButton.e_groupPos.None;
            this.AsoAddStorageOutItem.Image = global::Winform.Properties.Resources.add;
            this.AsoAddStorageOutItem.ImageLocation = RibbonStyle.RibbonMenuButton.e_imagelocation.Left;
            this.AsoAddStorageOutItem.ImageOffset = 0;
            this.AsoAddStorageOutItem.IsPressed = false;
            this.AsoAddStorageOutItem.KeepPress = false;
            this.AsoAddStorageOutItem.Location = new System.Drawing.Point(570, 57);
            this.AsoAddStorageOutItem.MaxImageSize = new System.Drawing.Point(0, 0);
            this.AsoAddStorageOutItem.MenuPos = new System.Drawing.Point(0, 0);
            this.AsoAddStorageOutItem.Name = "AsoAddStorageOutItem";
            this.AsoAddStorageOutItem.Radius = 10;
            this.AsoAddStorageOutItem.ShowBase = RibbonStyle.RibbonMenuButton.e_showbase.Yes;
            this.AsoAddStorageOutItem.Size = new System.Drawing.Size(76, 29);
            this.AsoAddStorageOutItem.SplitButton = RibbonStyle.RibbonMenuButton.e_splitbutton.No;
            this.AsoAddStorageOutItem.SplitDistance = 0;
            this.AsoAddStorageOutItem.TabIndex = 9;
            this.AsoAddStorageOutItem.Text = "添加";
            this.AsoAddStorageOutItem.Title = "";
            this.AsoAddStorageOutItem.UseVisualStyleBackColor = true;
            this.AsoAddStorageOutItem.Visible = false;
            this.AsoAddStorageOutItem.Click += new System.EventHandler(this.btnAddStorageOutItem_Click);
            // 
            // AsoStorageOutAmount
            // 
            this.AsoStorageOutAmount.Location = new System.Drawing.Point(422, 54);
            this.AsoStorageOutAmount.Name = "AsoStorageOutAmount";
            this.AsoStorageOutAmount.Size = new System.Drawing.Size(124, 23);
            this.AsoStorageOutAmount.TabIndex = 27;
            // 
            // formLabel31
            // 
            this.formLabel31.AutoSize = true;
            this.formLabel31.Location = new System.Drawing.Point(327, 57);
            this.formLabel31.Name = "formLabel31";
            this.formLabel31.Size = new System.Drawing.Size(35, 14);
            this.formLabel31.TabIndex = 26;
            this.formLabel31.Text = "数量";
            // 
            // AsoStorageOutProductNumber
            // 
            this.AsoStorageOutProductNumber.Location = new System.Drawing.Point(704, 54);
            this.AsoStorageOutProductNumber.Name = "AsoStorageOutProductNumber";
            this.AsoStorageOutProductNumber.Size = new System.Drawing.Size(124, 23);
            this.AsoStorageOutProductNumber.TabIndex = 12;
            this.AsoStorageOutProductNumber.Visible = false;
            this.AsoStorageOutProductNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AsoStorageOutProductNumber_KeyPress);
            // 
            // formLabel37
            // 
            this.formLabel37.AutoSize = true;
            this.formLabel37.Location = new System.Drawing.Point(663, 57);
            this.formLabel37.Name = "formLabel37";
            this.formLabel37.Size = new System.Drawing.Size(35, 14);
            this.formLabel37.TabIndex = 11;
            this.formLabel37.Text = "货号";
            this.formLabel37.Visible = false;
            // 
            // formLabel33
            // 
            this.formLabel33.AutoSize = true;
            this.formLabel33.Location = new System.Drawing.Point(663, 32);
            this.formLabel33.Name = "formLabel33";
            this.formLabel33.Size = new System.Drawing.Size(35, 14);
            this.formLabel33.TabIndex = 20;
            this.formLabel33.Text = "单位";
            this.formLabel33.Visible = false;
            // 
            // formLabel29
            // 
            this.formLabel29.AutoSize = true;
            this.formLabel29.Location = new System.Drawing.Point(327, 32);
            this.formLabel29.Name = "formLabel29";
            this.formLabel29.Size = new System.Drawing.Size(63, 14);
            this.formLabel29.TabIndex = 2;
            this.formLabel29.Text = "出库日期";
            // 
            // AsoStorageOutProductName
            // 
            this.AsoStorageOutProductName.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AsoStorageOutProductName.Location = new System.Drawing.Point(491, 90);
            this.AsoStorageOutProductName.Name = "AsoStorageOutProductName";
            this.AsoStorageOutProductName.ReadOnly = true;
            this.AsoStorageOutProductName.Size = new System.Drawing.Size(124, 23);
            this.AsoStorageOutProductName.TabIndex = 17;
            this.AsoStorageOutProductName.Visible = false;
            // 
            // formLabel35
            // 
            this.formLabel35.AutoSize = true;
            this.formLabel35.Location = new System.Drawing.Point(419, 92);
            this.formLabel35.Name = "formLabel35";
            this.formLabel35.Size = new System.Drawing.Size(49, 14);
            this.formLabel35.TabIndex = 16;
            this.formLabel35.Text = "产品名";
            this.formLabel35.Visible = false;
            // 
            // AsoStorageOutUnit
            // 
            this.AsoStorageOutUnit.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AsoStorageOutUnit.Location = new System.Drawing.Point(704, 27);
            this.AsoStorageOutUnit.Name = "AsoStorageOutUnit";
            this.AsoStorageOutUnit.ReadOnly = true;
            this.AsoStorageOutUnit.Size = new System.Drawing.Size(124, 23);
            this.AsoStorageOutUnit.TabIndex = 27;
            this.AsoStorageOutUnit.Visible = false;
            // 
            // AsoStorageOutTime
            // 
            this.AsoStorageOutTime.Location = new System.Drawing.Point(422, 27);
            this.AsoStorageOutTime.Name = "AsoStorageOutTime";
            this.AsoStorageOutTime.Size = new System.Drawing.Size(234, 23);
            this.AsoStorageOutTime.TabIndex = 3;
            this.AsoStorageOutTime.Value = new System.DateTime(2012, 8, 24, 0, 0, 0, 0);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label15.ForeColor = System.Drawing.Color.DarkRed;
            this.label15.Location = new System.Drawing.Point(249, 38);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(11, 12);
            this.label15.TabIndex = 11;
            this.label15.Text = "*";
            // 
            // formLabel34
            // 
            this.formLabel34.AutoSize = true;
            this.formLabel34.Location = new System.Drawing.Point(652, 92);
            this.formLabel34.Name = "formLabel34";
            this.formLabel34.Size = new System.Drawing.Size(35, 14);
            this.formLabel34.TabIndex = 18;
            this.formLabel34.Text = "规格";
            this.formLabel34.Visible = false;
            // 
            // AsoSaveStorageOut
            // 
            this.AsoSaveStorageOut.Arrow = RibbonStyle.RibbonMenuButton.e_arrow.None;
            this.AsoSaveStorageOut.BackColor = System.Drawing.Color.Transparent;
            this.AsoSaveStorageOut.ColorBase = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(209)))), ((int)(((byte)(240)))));
            this.AsoSaveStorageOut.ColorBaseStroke = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(187)))), ((int)(((byte)(213)))));
            this.AsoSaveStorageOut.ColorOn = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(78)))));
            this.AsoSaveStorageOut.ColorOnStroke = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(177)))), ((int)(((byte)(118)))));
            this.AsoSaveStorageOut.ColorPress = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.AsoSaveStorageOut.ColorPressStroke = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.AsoSaveStorageOut.FadingSpeed = 20;
            this.AsoSaveStorageOut.FlatAppearance.BorderSize = 0;
            this.AsoSaveStorageOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AsoSaveStorageOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AsoSaveStorageOut.ForeColor = System.Drawing.Color.DarkBlue;
            this.AsoSaveStorageOut.GroupPos = RibbonStyle.RibbonMenuButton.e_groupPos.None;
            this.AsoSaveStorageOut.Image = global::Winform.Properties.Resources.document_open;
            this.AsoSaveStorageOut.ImageLocation = RibbonStyle.RibbonMenuButton.e_imagelocation.Left;
            this.AsoSaveStorageOut.ImageOffset = 0;
            this.AsoSaveStorageOut.IsPressed = false;
            this.AsoSaveStorageOut.KeepPress = false;
            this.AsoSaveStorageOut.Location = new System.Drawing.Point(43, 84);
            this.AsoSaveStorageOut.MaxImageSize = new System.Drawing.Point(0, 0);
            this.AsoSaveStorageOut.MenuPos = new System.Drawing.Point(0, 0);
            this.AsoSaveStorageOut.Name = "AsoSaveStorageOut";
            this.AsoSaveStorageOut.Radius = 10;
            this.AsoSaveStorageOut.ShowBase = RibbonStyle.RibbonMenuButton.e_showbase.Yes;
            this.AsoSaveStorageOut.Size = new System.Drawing.Size(88, 29);
            this.AsoSaveStorageOut.SplitButton = RibbonStyle.RibbonMenuButton.e_splitbutton.No;
            this.AsoSaveStorageOut.SplitDistance = 0;
            this.AsoSaveStorageOut.TabIndex = 29;
            this.AsoSaveStorageOut.Text = "  保存";
            this.AsoSaveStorageOut.Title = "";
            this.AsoSaveStorageOut.UseVisualStyleBackColor = true;
            this.AsoSaveStorageOut.Click += new System.EventHandler(this.AsoSaveStorageOut_Click);
            // 
            // AsoStorageOutSpeciText
            // 
            this.AsoStorageOutSpeciText.Enabled = false;
            this.AsoStorageOutSpeciText.FormattingEnabled = true;
            this.AsoStorageOutSpeciText.Location = new System.Drawing.Point(704, 90);
            this.AsoStorageOutSpeciText.Name = "AsoStorageOutSpeciText";
            this.AsoStorageOutSpeciText.Size = new System.Drawing.Size(124, 22);
            this.AsoStorageOutSpeciText.TabIndex = 28;
            this.AsoStorageOutSpeciText.Visible = false;
            // 
            // AsoStorageOutUnitPrice
            // 
            this.AsoStorageOutUnitPrice.Location = new System.Drawing.Point(693, 73);
            this.AsoStorageOutUnitPrice.Name = "AsoStorageOutUnitPrice";
            this.AsoStorageOutUnitPrice.Size = new System.Drawing.Size(124, 23);
            this.AsoStorageOutUnitPrice.TabIndex = 25;
            this.AsoStorageOutUnitPrice.Visible = false;
            // 
            // formLabel32
            // 
            this.formLabel32.AutoSize = true;
            this.formLabel32.Location = new System.Drawing.Point(649, 73);
            this.formLabel32.Name = "formLabel32";
            this.formLabel32.Size = new System.Drawing.Size(49, 14);
            this.formLabel32.TabIndex = 24;
            this.formLabel32.Text = "销售价";
            this.formLabel32.Visible = false;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.AsoStorageOutItemDataGridView);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(3, 119);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(876, 267);
            this.panel7.TabIndex = 2;
            // 
            // AsoStorageOutItemDataGridView
            // 
            this.AsoStorageOutItemDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AsoStorageOutItemDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AsoProductListId,
            this.AsoProductListSpecId,
            this.AsoProductListProductName,
            this.AsoProductListAmount,
            this.AsoProductListProductNumber,
            this.AsoProductListBarcode,
            this.AsoProductListUnitPrice,
            this.AsoProductListCategory,
            this.AsoProductListTaxRate,
            this.AsoProductListSpecifiText,
            this.AsoProductListUnit,
            this.AsoProductListIsDel,
            this.AsoProductListCreateTime});
            this.AsoStorageOutItemDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AsoStorageOutItemDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.AsoStorageOutItemDataGridView.Location = new System.Drawing.Point(0, 0);
            this.AsoStorageOutItemDataGridView.Name = "AsoStorageOutItemDataGridView";
            this.AsoStorageOutItemDataGridView.RowTemplate.Height = 23;
            this.AsoStorageOutItemDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AsoStorageOutItemDataGridView.Size = new System.Drawing.Size(876, 267);
            this.AsoStorageOutItemDataGridView.TabIndex = 4;
            // 
            // AsoProductListCreateTime
            // 
            this.AsoProductListCreateTime.HeaderText = "CreateTime";
            this.AsoProductListCreateTime.Name = "AsoProductListCreateTime";
            this.AsoProductListCreateTime.Visible = false;
            // 
            // AsoProductListIsDel
            // 
            this.AsoProductListIsDel.HeaderText = "IsDel";
            this.AsoProductListIsDel.Name = "AsoProductListIsDel";
            this.AsoProductListIsDel.Visible = false;
            // 
            // AsoProductListUnit
            // 
            this.AsoProductListUnit.DataPropertyName = "Unit";
            this.AsoProductListUnit.HeaderText = "计量单位";
            this.AsoProductListUnit.Name = "AsoProductListUnit";
            // 
            // AsoProductListSpecifiText
            // 
            this.AsoProductListSpecifiText.DataPropertyName = "SpecifiText";
            this.AsoProductListSpecifiText.HeaderText = "规格";
            this.AsoProductListSpecifiText.Name = "AsoProductListSpecifiText";
            // 
            // AsoProductListTaxRate
            // 
            this.AsoProductListTaxRate.DataPropertyName = "TaxRate";
            this.AsoProductListTaxRate.HeaderText = "税率(%)";
            this.AsoProductListTaxRate.Name = "AsoProductListTaxRate";
            // 
            // AsoProductListCategory
            // 
            this.AsoProductListCategory.DataPropertyName = "Category";
            this.AsoProductListCategory.HeaderText = "类别";
            this.AsoProductListCategory.Name = "AsoProductListCategory";
            // 
            // AsoProductListUnitPrice
            // 
            this.AsoProductListUnitPrice.DataPropertyName = "UnitPrice";
            this.AsoProductListUnitPrice.HeaderText = "进货价(含税)";
            this.AsoProductListUnitPrice.Name = "AsoProductListUnitPrice";
            // 
            // AsoProductListBarcode
            // 
            this.AsoProductListBarcode.DataPropertyName = "Barcode";
            this.AsoProductListBarcode.HeaderText = "条码";
            this.AsoProductListBarcode.Name = "AsoProductListBarcode";
            // 
            // AsoProductListProductNumber
            // 
            this.AsoProductListProductNumber.DataPropertyName = "ProductNumber";
            this.AsoProductListProductNumber.HeaderText = "货号";
            this.AsoProductListProductNumber.Name = "AsoProductListProductNumber";
            // 
            // AsoProductListAmount
            // 
            this.AsoProductListAmount.DataPropertyName = "Amount";
            this.AsoProductListAmount.HeaderText = "数量";
            this.AsoProductListAmount.Name = "AsoProductListAmount";
            // 
            // AsoProductListProductName
            // 
            this.AsoProductListProductName.DataPropertyName = "ProductName";
            this.AsoProductListProductName.HeaderText = "名称";
            this.AsoProductListProductName.Name = "AsoProductListProductName";
            // 
            // AsoProductListSpecId
            // 
            this.AsoProductListSpecId.DataPropertyName = "SpecId";
            this.AsoProductListSpecId.HeaderText = "SpecId";
            this.AsoProductListSpecId.Name = "AsoProductListSpecId";
            this.AsoProductListSpecId.Visible = false;
            // 
            // AsoProductListId
            // 
            this.AsoProductListId.DataPropertyName = "ProductId";
            this.AsoProductListId.HeaderText = "Id";
            this.AsoProductListId.Name = "AsoProductListId";
            this.AsoProductListId.Visible = false;
            // 
            // listStorageOutPage
            // 
            this.listStorageOutPage.Controls.Add(this.StorageOutList);
            this.listStorageOutPage.Controls.Add(this.groupBox12);
            this.listStorageOutPage.Location = new System.Drawing.Point(4, 24);
            this.listStorageOutPage.Name = "listStorageOutPage";
            this.listStorageOutPage.Padding = new System.Windows.Forms.Padding(3);
            this.listStorageOutPage.Size = new System.Drawing.Size(882, 389);
            this.listStorageOutPage.TabIndex = 5;
            this.listStorageOutPage.Text = "销售出库单  ";
            this.listStorageOutPage.UseVisualStyleBackColor = true;
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.ribbonMenuButton5);
            this.groupBox12.Controls.Add(this.SolSearchEndTime);
            this.groupBox12.Controls.Add(this.label14);
            this.groupBox12.Controls.Add(this.SolSearchStartTime);
            this.groupBox12.Controls.Add(this.formLabel28);
            this.groupBox12.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox12.Location = new System.Drawing.Point(3, 3);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(876, 78);
            this.groupBox12.TabIndex = 1;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "查询";
            this.groupBox12.Visible = false;
            // 
            // formLabel28
            // 
            this.formLabel28.AutoSize = true;
            this.formLabel28.Location = new System.Drawing.Point(31, 37);
            this.formLabel28.Name = "formLabel28";
            this.formLabel28.Size = new System.Drawing.Size(77, 14);
            this.formLabel28.TabIndex = 0;
            this.formLabel28.Text = "出库时间段";
            // 
            // SolSearchStartTime
            // 
            this.SolSearchStartTime.Location = new System.Drawing.Point(123, 31);
            this.SolSearchStartTime.Name = "SolSearchStartTime";
            this.SolSearchStartTime.Size = new System.Drawing.Size(132, 23);
            this.SolSearchStartTime.TabIndex = 1;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(261, 37);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(21, 14);
            this.label14.TabIndex = 2;
            this.label14.Text = "至";
            // 
            // SolSearchEndTime
            // 
            this.SolSearchEndTime.Location = new System.Drawing.Point(288, 31);
            this.SolSearchEndTime.Name = "SolSearchEndTime";
            this.SolSearchEndTime.Size = new System.Drawing.Size(132, 23);
            this.SolSearchEndTime.TabIndex = 3;
            // 
            // ribbonMenuButton5
            // 
            this.ribbonMenuButton5.Arrow = RibbonStyle.RibbonMenuButton.e_arrow.None;
            this.ribbonMenuButton5.BackColor = System.Drawing.Color.Transparent;
            this.ribbonMenuButton5.ColorBase = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(209)))), ((int)(((byte)(240)))));
            this.ribbonMenuButton5.ColorBaseStroke = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(187)))), ((int)(((byte)(213)))));
            this.ribbonMenuButton5.ColorOn = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(78)))));
            this.ribbonMenuButton5.ColorOnStroke = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(177)))), ((int)(((byte)(118)))));
            this.ribbonMenuButton5.ColorPress = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ribbonMenuButton5.ColorPressStroke = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ribbonMenuButton5.FadingSpeed = 20;
            this.ribbonMenuButton5.FlatAppearance.BorderSize = 0;
            this.ribbonMenuButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ribbonMenuButton5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ribbonMenuButton5.ForeColor = System.Drawing.Color.DarkBlue;
            this.ribbonMenuButton5.GroupPos = RibbonStyle.RibbonMenuButton.e_groupPos.None;
            this.ribbonMenuButton5.Image = global::Winform.Properties.Resources.add;
            this.ribbonMenuButton5.ImageLocation = RibbonStyle.RibbonMenuButton.e_imagelocation.Left;
            this.ribbonMenuButton5.ImageOffset = 0;
            this.ribbonMenuButton5.IsPressed = false;
            this.ribbonMenuButton5.KeepPress = false;
            this.ribbonMenuButton5.Location = new System.Drawing.Point(598, 29);
            this.ribbonMenuButton5.MaxImageSize = new System.Drawing.Point(0, 0);
            this.ribbonMenuButton5.MenuPos = new System.Drawing.Point(0, 0);
            this.ribbonMenuButton5.Name = "ribbonMenuButton5";
            this.ribbonMenuButton5.Radius = 10;
            this.ribbonMenuButton5.ShowBase = RibbonStyle.RibbonMenuButton.e_showbase.Yes;
            this.ribbonMenuButton5.Size = new System.Drawing.Size(76, 29);
            this.ribbonMenuButton5.SplitButton = RibbonStyle.RibbonMenuButton.e_splitbutton.No;
            this.ribbonMenuButton5.SplitDistance = 0;
            this.ribbonMenuButton5.TabIndex = 5;
            this.ribbonMenuButton5.Text = "查询";
            this.ribbonMenuButton5.Title = "";
            this.ribbonMenuButton5.UseVisualStyleBackColor = true;
            this.ribbonMenuButton5.Click += new System.EventHandler(this.ribbonMenuButton5_Click);
            // 
            // StorageOutList
            // 
            this.StorageOutList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StorageOutList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn18,
            this.dataGridViewTextBoxColumn19,
            this.dataGridViewTextBoxColumn20,
            this.dataGridViewTextBoxColumn21,
            this.Column1,
            this.IsDel,
            this.CreateTime});
            this.StorageOutList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StorageOutList.Location = new System.Drawing.Point(3, 81);
            this.StorageOutList.Name = "StorageOutList";
            this.StorageOutList.RowTemplate.Height = 23;
            this.StorageOutList.Size = new System.Drawing.Size(876, 305);
            this.StorageOutList.TabIndex = 2;
            // 
            // CreateTime
            // 
            this.CreateTime.DataPropertyName = "CreateTime";
            this.CreateTime.HeaderText = "CreateTime";
            this.CreateTime.Name = "CreateTime";
            this.CreateTime.Visible = false;
            // 
            // IsDel
            // 
            this.IsDel.DataPropertyName = "IsDel";
            this.IsDel.HeaderText = "IsDel";
            this.IsDel.Name = "IsDel";
            this.IsDel.Visible = false;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "TotalAmount";
            this.Column1.HeaderText = "总数量";
            this.Column1.Name = "Column1";
            // 
            // dataGridViewTextBoxColumn21
            // 
            this.dataGridViewTextBoxColumn21.DataPropertyName = "TotalPrice";
            this.dataGridViewTextBoxColumn21.HeaderText = "总金额";
            this.dataGridViewTextBoxColumn21.Name = "dataGridViewTextBoxColumn21";
            // 
            // dataGridViewTextBoxColumn20
            // 
            this.dataGridViewTextBoxColumn20.DataPropertyName = "StorageInTime";
            this.dataGridViewTextBoxColumn20.HeaderText = "出库时间";
            this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.DataPropertyName = "ListNumber";
            this.dataGridViewTextBoxColumn19.HeaderText = "销售出库单号";
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn18.HeaderText = "Id";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            this.dataGridViewTextBoxColumn18.Visible = false;
            // 
            // addStorageInPage
            // 
            this.addStorageInPage.Controls.Add(this.panel5);
            this.addStorageInPage.Controls.Add(this.groupBox8);
            this.addStorageInPage.Location = new System.Drawing.Point(4, 24);
            this.addStorageInPage.Name = "addStorageInPage";
            this.addStorageInPage.Padding = new System.Windows.Forms.Padding(3);
            this.addStorageInPage.Size = new System.Drawing.Size(882, 389);
            this.addStorageInPage.TabIndex = 1;
            this.addStorageInPage.Text = "添加采购入库  ";
            this.addStorageInPage.UseVisualStyleBackColor = true;
            this.addStorageInPage.Enter += new System.EventHandler(this.addStorageInPage_Enter);
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.formLabel15);
            this.groupBox8.Controls.Add(this.AsProductUnitPrice);
            this.groupBox8.Controls.Add(this.AsProductUnit);
            this.groupBox8.Controls.Add(this.AsProductSpeciText);
            this.groupBox8.Controls.Add(this.formLabel18);
            this.groupBox8.Controls.Add(this.AsProductName);
            this.groupBox8.Controls.Add(this.formLabel16);
            this.groupBox8.Controls.Add(this.btnSaveStorageIn);
            this.groupBox8.Controls.Add(this.label12);
            this.groupBox8.Controls.Add(this.AsStorageInTime);
            this.groupBox8.Controls.Add(this.formLabel17);
            this.groupBox8.Controls.Add(this.formLabel11);
            this.groupBox8.Controls.Add(this.AsProductAmount);
            this.groupBox8.Controls.Add(this.AsNumber);
            this.groupBox8.Controls.Add(this.formLabel14);
            this.groupBox8.Controls.Add(this.formLabel10);
            this.groupBox8.Controls.Add(this.formLabel27);
            this.groupBox8.Controls.Add(this.AsProductNumber);
            this.groupBox8.Controls.Add(this.AsProductBarcode);
            this.groupBox8.Controls.Add(this.formLabel19);
            this.groupBox8.Controls.Add(this.btnDeleteStorageInItem);
            this.groupBox8.Controls.Add(this.btnAddStorageInItem);
            this.groupBox8.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox8.Location = new System.Drawing.Point(3, 3);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(876, 122);
            this.groupBox8.TabIndex = 0;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "入库单信息";
            // 
            // btnAddStorageInItem
            // 
            this.btnAddStorageInItem.Arrow = RibbonStyle.RibbonMenuButton.e_arrow.None;
            this.btnAddStorageInItem.BackColor = System.Drawing.Color.Transparent;
            this.btnAddStorageInItem.ColorBase = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(209)))), ((int)(((byte)(240)))));
            this.btnAddStorageInItem.ColorBaseStroke = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(187)))), ((int)(((byte)(213)))));
            this.btnAddStorageInItem.ColorOn = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(78)))));
            this.btnAddStorageInItem.ColorOnStroke = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(177)))), ((int)(((byte)(118)))));
            this.btnAddStorageInItem.ColorPress = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnAddStorageInItem.ColorPressStroke = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnAddStorageInItem.FadingSpeed = 20;
            this.btnAddStorageInItem.FlatAppearance.BorderSize = 0;
            this.btnAddStorageInItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddStorageInItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddStorageInItem.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnAddStorageInItem.GroupPos = RibbonStyle.RibbonMenuButton.e_groupPos.None;
            this.btnAddStorageInItem.Image = global::Winform.Properties.Resources.add;
            this.btnAddStorageInItem.ImageLocation = RibbonStyle.RibbonMenuButton.e_imagelocation.Left;
            this.btnAddStorageInItem.ImageOffset = 0;
            this.btnAddStorageInItem.IsPressed = false;
            this.btnAddStorageInItem.KeepPress = false;
            this.btnAddStorageInItem.Location = new System.Drawing.Point(460, 57);
            this.btnAddStorageInItem.MaxImageSize = new System.Drawing.Point(0, 0);
            this.btnAddStorageInItem.MenuPos = new System.Drawing.Point(0, 0);
            this.btnAddStorageInItem.Name = "btnAddStorageInItem";
            this.btnAddStorageInItem.Radius = 10;
            this.btnAddStorageInItem.ShowBase = RibbonStyle.RibbonMenuButton.e_showbase.Yes;
            this.btnAddStorageInItem.Size = new System.Drawing.Size(110, 24);
            this.btnAddStorageInItem.SplitButton = RibbonStyle.RibbonMenuButton.e_splitbutton.No;
            this.btnAddStorageInItem.SplitDistance = 0;
            this.btnAddStorageInItem.TabIndex = 9;
            this.btnAddStorageInItem.Text = "添加产品";
            this.btnAddStorageInItem.Title = "";
            this.btnAddStorageInItem.UseVisualStyleBackColor = true;
            this.btnAddStorageInItem.Click += new System.EventHandler(this.btnAddStorageInItem_Click);
            // 
            // btnDeleteStorageInItem
            // 
            this.btnDeleteStorageInItem.Arrow = RibbonStyle.RibbonMenuButton.e_arrow.None;
            this.btnDeleteStorageInItem.BackColor = System.Drawing.Color.Transparent;
            this.btnDeleteStorageInItem.ColorBase = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(209)))), ((int)(((byte)(240)))));
            this.btnDeleteStorageInItem.ColorBaseStroke = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(187)))), ((int)(((byte)(213)))));
            this.btnDeleteStorageInItem.ColorOn = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(78)))));
            this.btnDeleteStorageInItem.ColorOnStroke = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(177)))), ((int)(((byte)(118)))));
            this.btnDeleteStorageInItem.ColorPress = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnDeleteStorageInItem.ColorPressStroke = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnDeleteStorageInItem.FadingSpeed = 20;
            this.btnDeleteStorageInItem.FlatAppearance.BorderSize = 0;
            this.btnDeleteStorageInItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteStorageInItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteStorageInItem.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnDeleteStorageInItem.GroupPos = RibbonStyle.RibbonMenuButton.e_groupPos.None;
            this.btnDeleteStorageInItem.Image = global::Winform.Properties.Resources.gtk_remove;
            this.btnDeleteStorageInItem.ImageLocation = RibbonStyle.RibbonMenuButton.e_imagelocation.Left;
            this.btnDeleteStorageInItem.ImageOffset = 0;
            this.btnDeleteStorageInItem.IsPressed = false;
            this.btnDeleteStorageInItem.KeepPress = false;
            this.btnDeleteStorageInItem.Location = new System.Drawing.Point(141, 87);
            this.btnDeleteStorageInItem.MaxImageSize = new System.Drawing.Point(0, 0);
            this.btnDeleteStorageInItem.MenuPos = new System.Drawing.Point(0, 0);
            this.btnDeleteStorageInItem.Name = "btnDeleteStorageInItem";
            this.btnDeleteStorageInItem.Radius = 10;
            this.btnDeleteStorageInItem.ShowBase = RibbonStyle.RibbonMenuButton.e_showbase.Yes;
            this.btnDeleteStorageInItem.Size = new System.Drawing.Size(76, 29);
            this.btnDeleteStorageInItem.SplitButton = RibbonStyle.RibbonMenuButton.e_splitbutton.No;
            this.btnDeleteStorageInItem.SplitDistance = 0;
            this.btnDeleteStorageInItem.TabIndex = 10;
            this.btnDeleteStorageInItem.Text = "删除";
            this.btnDeleteStorageInItem.Title = "";
            this.btnDeleteStorageInItem.UseVisualStyleBackColor = true;
            this.btnDeleteStorageInItem.Click += new System.EventHandler(this.btnDeleteStorageInItem_Click);
            // 
            // formLabel19
            // 
            this.formLabel19.AutoSize = true;
            this.formLabel19.Location = new System.Drawing.Point(40, 68);
            this.formLabel19.Name = "formLabel19";
            this.formLabel19.Size = new System.Drawing.Size(35, 14);
            this.formLabel19.TabIndex = 14;
            this.formLabel19.Text = "条码";
            // 
            // AsProductBarcode
            // 
            this.AsProductBarcode.Location = new System.Drawing.Point(109, 60);
            this.AsProductBarcode.Name = "AsProductBarcode";
            this.AsProductBarcode.Size = new System.Drawing.Size(124, 23);
            this.AsProductBarcode.TabIndex = 15;
            this.AsProductBarcode.TextChanged += new System.EventHandler(this.AsProductBarcode_TextChanged);
            this.AsProductBarcode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AsProductBarcode_KeyPress);
            // 
            // AsProductNumber
            // 
            this.AsProductNumber.Location = new System.Drawing.Point(663, 28);
            this.AsProductNumber.Name = "AsProductNumber";
            this.AsProductNumber.Size = new System.Drawing.Size(124, 23);
            this.AsProductNumber.TabIndex = 12;
            this.AsProductNumber.Visible = false;
            this.AsProductNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AsProductNumber_KeyPress);
            // 
            // formLabel27
            // 
            this.formLabel27.AutoSize = true;
            this.formLabel27.Location = new System.Drawing.Point(622, 30);
            this.formLabel27.Name = "formLabel27";
            this.formLabel27.Size = new System.Drawing.Size(35, 14);
            this.formLabel27.TabIndex = 11;
            this.formLabel27.Text = "货号";
            this.formLabel27.Visible = false;
            // 
            // formLabel10
            // 
            this.formLabel10.AutoSize = true;
            this.formLabel10.Location = new System.Drawing.Point(40, 33);
            this.formLabel10.Name = "formLabel10";
            this.formLabel10.Size = new System.Drawing.Size(63, 14);
            this.formLabel10.TabIndex = 0;
            this.formLabel10.Text = "入库单号";
            // 
            // formLabel14
            // 
            this.formLabel14.AutoSize = true;
            this.formLabel14.Location = new System.Drawing.Point(268, 63);
            this.formLabel14.Name = "formLabel14";
            this.formLabel14.Size = new System.Drawing.Size(35, 14);
            this.formLabel14.TabIndex = 26;
            this.formLabel14.Text = "数量";
            // 
            // AsNumber
            // 
            this.AsNumber.Enabled = false;
            this.AsNumber.Location = new System.Drawing.Point(109, 30);
            this.AsNumber.Name = "AsNumber";
            this.AsNumber.Size = new System.Drawing.Size(124, 23);
            this.AsNumber.TabIndex = 1;
            this.AsNumber.TextChanged += new System.EventHandler(this.AsNumber_TextChanged);
            // 
            // AsProductAmount
            // 
            this.AsProductAmount.Location = new System.Drawing.Point(330, 60);
            this.AsProductAmount.Name = "AsProductAmount";
            this.AsProductAmount.Size = new System.Drawing.Size(124, 23);
            this.AsProductAmount.TabIndex = 27;
            // 
            // formLabel11
            // 
            this.formLabel11.AutoSize = true;
            this.formLabel11.Location = new System.Drawing.Point(268, 35);
            this.formLabel11.Name = "formLabel11";
            this.formLabel11.Size = new System.Drawing.Size(63, 14);
            this.formLabel11.TabIndex = 2;
            this.formLabel11.Text = "入库日期";
            // 
            // formLabel17
            // 
            this.formLabel17.AutoSize = true;
            this.formLabel17.Location = new System.Drawing.Point(622, 55);
            this.formLabel17.Name = "formLabel17";
            this.formLabel17.Size = new System.Drawing.Size(35, 14);
            this.formLabel17.TabIndex = 18;
            this.formLabel17.Text = "规格";
            this.formLabel17.Visible = false;
            // 
            // AsStorageInTime
            // 
            this.AsStorageInTime.Location = new System.Drawing.Point(375, 30);
            this.AsStorageInTime.Name = "AsStorageInTime";
            this.AsStorageInTime.Size = new System.Drawing.Size(226, 23);
            this.AsStorageInTime.TabIndex = 3;
            this.AsStorageInTime.Value = new System.DateTime(2012, 8, 21, 1, 12, 1, 0);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.ForeColor = System.Drawing.Color.DarkRed;
            this.label12.Location = new System.Drawing.Point(249, 38);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(11, 12);
            this.label12.TabIndex = 11;
            this.label12.Text = "*";
            // 
            // btnSaveStorageIn
            // 
            this.btnSaveStorageIn.Arrow = RibbonStyle.RibbonMenuButton.e_arrow.None;
            this.btnSaveStorageIn.BackColor = System.Drawing.Color.Transparent;
            this.btnSaveStorageIn.ColorBase = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(209)))), ((int)(((byte)(240)))));
            this.btnSaveStorageIn.ColorBaseStroke = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(187)))), ((int)(((byte)(213)))));
            this.btnSaveStorageIn.ColorOn = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(78)))));
            this.btnSaveStorageIn.ColorOnStroke = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(177)))), ((int)(((byte)(118)))));
            this.btnSaveStorageIn.ColorPress = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSaveStorageIn.ColorPressStroke = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnSaveStorageIn.FadingSpeed = 20;
            this.btnSaveStorageIn.FlatAppearance.BorderSize = 0;
            this.btnSaveStorageIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveStorageIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveStorageIn.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnSaveStorageIn.GroupPos = RibbonStyle.RibbonMenuButton.e_groupPos.None;
            this.btnSaveStorageIn.Image = global::Winform.Properties.Resources.document_open;
            this.btnSaveStorageIn.ImageLocation = RibbonStyle.RibbonMenuButton.e_imagelocation.Left;
            this.btnSaveStorageIn.ImageOffset = 0;
            this.btnSaveStorageIn.IsPressed = false;
            this.btnSaveStorageIn.KeepPress = false;
            this.btnSaveStorageIn.Location = new System.Drawing.Point(47, 87);
            this.btnSaveStorageIn.MaxImageSize = new System.Drawing.Point(0, 0);
            this.btnSaveStorageIn.MenuPos = new System.Drawing.Point(0, 0);
            this.btnSaveStorageIn.Name = "btnSaveStorageIn";
            this.btnSaveStorageIn.Radius = 10;
            this.btnSaveStorageIn.ShowBase = RibbonStyle.RibbonMenuButton.e_showbase.Yes;
            this.btnSaveStorageIn.Size = new System.Drawing.Size(88, 29);
            this.btnSaveStorageIn.SplitButton = RibbonStyle.RibbonMenuButton.e_splitbutton.No;
            this.btnSaveStorageIn.SplitDistance = 0;
            this.btnSaveStorageIn.TabIndex = 29;
            this.btnSaveStorageIn.Text = "  保存";
            this.btnSaveStorageIn.Title = "";
            this.btnSaveStorageIn.UseVisualStyleBackColor = true;
            this.btnSaveStorageIn.Click += new System.EventHandler(this.btnSaveStorageIn_Click);
            // 
            // formLabel16
            // 
            this.formLabel16.AutoSize = true;
            this.formLabel16.Location = new System.Drawing.Point(622, 84);
            this.formLabel16.Name = "formLabel16";
            this.formLabel16.Size = new System.Drawing.Size(35, 14);
            this.formLabel16.TabIndex = 20;
            this.formLabel16.Text = "单位";
            this.formLabel16.Visible = false;
            // 
            // AsProductName
            // 
            this.AsProductName.BackColor = System.Drawing.SystemColors.Window;
            this.AsProductName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.AsProductName.Location = new System.Drawing.Point(292, 92);
            this.AsProductName.Name = "AsProductName";
            this.AsProductName.ReadOnly = true;
            this.AsProductName.Size = new System.Drawing.Size(124, 23);
            this.AsProductName.TabIndex = 17;
            this.AsProductName.Visible = false;
            // 
            // formLabel18
            // 
            this.formLabel18.AutoSize = true;
            this.formLabel18.Location = new System.Drawing.Point(237, 101);
            this.formLabel18.Name = "formLabel18";
            this.formLabel18.Size = new System.Drawing.Size(49, 14);
            this.formLabel18.TabIndex = 16;
            this.formLabel18.Text = "产品名";
            this.formLabel18.Visible = false;
            // 
            // AsProductSpeciText
            // 
            this.AsProductSpeciText.Enabled = false;
            this.AsProductSpeciText.FormattingEnabled = true;
            this.AsProductSpeciText.Location = new System.Drawing.Point(663, 55);
            this.AsProductSpeciText.Name = "AsProductSpeciText";
            this.AsProductSpeciText.Size = new System.Drawing.Size(124, 22);
            this.AsProductSpeciText.TabIndex = 28;
            this.AsProductSpeciText.Visible = false;
            this.AsProductSpeciText.SelectedValueChanged += new System.EventHandler(this.AsProductSpeciText_SelectedValueChanged);
            // 
            // AsProductUnit
            // 
            this.AsProductUnit.BackColor = System.Drawing.SystemColors.Window;
            this.AsProductUnit.Location = new System.Drawing.Point(663, 81);
            this.AsProductUnit.Name = "AsProductUnit";
            this.AsProductUnit.ReadOnly = true;
            this.AsProductUnit.Size = new System.Drawing.Size(124, 23);
            this.AsProductUnit.TabIndex = 27;
            this.AsProductUnit.Visible = false;
            this.AsProductUnit.TextChanged += new System.EventHandler(this.AsProductUnit_TextChanged);
            // 
            // AsProductUnitPrice
            // 
            this.AsProductUnitPrice.Location = new System.Drawing.Point(477, 94);
            this.AsProductUnitPrice.Name = "AsProductUnitPrice";
            this.AsProductUnitPrice.Size = new System.Drawing.Size(124, 23);
            this.AsProductUnitPrice.TabIndex = 25;
            this.AsProductUnitPrice.Visible = false;
            // 
            // formLabel15
            // 
            this.formLabel15.AutoSize = true;
            this.formLabel15.Location = new System.Drawing.Point(422, 97);
            this.formLabel15.Name = "formLabel15";
            this.formLabel15.Size = new System.Drawing.Size(49, 14);
            this.formLabel15.TabIndex = 24;
            this.formLabel15.Text = "进货价";
            this.formLabel15.Visible = false;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.AsStorageInItemDataGridView);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(3, 125);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(876, 261);
            this.panel5.TabIndex = 1;
            // 
            // AsStorageInItemDataGridView
            // 
            this.AsStorageInItemDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AsStorageInItemDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AsProductListId,
            this.AsProductListSpecId,
            this.AsProductListName,
            this.AsProductListAmount,
            this.AdProductListNumber,
            this.AsProductListBarcode,
            this.AsProductListUnitPrice,
            this.AsProductListCategory,
            this.AsProductListTaxRate,
            this.AsProductListSpeciText,
            this.AsProductListUnit,
            this.AsProductListIsDel,
            this.AsProductListCreateTime});
            this.AsStorageInItemDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AsStorageInItemDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.AsStorageInItemDataGridView.Location = new System.Drawing.Point(0, 0);
            this.AsStorageInItemDataGridView.Name = "AsStorageInItemDataGridView";
            this.AsStorageInItemDataGridView.RowTemplate.Height = 23;
            this.AsStorageInItemDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AsStorageInItemDataGridView.Size = new System.Drawing.Size(876, 261);
            this.AsStorageInItemDataGridView.TabIndex = 4;
            this.AsStorageInItemDataGridView.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.AsStorageInItemDataGridView_CellBeginEdit);
            this.AsStorageInItemDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AsStorageInItemDataGridView_CellContentClick);
            this.AsStorageInItemDataGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.AsStorageInItemDataGridView_CellEndEdit);
            this.AsStorageInItemDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.AsStorageInItemDataGridView_DataError);
            // 
            // AsProductListCreateTime
            // 
            this.AsProductListCreateTime.HeaderText = "CreateTime";
            this.AsProductListCreateTime.Name = "AsProductListCreateTime";
            this.AsProductListCreateTime.Visible = false;
            // 
            // AsProductListIsDel
            // 
            this.AsProductListIsDel.HeaderText = "IsDel";
            this.AsProductListIsDel.Name = "AsProductListIsDel";
            this.AsProductListIsDel.Visible = false;
            // 
            // AsProductListUnit
            // 
            this.AsProductListUnit.DataPropertyName = "Unit";
            this.AsProductListUnit.HeaderText = "计量单位";
            this.AsProductListUnit.Name = "AsProductListUnit";
            // 
            // AsProductListSpeciText
            // 
            this.AsProductListSpeciText.DataPropertyName = "SpecifiText";
            this.AsProductListSpeciText.HeaderText = "规格";
            this.AsProductListSpeciText.Name = "AsProductListSpeciText";
            // 
            // AsProductListTaxRate
            // 
            this.AsProductListTaxRate.DataPropertyName = "TaxRate";
            this.AsProductListTaxRate.HeaderText = "税率(%)";
            this.AsProductListTaxRate.Name = "AsProductListTaxRate";
            // 
            // AsProductListCategory
            // 
            this.AsProductListCategory.DataPropertyName = "Category";
            this.AsProductListCategory.HeaderText = "类别";
            this.AsProductListCategory.Name = "AsProductListCategory";
            // 
            // AsProductListUnitPrice
            // 
            this.AsProductListUnitPrice.DataPropertyName = "UnitPrice";
            this.AsProductListUnitPrice.HeaderText = "进货价(含税)";
            this.AsProductListUnitPrice.Name = "AsProductListUnitPrice";
            // 
            // AsProductListBarcode
            // 
            this.AsProductListBarcode.DataPropertyName = "Barcode";
            this.AsProductListBarcode.HeaderText = "条码";
            this.AsProductListBarcode.Name = "AsProductListBarcode";
            // 
            // AdProductListNumber
            // 
            this.AdProductListNumber.DataPropertyName = "ProductNumber";
            this.AdProductListNumber.HeaderText = "货号";
            this.AdProductListNumber.Name = "AdProductListNumber";
            // 
            // AsProductListAmount
            // 
            this.AsProductListAmount.DataPropertyName = "Amount";
            this.AsProductListAmount.HeaderText = "数量";
            this.AsProductListAmount.Name = "AsProductListAmount";
            // 
            // AsProductListName
            // 
            this.AsProductListName.DataPropertyName = "ProductName";
            this.AsProductListName.HeaderText = "名称";
            this.AsProductListName.Name = "AsProductListName";
            // 
            // AsProductListSpecId
            // 
            this.AsProductListSpecId.DataPropertyName = "SpecId";
            this.AsProductListSpecId.HeaderText = "SpecId";
            this.AsProductListSpecId.Name = "AsProductListSpecId";
            this.AsProductListSpecId.Visible = false;
            // 
            // AsProductListId
            // 
            this.AsProductListId.DataPropertyName = "ProductId";
            this.AsProductListId.HeaderText = "Id";
            this.AsProductListId.Name = "AsProductListId";
            this.AsProductListId.Visible = false;
            // 
            // listStorageInPage
            // 
            this.listStorageInPage.Controls.Add(this.StorageInListDataGridView);
            this.listStorageInPage.Controls.Add(this.groupBox4);
            this.listStorageInPage.Location = new System.Drawing.Point(4, 24);
            this.listStorageInPage.Name = "listStorageInPage";
            this.listStorageInPage.Padding = new System.Windows.Forms.Padding(3);
            this.listStorageInPage.Size = new System.Drawing.Size(882, 389);
            this.listStorageInPage.TabIndex = 4;
            this.listStorageInPage.Text = "采购入库单  ";
            this.listStorageInPage.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.ribbonMenuButton9);
            this.groupBox4.Controls.Add(this.ribbonMenuButton7);
            this.groupBox4.Controls.Add(this.btnSearchStorageIn);
            this.groupBox4.Controls.Add(this.SilSearchEndTime);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.SilSearchStartTime);
            this.groupBox4.Controls.Add(this.formLabel5);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox4.Location = new System.Drawing.Point(3, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(876, 78);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "查询";
            // 
            // formLabel5
            // 
            this.formLabel5.AutoSize = true;
            this.formLabel5.Location = new System.Drawing.Point(6, 31);
            this.formLabel5.Name = "formLabel5";
            this.formLabel5.Size = new System.Drawing.Size(77, 14);
            this.formLabel5.TabIndex = 0;
            this.formLabel5.Text = "入库时间段";
            // 
            // SilSearchStartTime
            // 
            this.SilSearchStartTime.Location = new System.Drawing.Point(89, 31);
            this.SilSearchStartTime.Name = "SilSearchStartTime";
            this.SilSearchStartTime.Size = new System.Drawing.Size(238, 23);
            this.SilSearchStartTime.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(62, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 14);
            this.label6.TabIndex = 2;
            this.label6.Text = "至";
            // 
            // SilSearchEndTime
            // 
            this.SilSearchEndTime.Location = new System.Drawing.Point(89, 57);
            this.SilSearchEndTime.Name = "SilSearchEndTime";
            this.SilSearchEndTime.Size = new System.Drawing.Size(238, 23);
            this.SilSearchEndTime.TabIndex = 3;
            // 
            // btnSearchStorageIn
            // 
            this.btnSearchStorageIn.Arrow = RibbonStyle.RibbonMenuButton.e_arrow.None;
            this.btnSearchStorageIn.BackColor = System.Drawing.Color.Transparent;
            this.btnSearchStorageIn.ColorBase = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(209)))), ((int)(((byte)(240)))));
            this.btnSearchStorageIn.ColorBaseStroke = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(187)))), ((int)(((byte)(213)))));
            this.btnSearchStorageIn.ColorOn = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(78)))));
            this.btnSearchStorageIn.ColorOnStroke = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(177)))), ((int)(((byte)(118)))));
            this.btnSearchStorageIn.ColorPress = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSearchStorageIn.ColorPressStroke = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnSearchStorageIn.FadingSpeed = 20;
            this.btnSearchStorageIn.FlatAppearance.BorderSize = 0;
            this.btnSearchStorageIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchStorageIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchStorageIn.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnSearchStorageIn.GroupPos = RibbonStyle.RibbonMenuButton.e_groupPos.None;
            this.btnSearchStorageIn.Image = global::Winform.Properties.Resources.clean;
            this.btnSearchStorageIn.ImageLocation = RibbonStyle.RibbonMenuButton.e_imagelocation.Left;
            this.btnSearchStorageIn.ImageOffset = 0;
            this.btnSearchStorageIn.IsPressed = false;
            this.btnSearchStorageIn.KeepPress = false;
            this.btnSearchStorageIn.Location = new System.Drawing.Point(352, 31);
            this.btnSearchStorageIn.MaxImageSize = new System.Drawing.Point(0, 0);
            this.btnSearchStorageIn.MenuPos = new System.Drawing.Point(0, 0);
            this.btnSearchStorageIn.Name = "btnSearchStorageIn";
            this.btnSearchStorageIn.Radius = 10;
            this.btnSearchStorageIn.ShowBase = RibbonStyle.RibbonMenuButton.e_showbase.Yes;
            this.btnSearchStorageIn.Size = new System.Drawing.Size(76, 29);
            this.btnSearchStorageIn.SplitButton = RibbonStyle.RibbonMenuButton.e_splitbutton.No;
            this.btnSearchStorageIn.SplitDistance = 0;
            this.btnSearchStorageIn.TabIndex = 5;
            this.btnSearchStorageIn.Text = "查询";
            this.btnSearchStorageIn.Title = "";
            this.btnSearchStorageIn.UseVisualStyleBackColor = true;
            this.btnSearchStorageIn.Click += new System.EventHandler(this.btnSearchStorageIn_Click);
            // 
            // ribbonMenuButton7
            // 
            this.ribbonMenuButton7.Arrow = RibbonStyle.RibbonMenuButton.e_arrow.None;
            this.ribbonMenuButton7.BackColor = System.Drawing.Color.Transparent;
            this.ribbonMenuButton7.ColorBase = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(209)))), ((int)(((byte)(240)))));
            this.ribbonMenuButton7.ColorBaseStroke = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(187)))), ((int)(((byte)(213)))));
            this.ribbonMenuButton7.ColorOn = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(78)))));
            this.ribbonMenuButton7.ColorOnStroke = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(177)))), ((int)(((byte)(118)))));
            this.ribbonMenuButton7.ColorPress = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ribbonMenuButton7.ColorPressStroke = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ribbonMenuButton7.FadingSpeed = 20;
            this.ribbonMenuButton7.FlatAppearance.BorderSize = 0;
            this.ribbonMenuButton7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ribbonMenuButton7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ribbonMenuButton7.ForeColor = System.Drawing.Color.DarkBlue;
            this.ribbonMenuButton7.GroupPos = RibbonStyle.RibbonMenuButton.e_groupPos.None;
            this.ribbonMenuButton7.Image = global::Winform.Properties.Resources.add;
            this.ribbonMenuButton7.ImageLocation = RibbonStyle.RibbonMenuButton.e_imagelocation.Left;
            this.ribbonMenuButton7.ImageOffset = 0;
            this.ribbonMenuButton7.IsPressed = false;
            this.ribbonMenuButton7.KeepPress = false;
            this.ribbonMenuButton7.Location = new System.Drawing.Point(434, 31);
            this.ribbonMenuButton7.MaxImageSize = new System.Drawing.Point(0, 0);
            this.ribbonMenuButton7.MenuPos = new System.Drawing.Point(0, 0);
            this.ribbonMenuButton7.Name = "ribbonMenuButton7";
            this.ribbonMenuButton7.Radius = 10;
            this.ribbonMenuButton7.ShowBase = RibbonStyle.RibbonMenuButton.e_showbase.Yes;
            this.ribbonMenuButton7.Size = new System.Drawing.Size(76, 29);
            this.ribbonMenuButton7.SplitButton = RibbonStyle.RibbonMenuButton.e_splitbutton.No;
            this.ribbonMenuButton7.SplitDistance = 0;
            this.ribbonMenuButton7.TabIndex = 8;
            this.ribbonMenuButton7.Text = "添加";
            this.ribbonMenuButton7.Title = "";
            this.ribbonMenuButton7.UseVisualStyleBackColor = true;
            this.ribbonMenuButton7.Click += new System.EventHandler(this.ribbonMenuButton7_Click);
            // 
            // ribbonMenuButton9
            // 
            this.ribbonMenuButton9.Arrow = RibbonStyle.RibbonMenuButton.e_arrow.None;
            this.ribbonMenuButton9.BackColor = System.Drawing.Color.Transparent;
            this.ribbonMenuButton9.ColorBase = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(209)))), ((int)(((byte)(240)))));
            this.ribbonMenuButton9.ColorBaseStroke = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(187)))), ((int)(((byte)(213)))));
            this.ribbonMenuButton9.ColorOn = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(78)))));
            this.ribbonMenuButton9.ColorOnStroke = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(177)))), ((int)(((byte)(118)))));
            this.ribbonMenuButton9.ColorPress = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ribbonMenuButton9.ColorPressStroke = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ribbonMenuButton9.FadingSpeed = 20;
            this.ribbonMenuButton9.FlatAppearance.BorderSize = 0;
            this.ribbonMenuButton9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ribbonMenuButton9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ribbonMenuButton9.ForeColor = System.Drawing.Color.DarkBlue;
            this.ribbonMenuButton9.GroupPos = RibbonStyle.RibbonMenuButton.e_groupPos.None;
            this.ribbonMenuButton9.Image = global::Winform.Properties.Resources.document_open;
            this.ribbonMenuButton9.ImageLocation = RibbonStyle.RibbonMenuButton.e_imagelocation.Left;
            this.ribbonMenuButton9.ImageOffset = 0;
            this.ribbonMenuButton9.IsPressed = false;
            this.ribbonMenuButton9.KeepPress = false;
            this.ribbonMenuButton9.Location = new System.Drawing.Point(516, 31);
            this.ribbonMenuButton9.MaxImageSize = new System.Drawing.Point(0, 0);
            this.ribbonMenuButton9.MenuPos = new System.Drawing.Point(0, 0);
            this.ribbonMenuButton9.Name = "ribbonMenuButton9";
            this.ribbonMenuButton9.Radius = 10;
            this.ribbonMenuButton9.ShowBase = RibbonStyle.RibbonMenuButton.e_showbase.Yes;
            this.ribbonMenuButton9.Size = new System.Drawing.Size(102, 29);
            this.ribbonMenuButton9.SplitButton = RibbonStyle.RibbonMenuButton.e_splitbutton.No;
            this.ribbonMenuButton9.SplitDistance = 0;
            this.ribbonMenuButton9.TabIndex = 9;
            this.ribbonMenuButton9.Text = "查看详细";
            this.ribbonMenuButton9.Title = "";
            this.ribbonMenuButton9.UseVisualStyleBackColor = true;
            this.ribbonMenuButton9.Click += new System.EventHandler(this.ribbonMenuButton9_Click);
            // 
            // StorageInListDataGridView
            // 
            this.StorageInListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StorageInListDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StlId,
            this.StlStorageListNumber,
            this.StlStorageInTotalPrice,
            this.StlStorageInTotalAmount,
            this.StlStorageInTime,
            this.Column2,
            this.Column3});
            this.StorageInListDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StorageInListDataGridView.Location = new System.Drawing.Point(3, 81);
            this.StorageInListDataGridView.Name = "StorageInListDataGridView";
            this.StorageInListDataGridView.RowTemplate.Height = 23;
            this.StorageInListDataGridView.Size = new System.Drawing.Size(876, 305);
            this.StorageInListDataGridView.TabIndex = 1;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "CreateTime";
            this.Column3.HeaderText = "CreateTime";
            this.Column3.Name = "Column3";
            this.Column3.Visible = false;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "IsDel";
            this.Column2.HeaderText = "IsDel";
            this.Column2.Name = "Column2";
            this.Column2.Visible = false;
            // 
            // StlStorageInTime
            // 
            this.StlStorageInTime.DataPropertyName = "StorageInTime";
            this.StlStorageInTime.HeaderText = "入库时间";
            this.StlStorageInTime.Name = "StlStorageInTime";
            // 
            // StlStorageInTotalAmount
            // 
            this.StlStorageInTotalAmount.DataPropertyName = "TotalAmount";
            this.StlStorageInTotalAmount.HeaderText = "总数量";
            this.StlStorageInTotalAmount.Name = "StlStorageInTotalAmount";
            // 
            // StlStorageInTotalPrice
            // 
            this.StlStorageInTotalPrice.DataPropertyName = "TotalPrice";
            this.StlStorageInTotalPrice.HeaderText = "总金额";
            this.StlStorageInTotalPrice.Name = "StlStorageInTotalPrice";
            // 
            // StlStorageListNumber
            // 
            this.StlStorageListNumber.DataPropertyName = "ListNumber";
            this.StlStorageListNumber.HeaderText = "入库单号";
            this.StlStorageListNumber.Name = "StlStorageListNumber";
            // 
            // StlId
            // 
            this.StlId.DataPropertyName = "Id";
            this.StlId.HeaderText = "Id";
            this.StlId.Name = "StlId";
            this.StlId.Visible = false;
            // 
            // AddProductPage
            // 
            this.AddProductPage.Controls.Add(this.groupBox5);
            this.AddProductPage.Controls.Add(this.groupBox3);
            this.AddProductPage.Location = new System.Drawing.Point(4, 24);
            this.AddProductPage.Name = "AddProductPage";
            this.AddProductPage.Size = new System.Drawing.Size(882, 389);
            this.AddProductPage.TabIndex = 0;
            this.AddProductPage.Text = "添加产品  ";
            this.AddProductPage.UseVisualStyleBackColor = true;
            this.AddProductPage.Enter += new System.EventHandler(this.AddProductPage_Enter);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.ApTaxRate);
            this.groupBox3.Controls.Add(this.formLabel4);
            this.groupBox3.Controls.Add(this.ApCategory);
            this.groupBox3.Controls.Add(this.ApProductNumber);
            this.groupBox3.Controls.Add(this.ApProductName);
            this.groupBox3.Controls.Add(this.formLabel3);
            this.groupBox3.Controls.Add(this.formLabel2);
            this.groupBox3.Controls.Add(this.formLabel1);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(882, 101);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "产品基本信息";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // formLabel1
            // 
            this.formLabel1.AutoSize = true;
            this.formLabel1.Location = new System.Drawing.Point(22, 30);
            this.formLabel1.Name = "formLabel1";
            this.formLabel1.Size = new System.Drawing.Size(49, 14);
            this.formLabel1.TabIndex = 0;
            this.formLabel1.Text = "产品名";
            // 
            // formLabel2
            // 
            this.formLabel2.AutoSize = true;
            this.formLabel2.Location = new System.Drawing.Point(517, 23);
            this.formLabel2.Name = "formLabel2";
            this.formLabel2.Size = new System.Drawing.Size(49, 14);
            this.formLabel2.TabIndex = 1;
            this.formLabel2.Text = "货  号";
            this.formLabel2.Visible = false;
            // 
            // formLabel3
            // 
            this.formLabel3.AutoSize = true;
            this.formLabel3.Location = new System.Drawing.Point(297, 30);
            this.formLabel3.Name = "formLabel3";
            this.formLabel3.Size = new System.Drawing.Size(49, 14);
            this.formLabel3.TabIndex = 2;
            this.formLabel3.Text = "类  别";
            // 
            // ApProductName
            // 
            this.ApProductName.Location = new System.Drawing.Point(87, 27);
            this.ApProductName.Name = "ApProductName";
            this.ApProductName.Size = new System.Drawing.Size(121, 23);
            this.ApProductName.TabIndex = 1;
            // 
            // ApProductNumber
            // 
            this.ApProductNumber.Location = new System.Drawing.Point(583, 20);
            this.ApProductNumber.Name = "ApProductNumber";
            this.ApProductNumber.Size = new System.Drawing.Size(121, 23);
            this.ApProductNumber.TabIndex = 4;
            this.ApProductNumber.Visible = false;
            // 
            // ApCategory
            // 
            this.ApCategory.BackColor = System.Drawing.SystemColors.Window;
            this.ApCategory.Location = new System.Drawing.Point(362, 27);
            this.ApCategory.Name = "ApCategory";
            this.ApCategory.ReadOnly = true;
            this.ApCategory.Size = new System.Drawing.Size(121, 23);
            this.ApCategory.TabIndex = 2;
            this.ApCategory.Enter += new System.EventHandler(this.tbCategory_Enter);
            this.ApCategory.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ApCategory_KeyDown);
            // 
            // formLabel4
            // 
            this.formLabel4.AutoSize = true;
            this.formLabel4.Location = new System.Drawing.Point(22, 59);
            this.formLabel4.Name = "formLabel4";
            this.formLabel4.Size = new System.Drawing.Size(49, 14);
            this.formLabel4.TabIndex = 6;
            this.formLabel4.Text = "税  率";
            // 
            // ApTaxRate
            // 
            this.ApTaxRate.Location = new System.Drawing.Point(87, 56);
            this.ApTaxRate.Name = "ApTaxRate";
            this.ApTaxRate.Size = new System.Drawing.Size(121, 23);
            this.ApTaxRate.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(220, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(11, 12);
            this.label2.TabIndex = 10;
            this.label2.Text = "*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.DarkRed;
            this.label4.Location = new System.Drawing.Point(220, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(11, 12);
            this.label4.TabIndex = 12;
            this.label4.Text = "*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.ForeColor = System.Drawing.Color.DarkRed;
            this.label5.Location = new System.Drawing.Point(489, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(11, 12);
            this.label5.TabIndex = 13;
            this.label5.Text = "*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(85, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 12);
            this.label1.TabIndex = 15;
            this.label1.Text = "( 如6%的税率输入6 )";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.ApSpecDataGridView);
            this.groupBox5.Controls.Add(this.panel3);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox5.Location = new System.Drawing.Point(0, 101);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(882, 288);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "产品规格";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.ApUnit);
            this.panel3.Controls.Add(this.ApBarcode);
            this.panel3.Controls.Add(this.ApSpeciText);
            this.panel3.Controls.Add(this.ApUnitPrice);
            this.panel3.Controls.Add(this.formLabel41);
            this.panel3.Controls.Add(this.formLabel40);
            this.panel3.Controls.Add(this.formLabel39);
            this.panel3.Controls.Add(this.formLabel38);
            this.panel3.Controls.Add(this.btnSaveClose);
            this.panel3.Controls.Add(this.btnSaveAndContinue);
            this.panel3.Controls.Add(this.btnAddSpec);
            this.panel3.Controls.Add(this.btnDeleteSpec);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(3, 19);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(876, 118);
            this.panel3.TabIndex = 2;
            // 
            // btnDeleteSpec
            // 
            this.btnDeleteSpec.Arrow = RibbonStyle.RibbonMenuButton.e_arrow.None;
            this.btnDeleteSpec.BackColor = System.Drawing.Color.Transparent;
            this.btnDeleteSpec.ColorBase = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(209)))), ((int)(((byte)(240)))));
            this.btnDeleteSpec.ColorBaseStroke = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(187)))), ((int)(((byte)(213)))));
            this.btnDeleteSpec.ColorOn = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(78)))));
            this.btnDeleteSpec.ColorOnStroke = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(177)))), ((int)(((byte)(118)))));
            this.btnDeleteSpec.ColorPress = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnDeleteSpec.ColorPressStroke = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnDeleteSpec.FadingSpeed = 20;
            this.btnDeleteSpec.FlatAppearance.BorderSize = 0;
            this.btnDeleteSpec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteSpec.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteSpec.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnDeleteSpec.GroupPos = RibbonStyle.RibbonMenuButton.e_groupPos.None;
            this.btnDeleteSpec.Image = global::Winform.Properties.Resources.gtk_remove;
            this.btnDeleteSpec.ImageLocation = RibbonStyle.RibbonMenuButton.e_imagelocation.Left;
            this.btnDeleteSpec.ImageOffset = 0;
            this.btnDeleteSpec.IsPressed = false;
            this.btnDeleteSpec.KeepPress = false;
            this.btnDeleteSpec.Location = new System.Drawing.Point(125, 70);
            this.btnDeleteSpec.MaxImageSize = new System.Drawing.Point(0, 0);
            this.btnDeleteSpec.MenuPos = new System.Drawing.Point(0, 0);
            this.btnDeleteSpec.Name = "btnDeleteSpec";
            this.btnDeleteSpec.Radius = 10;
            this.btnDeleteSpec.ShowBase = RibbonStyle.RibbonMenuButton.e_showbase.Yes;
            this.btnDeleteSpec.Size = new System.Drawing.Size(76, 29);
            this.btnDeleteSpec.SplitButton = RibbonStyle.RibbonMenuButton.e_splitbutton.No;
            this.btnDeleteSpec.SplitDistance = 0;
            this.btnDeleteSpec.TabIndex = 8;
            this.btnDeleteSpec.Text = "删除";
            this.btnDeleteSpec.Title = "";
            this.btnDeleteSpec.UseVisualStyleBackColor = true;
            this.btnDeleteSpec.Click += new System.EventHandler(this.btnDeleteSpec_Click);
            // 
            // btnAddSpec
            // 
            this.btnAddSpec.Arrow = RibbonStyle.RibbonMenuButton.e_arrow.None;
            this.btnAddSpec.BackColor = System.Drawing.Color.Transparent;
            this.btnAddSpec.ColorBase = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(209)))), ((int)(((byte)(240)))));
            this.btnAddSpec.ColorBaseStroke = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(187)))), ((int)(((byte)(213)))));
            this.btnAddSpec.ColorOn = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(78)))));
            this.btnAddSpec.ColorOnStroke = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(177)))), ((int)(((byte)(118)))));
            this.btnAddSpec.ColorPress = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnAddSpec.ColorPressStroke = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnAddSpec.FadingSpeed = 20;
            this.btnAddSpec.FlatAppearance.BorderSize = 0;
            this.btnAddSpec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddSpec.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSpec.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnAddSpec.GroupPos = RibbonStyle.RibbonMenuButton.e_groupPos.None;
            this.btnAddSpec.Image = global::Winform.Properties.Resources.add;
            this.btnAddSpec.ImageLocation = RibbonStyle.RibbonMenuButton.e_imagelocation.Left;
            this.btnAddSpec.ImageOffset = 0;
            this.btnAddSpec.IsPressed = false;
            this.btnAddSpec.KeepPress = false;
            this.btnAddSpec.Location = new System.Drawing.Point(22, 70);
            this.btnAddSpec.MaxImageSize = new System.Drawing.Point(0, 0);
            this.btnAddSpec.MenuPos = new System.Drawing.Point(0, 0);
            this.btnAddSpec.Name = "btnAddSpec";
            this.btnAddSpec.Radius = 10;
            this.btnAddSpec.ShowBase = RibbonStyle.RibbonMenuButton.e_showbase.Yes;
            this.btnAddSpec.Size = new System.Drawing.Size(76, 29);
            this.btnAddSpec.SplitButton = RibbonStyle.RibbonMenuButton.e_splitbutton.No;
            this.btnAddSpec.SplitDistance = 0;
            this.btnAddSpec.TabIndex = 7;
            this.btnAddSpec.Text = "添加";
            this.btnAddSpec.Title = "";
            this.btnAddSpec.UseVisualStyleBackColor = true;
            this.btnAddSpec.Click += new System.EventHandler(this.btnAddSpec_Click);
            // 
            // btnSaveAndContinue
            // 
            this.btnSaveAndContinue.Arrow = RibbonStyle.RibbonMenuButton.e_arrow.None;
            this.btnSaveAndContinue.BackColor = System.Drawing.Color.Transparent;
            this.btnSaveAndContinue.ColorBase = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(209)))), ((int)(((byte)(240)))));
            this.btnSaveAndContinue.ColorBaseStroke = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(187)))), ((int)(((byte)(213)))));
            this.btnSaveAndContinue.ColorOn = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(78)))));
            this.btnSaveAndContinue.ColorOnStroke = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(177)))), ((int)(((byte)(118)))));
            this.btnSaveAndContinue.ColorPress = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSaveAndContinue.ColorPressStroke = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnSaveAndContinue.FadingSpeed = 20;
            this.btnSaveAndContinue.FlatAppearance.BorderSize = 0;
            this.btnSaveAndContinue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveAndContinue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveAndContinue.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnSaveAndContinue.GroupPos = RibbonStyle.RibbonMenuButton.e_groupPos.None;
            this.btnSaveAndContinue.Image = global::Winform.Properties.Resources.document_open;
            this.btnSaveAndContinue.ImageLocation = RibbonStyle.RibbonMenuButton.e_imagelocation.Left;
            this.btnSaveAndContinue.ImageOffset = 0;
            this.btnSaveAndContinue.IsPressed = false;
            this.btnSaveAndContinue.KeepPress = false;
            this.btnSaveAndContinue.Location = new System.Drawing.Point(493, 70);
            this.btnSaveAndContinue.MaxImageSize = new System.Drawing.Point(0, 0);
            this.btnSaveAndContinue.MenuPos = new System.Drawing.Point(0, 0);
            this.btnSaveAndContinue.Name = "btnSaveAndContinue";
            this.btnSaveAndContinue.Radius = 10;
            this.btnSaveAndContinue.ShowBase = RibbonStyle.RibbonMenuButton.e_showbase.Yes;
            this.btnSaveAndContinue.Size = new System.Drawing.Size(101, 29);
            this.btnSaveAndContinue.SplitButton = RibbonStyle.RibbonMenuButton.e_splitbutton.No;
            this.btnSaveAndContinue.SplitDistance = 0;
            this.btnSaveAndContinue.TabIndex = 9;
            this.btnSaveAndContinue.Text = "保存继续";
            this.btnSaveAndContinue.Title = "";
            this.btnSaveAndContinue.UseVisualStyleBackColor = true;
            this.btnSaveAndContinue.Click += new System.EventHandler(this.btnSaveAndContinue_Click);
            // 
            // btnSaveClose
            // 
            this.btnSaveClose.Arrow = RibbonStyle.RibbonMenuButton.e_arrow.None;
            this.btnSaveClose.BackColor = System.Drawing.Color.Transparent;
            this.btnSaveClose.ColorBase = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(209)))), ((int)(((byte)(240)))));
            this.btnSaveClose.ColorBaseStroke = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(187)))), ((int)(((byte)(213)))));
            this.btnSaveClose.ColorOn = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(78)))));
            this.btnSaveClose.ColorOnStroke = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(177)))), ((int)(((byte)(118)))));
            this.btnSaveClose.ColorPress = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSaveClose.ColorPressStroke = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnSaveClose.FadingSpeed = 20;
            this.btnSaveClose.FlatAppearance.BorderSize = 0;
            this.btnSaveClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveClose.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnSaveClose.GroupPos = RibbonStyle.RibbonMenuButton.e_groupPos.None;
            this.btnSaveClose.Image = global::Winform.Properties.Resources.document_open;
            this.btnSaveClose.ImageLocation = RibbonStyle.RibbonMenuButton.e_imagelocation.Left;
            this.btnSaveClose.ImageOffset = 0;
            this.btnSaveClose.IsPressed = false;
            this.btnSaveClose.KeepPress = false;
            this.btnSaveClose.Location = new System.Drawing.Point(600, 70);
            this.btnSaveClose.MaxImageSize = new System.Drawing.Point(0, 0);
            this.btnSaveClose.MenuPos = new System.Drawing.Point(0, 0);
            this.btnSaveClose.Name = "btnSaveClose";
            this.btnSaveClose.Radius = 10;
            this.btnSaveClose.ShowBase = RibbonStyle.RibbonMenuButton.e_showbase.Yes;
            this.btnSaveClose.Size = new System.Drawing.Size(101, 29);
            this.btnSaveClose.SplitButton = RibbonStyle.RibbonMenuButton.e_splitbutton.No;
            this.btnSaveClose.SplitDistance = 0;
            this.btnSaveClose.TabIndex = 10;
            this.btnSaveClose.Text = "保存关闭";
            this.btnSaveClose.Title = "";
            this.btnSaveClose.UseVisualStyleBackColor = true;
            this.btnSaveClose.Visible = false;
            this.btnSaveClose.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // formLabel38
            // 
            this.formLabel38.AutoSize = true;
            this.formLabel38.Location = new System.Drawing.Point(19, 14);
            this.formLabel38.Name = "formLabel38";
            this.formLabel38.Size = new System.Drawing.Size(63, 14);
            this.formLabel38.TabIndex = 11;
            this.formLabel38.Text = "产品规格";
            // 
            // formLabel39
            // 
            this.formLabel39.AutoSize = true;
            this.formLabel39.Location = new System.Drawing.Point(294, 14);
            this.formLabel39.Name = "formLabel39";
            this.formLabel39.Size = new System.Drawing.Size(63, 14);
            this.formLabel39.TabIndex = 12;
            this.formLabel39.Text = "计量单位";
            // 
            // formLabel40
            // 
            this.formLabel40.AutoSize = true;
            this.formLabel40.Location = new System.Drawing.Point(19, 41);
            this.formLabel40.Name = "formLabel40";
            this.formLabel40.Size = new System.Drawing.Size(63, 14);
            this.formLabel40.TabIndex = 13;
            this.formLabel40.Text = "条 形 码";
            // 
            // formLabel41
            // 
            this.formLabel41.AutoSize = true;
            this.formLabel41.Location = new System.Drawing.Point(294, 41);
            this.formLabel41.Name = "formLabel41";
            this.formLabel41.Size = new System.Drawing.Size(63, 14);
            this.formLabel41.TabIndex = 14;
            this.formLabel41.Text = "单    价";
            // 
            // ApUnitPrice
            // 
            this.ApUnitPrice.Location = new System.Drawing.Point(359, 38);
            this.ApUnitPrice.Name = "ApUnitPrice";
            this.ApUnitPrice.Size = new System.Drawing.Size(121, 23);
            this.ApUnitPrice.TabIndex = 15;
            // 
            // ApSpeciText
            // 
            this.ApSpeciText.Location = new System.Drawing.Point(84, 11);
            this.ApSpeciText.Name = "ApSpeciText";
            this.ApSpeciText.Size = new System.Drawing.Size(121, 23);
            this.ApSpeciText.TabIndex = 16;
            // 
            // ApBarcode
            // 
            this.ApBarcode.Location = new System.Drawing.Point(84, 38);
            this.ApBarcode.Name = "ApBarcode";
            this.ApBarcode.Size = new System.Drawing.Size(121, 23);
            this.ApBarcode.TabIndex = 17;
            // 
            // ApUnit
            // 
            this.ApUnit.FormattingEnabled = true;
            this.ApUnit.Location = new System.Drawing.Point(359, 11);
            this.ApUnit.Name = "ApUnit";
            this.ApUnit.Size = new System.Drawing.Size(121, 22);
            this.ApUnit.TabIndex = 18;
            // 
            // ApSpecDataGridView
            // 
            this.ApSpecDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.ApSpecDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ApSpecDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SLId,
            this.SLSpecifiText,
            this.SLShowUnit,
            this.SLUnit,
            this.SLBarcode,
            this.SLUnitPrice,
            this.SLIsDel,
            this.SLCreateTime});
            this.ApSpecDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ApSpecDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.ApSpecDataGridView.Location = new System.Drawing.Point(3, 137);
            this.ApSpecDataGridView.Name = "ApSpecDataGridView";
            this.ApSpecDataGridView.RowTemplate.Height = 23;
            this.ApSpecDataGridView.Size = new System.Drawing.Size(876, 148);
            this.ApSpecDataGridView.TabIndex = 3;
            this.ApSpecDataGridView.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.SpecDataGridView_CellBeginEdit);
            this.ApSpecDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SpecDataGridView_CellClick);
            this.ApSpecDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SpecDataGridView_CellContentClick);
            this.ApSpecDataGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.SpecDataGridView_CellEndEdit);
            this.ApSpecDataGridView.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.SpecDataGridView_CellEnter);
            this.ApSpecDataGridView.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.SpecDataGridView_CellMouseDown);
            // 
            // SLCreateTime
            // 
            this.SLCreateTime.DataPropertyName = "CreateTime";
            this.SLCreateTime.HeaderText = "CreateTime";
            this.SLCreateTime.Name = "SLCreateTime";
            this.SLCreateTime.Visible = false;
            // 
            // SLIsDel
            // 
            this.SLIsDel.DataPropertyName = "IsDel";
            this.SLIsDel.HeaderText = "IsDel";
            this.SLIsDel.Name = "SLIsDel";
            this.SLIsDel.Visible = false;
            // 
            // SLUnitPrice
            // 
            this.SLUnitPrice.DataPropertyName = "UnitPrice";
            this.SLUnitPrice.HeaderText = "单价(含税)";
            this.SLUnitPrice.Name = "SLUnitPrice";
            // 
            // SLBarcode
            // 
            this.SLBarcode.DataPropertyName = "Barcode";
            this.SLBarcode.HeaderText = "条形码";
            this.SLBarcode.Name = "SLBarcode";
            // 
            // SLUnit
            // 
            this.SLUnit.DataPropertyName = "UnitId";
            this.SLUnit.HeaderText = "计量单位";
            this.SLUnit.Name = "SLUnit";
            this.SLUnit.Visible = false;
            // 
            // SLShowUnit
            // 
            this.SLShowUnit.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.SLShowUnit.HeaderText = "计量单位";
            this.SLShowUnit.Name = "SLShowUnit";
            // 
            // SLSpecifiText
            // 
            this.SLSpecifiText.DataPropertyName = "SpecifiText";
            this.SLSpecifiText.HeaderText = "产品规格";
            this.SLSpecifiText.Name = "SLSpecifiText";
            // 
            // SLId
            // 
            this.SLId.DataPropertyName = "Id";
            this.SLId.HeaderText = "Id";
            this.SLId.Name = "SLId";
            this.SLId.Visible = false;
            // 
            // ProductListPage
            // 
            this.ProductListPage.Controls.Add(this.panel1);
            this.ProductListPage.Controls.Add(this.treeView1);
            this.ProductListPage.Location = new System.Drawing.Point(4, 24);
            this.ProductListPage.Name = "ProductListPage";
            this.ProductListPage.Padding = new System.Windows.Forms.Padding(3);
            this.ProductListPage.Size = new System.Drawing.Size(739, 389);
            this.ProductListPage.TabIndex = 0;
            this.ProductListPage.Text = "产品列表  ";
            this.ProductListPage.UseVisualStyleBackColor = true;
            this.ProductListPage.Enter += new System.EventHandler(this.ProductListPage_Enter);
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeView1.LabelEdit = true;
            this.treeView1.Location = new System.Drawing.Point(3, 3);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "RootNode";
            treeNode1.Text = "产品类别";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1});
            this.treeView1.Size = new System.Drawing.Size(160, 383);
            this.treeView1.TabIndex = 0;
            this.treeView1.BeforeLabelEdit += new System.Windows.Forms.NodeLabelEditEventHandler(this.treeView1_BeforeLabelEdit);
            this.treeView1.AfterLabelEdit += new System.Windows.Forms.NodeLabelEditEventHandler(this.treeView1_AfterLabelEdit);
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            this.treeView1.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(163, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(573, 383);
            this.panel1.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDeleteProduct);
            this.groupBox1.Controls.Add(this.ribbonMenuButton6);
            this.groupBox1.Controls.Add(this.btnAddProduct);
            this.groupBox1.Controls.Add(this.btnEditProduct);
            this.groupBox1.Controls.Add(this.tbBarcode);
            this.groupBox1.Controls.Add(this.lblBarcode);
            this.groupBox1.Controls.Add(this.tbProduct);
            this.groupBox1.Controls.Add(this.lblProductNumber);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(573, 94);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "查询";
            // 
            // lblProductNumber
            // 
            this.lblProductNumber.AutoSize = true;
            this.lblProductNumber.Location = new System.Drawing.Point(364, 18);
            this.lblProductNumber.Name = "lblProductNumber";
            this.lblProductNumber.Size = new System.Drawing.Size(35, 14);
            this.lblProductNumber.TabIndex = 0;
            this.lblProductNumber.Text = "货号";
            this.lblProductNumber.Visible = false;
            // 
            // tbProduct
            // 
            this.tbProduct.Location = new System.Drawing.Point(405, 18);
            this.tbProduct.Name = "tbProduct";
            this.tbProduct.Size = new System.Drawing.Size(100, 23);
            this.tbProduct.TabIndex = 2;
            this.tbProduct.Visible = false;
            // 
            // lblBarcode
            // 
            this.lblBarcode.AutoSize = true;
            this.lblBarcode.Location = new System.Drawing.Point(18, 20);
            this.lblBarcode.Name = "lblBarcode";
            this.lblBarcode.Size = new System.Drawing.Size(35, 14);
            this.lblBarcode.TabIndex = 2;
            this.lblBarcode.Text = "条码";
            // 
            // tbBarcode
            // 
            this.tbBarcode.Location = new System.Drawing.Point(88, 20);
            this.tbBarcode.Name = "tbBarcode";
            this.tbBarcode.Size = new System.Drawing.Size(100, 23);
            this.tbBarcode.TabIndex = 1;
            this.tbBarcode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbBarcode_KeyPress);
            // 
            // btnEditProduct
            // 
            this.btnEditProduct.Arrow = RibbonStyle.RibbonMenuButton.e_arrow.None;
            this.btnEditProduct.BackColor = System.Drawing.Color.Transparent;
            this.btnEditProduct.ColorBase = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(209)))), ((int)(((byte)(240)))));
            this.btnEditProduct.ColorBaseStroke = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(187)))), ((int)(((byte)(213)))));
            this.btnEditProduct.ColorOn = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(78)))));
            this.btnEditProduct.ColorOnStroke = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(177)))), ((int)(((byte)(118)))));
            this.btnEditProduct.ColorPress = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnEditProduct.ColorPressStroke = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnEditProduct.FadingSpeed = 20;
            this.btnEditProduct.FlatAppearance.BorderSize = 0;
            this.btnEditProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditProduct.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnEditProduct.GroupPos = RibbonStyle.RibbonMenuButton.e_groupPos.None;
            this.btnEditProduct.Image = global::Winform.Properties.Resources.edit;
            this.btnEditProduct.ImageLocation = RibbonStyle.RibbonMenuButton.e_imagelocation.Left;
            this.btnEditProduct.ImageOffset = 0;
            this.btnEditProduct.IsPressed = false;
            this.btnEditProduct.KeepPress = false;
            this.btnEditProduct.Location = new System.Drawing.Point(88, 56);
            this.btnEditProduct.MaxImageSize = new System.Drawing.Point(0, 0);
            this.btnEditProduct.MenuPos = new System.Drawing.Point(0, 0);
            this.btnEditProduct.Name = "btnEditProduct";
            this.btnEditProduct.Radius = 10;
            this.btnEditProduct.ShowBase = RibbonStyle.RibbonMenuButton.e_showbase.Yes;
            this.btnEditProduct.Size = new System.Drawing.Size(76, 29);
            this.btnEditProduct.SplitButton = RibbonStyle.RibbonMenuButton.e_splitbutton.No;
            this.btnEditProduct.SplitDistance = 0;
            this.btnEditProduct.TabIndex = 5;
            this.btnEditProduct.Text = "修改";
            this.btnEditProduct.Title = "";
            this.btnEditProduct.UseVisualStyleBackColor = true;
            this.btnEditProduct.Click += new System.EventHandler(this.btnEditProduct_Click);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Arrow = RibbonStyle.RibbonMenuButton.e_arrow.None;
            this.btnAddProduct.BackColor = System.Drawing.Color.Transparent;
            this.btnAddProduct.ColorBase = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(209)))), ((int)(((byte)(240)))));
            this.btnAddProduct.ColorBaseStroke = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(187)))), ((int)(((byte)(213)))));
            this.btnAddProduct.ColorOn = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(78)))));
            this.btnAddProduct.ColorOnStroke = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(177)))), ((int)(((byte)(118)))));
            this.btnAddProduct.ColorPress = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnAddProduct.ColorPressStroke = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnAddProduct.FadingSpeed = 20;
            this.btnAddProduct.FlatAppearance.BorderSize = 0;
            this.btnAddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProduct.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnAddProduct.GroupPos = RibbonStyle.RibbonMenuButton.e_groupPos.None;
            this.btnAddProduct.Image = global::Winform.Properties.Resources.add;
            this.btnAddProduct.ImageLocation = RibbonStyle.RibbonMenuButton.e_imagelocation.Left;
            this.btnAddProduct.ImageOffset = 0;
            this.btnAddProduct.IsPressed = false;
            this.btnAddProduct.KeepPress = false;
            this.btnAddProduct.Location = new System.Drawing.Point(6, 56);
            this.btnAddProduct.MaxImageSize = new System.Drawing.Point(0, 0);
            this.btnAddProduct.MenuPos = new System.Drawing.Point(0, 0);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Radius = 10;
            this.btnAddProduct.ShowBase = RibbonStyle.RibbonMenuButton.e_showbase.Yes;
            this.btnAddProduct.Size = new System.Drawing.Size(76, 29);
            this.btnAddProduct.SplitButton = RibbonStyle.RibbonMenuButton.e_splitbutton.No;
            this.btnAddProduct.SplitDistance = 0;
            this.btnAddProduct.TabIndex = 4;
            this.btnAddProduct.Text = "添加";
            this.btnAddProduct.Title = "";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // ribbonMenuButton6
            // 
            this.ribbonMenuButton6.Arrow = RibbonStyle.RibbonMenuButton.e_arrow.None;
            this.ribbonMenuButton6.BackColor = System.Drawing.Color.Transparent;
            this.ribbonMenuButton6.ColorBase = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(209)))), ((int)(((byte)(240)))));
            this.ribbonMenuButton6.ColorBaseStroke = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(187)))), ((int)(((byte)(213)))));
            this.ribbonMenuButton6.ColorOn = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(78)))));
            this.ribbonMenuButton6.ColorOnStroke = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(177)))), ((int)(((byte)(118)))));
            this.ribbonMenuButton6.ColorPress = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ribbonMenuButton6.ColorPressStroke = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ribbonMenuButton6.FadingSpeed = 20;
            this.ribbonMenuButton6.FlatAppearance.BorderSize = 0;
            this.ribbonMenuButton6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ribbonMenuButton6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ribbonMenuButton6.ForeColor = System.Drawing.Color.DarkBlue;
            this.ribbonMenuButton6.GroupPos = RibbonStyle.RibbonMenuButton.e_groupPos.None;
            this.ribbonMenuButton6.Image = global::Winform.Properties.Resources.edit;
            this.ribbonMenuButton6.ImageLocation = RibbonStyle.RibbonMenuButton.e_imagelocation.Left;
            this.ribbonMenuButton6.ImageOffset = 0;
            this.ribbonMenuButton6.IsPressed = false;
            this.ribbonMenuButton6.KeepPress = false;
            this.ribbonMenuButton6.Location = new System.Drawing.Point(558, 18);
            this.ribbonMenuButton6.MaxImageSize = new System.Drawing.Point(0, 0);
            this.ribbonMenuButton6.MenuPos = new System.Drawing.Point(0, 0);
            this.ribbonMenuButton6.Name = "ribbonMenuButton6";
            this.ribbonMenuButton6.Radius = 10;
            this.ribbonMenuButton6.ShowBase = RibbonStyle.RibbonMenuButton.e_showbase.Yes;
            this.ribbonMenuButton6.Size = new System.Drawing.Size(76, 29);
            this.ribbonMenuButton6.SplitButton = RibbonStyle.RibbonMenuButton.e_splitbutton.No;
            this.ribbonMenuButton6.SplitDistance = 0;
            this.ribbonMenuButton6.TabIndex = 6;
            this.ribbonMenuButton6.Text = "查询";
            this.ribbonMenuButton6.Title = "";
            this.ribbonMenuButton6.UseVisualStyleBackColor = true;
            this.ribbonMenuButton6.Visible = false;
            this.ribbonMenuButton6.Click += new System.EventHandler(this.ribbonMenuButton6_Click);
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.Arrow = RibbonStyle.RibbonMenuButton.e_arrow.None;
            this.btnDeleteProduct.BackColor = System.Drawing.Color.Transparent;
            this.btnDeleteProduct.ColorBase = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(209)))), ((int)(((byte)(240)))));
            this.btnDeleteProduct.ColorBaseStroke = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(187)))), ((int)(((byte)(213)))));
            this.btnDeleteProduct.ColorOn = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(78)))));
            this.btnDeleteProduct.ColorOnStroke = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(177)))), ((int)(((byte)(118)))));
            this.btnDeleteProduct.ColorPress = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnDeleteProduct.ColorPressStroke = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnDeleteProduct.FadingSpeed = 20;
            this.btnDeleteProduct.FlatAppearance.BorderSize = 0;
            this.btnDeleteProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteProduct.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnDeleteProduct.GroupPos = RibbonStyle.RibbonMenuButton.e_groupPos.None;
            this.btnDeleteProduct.Image = global::Winform.Properties.Resources.gtk_remove;
            this.btnDeleteProduct.ImageLocation = RibbonStyle.RibbonMenuButton.e_imagelocation.Left;
            this.btnDeleteProduct.ImageOffset = 0;
            this.btnDeleteProduct.IsPressed = false;
            this.btnDeleteProduct.KeepPress = false;
            this.btnDeleteProduct.Location = new System.Drawing.Point(170, 56);
            this.btnDeleteProduct.MaxImageSize = new System.Drawing.Point(0, 0);
            this.btnDeleteProduct.MenuPos = new System.Drawing.Point(0, 0);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Radius = 10;
            this.btnDeleteProduct.ShowBase = RibbonStyle.RibbonMenuButton.e_showbase.Yes;
            this.btnDeleteProduct.Size = new System.Drawing.Size(76, 29);
            this.btnDeleteProduct.SplitButton = RibbonStyle.RibbonMenuButton.e_splitbutton.No;
            this.btnDeleteProduct.SplitDistance = 0;
            this.btnDeleteProduct.TabIndex = 6;
            this.btnDeleteProduct.Text = "删除";
            this.btnDeleteProduct.Title = "";
            this.btnDeleteProduct.UseVisualStyleBackColor = true;
            this.btnDeleteProduct.Click += new System.EventHandler(this.btnDeleteProduct_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.productListDataGridView);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 94);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(573, 289);
            this.panel2.TabIndex = 2;
            // 
            // productListDataGridView
            // 
            this.productListDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.productListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productListDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PlId,
            this.PlSpecId,
            this.PlProductName,
            this.PlProductNumber,
            this.PlUnitPrice,
            this.PlSpecText,
            this.PlCategory,
            this.PlTaxRate,
            this.PlUnit,
            this.PlProductAmount,
            this.PlBarcode});
            this.productListDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productListDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.productListDataGridView.Location = new System.Drawing.Point(0, 0);
            this.productListDataGridView.MultiSelect = false;
            this.productListDataGridView.Name = "productListDataGridView";
            this.productListDataGridView.RowTemplate.Height = 23;
            this.productListDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.productListDataGridView.Size = new System.Drawing.Size(573, 289);
            this.productListDataGridView.TabIndex = 3;
            // 
            // PlBarcode
            // 
            this.PlBarcode.DataPropertyName = "Barcode";
            this.PlBarcode.HeaderText = "条形码";
            this.PlBarcode.Name = "PlBarcode";
            // 
            // PlProductAmount
            // 
            this.PlProductAmount.DataPropertyName = "Amount";
            this.PlProductAmount.HeaderText = "数量";
            this.PlProductAmount.Name = "PlProductAmount";
            this.PlProductAmount.Visible = false;
            // 
            // PlUnit
            // 
            this.PlUnit.DataPropertyName = "Unit";
            this.PlUnit.HeaderText = "计量单位";
            this.PlUnit.Name = "PlUnit";
            // 
            // PlTaxRate
            // 
            this.PlTaxRate.DataPropertyName = "TaxRate";
            this.PlTaxRate.HeaderText = "税率(%)";
            this.PlTaxRate.Name = "PlTaxRate";
            // 
            // PlCategory
            // 
            this.PlCategory.DataPropertyName = "Category";
            this.PlCategory.HeaderText = "类别";
            this.PlCategory.Name = "PlCategory";
            // 
            // PlSpecText
            // 
            this.PlSpecText.DataPropertyName = "SpecifiText";
            this.PlSpecText.HeaderText = "规格";
            this.PlSpecText.Name = "PlSpecText";
            // 
            // PlUnitPrice
            // 
            this.PlUnitPrice.DataPropertyName = "UnitPrice";
            this.PlUnitPrice.HeaderText = "单价";
            this.PlUnitPrice.Name = "PlUnitPrice";
            // 
            // PlProductNumber
            // 
            this.PlProductNumber.DataPropertyName = "ProductNumber";
            this.PlProductNumber.HeaderText = "货号";
            this.PlProductNumber.Name = "PlProductNumber";
            // 
            // PlProductName
            // 
            this.PlProductName.DataPropertyName = "ProductName";
            this.PlProductName.HeaderText = "产品名";
            this.PlProductName.Name = "PlProductName";
            // 
            // PlSpecId
            // 
            this.PlSpecId.DataPropertyName = "SpecId";
            this.PlSpecId.HeaderText = "SpecId";
            this.PlSpecId.Name = "PlSpecId";
            this.PlSpecId.Visible = false;
            // 
            // PlId
            // 
            this.PlId.DataPropertyName = "ProductId";
            this.PlId.HeaderText = "Id";
            this.PlId.Name = "PlId";
            this.PlId.Visible = false;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.extensionTabControl1);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel9.Location = new System.Drawing.Point(143, 24);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(747, 417);
            this.panel9.TabIndex = 6;
            // 
            // ribbonMenuButton3
            // 
            this.ribbonMenuButton3.Arrow = RibbonStyle.RibbonMenuButton.e_arrow.None;
            this.ribbonMenuButton3.BackColor = System.Drawing.Color.Transparent;
            this.ribbonMenuButton3.ColorBase = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(209)))), ((int)(((byte)(240)))));
            this.ribbonMenuButton3.ColorBaseStroke = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(187)))), ((int)(((byte)(213)))));
            this.ribbonMenuButton3.ColorOn = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(214)))), ((int)(((byte)(78)))));
            this.ribbonMenuButton3.ColorOnStroke = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(177)))), ((int)(((byte)(118)))));
            this.ribbonMenuButton3.ColorPress = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ribbonMenuButton3.ColorPressStroke = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ribbonMenuButton3.FadingSpeed = 20;
            this.ribbonMenuButton3.FlatAppearance.BorderSize = 0;
            this.ribbonMenuButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ribbonMenuButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ribbonMenuButton3.ForeColor = System.Drawing.Color.DarkBlue;
            this.ribbonMenuButton3.GroupPos = RibbonStyle.RibbonMenuButton.e_groupPos.None;
            this.ribbonMenuButton3.Image = global::Winform.Properties.Resources.add;
            this.ribbonMenuButton3.ImageLocation = RibbonStyle.RibbonMenuButton.e_imagelocation.Left;
            this.ribbonMenuButton3.ImageOffset = 0;
            this.ribbonMenuButton3.IsPressed = false;
            this.ribbonMenuButton3.KeepPress = false;
            this.ribbonMenuButton3.Location = new System.Drawing.Point(12, 3);
            this.ribbonMenuButton3.MaxImageSize = new System.Drawing.Point(0, 0);
            this.ribbonMenuButton3.MenuPos = new System.Drawing.Point(0, 0);
            this.ribbonMenuButton3.Name = "ribbonMenuButton3";
            this.ribbonMenuButton3.Radius = 10;
            this.ribbonMenuButton3.ShowBase = RibbonStyle.RibbonMenuButton.e_showbase.Yes;
            this.ribbonMenuButton3.Size = new System.Drawing.Size(111, 29);
            this.ribbonMenuButton3.SplitButton = RibbonStyle.RibbonMenuButton.e_splitbutton.No;
            this.ribbonMenuButton3.SplitDistance = 0;
            this.ribbonMenuButton3.TabIndex = 5;
            this.ribbonMenuButton3.Text = "销售出库";
            this.ribbonMenuButton3.Title = "";
            this.ribbonMenuButton3.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 441);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = true;
            this.MinimizeBox = true;
            this.Name = "MainForm";
            this.Text = "安利进销存";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.CategoryTreeContextMenuStrip.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.extensionTabControl1.ResumeLayout(false);
            this.updateProductPage.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpSpecDataGridView)).EndInit();
            this.updateStorageInPage.ResumeLayout(false);
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.inventoryPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.inventoryDataGridView)).EndInit();
            this.addStorageOutPage.ResumeLayout(false);
            this.groupBox13.ResumeLayout(false);
            this.groupBox13.PerformLayout();
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AsoStorageOutItemDataGridView)).EndInit();
            this.listStorageOutPage.ResumeLayout(false);
            this.groupBox12.ResumeLayout(false);
            this.groupBox12.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StorageOutList)).EndInit();
            this.addStorageInPage.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AsStorageInItemDataGridView)).EndInit();
            this.listStorageInPage.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StorageInListDataGridView)).EndInit();
            this.AddProductPage.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ApSpecDataGridView)).EndInit();
            this.ProductListPage.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.productListDataGridView)).EndInit();
            this.panel9.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem invoicingToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem productInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addProductToolStripMenuItem;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolStripMenuItem SystemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExportMyDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem InportMyDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem InvoicingUpdateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem InvoicingViewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PurchaseManagerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PurchaseStorageInToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SalesManagerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SalesStorageOutToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip CategoryTreeContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem AddCategoryMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RenameMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeleteCategoryMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SystemDictionaryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PurchaseReporterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SalesReporterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem InvoicingReporterToolStripMenuItem;
        private Panel panel8;
        private RibbonStyle.RibbonMenuButton ribbonMenuButton3;
        private WinformControls.ExtensionTabControl extensionTabControl1;
        private TabPage ProductListPage;
        private Panel panel1;
        private Panel panel2;
        private DataGridView productListDataGridView;
        private DataGridViewTextBoxColumn PlId;
        private DataGridViewTextBoxColumn PlSpecId;
        private DataGridViewTextBoxColumn PlProductName;
        private DataGridViewTextBoxColumn PlProductNumber;
        private DataGridViewTextBoxColumn PlUnitPrice;
        private DataGridViewTextBoxColumn PlSpecText;
        private DataGridViewTextBoxColumn PlCategory;
        private DataGridViewTextBoxColumn PlTaxRate;
        private DataGridViewTextBoxColumn PlUnit;
        private DataGridViewTextBoxColumn PlProductAmount;
        private DataGridViewTextBoxColumn PlBarcode;
        private GroupBox groupBox1;
        private RibbonStyle.RibbonMenuButton btnDeleteProduct;
        private RibbonStyle.RibbonMenuButton ribbonMenuButton6;
        private RibbonStyle.RibbonMenuButton btnAddProduct;
        private RibbonStyle.RibbonMenuButton btnEditProduct;
        private TextBox tbBarcode;
        private WinformControls.FormLabel lblBarcode;
        private TextBox tbProduct;
        private WinformControls.FormLabel lblProductNumber;
        private TreeView treeView1;
        private TabPage AddProductPage;
        private GroupBox groupBox5;
        private DataGridView ApSpecDataGridView;
        private DataGridViewTextBoxColumn SLId;
        private DataGridViewTextBoxColumn SLSpecifiText;
        private DataGridViewComboBoxColumn SLShowUnit;
        private DataGridViewTextBoxColumn SLUnit;
        private DataGridViewTextBoxColumn SLBarcode;
        private DataGridViewTextBoxColumn SLUnitPrice;
        private DataGridViewCheckBoxColumn SLIsDel;
        private DataGridViewTextBoxColumn SLCreateTime;
        private Panel panel3;
        private ComboBox ApUnit;
        private TextBox ApBarcode;
        private TextBox ApSpeciText;
        private WinformControls.NumberInputBox ApUnitPrice;
        private WinformControls.FormLabel formLabel41;
        private WinformControls.FormLabel formLabel40;
        private WinformControls.FormLabel formLabel39;
        private WinformControls.FormLabel formLabel38;
        private RibbonStyle.RibbonMenuButton btnSaveClose;
        private RibbonStyle.RibbonMenuButton btnSaveAndContinue;
        private RibbonStyle.RibbonMenuButton btnAddSpec;
        private RibbonStyle.RibbonMenuButton btnDeleteSpec;
        private GroupBox groupBox3;
        private Label label1;
        private Label label5;
        private Label label4;
        private Label label2;
        private WinformControls.NumberInputBox ApTaxRate;
        private WinformControls.FormLabel formLabel4;
        private TextBox ApCategory;
        private TextBox ApProductNumber;
        private TextBox ApProductName;
        private WinformControls.FormLabel formLabel3;
        private WinformControls.FormLabel formLabel2;
        private WinformControls.FormLabel formLabel1;
        private TabPage listStorageInPage;
        private DataGridView StorageInListDataGridView;
        private DataGridViewTextBoxColumn StlId;
        private DataGridViewTextBoxColumn StlStorageListNumber;
        private DataGridViewTextBoxColumn StlStorageInTotalPrice;
        private DataGridViewTextBoxColumn StlStorageInTotalAmount;
        private DataGridViewTextBoxColumn StlStorageInTime;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private GroupBox groupBox4;
        private RibbonStyle.RibbonMenuButton ribbonMenuButton9;
        private RibbonStyle.RibbonMenuButton ribbonMenuButton7;
        private RibbonStyle.RibbonMenuButton btnSearchStorageIn;
        private DateTimePicker SilSearchEndTime;
        private Label label6;
        private DateTimePicker SilSearchStartTime;
        private WinformControls.FormLabel formLabel5;
        private TabPage addStorageInPage;
        private Panel panel5;
        private DataGridView AsStorageInItemDataGridView;
        private DataGridViewTextBoxColumn AsProductListId;
        private DataGridViewTextBoxColumn AsProductListSpecId;
        private DataGridViewTextBoxColumn AsProductListName;
        private DataGridViewTextBoxColumn AsProductListAmount;
        private DataGridViewTextBoxColumn AdProductListNumber;
        private DataGridViewTextBoxColumn AsProductListBarcode;
        private DataGridViewTextBoxColumn AsProductListUnitPrice;
        private DataGridViewTextBoxColumn AsProductListCategory;
        private DataGridViewTextBoxColumn AsProductListTaxRate;
        private DataGridViewTextBoxColumn AsProductListSpeciText;
        private DataGridViewTextBoxColumn AsProductListUnit;
        private DataGridViewTextBoxColumn AsProductListIsDel;
        private DataGridViewTextBoxColumn AsProductListCreateTime;
        private GroupBox groupBox8;
        private WinformControls.FormLabel formLabel15;
        private WinformControls.NumberInputBox AsProductUnitPrice;
        private WinformControls.NumberInputBox AsProductUnit;
        private ComboBox AsProductSpeciText;
        private WinformControls.FormLabel formLabel18;
        private TextBox AsProductName;
        private WinformControls.FormLabel formLabel16;
        private RibbonStyle.RibbonMenuButton btnSaveStorageIn;
        private Label label12;
        private DateTimePicker AsStorageInTime;
        private WinformControls.FormLabel formLabel17;
        private WinformControls.FormLabel formLabel11;
        private WinformControls.NumberInputBox AsProductAmount;
        private TextBox AsNumber;
        private WinformControls.FormLabel formLabel14;
        private WinformControls.FormLabel formLabel10;
        private WinformControls.FormLabel formLabel27;
        private TextBox AsProductNumber;
        private TextBox AsProductBarcode;
        private WinformControls.FormLabel formLabel19;
        private RibbonStyle.RibbonMenuButton btnDeleteStorageInItem;
        private RibbonStyle.RibbonMenuButton btnAddStorageInItem;
        private TabPage listStorageOutPage;
        private DataGridView StorageOutList;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn IsDel;
        private DataGridViewTextBoxColumn CreateTime;
        private GroupBox groupBox12;
        private RibbonStyle.RibbonMenuButton ribbonMenuButton5;
        private DateTimePicker SolSearchEndTime;
        private Label label14;
        private DateTimePicker SolSearchStartTime;
        private WinformControls.FormLabel formLabel28;
        private TabPage addStorageOutPage;
        private Panel panel7;
        private DataGridView AsoStorageOutItemDataGridView;
        private DataGridViewTextBoxColumn AsoProductListId;
        private DataGridViewTextBoxColumn AsoProductListSpecId;
        private DataGridViewTextBoxColumn AsoProductListProductName;
        private DataGridViewTextBoxColumn AsoProductListAmount;
        private DataGridViewTextBoxColumn AsoProductListProductNumber;
        private DataGridViewTextBoxColumn AsoProductListBarcode;
        private DataGridViewTextBoxColumn AsoProductListUnitPrice;
        private DataGridViewTextBoxColumn AsoProductListCategory;
        private DataGridViewTextBoxColumn AsoProductListTaxRate;
        private DataGridViewTextBoxColumn AsoProductListSpecifiText;
        private DataGridViewTextBoxColumn AsoProductListUnit;
        private DataGridViewTextBoxColumn AsoProductListIsDel;
        private DataGridViewTextBoxColumn AsoProductListCreateTime;
        private GroupBox groupBox13;
        private WinformControls.FormLabel formLabel32;
        private WinformControls.NumberInputBox AsoStorageOutUnitPrice;
        private ComboBox AsoStorageOutSpeciText;
        private RibbonStyle.RibbonMenuButton AsoSaveStorageOut;
        private WinformControls.FormLabel formLabel34;
        private Label label15;
        private DateTimePicker AsoStorageOutTime;
        private WinformControls.NumberInputBox AsoStorageOutUnit;
        private WinformControls.FormLabel formLabel35;
        private TextBox AsoStorageOutProductName;
        private WinformControls.FormLabel formLabel29;
        private WinformControls.FormLabel formLabel33;
        private WinformControls.FormLabel formLabel37;
        private TextBox AsoStorageOutProductNumber;
        private WinformControls.FormLabel formLabel31;
        private WinformControls.NumberInputBox AsoStorageOutAmount;
        private RibbonStyle.RibbonMenuButton AsoAddStorageOutItem;
        private TextBox AsoStorageOutNumber;
        private RibbonStyle.RibbonMenuButton AsoDeleteStorageOutItem;
        private WinformControls.FormLabel formLabel30;
        private WinformControls.FormLabel formLabel36;
        private TextBox AsoStorageOutBarcode;
        private TabPage inventoryPage;
        private DataGridView inventoryDataGridView;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn22;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn23;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn24;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn25;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn26;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn30;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn27;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn28;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn29;
        private GroupBox groupBox15;
        private TabPage updateStorageInPage;
        private Panel panel6;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn31;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn32;
        private GroupBox groupBox11;
        private ComboBox UsSearchSpeciText;
        private WinformControls.NumberInputBox UsSearchUnit;
        private WinformControls.FormLabel formLabel21;
        private WinformControls.FormLabel formLabel22;
        private WinformControls.NumberInputBox UsSearchAmount;
        private WinformControls.FormLabel formLabel26;
        private WinformControls.NumberInputBox UsSearchUnitPrice;
        private WinformControls.FormLabel formLabel20;
        private TextBox UsSearchProductName;
        private WinformControls.FormLabel formLabel23;
        private TextBox UsSearchBarcode;
        private WinformControls.FormLabel formLabel24;
        private TextBox UsSearchProductNumber;
        private WinformControls.FormLabel formLabel25;
        private RibbonStyle.RibbonMenuButton ribbonMenuButton1;
        private RibbonStyle.RibbonMenuButton ribbonMenuButton2;
        private GroupBox groupBox10;
        private Label label13;
        private DateTimePicker dateTimePicker2;
        private WinformControls.FormLabel formLabel12;
        private TextBox textBox2;
        private WinformControls.FormLabel formLabel13;
        private TabPage updateProductPage;
        private GroupBox groupBox7;
        private DataGridView UpSpecDataGridView;
        private DataGridViewTextBoxColumn UpSlId;
        private DataGridViewTextBoxColumn UpSlSpecifiText;
        private DataGridViewComboBoxColumn UpSlShowUnit;
        private DataGridViewTextBoxColumn UpSlUnitId;
        private DataGridViewTextBoxColumn UpSlBarcode;
        private DataGridViewTextBoxColumn UpSlUnitPrice;
        private DataGridViewCheckBoxColumn UpSlIsDel;
        private DataGridViewTextBoxColumn UpSlCreateTime;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewComboBoxColumn dataGridViewComboBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private Panel panel4;
        private RibbonStyle.RibbonMenuButton UpSave;
        private RibbonStyle.RibbonMenuButton UpAddSpec;
        private RibbonStyle.RibbonMenuButton UpDeleteSpec;
        private GroupBox groupBox6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private WinformControls.NumberInputBox UpTaxRate;
        private Label label11;
        private WinformControls.FormLabel formLabel6;
        private TextBox UpCategory;
        private TextBox UpProductNumber;
        private TextBox UpProductName;
        private WinformControls.FormLabel formLabel7;
        private WinformControls.FormLabel formLabel8;
        private WinformControls.FormLabel formLabel9;
        private Panel panel9;
    }
}
