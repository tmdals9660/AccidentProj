﻿using Accident.Data;
using Accident.Properties;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Accident.From
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {

            Admin admins = DB.Admin.LoginCheck(txbId.Text, txbPw.Text);
            if (admins != null)
            {
                MessageBox.Show($"안녕하세요. {admins.AdminName.ToString()}님!" +
                    $"\n로그인 되었습니다.");

                OnLoginMode();

                Close();
            }
            else
                MessageBox.Show("존재하지 않는 ID이거나\n비밀번호가 일치하지 않습니다.");
        }

        #region LoginMode event things for C# 3.0
        public event EventHandler<LoginModeEventArgs> LoginMode;

        protected virtual void OnLoginMode(LoginModeEventArgs e)
        {
            if (LoginMode != null)
                LoginMode(this, e);
        }

        private LoginModeEventArgs OnLoginMode()
        {
            LoginModeEventArgs args = new LoginModeEventArgs();
            OnLoginMode(args);

            return args;
        }

        /*private LoginModeEventArgs OnLoginModeForOut()
        {
            LoginModeEventArgs args = new LoginModeEventArgs();
            OnLoginMode(args);

            return args;
        }*/

        public class LoginModeEventArgs : EventArgs
        {


            /*public LoginModeEventArgs()
            {
            }

            public LoginModeEventArgs()
            {

            }*/
        }
        #endregion

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnSingUp_Click(object sender, EventArgs e)
        {
            AddAdminInfo addInfo = new AddAdminInfo();
            addInfo.ShowDialog();
        }
    }
}
