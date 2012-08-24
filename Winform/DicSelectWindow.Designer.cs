namespace Winform
{
    partial class DicSelectWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        protected void InitializeComponent()
        {
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.dicDataGridView = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DicNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DicName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MnemonicCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsDel = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbbDicCategory = new System.Windows.Forms.ComboBox();
            this.btnSave = new RibbonStyle.RibbonMenuButton();
            this.btnDelete = new RibbonStyle.RibbonMenuButton();
            this.btnSelect = new RibbonStyle.RibbonMenuButton();
            this.btnAddDic = new RibbonStyle.RibbonMenuButton();
            ((System.ComponentModel.ISupportInitialize)(this.dicDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(401, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // dicDataGridView
            // 
            this.dicDataGridView.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.dicDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dicDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.DicNumber,
            this.DicName,
            this.MnemonicCode,
            this.CreateTime,
            this.IsDel});
            this.dicDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dicDataGridView.Location = new System.Drawing.Point(0, 30);
            this.dicDataGridView.MultiSelect = false;
            this.dicDataGridView.Name = "dicDataGridView";
            this.dicDataGridView.RowTemplate.Height = 23;
            this.dicDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dicDataGridView.Size = new System.Drawing.Size(401, 237);
            this.dicDataGridView.TabIndex = 3;
            this.dicDataGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dicDataGridView_CellEndEdit);
            this.dicDataGridView.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dicDataGridView_RowsAdded);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // DicNumber
            // 
            this.DicNumber.DataPropertyName = "DicNumber";
            this.DicNumber.HeaderText = "编码";
            this.DicNumber.Name = "DicNumber";
            // 
            // DicName
            // 
            this.DicName.DataPropertyName = "DicName";
            this.DicName.HeaderText = "名称";
            this.DicName.Name = "DicName";
            // 
            // MnemonicCode
            // 
            this.MnemonicCode.DataPropertyName = "MnemonicCode";
            this.MnemonicCode.HeaderText = "助记码";
            this.MnemonicCode.Name = "MnemonicCode";
            this.MnemonicCode.Visible = false;
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
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.dicDataGridView);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(401, 267);
            this.panel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cbbDicCategory);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(401, 32);
            this.panel2.TabIndex = 4;
            // 
            // cbbDicCategory
            // 
            this.cbbDicCategory.FormattingEnabled = true;
            this.cbbDicCategory.Location = new System.Drawing.Point(7, 4);
            this.cbbDicCategory.Name = "cbbDicCategory";
            this.cbbDicCategory.Size = new System.Drawing.Size(121, 20);
            this.cbbDicCategory.TabIndex = 0;
            this.cbbDicCategory.SelectedIndexChanged += new System.EventHandler(this.cbbDicCategory_SelectedIndexChanged);
            // 
            // btnSave
            // 
            this.btnSave.Arrow = RibbonStyle.RibbonMenuButton.e_arrow.None;
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.ColorBase = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.btnSave.ColorBaseStroke = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSave.ColorOn = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSave.ColorOnStroke = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSave.ColorPress = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSave.ColorPressStroke = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSave.FadingSpeed = 35;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.GroupPos = RibbonStyle.RibbonMenuButton.e_groupPos.None;
            this.btnSave.Image = global::Winform.Properties.Resources.document_open;
            this.btnSave.ImageLocation = RibbonStyle.RibbonMenuButton.e_imagelocation.Left;
            this.btnSave.ImageOffset = 0;
            this.btnSave.IsPressed = false;
            this.btnSave.KeepPress = false;
            this.btnSave.Location = new System.Drawing.Point(317, 0);
            this.btnSave.MaxImageSize = new System.Drawing.Point(0, 0);
            this.btnSave.MenuPos = new System.Drawing.Point(0, 0);
            this.btnSave.Name = "btnSave";
            this.btnSave.Radius = 3;
            this.btnSave.ShowBase = RibbonStyle.RibbonMenuButton.e_showbase.Yes;
            this.btnSave.Size = new System.Drawing.Size(84, 23);
            this.btnSave.SplitButton = RibbonStyle.RibbonMenuButton.e_splitbutton.No;
            this.btnSave.SplitDistance = 0;
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "保存修改";
            this.btnSave.Title = "";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Arrow = RibbonStyle.RibbonMenuButton.e_arrow.None;
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.ColorBase = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.btnDelete.ColorBaseStroke = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnDelete.ColorOn = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnDelete.ColorOnStroke = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnDelete.ColorPress = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnDelete.ColorPressStroke = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnDelete.FadingSpeed = 35;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.GroupPos = RibbonStyle.RibbonMenuButton.e_groupPos.None;
            this.btnDelete.Image = global::Winform.Properties.Resources.gtk_remove;
            this.btnDelete.ImageLocation = RibbonStyle.RibbonMenuButton.e_imagelocation.Left;
            this.btnDelete.ImageOffset = 0;
            this.btnDelete.IsPressed = false;
            this.btnDelete.KeepPress = false;
            this.btnDelete.Location = new System.Drawing.Point(66, 0);
            this.btnDelete.MaxImageSize = new System.Drawing.Point(0, 0);
            this.btnDelete.MenuPos = new System.Drawing.Point(0, 0);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Radius = 3;
            this.btnDelete.ShowBase = RibbonStyle.RibbonMenuButton.e_showbase.Yes;
            this.btnDelete.Size = new System.Drawing.Size(62, 23);
            this.btnDelete.SplitButton = RibbonStyle.RibbonMenuButton.e_splitbutton.No;
            this.btnDelete.SplitDistance = 0;
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "删除";
            this.btnDelete.Title = "";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.Arrow = RibbonStyle.RibbonMenuButton.e_arrow.None;
            this.btnSelect.BackColor = System.Drawing.Color.Transparent;
            this.btnSelect.ColorBase = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.btnSelect.ColorBaseStroke = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSelect.ColorOn = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSelect.ColorOnStroke = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSelect.ColorPress = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSelect.ColorPressStroke = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSelect.FadingSpeed = 35;
            this.btnSelect.FlatAppearance.BorderSize = 0;
            this.btnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelect.GroupPos = RibbonStyle.RibbonMenuButton.e_groupPos.None;
            this.btnSelect.Image = global::Winform.Properties.Resources.clean;
            this.btnSelect.ImageLocation = RibbonStyle.RibbonMenuButton.e_imagelocation.Left;
            this.btnSelect.ImageOffset = 0;
            this.btnSelect.IsPressed = false;
            this.btnSelect.KeepPress = false;
            this.btnSelect.Location = new System.Drawing.Point(130, 0);
            this.btnSelect.MaxImageSize = new System.Drawing.Point(0, 0);
            this.btnSelect.MenuPos = new System.Drawing.Point(0, 0);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Radius = 3;
            this.btnSelect.ShowBase = RibbonStyle.RibbonMenuButton.e_showbase.Yes;
            this.btnSelect.Size = new System.Drawing.Size(62, 23);
            this.btnSelect.SplitButton = RibbonStyle.RibbonMenuButton.e_splitbutton.No;
            this.btnSelect.SplitDistance = 0;
            this.btnSelect.TabIndex = 2;
            this.btnSelect.Text = "选择";
            this.btnSelect.Title = "";
            this.btnSelect.UseVisualStyleBackColor = false;
            this.btnSelect.Visible = false;
            // 
            // btnAddDic
            // 
            this.btnAddDic.Arrow = RibbonStyle.RibbonMenuButton.e_arrow.None;
            this.btnAddDic.BackColor = System.Drawing.Color.Transparent;
            this.btnAddDic.ColorBase = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.btnAddDic.ColorBaseStroke = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnAddDic.ColorOn = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnAddDic.ColorOnStroke = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnAddDic.ColorPress = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnAddDic.ColorPressStroke = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnAddDic.FadingSpeed = 35;
            this.btnAddDic.FlatAppearance.BorderSize = 0;
            this.btnAddDic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddDic.GroupPos = RibbonStyle.RibbonMenuButton.e_groupPos.None;
            this.btnAddDic.Image = global::Winform.Properties.Resources.add;
            this.btnAddDic.ImageLocation = RibbonStyle.RibbonMenuButton.e_imagelocation.Left;
            this.btnAddDic.ImageOffset = 0;
            this.btnAddDic.IsPressed = false;
            this.btnAddDic.KeepPress = false;
            this.btnAddDic.Location = new System.Drawing.Point(5, 0);
            this.btnAddDic.MaxImageSize = new System.Drawing.Point(0, 0);
            this.btnAddDic.MenuPos = new System.Drawing.Point(0, 0);
            this.btnAddDic.Name = "btnAddDic";
            this.btnAddDic.Radius = 3;
            this.btnAddDic.ShowBase = RibbonStyle.RibbonMenuButton.e_showbase.Yes;
            this.btnAddDic.Size = new System.Drawing.Size(62, 23);
            this.btnAddDic.SplitButton = RibbonStyle.RibbonMenuButton.e_splitbutton.No;
            this.btnAddDic.SplitDistance = 0;
            this.btnAddDic.TabIndex = 1;
            this.btnAddDic.Text = "添加";
            this.btnAddDic.Title = "";
            this.btnAddDic.UseVisualStyleBackColor = false;
            this.btnAddDic.Click += new System.EventHandler(this.btnAddDic_Click);
            // 
            // DicSelectWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 292);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.btnAddDic);
            this.Controls.Add(this.toolStrip1);
            this.Name = "DicSelectWindow";
            this.Text = "系统字典";
            this.Load += new System.EventHandler(this.DicSelectWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dicDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.ToolStrip toolStrip1;
        protected RibbonStyle.RibbonMenuButton btnAddDic;
        protected RibbonStyle.RibbonMenuButton btnSelect;
        protected System.Windows.Forms.DataGridView dicDataGridView;
        protected RibbonStyle.RibbonMenuButton btnDelete;
        protected RibbonStyle.RibbonMenuButton btnSave;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.ComboBox cbbDicCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn DicNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn DicName;
        private System.Windows.Forms.DataGridViewTextBoxColumn MnemonicCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreateTime;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsDel;
    }
}