using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DomainModule;
using BusinessServiceInterface;
using BusinessService;
using WinformControls;

namespace Winform
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                StringBuilder sb = new StringBuilder();
                if (String.IsNullOrEmpty(tbLoginName.Text))
                {
                    sb.Append("登陆名不能为空\n");
                }
                if (string.IsNullOrEmpty(tbPassword.Text))
                {
                    sb.Append("密码不能为空\n");
                }
                if (!tbPassword.Text.Equals(tbConfirm.Text))
                {
                    sb.Append("两次输入密码不一致\n");
                }

                if (string.IsNullOrEmpty(tbAmwayCardId.Text))
                {
                    sb.Append("卡号不能为空");
                }

                if (sb.Length > 0)
                {
                    lblErrorMsg.Text = sb.ToString();
                    Toast.Show(sb.ToString());
                }
                else
                {
                    //IUserService userService = new UserService();
                    UserInfo user = new UserInfo();
                    user.LoginName = tbLoginName.Text;
                    user.Password = tbPassword.Text;
                    user.Address = tbAddress.Text;
                    user.Phone = tbPhone.Text;
                    user.AmwayCardId = tbAmwayCardId.Text;
                    user.IdentityNumber = tbIdentityNumber.Text;
                    user.UserName = tbUserName.Text;
                    user.StartTime = dpStartTime.Value;
                    user.EndTime = dpStartTime.Value;

                    if (SystemVariable.UserService.RegisterUser(user))
                    {
                        this.Close();
                        this.Dispose();
                    }
                    else
                    {
                        Toast.Show("存在相同用户名");
                    }
                }
            }
            catch (Exception ex)
            {
                Toast.Show(ex.Message + ex.StackTrace);
            }
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
                this.Dispose();
            }
            catch (Exception ex)
            {
                Toast.Show(ex.Message + ex.StackTrace);
            }
            
        }
    }
}
