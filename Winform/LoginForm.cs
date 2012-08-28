using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WinformControls;
using DomainModule;
using BusinessServiceInterface;
using BusinessService;

namespace Winform
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            try
            {
                
            }
            catch (Exception ex)
            {
                Toast.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                loginClick();
            }
            catch (Exception ex)
            {
                Toast.Show(ex.Message + ex.StackTrace);
            }
        }

        private void loginClick()
        {
            try
            {
                StringBuilder sb = new StringBuilder();
                if (String.IsNullOrEmpty(this.tbUserName.Text))
                {
                    sb.Append("登陆名不能为空\n");
                }
                if (string.IsNullOrEmpty(tbPassword.Text))
                {
                    sb.Append("密码不能为空\n");
                }
                if (sb.Length > 0)
                {
                    Toast.Show(sb.ToString());
                    return;
                }


                //IUserService userService = new UserService();

                UserInfo user = SystemVariable.UserService.Login(tbUserName.Text, tbPassword.Text);
                if (user != null)
                {
                    SystemVariable.LoginUser = user;
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                    this.Dispose();
                }
                else
                {
                    Toast.Show("登陆失败");

                }
            }
            catch (Exception ex)
            {
                Toast.Show(ex.Message + ex.StackTrace);
            }
        }

        private void lklblRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                RegisterForm regForm = new RegisterForm();
                regForm.ShowDialog();
            }
            catch (Exception ex)
            {
                Toast.Show(ex.Message + ex.StackTrace);
            }
        }

        private void tbPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
                loginClick();
        }
    }
}
