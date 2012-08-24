namespace Winform
{
    partial class RegisterForm
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
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.requiredLoginName = new System.Windows.Forms.Label();
            this.tbConfirm = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.lblConfirm = new WinformControls.FormLabel();
            this.lblPassword = new WinformControls.FormLabel();
            this.tbLoginName = new System.Windows.Forms.TextBox();
            this.lblLoginName = new WinformControls.FormLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.lblPhone = new WinformControls.FormLabel();
            this.tbIdentityNumber = new System.Windows.Forms.TextBox();
            this.lblIdentityNumber = new WinformControls.FormLabel();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.lblAddress = new WinformControls.FormLabel();
            this.lblUserName = new WinformControls.FormLabel();
            this.lblStartTime = new WinformControls.FormLabel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dpEndTime = new System.Windows.Forms.DateTimePicker();
            this.dpStartTime = new System.Windows.Forms.DateTimePicker();
            this.lblEndTime = new WinformControls.FormLabel();
            this.tbAmwayCardId = new System.Windows.Forms.TextBox();
            this.lblAmwayCardId = new WinformControls.FormLabel();
            this.lblMessage = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblErrorMsg = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.requiredLoginName);
            this.groupBox1.Controls.Add(this.tbConfirm);
            this.groupBox1.Controls.Add(this.tbPassword);
            this.groupBox1.Controls.Add(this.lblConfirm);
            this.groupBox1.Controls.Add(this.lblPassword);
            this.groupBox1.Controls.Add(this.tbLoginName);
            this.groupBox1.Controls.Add(this.lblLoginName);
            this.groupBox1.Location = new System.Drawing.Point(12, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(321, 164);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "登陆信息";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(222, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(11, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(222, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(11, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "*";
            // 
            // requiredLoginName
            // 
            this.requiredLoginName.AutoSize = true;
            this.requiredLoginName.ForeColor = System.Drawing.Color.Red;
            this.requiredLoginName.Location = new System.Drawing.Point(222, 40);
            this.requiredLoginName.Name = "requiredLoginName";
            this.requiredLoginName.Size = new System.Drawing.Size(11, 12);
            this.requiredLoginName.TabIndex = 6;
            this.requiredLoginName.Text = "*";
            // 
            // tbConfirm
            // 
            this.tbConfirm.Location = new System.Drawing.Point(96, 102);
            this.tbConfirm.MaxLength = 50;
            this.tbConfirm.Name = "tbConfirm";
            this.tbConfirm.PasswordChar = '*';
            this.tbConfirm.Size = new System.Drawing.Size(117, 21);
            this.tbConfirm.TabIndex = 5;
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(96, 69);
            this.tbPassword.MaxLength = 50;
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(117, 21);
            this.tbPassword.TabIndex = 4;
            // 
            // lblConfirm
            // 
            this.lblConfirm.AutoSize = true;
            this.lblConfirm.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblConfirm.Location = new System.Drawing.Point(23, 103);
            this.lblConfirm.Name = "lblConfirm";
            this.lblConfirm.Size = new System.Drawing.Size(63, 14);
            this.lblConfirm.TabIndex = 3;
            this.lblConfirm.Text = "确认密码";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblPassword.Location = new System.Drawing.Point(23, 70);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(63, 14);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "密    码";
            // 
            // tbLoginName
            // 
            this.tbLoginName.Location = new System.Drawing.Point(96, 39);
            this.tbLoginName.MaxLength = 50;
            this.tbLoginName.Name = "tbLoginName";
            this.tbLoginName.Size = new System.Drawing.Size(117, 21);
            this.tbLoginName.TabIndex = 1;
            // 
            // lblLoginName
            // 
            this.lblLoginName.AutoSize = true;
            this.lblLoginName.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblLoginName.Location = new System.Drawing.Point(23, 40);
            this.lblLoginName.Name = "lblLoginName";
            this.lblLoginName.Size = new System.Drawing.Size(63, 14);
            this.lblLoginName.TabIndex = 0;
            this.lblLoginName.Text = "登 陆 名";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbPhone);
            this.groupBox2.Controls.Add(this.lblPhone);
            this.groupBox2.Controls.Add(this.tbIdentityNumber);
            this.groupBox2.Controls.Add(this.lblIdentityNumber);
            this.groupBox2.Controls.Add(this.tbAddress);
            this.groupBox2.Controls.Add(this.tbUserName);
            this.groupBox2.Controls.Add(this.lblAddress);
            this.groupBox2.Controls.Add(this.lblUserName);
            this.groupBox2.Location = new System.Drawing.Point(339, 66);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(394, 306);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "用户信息";
            // 
            // tbPhone
            // 
            this.tbPhone.Location = new System.Drawing.Point(103, 135);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(117, 21);
            this.tbPhone.TabIndex = 9;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblPhone.Location = new System.Drawing.Point(28, 136);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(63, 14);
            this.lblPhone.TabIndex = 8;
            this.lblPhone.Text = "电    话";
            // 
            // tbIdentityNumber
            // 
            this.tbIdentityNumber.Location = new System.Drawing.Point(103, 102);
            this.tbIdentityNumber.Name = "tbIdentityNumber";
            this.tbIdentityNumber.Size = new System.Drawing.Size(117, 21);
            this.tbIdentityNumber.TabIndex = 7;
            // 
            // lblIdentityNumber
            // 
            this.lblIdentityNumber.AutoSize = true;
            this.lblIdentityNumber.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblIdentityNumber.Location = new System.Drawing.Point(28, 103);
            this.lblIdentityNumber.Name = "lblIdentityNumber";
            this.lblIdentityNumber.Size = new System.Drawing.Size(63, 14);
            this.lblIdentityNumber.TabIndex = 6;
            this.lblIdentityNumber.Text = "身份证号";
            // 
            // tbAddress
            // 
            this.tbAddress.Location = new System.Drawing.Point(103, 69);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(117, 21);
            this.tbAddress.TabIndex = 5;
            // 
            // tbUserName
            // 
            this.tbUserName.Location = new System.Drawing.Point(103, 40);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(117, 21);
            this.tbUserName.TabIndex = 3;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblAddress.Location = new System.Drawing.Point(28, 70);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(63, 14);
            this.lblAddress.TabIndex = 2;
            this.lblAddress.Text = "地    址";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblUserName.Location = new System.Drawing.Point(28, 40);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(63, 14);
            this.lblUserName.TabIndex = 0;
            this.lblUserName.Text = "用户姓名";
            // 
            // lblStartTime
            // 
            this.lblStartTime.AutoSize = true;
            this.lblStartTime.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblStartTime.Location = new System.Drawing.Point(21, 60);
            this.lblStartTime.Name = "lblStartTime";
            this.lblStartTime.Size = new System.Drawing.Size(63, 14);
            this.lblStartTime.TabIndex = 9;
            this.lblStartTime.Text = "启用日期";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.dpEndTime);
            this.groupBox3.Controls.Add(this.dpStartTime);
            this.groupBox3.Controls.Add(this.lblEndTime);
            this.groupBox3.Controls.Add(this.lblStartTime);
            this.groupBox3.Controls.Add(this.tbAmwayCardId);
            this.groupBox3.Controls.Add(this.lblAmwayCardId);
            this.groupBox3.Location = new System.Drawing.Point(12, 236);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(321, 136);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "安利卡信息";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(222, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(11, 12);
            this.label3.TabIndex = 13;
            this.label3.Text = "*";
            // 
            // dpEndTime
            // 
            this.dpEndTime.Location = new System.Drawing.Point(96, 90);
            this.dpEndTime.Name = "dpEndTime";
            this.dpEndTime.Size = new System.Drawing.Size(117, 21);
            this.dpEndTime.TabIndex = 12;
            // 
            // dpStartTime
            // 
            this.dpStartTime.Location = new System.Drawing.Point(96, 58);
            this.dpStartTime.Name = "dpStartTime";
            this.dpStartTime.Size = new System.Drawing.Size(117, 21);
            this.dpStartTime.TabIndex = 11;
            // 
            // lblEndTime
            // 
            this.lblEndTime.AutoSize = true;
            this.lblEndTime.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblEndTime.Location = new System.Drawing.Point(21, 97);
            this.lblEndTime.Name = "lblEndTime";
            this.lblEndTime.Size = new System.Drawing.Size(63, 14);
            this.lblEndTime.TabIndex = 10;
            this.lblEndTime.Text = "失效日期";
            // 
            // tbAmwayCardId
            // 
            this.tbAmwayCardId.Location = new System.Drawing.Point(96, 26);
            this.tbAmwayCardId.Name = "tbAmwayCardId";
            this.tbAmwayCardId.Size = new System.Drawing.Size(117, 21);
            this.tbAmwayCardId.TabIndex = 6;
            // 
            // lblAmwayCardId
            // 
            this.lblAmwayCardId.AutoSize = true;
            this.lblAmwayCardId.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblAmwayCardId.Location = new System.Drawing.Point(21, 27);
            this.lblAmwayCardId.Name = "lblAmwayCardId";
            this.lblAmwayCardId.Size = new System.Drawing.Size(63, 14);
            this.lblAmwayCardId.TabIndex = 5;
            this.lblAmwayCardId.Text = "卡    号";
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(55, 29);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(95, 12);
            this.lblMessage.TabIndex = 3;
            this.lblMessage.Text = "带星号(*)为必填";
            // 
            // btnSubmit
            // 
            this.btnSubmit.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSubmit.Location = new System.Drawing.Point(355, 470);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 33);
            this.btnSubmit.TabIndex = 4;
            this.btnSubmit.Text = "确定";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(258, 470);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 33);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblErrorMsg
            // 
            this.lblErrorMsg.AutoSize = true;
            this.lblErrorMsg.Location = new System.Drawing.Point(246, 401);
            this.lblErrorMsg.Name = "lblErrorMsg";
            this.lblErrorMsg.Size = new System.Drawing.Size(0, 12);
            this.lblErrorMsg.TabIndex = 6;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 548);
            this.Controls.Add(this.lblErrorMsg);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "RegisterForm";
            this.Text = "RegisterForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private WinformControls.FormLabel lblLoginName;
        private WinformControls.FormLabel lblConfirm;
        private WinformControls.FormLabel lblPassword;
        private System.Windows.Forms.TextBox tbLoginName;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbConfirm;
        private System.Windows.Forms.GroupBox groupBox2;
        private WinformControls.FormLabel lblUserName;
        private System.Windows.Forms.TextBox tbUserName;
        private WinformControls.FormLabel lblAddress;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.TextBox tbIdentityNumber;
        private WinformControls.FormLabel lblIdentityNumber;
        private WinformControls.FormLabel lblStartTime;
        private WinformControls.FormLabel lblPhone;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tbAmwayCardId;
        private WinformControls.FormLabel lblAmwayCardId;
        private System.Windows.Forms.TextBox tbPhone;
        private WinformControls.FormLabel lblEndTime;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.DateTimePicker dpEndTime;
        private System.Windows.Forms.DateTimePicker dpStartTime;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label requiredLoginName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblErrorMsg;

    }
}